using CRM_4S.Business;
using CRM_4S.Business.ViewModel;
using CRM_4S.Common;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_4S.DCCManager
{
    public partial class FmDCCImport : Form
    {
        public FmDCCImport()
        {
            InitializeComponent();
            CRM_4S.Common.DevViewDefine.ResetToNormalView(this.gridControl1.MainView, false);
            this.gridView1.IndicatorWidth = 50;
        }

        public event EventHandler RefreshTable;
        private List<DateTime> dateList = new List<DateTime>();
        public ViewQueryInfo QInfo
        {
            get
            {
                return new ViewQueryInfo()
                {
                    DateRange = QueryDateRange.Customer,
                    StartDate = dateList.Min(),
                    EndDate = dateList.Max().AddDays(1)
                };
            }
        }

        DataTable dtSource = null;
        DataTable DtSource
        {
            get
            {
                if (dtSource == null)
                    dtSource = new DataTable("SourceTable");
                return dtSource;
            }
            set
            {
                dtSource = value;
                dtSource.TableName = "SourceTable";
            }
        }


        private void btnSelFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                //ofd.InitialDirectory = "C:\\";
                ofd.Filter = "Excel(*.xls;*.xlsx)|*.xls;*.xlsx";
                //ofd.RestoreDirectory = true;
                ofd.FilterIndex = 1;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = ofd.FileName;
                    DtSource.Dispose();//释放原表

                    DtSource = DataImportBusiness.Instance.ToDataTable(txtFilePath.Text);
                }
            }
            catch (Exception ex)
            {
                DtSource.Dispose();//释放原表
                XtraMessageBox.Show("读取文件失败，文件可能正在使用中，请重新选择文件！", "提示", MessageBoxButtons.OK);
            }
            finally
            {
                this.gridControl1.DataSource = DtSource;
                this.gridControl1.MainView.RefreshData();
            }
        }

        private void btnImportAndRefresh_Click(object sender, EventArgs e)
        {
            if (DtSource.Rows != null && DtSource.Rows.Count > 0)
            {
                FmProgressBar progressBar = new FmProgressBar("数据导入中........");
                var tempTable = DtSource.Copy();
                string runMsg = string.Empty;
                bool bSuccess = true;
                Task task = new Task(() =>
                {
                    try
                    {
                        DataColumn dtRecorderColumn = new DataColumn("Recorder", typeof(string));
                        DataColumn dtShopIdColumn = new DataColumn("ShopId", typeof(Int32));
                        tempTable.Columns.Add(dtShopIdColumn);
                        tempTable.Columns.Add(dtRecorderColumn);
                        dtShopIdColumn.SetOrdinal(0);
                        dtRecorderColumn.SetOrdinal(1);
                        int defaultPhone = 1;
                        foreach (DataRow datarow in tempTable.Rows)
                        {
                            datarow[dtShopIdColumn] = GlobalCaches.Instance.CurUser.ShopId;
                            datarow[dtRecorderColumn] = GlobalCaches.Instance.CurUser.RealName;
                            if (string.IsNullOrEmpty(datarow["客户电话"].ToString().Trim()))
                            {
                                datarow["客户电话"] = defaultPhone++;
                            }
                            DateTime rowDate = Convert.ToDateTime(datarow["创建时间"]).Date;
                            if (!dateList.Contains(rowDate))
                                dateList.Add(rowDate);
                        }

                        DCCRecordBusiness.Instance.BulkInsertData(tempTable);
                        runMsg = "导入成功";
                        bSuccess = true;
                    }
                    catch (Exception ex)
                    {
                        bSuccess = false;
                        runMsg = string.Format("导入失败：{0}", ex.ToString());
                    }
                    finally
                    {
                        tempTable.Dispose();
                        this.BeginInvoke(new MethodInvoker(delegate()
                        {
                            progressBar.LoadCaption = runMsg;
                            progressBar.DialogResult = DialogResult.OK;
                            this.DialogResult = DialogResult.Cancel;
                            //XtraMessageBox.Show(runMsg, "提示", MessageBoxButtons.OK);
                            if (bSuccess && RefreshTable != null)
                                RefreshTable(this, EventArgs.Empty);
                        }));
                    }
                });

                task.Start();
                progressBar.ShowDialog();
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            e.Info.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            if (e.RowHandle < 0)
                e.Info.DisplayText = "序号";

            if (e.Info.IsRowIndicator)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
