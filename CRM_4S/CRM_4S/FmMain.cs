
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
using DevExpress.XtraBars;
using CRM_4S.BasicsManager;
using CRM_4S.DataAnalyse;

namespace CRM_4S
{
    public partial class FmMain : RibbonFormSimpleDialogBase
    {
        Dictionary<RibbonPage, Form> mRibbonPages = new Dictionary<RibbonPage, Form>();

        public FmMain()
            : base(Language.Chinese)
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
                    fmUserView.BtnAdd = btnAddUser;
                    fmUserView.BtnUpdate = btnUpdateUser;
                    fmUserView.BtnRefresh = btnUserRefresh;
                    fmUserView.BtnResetPwd = btnResetPwd;
                }
                return fmUserView;
            }
        }

        FmFrontView fmFrontView = null;
        FmFrontView mFmFrontView
        {
            get
            {
                if (fmFrontView == null)
                {
                    fmFrontView = new FmFrontView();
                    fmFrontView.BtnFrontIn = btnFrontCustomerIn;
                    fmFrontView.BtnCustomerOut = btnFrontCustomerOut;
                    fmFrontView.BtnRefresh = btnFrontRefresh;
                    fmFrontView.BtnCustomerImport = btnFrontImport;
                    fmFrontView.BtnCustomerExport = btnFrontExport;
                }
                return fmFrontView;
            }
        }

        FmDCCView fmDCCView = null;
        FmDCCView mFmDCCView
        {
            get
            {
                if (fmDCCView == null)
                {
                    fmDCCView = new FmDCCView();
                    fmDCCView.BtnDCCAdd = btnDCCAdd;
                    fmDCCView.BtnDCCRecall = btnDCCRecall;
                    fmDCCView.BtnDCCImport = btnDCCImport;
                    fmDCCView.BtnDCCExport = btnDCCExport;
                    fmDCCView.BtnDCCRefresh = btnDCCRefresh;
                }
                return fmDCCView;
            }
        }

        FmBasicsView fmBasicsView = null;
        FmBasicsView mFmBasicsView
        {
            get
            {
                if (fmBasicsView == null)
                {
                    fmBasicsView = new FmBasicsView();
                    fmBasicsView.BtnAdd = btnAddBasics;
                    fmBasicsView.BtnUpdate = btnUpdateBasics;
                    fmBasicsView.BtnDelete = btnDeleteBasics;
                    fmBasicsView.BtnRefresh = btnBasicsRefresh;


                    fmBasicsView.NavBtnItemClicked += new EventHandler<NavBarClickedArgs>((object sender, NavBarClickedArgs args) =>
                    {
                        rPageGroupBasics.Text = string.Format("{0}-管理", args.NavMenuName);
                        btnAddBasics.Caption = string.Format("新增[{0}]", args.NavMenuName);
                        btnUpdateBasics.Caption = string.Format("更新[{0}]", args.NavMenuName);
                        btnDeleteBasics.Caption = string.Format("删除[{0}]", args.NavMenuName);
                        btnBasicsRefresh.Caption = string.Format("刷新[{0}]", args.NavMenuName);
                    });
                }
                return fmBasicsView;
            }
        }

        FmDataAnalyseView fmAnalyseView = null;
        FmDataAnalyseView mFmAnalyseView
        {
            get
            {
                if (fmAnalyseView == null)
                {
                    fmAnalyseView = new FmDataAnalyseView();
                    fmAnalyseView.BtnGroupAnalyse = btnGroupAnalyse;
                    fmAnalyseView.BtnSingleAnalyse = btnSingleAnalyse;
                }

                return fmAnalyseView;
            }
        }

        #endregion

        /// <summary>
        /// 添加 子窗体
        /// </summary>
        private void AddRibbonPageViews()
        {
            mRibbonPages.Add(rPageUser, mFmUserView);
            mRibbonPages.Add(rPageFront, mFmFrontView);
            mRibbonPages.Add(rPageDCC, mFmDCCView);
            mRibbonPages.Add(rPageBasics, mFmBasicsView);
            mRibbonPages.Add(rPageAnalyze, mFmAnalyseView);

            ribbon.SelectedPage = null;
            ribbon.SelectedPage = rPageUser;
        }

        private void FmMain_Load(object sender, EventArgs e)
        {
            AddRibbonPageViews();
            ribbon.Pages.RemoveAt(0);
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

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdatePwd_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FmUpdatePwd().ShowDialog();
        }

        private void btnUpdateUserInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FmUserInfo().ShowDialog();
        }

        private void btnThisMonth_ItemClick(object sender, ItemClickEventArgs e)
        {
            showSumView();
        }

        private void btnThisQuarter_ItemClick(object sender, ItemClickEventArgs e)
        {
            showSumView();
        }

        private void btnThisYear_ItemClick(object sender, ItemClickEventArgs e)
        {
            showSumView();
        }

        private void btnCustomTime_ItemClick(object sender, ItemClickEventArgs e)
        {
           DialogResult result =  new FmFrontCustomTime().ShowDialog();
           if (result == DialogResult.OK)
           {
               showSumView();
           }
        }

        private void showSumView()
        {
            pageViewContainer.Controls.Clear();
            Form sumView = new FmFrontSumView();
            sumView.TopLevel = false;
            sumView.Dock = DockStyle.Fill;
            pageViewContainer.Controls.Add(sumView);
            sumView.Show();
        }
    }
}
