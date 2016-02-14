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

namespace CRM_4S.FrontManager
{
    public partial class FmFrontView : Form
    {
        public FmFrontView()
        {
            InitializeComponent();
            initView();
            FrontRecordBusiness.Instance.OnDataChanged += new EventHandler<CusEventArgs>((object sender, CusEventArgs args) => { RefreshFrontRecordView(); });
        }

        private void initView()
        {

        }

        #region public controls
        private BarButtonItem btnFrontIn = null;
        public BarButtonItem BtnFrontIn
        {
            get { return btnFrontIn; }
            set
            {
                btnFrontIn = value;
                if (btnFrontIn != null)
                {
                    btnFrontIn.ItemClick += btnFrontIn_ItemClick;
                    // 系统管理员 不属于某个店面，没有shopId 所有涉及到店面的都不能操作
                    btnFrontIn.Enabled = GlobalCaches.Instance.CurUser.RoleId != GlobalConstants.RoleIdSysAdmin;
                }
            }
        }


        private BarButtonItem btnCustomerOut = null;
        public BarButtonItem BtnCustomerOut
        {
            get { return btnCustomerOut; }
            set
            {
                btnCustomerOut = value;
                if (btnCustomerOut != null)
                {
                    btnCustomerOut.ItemClick += btnCustomerOut_ItemClick;
                    btnCustomerOut.Enabled = GlobalCaches.Instance.CurUser.RoleId != GlobalConstants.RoleIdSysAdmin;
                }
            }
        }

        private BarButtonItem btnRefresh = null;
        public BarButtonItem BtnRefresh
        {
            get { return btnRefresh; }
            set
            {
                btnRefresh = value;
                if (btnRefresh != null)
                {
                    btnRefresh.ItemClick += btnRefresh_ItemClick;
                }
            }
        }

        private BarButtonItem btnCustomerImport = null;
        public BarButtonItem BtnCustomerImport
        {
            get { return btnCustomerImport; }
            set
            {
                btnCustomerImport = value;
                if (btnCustomerImport != null)
                {
                    btnCustomerImport.ItemClick += btnCustomerImport_ItemClick;
                    btnCustomerImport.Enabled = GlobalCaches.Instance.CurUser.RoleId != GlobalConstants.RoleIdSysAdmin;
                }
            }
        }

        private BarButtonItem btnCustomerExport = null;
        public BarButtonItem BtnCustomerExport
        {
            get { return btnCustomerExport; }
            set
            {
                btnCustomerExport = value;
                if (btnCustomerExport != null)
                {
                    btnCustomerExport.ItemClick += btnCustomerExport_ItemClick;
                }
            }
        }

        private void btnCustomerExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel|.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                XlsExportOptions options = new XlsExportOptions(TextExportMode.Value,true,true);
                try
                {
                    gridViewFrontRecord.ExportToXls(fileName, options);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(string.Format("保存失败：{0}", ex.ToString()), "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnCustomerImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FmFrontImport().ShowDialog();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshFrontRecordView();
        }

        void btnCustomerOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            Object rowData = gridViewFrontRecord.GetRow(gridViewFrontRecord.GetSelectedRows()[0]);
            new FmFrontOut(rowData as FrontCustomerRecordInfo).ShowDialog();
        }

        void btnFrontIn_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FmFrontIn().ShowDialog();
        }

        #endregion

        private ViewQueryInfo qInfo = null;
        public ViewQueryInfo QInfo
        {
            get
            {
                if (qInfo == null)
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
                    RefreshFrontRecordView();
                }
            }
        }

        private void FmFrontView_Load(object sender, EventArgs e)
        {
            RefreshFrontRecordView();
        }

        private void RefreshFrontRecordView()
        {
            var listResults = FrontRecordBusiness.Instance.GetFrontRecords(this.QInfo);
            gridControlFrontRecord.DataSource = listResults;
            gridControlFrontRecord.DefaultView.RefreshData();
        }

        private void gridViewFrontRecord_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }

            this.gridViewFrontRecord.IndicatorWidth = e.Info.DisplayText.Length + 25;
        }

        private void gridViewFrontRecord_MouseDown(object sender, MouseEventArgs e)
        {
            // 判断是否为左键双击
            if (e.Button != MouseButtons.Left || e.Clicks != 2)
                return;

            GridHitInfo hInfo = gridViewFrontRecord.CalcHitInfo(new Point(e.X, e.Y));
            //判断光标是否在行范围内  
            if (!hInfo.InRow || !hInfo.InRowCell)
                return;

            btnCustomerOut_ItemClick(sender, null);

        }
    }
}
