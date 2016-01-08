
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RibbonSkin.Common.FormBase;
using RibbonSkin.Common;
using DevExpress.XtraBars.Ribbon;
using CRM_4S.UserManager;
using CRM_4S.FrontManager;
using CRM_4S.DCCManager;

namespace CRM_4S
{
    public partial class FmMain : RibbonFormSimpleDialogBase
    {
        Dictionary<RibbonPage, Form> mRibbonPages = new Dictionary<RibbonPage, Form>();

        public FmMain():base(Language.Chinese)
        {
            InitializeComponent();
        }

        #region ribbon page views
        FmUserView fmUserView = null;
        FmUserView mFmUserView
        {
            get
            {
                if (fmUserView == null)
                {
                    fmUserView = new FmUserView();
                }
                return fmUserView;
            }
        }

        FrontView fmFrontView = null;
        FrontView mFmFrontView
        {
            get
            {
                if (fmFrontView == null)
                {
                    fmFrontView = new FrontView();
                }
                return fmFrontView;
            }
        }

        DCCView fmDCCView = null;
        DCCView mFmDCCView
        {
            get
            {
                if (fmDCCView == null)
                {
                    fmDCCView = new DCCView();
                }
                return fmDCCView;
            }
        }
        
        #endregion

        /// <summary>
        /// Ìí¼Ó ×Ó´°Ìå
        /// </summary>
        private void AddRibbonPageViews()
        {
            mRibbonPages.Add(rPageUser, mFmUserView);
            mRibbonPages.Add(rPageFront, mFmFrontView);
            mRibbonPages.Add(rPageDCC, mFmDCCView);

            ribbon.SelectedPage = null;
            ribbon.SelectedPage = rPageUser;
        }

        private void FmMain_Load(object sender, EventArgs e)
        {
            AddRibbonPageViews();
        }

        private void ribbon_SelectedPageChanged(object sender, EventArgs e)
        {
            if (ribbon.SelectedPage != null && mRibbonPages.ContainsKey(ribbon.SelectedPage))
            {
                pageViewContainer.Controls.Clear();
                Form view = mRibbonPages[ribbon.SelectedPage];
                if (view != null)
                {
                    view.TopLevel = false;
                    view.Dock = DockStyle.Fill;
                    pageViewContainer.Controls.Add(view);
                    view.Show();
                }
            }
        }
    }
}
