
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
using CRM_4S.Business.ViewModel;
using CRM_4S.OrderManager;

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


        private ViewQueryInfo curQueryInfo = null;
        public ViewQueryInfo CurQueryInfo
        {
            get
            {
                if (curQueryInfo == null)
                    curQueryInfo = new ViewQueryInfo()
                    {
                        ShopId = GlobalCaches.Instance.CurUser.ShopId,
                        StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1),
                        EndDate = DateTime.Now
                    };
                return curQueryInfo;
            }
            set
            {
                curQueryInfo = value;
            }
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
                    fmFrontView.RibbonSwitch += fmFrontView_RibbonSwitch;
                }
                return fmFrontView;
            }
        }

        void fmFrontView_RibbonSwitch(object sender, EventArgs e)
        {
            ribbon.SelectedPage = rPageOrder;
        }

        FmDCCView fmDCCView = null;
        FmDCCView mFmDCCView
        {
            get
            {
                if (fmDCCView == null)
                {
                    fmDCCView = new FmDCCView();
                    fmDCCView.BtnNewDCCRecall = btnNewDCCRecal;
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
                    fmBasicsView.BtnRefresh = btnRefreshBasics;


                    fmBasicsView.NavBtnItemClicked += new EventHandler<NavBarClickedArgs>((object sender, NavBarClickedArgs args) =>
                    {
                        rPageGroupBasics.Text = string.Format("{0}-管理", args.NavMenuName);
                        btnAddBasics.Caption = string.Format("新增[{0}]", args.NavMenuName);
                        btnUpdateBasics.Caption = string.Format("更新[{0}]", args.NavMenuName);
                        btnDeleteBasics.Caption = string.Format("删除[{0}]", args.NavMenuName);
                        btnRefreshBasics.Caption = string.Format("刷新[{0}]", args.NavMenuName);
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
                    fmAnalyseView.TxtConsName = txtConsName;
                    fmAnalyseView.TxtConsPhone = txtConsPhone;
                    fmAnalyseView.DtStartDate = dtStartDate;
                    fmAnalyseView.DtEndDate = dtEndDate;
                }

                return fmAnalyseView;
            }
        }

        FmOrderView fmOrderView = null;
        FmOrderView mFmOrderView
        {
            get
            {
                if (fmOrderView == null)
                {
                    fmOrderView = new FmOrderView();
                    fmOrderView.BtnAdd = btnAddOrder;
                    fmOrderView.BtnUpdate = btnUpdateOrder;
                    fmOrderView.BtnDelete = btnCanelOrder;
                    fmOrderView.BtnRefresh = btnRefreshOrder;
                }
                return fmOrderView;
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
            mRibbonPages.Add(rPageOrder, mFmOrderView);
            mRibbonPages.Add(rPageAnalyze, mFmAnalyseView);

            if (GlobalCaches.Instance.CurUser.RoleId == GlobalConstants.RoleIdConsultManager)
            {
                ribbon.Pages.Remove(rPageUser);
                ribbon.SelectedPage = rPageBasics;
                return;
            }

            if (GlobalCaches.Instance.CurUser.RoleId == GlobalConstants.RoleIdShopFront)
            {
                ribbon.Pages.Remove(rPageUser);
                ribbon.Pages.Remove(rPageBasics);
                ribbon.Pages.Remove(rPageAnalyze);
                ribbon.SelectedPage = rPageFront;
                return;
            }

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
                    //ribbon.Pages.RemoveAt(0);
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
            new FmUserInfo(new UserShopRoleInfo() { User = GlobalCaches.Instance.CurUser }).ShowDialog();
        }


        /// <summary>
        /// 获取（全记录）时间查询条件 
        /// </summary>
        /// <param name="dateRange"></param>
        /// <returns></returns>
        private ViewQueryInfo GetViewDateQuery(QueryDateRange dateRange)
        {
            var dateNow = DateTime.Now;
            var startDate = DateTime.Now;
            var endDate = dateNow;

            //if (dateRange == QueryDateRange.ThisWeek)
            //    startDate = dateNow.AddDays(1 - Convert.ToInt32(dateNow.DayOfWeek.ToString("d")));

            if (dateRange == QueryDateRange.ThisMonth)
                startDate = dateNow.AddDays(1 - dateNow.Day);

            if (dateRange == QueryDateRange.ThisQuarter)
                startDate = dateNow.AddMonths(0 - (dateNow.Month - 1) % 3).AddDays(1 - dateNow.Day);

            if (dateRange == QueryDateRange.ThisYear)
                startDate = new DateTime(dateNow.Year, 1, 1);

            if (dateRange == QueryDateRange.Customer)
            {
                FmCustomTime customTime = new FmCustomTime();
                customTime.StartDate = CurQueryInfo.StartDate.HasValue ? CurQueryInfo.StartDate.Value : DateTime.Now;
                customTime.EndDate = CurQueryInfo.EndDate.HasValue ? CurQueryInfo.EndDate.Value : DateTime.Now;

                if (customTime.ShowDialog() == DialogResult.OK)
                {
                    ViewQueryInfo queryInfo = new ViewQueryInfo();
                    startDate = customTime.StartDate;
                    endDate = customTime.EndDate;
                }
            }
            return new ViewQueryInfo() { DateRange = dateRange, StartDate = startDate, EndDate = dateNow };
            //return new ViewQueryGoodsInfo() { DateRange = dateRange, StartPurchaseDate = startDate, StartSaledDate = startDate, EndPurchaseDate = dateNow, EndSaledDate = dateNow };
        }

        private void btnThisMonth_ItemClick(object sender, ItemClickEventArgs e)
        {
            CurQueryInfo = GetViewDateQuery(QueryDateRange.ThisMonth);
            RefreshView(this.CurQueryInfo);
        }

        private void btnThisQuarter_ItemClick(object sender, ItemClickEventArgs e)
        {
            CurQueryInfo = GetViewDateQuery(QueryDateRange.ThisQuarter);
            RefreshView(this.CurQueryInfo);
        }

        private void btnThisYear_ItemClick(object sender, ItemClickEventArgs e)
        {
            CurQueryInfo = GetViewDateQuery(QueryDateRange.ThisYear);
            RefreshView(this.CurQueryInfo);
        }

        private void btnCustomTime_ItemClick(object sender, ItemClickEventArgs e)
        {
            CurQueryInfo = GetViewDateQuery(QueryDateRange.Customer);
            RefreshView(this.CurQueryInfo);
        }

        private void RefreshView(ViewQueryInfo queryInfo)
        {
            if (ribbon.SelectedPage == rPageFront)
            {
                fmFrontView.QInfo = queryInfo;
                return;
            }

            if (ribbon.SelectedPage == rPageDCC)
            {
                fmDCCView.QInfo = queryInfo;
                return;
            }
            if (ribbon.SelectedPage == rPageOrder)
            {
                fmOrderView.QInfo = queryInfo;
                return;
            }
        }
    }
}
