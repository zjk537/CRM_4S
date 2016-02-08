using CRM_4S.Business;
using CRM_4S.Business.BusinessModel;
using CRM_4S.Model.DataModel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                XtraMessageBox.Show("保存成功");
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



        private void FmFrontView_Load(object sender, EventArgs e)
        {
            RefreshFrontRecordView();
        }

        private void RefreshFrontRecordView()
        {
            var listResults = FrontRecordBusiness.Instance.GetFrontRecords(GloablCaches.Instance.CurUser.ShopId);
            gridControlFrontRecord.DataSource = listResults;
            gridControlFrontRecord.DefaultView.RefreshData();
        }

        private void defaultGridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "clmCNature" || e.Column.Name == "clmCarLicence" || e.Column.Name == "clmSource")
            {
                e.DisplayText = e.CellValue == null ? "" : GloablCaches.Instance.ConstantInfos.FirstOrDefault(info => info.Id == (int)e.CellValue).Name; 
                return;
            }
            if (e.Column.Name == "clmPurposeCar")
            {
                e.DisplayText = e.CellValue == null ? "" : GloablCaches.Instance.CarTypes.FirstOrDefault(info => info.Id == (int)e.CellValue).ToString();
            }
            if (e.Column.Name == "clmDriveStatus" || e.Column.Name == "clmInstallment" || e.Column.Name == "clmReplace")
            {
                e.DisplayText = e.CellValue == null ? "" : GloablConstants.BooleanDesc[(int)e.CellValue - 1];
                return;
            }

            if (e.Column.Name == "clmAddress")
            {
                var rowData = (FrontCustomerRecordInfo)this.gridViewFrontRecord.GetRow(e.RowHandle);
                RegionInfo region = GloablCaches.Instance.RegionInfos.FirstOrDefault(info => info.Id == rowData.Customer.RegionId);
                e.DisplayText = string.Format("{0} {1}", region, rowData.Customer.Address);
            }
        }

        private void gridViewFrontRecord_DoubleClick(object sender, EventArgs e)
        {
            btnCustomerOut_ItemClick(sender, null);
        }

        private void gridViewFrontRecord_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            this.gridViewFrontRecord.IndicatorWidth = 40;
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}
