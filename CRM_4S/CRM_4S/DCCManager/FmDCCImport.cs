using CRM_4S.Business;
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
                //bool isError = false;
                Task task = new Task(() =>
                {
                    try
                    {
                        XtraMessageBox.Show("Task start", "提示", MessageBoxButtons.OK);
                        DataColumn dtRecorderColumn = new DataColumn("Recorder", typeof(string));
                        DataColumn dtShopIdColumn = new DataColumn("ShopId", typeof(Int32));
                        tempTable.Columns.Add(dtShopIdColumn);
                        tempTable.Columns.Add(dtRecorderColumn);
                        dtShopIdColumn.SetOrdinal(0);
                        dtRecorderColumn.SetOrdinal(1);
                        int defaultPhone = 1;
                        XtraMessageBox.Show("总记录数" + tempTable.Rows.Count, "提示", MessageBoxButtons.OK);
                        foreach (DataRow datarow in tempTable.Rows)
                        {
                            datarow[dtShopIdColumn] = GlobalCaches.Instance.CurUser.ShopId;
                            datarow[dtRecorderColumn] = GlobalCaches.Instance.CurUser.RealName;
                            if (string.IsNullOrEmpty(datarow["客户电话"].ToString().Trim()))
                            {
                                datarow["客户电话"] = defaultPhone++;
                            }
                        }
                        XtraMessageBox.Show("start bulkInsert", "提示", MessageBoxButtons.OK);
                        DCCRecordBusiness.Instance.BulkInsertData(tempTable);
                        runMsg = "导入成功";
                        XtraMessageBox.Show(runMsg, "提示", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        runMsg = string.Format("导入失败：{0}", ex.ToString());
                        XtraMessageBox.Show(runMsg, "提示", MessageBoxButtons.OK);
                    }
                    finally
                    {
                        tempTable.Dispose();
                        this.BeginInvoke(new MethodInvoker(delegate()
                        {
                            progressBar.DialogResult = DialogResult.OK;
                            XtraMessageBox.Show(runMsg, "提示", MessageBoxButtons.OK);
                        }));
                    }
                });

                task.Start();

                progressBar.ShowDialog();
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
            this.gridView1.IndicatorWidth = e.Info.DisplayText.Length + 25;
        }
    }
}
