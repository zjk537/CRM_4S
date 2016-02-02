
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CRM_4S.Common.FormBase;
using CRM_4S.Common;
using DevExpress.XtraBars.Ribbon;
using CRM_4S.UserManager;
using CRM_4S.FrontManager;
using CRM_4S.DCCManager;
using DevExpress.XtraBars;
using CRM_4S.BasicsManager;
using CRM_4S.DataAnalyse;
using CRM_4S.Business.BusinessModel;
using CRM_4S.Business;
using System.Threading;
using System.Runtime.Remoting.Messaging;
using DevExpress.XtraEditors;

namespace CRM_4S
{
    public partial class FmMain : RibbonFormSimpleDialogBase
    {

        #region Login 
        
        private ManualResetEvent waitInitializeHandler = new ManualResetEvent(false);
        private ManualResetEvent waitloginHandler = null;
        private delegate void FormShowHandler();
        public DialogResult loginResult = DialogResult.Abort;


        private void Login()
        {
            FmLogin flogin = new FmLogin(waitInitializeHandler);
            waitloginHandler = flogin.waitLoginHandler;
            flogin.SetDialogResult += SetDialogResult;

            loginResult = flogin.ShowDialog();
        }

        private void SetDialogResult(DialogResult dialogResult)
        {
            this.loginResult = dialogResult;
        }

        private void LoginCallback(IAsyncResult ar)
        {
            try
            {
                AsyncResult result = (AsyncResult)ar;

                ((FormShowHandler)result.AsyncDelegate).EndInvoke(ar);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("Method: LoginCallback \r\bMssage:{0}", ex.Message));
            }
        }

        #endregion

        public FmMain()
            : base(Language.Chinese)
        {
            InitializeComponent();

            new FormShowHandler(Login).BeginInvoke(new AsyncCallback(LoginCallback), null);
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

            waitInitializeHandler.WaitOne();
        }



        Dictionary<RibbonPage, Form> mRibbonPages = new Dictionary<RibbonPage, Form>();

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
            try
            {
                if (loginResult == DialogResult.OK)
                {
                    this.WindowState = FormWindowState.Maximized;
                    this.ShowInTaskbar = true;

                    AddRibbonPageViews();
                    ribbon.Pages.RemoveAt(0);
                }
                else
                {
                    Application.Exit();
                }
            }
            finally
            {
                if (waitloginHandler != null)
                {
                    waitloginHandler.Set();
                }
            }
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
            new FmUserInfo(new UserShopRoleInfo() { User = GloablCaches.Instance.CurUser }).ShowDialog();
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
            DialogResult result = new FmFrontCustomTime().ShowDialog();
            if (result == DialogResult.OK)
            {
                
                showSumView();
            }
        }

        private void showSumView()
        {
            //pageViewContainer.Controls.Clear();
            //Form sumView = new FmFrontSumView();
            //sumView.TopLevel = false;
            //sumView.Dock = DockStyle.Fill;
            //pageViewContainer.Controls.Add(sumView);
            //sumView.Show();
        }
    }
}
