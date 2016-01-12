using CRM_4S.Business;
using CRM_4S.Business.Model;
using DevExpress.XtraBars;
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
        }

        private void initView()
        {

        }

        #region public controls
        private BarButtonItem btnCustomerIn = null;
        public BarButtonItem BtnCustomerIn
        {
            get { return btnCustomerIn; }
            set
            {
                btnCustomerIn = value;
                if (btnCustomerIn != null)
                {
                    btnCustomerIn.ItemClick += btnCustomerIn_ItemClick;
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

        }
        private void btnCustomerImport_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        void btnCustomerOut_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        void btnCustomerIn_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FmFrontCustomerInfo().ShowDialog();
        }

        #endregion

        List<FrontCustomerInfo> dataSource = null;
        public List<FrontCustomerInfo> DataSource
        {
            get
            {
                if (dataSource == null)
                {
                    dataSource = new List<FrontCustomerInfo>();
                    dataSource.AddRange(CustomerBusiness.Instance.GetFrontCustomerRecords());
                }
                return dataSource;
            }
            set
            {
                dataSource = value;

            }
        }

        private void FmFrontView_Load(object sender, EventArgs e)
        {
            gridControlFrontRecord.DataSource = DataSource;
        }

    }
}
