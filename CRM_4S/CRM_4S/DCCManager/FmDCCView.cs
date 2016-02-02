using CRM_4S.Business;
using CRM_4S.Business.BusinessModel;
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
        }

        #region Public control

        private BarButtonItem btnDCCAdd = null;
        public BarButtonItem BtnDCCAdd
        {
            get { return btnDCCAdd; }
            set
            {
                btnDCCAdd = value;
                if (btnDCCAdd != null)
                {
                    btnDCCAdd.ItemClick += btnDCCAdd_ItemClick;
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
                XtraMessageBox.Show("保存成功");
            }
        }

        private void btnDCCImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FmDCCImport().ShowDialog();
        }
        private void btnDCCRecall_ItemClick(object sender, ItemClickEventArgs e)
        {
            var rowData = gridViewDCCRecord.GetRow(gridViewDCCRecord.GetSelectedRows()[0]);
            new FmDCCRecall(rowData as DCCCustomerRecordInfo).ShowDialog();
        }

        private void btnDCCAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FmDCCIn().ShowDialog();
        }

        #endregion


        private void RefreshDCCRecordView()
        {
            var listResults = DCCRecordBusiness.Instance.GetDCCRecords(GloablCaches.Instance.CurUser.ShopId);
            gridControlDCCRecord.DataSource = listResults;
            gridControlDCCRecord.DefaultView.RefreshData();
        }

        private void defaultGridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "clmDCCSource")
            {
                e.DisplayText = e.CellValue == null ? "" : GloablCaches.Instance.ConstantInfos.FirstOrDefault(info => info.Id == (int)e.CellValue).Name;
                return;
            }

            if (e.Column.Name == "cmlDCCStatus")
            {
                e.DisplayText = e.CellValue == null ? "" : GloablCaches.Instance.ConstantInfos.FirstOrDefault(info => info.Id == (int)e.CellValue).Name;
                return;
            }

            if (e.Column.Name == "clmPurposeCar")
            {
                e.DisplayText = e.CellValue == null ? "" : GloablCaches.Instance.CarTypes.FirstOrDefault(t => t.Id == (int)e.CellValue).ToString();
                return;
            }

            if (e.Column.Name == "clmIsLogin")
            {
                e.DisplayText = e.CellValue == null ? "" : GloablConstants.BooleanDesc[(int)e.CellValue];
                return;
            }
            if (e.Column.Name == "clmPromiseShop")
            {
                e.DisplayText = e.CellValue == null ? "" : GloablConstants.BooleanDesc[(int)e.CellValue];
                return;
            }
        }

        private void gridViewFrontRecord_DoubleClick(object sender, EventArgs e)
        {
            btnDCCRecall_ItemClick(sender, null);
        }

        private void FmDCCView_Load(object sender, EventArgs e)
        {
            RefreshDCCRecordView();
        }
    }
}
