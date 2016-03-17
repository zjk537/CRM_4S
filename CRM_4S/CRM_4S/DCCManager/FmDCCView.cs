using CRM_4S.Business;
using CRM_4S.Business.BusinessModel;
using CRM_4S.Business.ViewModel;
using CRM_4S.Model.DataModel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRM_4S.DCCManager
{
    public partial class FmDCCView : Form
    {
        public FmDCCView()
        {
            InitializeComponent();
            initView();
            DCCRecordBusiness.Instance.OnDataChanged += new EventHandler<CusEventArgs>((object sender, CusEventArgs args) => { RefreshDCCRecordView(); });
        }

        private void initView()
        {
            this.gridViewDCCRecord.IndicatorWidth = 50;
        }

        #region Public control
        private BarButtonItem btnNewDCCRecall = null;
        public BarButtonItem BtnNewDCCRecall
        {
            get { return btnNewDCCRecall; }
            set
            {
                btnNewDCCRecall = value;
                if (btnNewDCCRecall != null)
                {
                    btnNewDCCRecall.ItemClick += btnNewDCCRecall_ItemClick;
                    btnNewDCCRecall.Enabled = GlobalCaches.Instance.CurUser.RoleId != GlobalConstants.RoleIdSysAdmin;
                }
            }
        }



        private BarButtonItem btnDCCRecall = null;
        public BarButtonItem BtnDCCRecall
        {
            get { return btnDCCRecall; }
            set
            {
                btnDCCRecall = value;
                if (btnDCCRecall != null)
                {
                    btnDCCRecall.ItemClick += btnDCCRecall_ItemClick;
                    btnDCCRecall.Enabled = GlobalCaches.Instance.CurUser.RoleId != GlobalConstants.RoleIdSysAdmin;
                }
            }
        }
        private BarButtonItem btnDCCImport = null;
        public BarButtonItem BtnDCCImport
        {
            get { return btnDCCImport; }
            set
            {
                btnDCCImport = value;
                if (btnDCCImport != null)
                {
                    btnDCCImport.ItemClick += btnDCCImport_ItemClick;
                    btnDCCImport.Enabled = GlobalCaches.Instance.CurUser.RoleId != GlobalConstants.RoleIdSysAdmin;
                }
            }
        }

        private BarButtonItem btnDCCExport = null;
        public BarButtonItem BtnDCCExport
        {
            get { return btnDCCExport; }
            set
            {
                btnDCCExport = value;
                if (btnDCCExport != null)
                {
                    btnDCCExport.ItemClick += btnDCCExport_ItemClick;
                }
            }
        }

        private BarButtonItem btnDCCRefresh = null;
        public BarButtonItem BtnDCCRefresh
        {
            get { return btnDCCRefresh; }
            set
            {
                btnDCCRefresh = value;
                if (btnDCCRefresh != null)
                {
                    btnDCCRefresh.ItemClick += btnDCCRefresh_ItemClick;
                }
            }
        }

        private void btnDCCRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshDCCRecordView();
        }

        private void btnDCCExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                XlsExportOptions options = new XlsExportOptions(TextExportMode.Value, true, true);
                try
                {
                    this.gridViewDCCRecord.ExportToXls(fileName, options);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(string.Format("保存失败：{0}", ex.ToString()), "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDCCImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FmDCCImport().ShowDialog();
        }
        private void btnDCCRecall_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selectedRows = gridViewDCCRecord.GetSelectedRows();
            if (selectedRows == null || selectedRows.Length == 0)
            {
                new FmDCCRecall().ShowDialog();
            }
            else
            {
                var rowData = gridViewDCCRecord.GetRow(selectedRows[0]);
                new FmDCCRecall(rowData as DCCCustomerRecordInfo).ShowDialog();
            }
        }

        private void btnNewDCCRecall_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FmDCCRecall().ShowDialog();
        }

        #endregion


        private ViewQueryInfo qInfo = null;
        public ViewQueryInfo QInfo
        {
            get
            {
                qInfo = new ViewQueryInfo()
                {
                    ShopId = GlobalCaches.Instance.CurUser.ShopId,
                    StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1),
                    EndDate = DateTime.Now
                };
                return qInfo;
            }
            set
            {
                qInfo = value;
                if (qInfo != null)
                {
                    qInfo.ShopId = GlobalCaches.Instance.CurUser.ShopId;
                    RefreshDCCRecordView();
                }
            }
        }

        private void RefreshDCCRecordView()
        {
            var listResults = DCCRecordBusiness.Instance.GetDCCRecords(this.QInfo);
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(delegate()
                {
                    gridControlDCCRecord.DataSource = listResults;
                    gridControlDCCRecord.DefaultView.RefreshData();
                    this.btnDCCRecall.Enabled = listResults.Count > 0;
                }));
            }
            else
            {
                gridControlDCCRecord.DataSource = listResults;
                gridControlDCCRecord.DefaultView.RefreshData();
                this.btnDCCRecall.Enabled = listResults.Count > 0;
            }
        }

        private void FmDCCView_Load(object sender, EventArgs e)
        {
            RefreshDCCRecordView();
        }

        private void gridViewDCCRecord_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            e.Info.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            if (e.RowHandle < 0)
                e.Info.DisplayText = "序号";

            if (e.Info.IsRowIndicator)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        /// <summary>
        /// 双击处理事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewDCCRecord_MouseDown(object sender, MouseEventArgs e)
        {
            // 判断是否为左键双击
            if (e.Button != MouseButtons.Left || e.Clicks != 2)
                return;

            GridHitInfo hInfo = gridViewDCCRecord.CalcHitInfo(new Point(e.X, e.Y));
            //判断光标是否在行范围内  
            if (!hInfo.InRow || !hInfo.InRowCell)
                return;
            btnDCCRecall_ItemClick(sender, null);
        }
    }
}
