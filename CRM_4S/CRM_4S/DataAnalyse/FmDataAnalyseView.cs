using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRM_4S.DataAnalyse
{
    public partial class FmDataAnalyseView : Form
    {
        public FmDataAnalyseView()
        {
            InitializeComponent();
        }

        #region Public Controls

        private BarButtonItem btnSingleAnalyse = null;
        public BarButtonItem BtnSingleAnalyse
        {
            get { return btnSingleAnalyse; }
            set
            {
                btnSingleAnalyse = value;
                if (btnSingleAnalyse != null)
                {
                    btnSingleAnalyse.ItemClick += btnSingleAnalyse_ItemClick;
                }
            }
        }

       


        private BarButtonItem btnGroupAnalyse = null;
        public BarButtonItem BtnGroupAnalyse
        {
            get { return btnGroupAnalyse; }
            set
            {
                btnGroupAnalyse = value;
                if (btnGroupAnalyse != null)
                {
                    btnGroupAnalyse.ItemClick += btnGroupAnalyse_ItemClick;
                }
            }
        }

        void btnGroupAnalyse_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FmAnalyseResult().Show();
        }


        void btnSingleAnalyse_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FmAnalyseResult().Show();
        }

        #endregion
    }
}
