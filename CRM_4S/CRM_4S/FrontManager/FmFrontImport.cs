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

namespace CRM_4S.FrontManager
{
    public partial class FmFrontImport : Form
    {

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
        public FmFrontImport()
        {
            InitializeComponent();
            CRM_4S.Common.DevViewDefine.ResetToNormalView(this.gridControl1.MainView, false);
            gridView1.IndicatorWidth = 50;
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
                    DtSource.Dispose();//�ͷ�ԭ��

                    DtSource = DataImportBusiness.Instance.ToDataTable(txtFilePath.Text);
                }
            }
            catch (Exception ex)
            {
                DtSource.Dispose();//�ͷ�ԭ��
                XtraMessageBox.Show("��ȡ�ļ�ʧ�ܣ��ļ���������ʹ���У�������ѡ���ļ���", "��ʾ", MessageBoxButtons.OK);
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
                FmProgressBar progressBar = new FmProgressBar("���ݵ�����........");
                var tempTable = DtSource.Copy();
                string runMsg = string.Empty;
                //bool isError = false;
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

                            if (string.IsNullOrEmpty(datarow["�ͻ��绰"].ToString().Trim()))
                            {
                                datarow["�ͻ��绰"] = defaultPhone++;
                            }
                        }
                        FrontRecordBusiness.Instance.BulkInsertData(tempTable);
                        runMsg = "����ɹ�";

                    }
                    catch (Exception ex)
                    {
                        runMsg = string.Format("����ʧ�ܣ�{0}", ex.ToString());
                    }
                    finally
                    {
                        tempTable.Dispose();
                        this.BeginInvoke(new MethodInvoker(delegate()
                        {
                            progressBar.DialogResult = DialogResult.OK;
                            this.DialogResult = DialogResult.Cancel;
                            XtraMessageBox.Show(runMsg, "��ʾ", MessageBoxButtons.OK);
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
                e.Info.DisplayText = "���";

            if (e.Info.IsRowIndicator)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();

        }
    }
}
