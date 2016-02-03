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
                        DataColumn dataColumn = new DataColumn("Recorder", typeof(string));
                        tempTable.Columns.Add(dataColumn);

                        dataColumn.SetOrdinal(0);
                        foreach (DataRow datarow in tempTable.Rows)
                        {
                            datarow[dataColumn] = GloablCaches.Instance.CurUser.RealName;
                        }

                        DataImportBusiness.Instance.BulkInsertData("Front", tempTable);
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
                            XtraMessageBox.Show(runMsg, "��ʾ", MessageBoxButtons.OK);
                        }));
                    }
                });

                task.Start();

                progressBar.ShowDialog();
            }
        }
    }
}
