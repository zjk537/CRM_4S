using CRM_4S.Business;
using CRM_4S.Business.BusinessModel;
using CRM_4S.Common;
using CRM_4S.Model.DataModel;
using CRM_4S.Model.EnumType;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraNavBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRM_4S.BasicsManager
{
    public partial class FmBasicsView : Form
    {
        public EventHandler<NavBarClickedArgs> NavBtnItemClicked;

        private ColumnView defaultGridView;
        public FmBasicsView()
        {
            InitializeComponent();
            initView();

            ShopBusiness.Instance.OnDataChanged += new EventHandler<CusEventArgs>((object sender, CusEventArgs args) => { RefreshView(); });
            CarTypeBusiness.Instance.OnDataChanged += new EventHandler<CusEventArgs>((object sender, CusEventArgs args) => { RefreshView(); });
            PurposeLevelBusiness.Instance.OnDataChanged += new EventHandler<CusEventArgs>((object sender, CusEventArgs args) => { RefreshView(); });
            EvaluateQuestionBusiness.Instance.OnDataChanged += new EventHandler<CusEventArgs>((object sender, CusEventArgs args) => { RefreshView(); });
            UserTaskBusiness.Instance.OnDataChanged += new EventHandler<CusEventArgs>((object sender, CusEventArgs args) => { RefreshView(); });
            AnalyseKPIBusiness.Instance.OnDataChanged += new EventHandler<CusEventArgs>((object sender, CusEventArgs args) => { RefreshView(); });
        }

        private void initView()
        {
            navBarBasics.AllowSelectedLink = true;
            gridControlShop.Dock = gridControlCarType.Dock = gridControlLevel.Dock =
                gridControlConsultant.Dock = gridControlQuestion.Dock = gridControlAnalyse.Dock = DockStyle.Fill;
            gridControlShop.Visible = gridControlCarType.Visible = gridControlLevel.Visible =
                gridControlConsultant.Visible = gridControlQuestion.Visible = gridControlAnalyse.Visible = false;

            //navBtnItem_LinkClicked(this.navBtnShop, null);

            
        }

        private void FmBasicsView_Load(object sender, EventArgs e)
        {
            if (GlobalCaches.Instance.CurUser.RoleId == GlobalConstants.RoleIdConsultManager)
            {
                this.navBarGroup1.ItemLinks.Remove(this.navBtnShop);
                this.navBarGroup1.ItemLinks.Remove(this.navBtnQuestion);
                this.navBarGroup1.ItemLinks.Remove(this.navBtnLevel);
                this.navBarGroup1.ItemLinks.Remove(this.navBtnAnalyse);
            }

            navBtnItem_LinkClicked(this.navBarGroup1.ItemLinks[0].Item, null);
        }

        #region Refresh View

        private void RefreshView()
        {
            try
            {
                RefreshShopView();
                RefreshCarTypeView();
                RefreshLevelView();
                RefreshConsultantView();
                RefreshQuestionView();
                RefreshAnalyseView();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("获取数据失败，请稍后重试", "提示", MessageBoxButtons.OK);
            }
        }

        private void RefreshShopView()
        {
            if (gridControlShop.Visible)
            {
                var listResult = ShopBusiness.Instance.GetShops();
                gridControlShop.DataSource = listResult;
                gridControlShop.DefaultView.RefreshData();
                defaultGridView = gridControlShop.DefaultView as ColumnView;
            }
        }

        private void RefreshCarTypeView()
        {
            if (gridControlCarType.Visible)
            {
                var listResult = CarTypeBusiness.Instance.GetCarTypes();
                gridControlCarType.DataSource = listResult;
                gridControlCarType.DefaultView.RefreshData();
                defaultGridView = gridControlCarType.DefaultView as ColumnView;
            }
        }
        private void RefreshLevelView()
        {
            if (gridControlLevel.Visible)
            {
                var listResult = PurposeLevelBusiness.Instance.GetPurposeLevels();
                gridControlLevel.DataSource = listResult;
                gridControlLevel.DefaultView.RefreshData();
                defaultGridView = gridControlLevel.DefaultView as ColumnView;
            }
        }
        private void RefreshConsultantView()
        {
            if (gridControlConsultant.Visible)
            {
                var listResult = UserTaskBusiness.Instance.GetUserCarTypeTasks();
                gridControlConsultant.DataSource = listResult;
                gridControlConsultant.DefaultView.RefreshData();
                defaultGridView = gridControlConsultant.DefaultView as ColumnView;
            }
        }
        private void RefreshQuestionView()
        {
            if (gridControlQuestion.Visible)
            {
                var listResult = EvaluateQuestionBusiness.Instance.GetEvaluateQuestions();
                gridControlQuestion.DataSource = listResult;
                gridControlQuestion.DefaultView.RefreshData();
                defaultGridView = gridControlQuestion.DefaultView as ColumnView;
            }
        }
        private void RefreshAnalyseView()
        {
            if (gridControlAnalyse.Visible)
            {
                var listResult = AnalyseKPIBusiness.Instance.GetAnalyseKPIs();
                gridControlAnalyse.DataSource = listResult;
                gridControlAnalyse.DefaultView.RefreshData();
                defaultGridView = gridControlAnalyse.DefaultView as ColumnView;
            }
        }

        #endregion


        #region init public button

        BarButtonItem btnAdd = null;
        public BarButtonItem BtnAdd
        {
            get { return btnAdd; }
            set
            {
                btnAdd = value;
                if (btnAdd != null)
                {
                    btnAdd.ItemClick += btnAdd_ItemClick;
                }
            }
        }

        BarButtonItem btnUpdate = null;
        public BarButtonItem BtnUpdate
        {
            get { return btnUpdate; }
            set
            {
                btnUpdate = value;
                if (btnUpdate != null)
                {
                    btnUpdate.ItemClick += btnUpdate_ItemClick;
                }
            }
        }

        BarButtonItem btnDelete = null;
        public BarButtonItem BtnDelete
        {
            get { return btnDelete; }
            set
            {
                btnDelete = value;
                if (btnDelete != null)
                {
                    btnDelete.ItemClick += btnDelete_ItemClick;
                }
            }
        }

        BarButtonItem btnRefresh = null;
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

        void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshView();
        }

        void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (defaultGridView == null || defaultGridView.SelectedRowsCount <= 0)
            {
                return;
            }

            if (!UICommon.DeleteConfirm())
            {
                return;
            }

            Object rowData = defaultGridView.GetRow(defaultGridView.GetSelectedRows()[0]);
            if (navBtnShop.Links[0].State == ObjectState.Selected)
            {
                ShopBusiness.Instance.DeleteShop(rowData as ShopInfo);
            }
            else if (navBtnCarType.Links[0].State == ObjectState.Selected)
            {
                CarTypeBusiness.Instance.DeleteCarType(rowData as CarTypeInfo);
            }
            else if (navBtnLevel.Links[0].State == ObjectState.Selected)
            {
                PurposeLevelBusiness.Instance.DeletePurposeLevel(rowData as PurposeLevelInfo);
            }
            else if (navBtnConsultantTask.Links[0].State == ObjectState.Selected)
            {
                UserTaskBusiness.Instance.DeleteUserTask((rowData as UserCarTypeTaskInfo).UserTask);
            }
            else if (navBtnQuestion.Links[0].State == ObjectState.Selected)
            {
                EvaluateQuestionBusiness.Instance.DeleteEvaluateQuestion(rowData as EvaluateQuestionInfo);
            }
            else if (navBtnAnalyse.Links[0].State == ObjectState.Selected)
            {
                AnalyseKPIBusiness.Instance.DeleteAnalyseKPI(rowData as AnalyseKPIInfo);
            }
        }
        void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (defaultGridView == null || defaultGridView.SelectedRowsCount <= 0)
            {
                return;
            }

            Object rowData = defaultGridView.GetRow(defaultGridView.GetSelectedRows()[0]);
            if (navBtnShop.Links[0].State == ObjectState.Selected)
            {
                new FmShopInfo(rowData as ShopInfo).ShowDialog();
            }
            else if (navBtnCarType.Links[0].State == ObjectState.Selected)
            {
                new FmCarTypeInfo(rowData as CarTypeInfo).ShowDialog();
            }
            else if (navBtnLevel.Links[0].State == ObjectState.Selected)
            {
                new FmPurposeLevelInfo(rowData as PurposeLevelInfo).ShowDialog();
            }
            else if (navBtnConsultantTask.Links[0].State == ObjectState.Selected)
            {
                new FmConsultantTaskInfo(rowData as UserCarTypeTaskInfo).ShowDialog();
            }
            else if (navBtnQuestion.Links[0].State == ObjectState.Selected)
            {
                new FmQuestionInfo(rowData as EvaluateQuestionInfo).ShowDialog();
            }
            else if (navBtnAnalyse.Links[0].State == ObjectState.Selected)
            {
                new FmAnalyseInfo(rowData as AnalyseKPIInfo).ShowDialog();
            }
        }
        void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (navBtnShop.Links[0].State == ObjectState.Selected)
            {
                new FmShopInfo().ShowDialog();
            }
            else if (navBtnCarType.Links[0].State == ObjectState.Selected)
            {
                new FmCarTypeInfo().ShowDialog();
            }
            else if (navBtnLevel.Links[0].State == ObjectState.Selected)
            {
                new FmPurposeLevelInfo().ShowDialog();
            }
            else if (navBtnConsultantTask.Links[0].State == ObjectState.Selected)
            {
                new FmConsultantTaskInfo().ShowDialog();
            }
            else if (navBtnQuestion.Links[0].State == ObjectState.Selected)
            {
                new FmQuestionInfo().ShowDialog();
            }
            else if (navBtnAnalyse.Links[0].State == ObjectState.Selected)
            {
                new FmAnalyseInfo().ShowDialog();
            }
        }

        #endregion

        private void navBtnItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (NavBtnItemClicked != null)
            {
                NavBtnItemClicked(this, new NavBarClickedArgs() { NavMenuName = ((NavBarItem)sender).Caption });
            }
            gridControlShop.Visible = sender == navBtnShop;
            gridControlCarType.Visible = sender == navBtnCarType;
            gridControlLevel.Visible = sender == navBtnLevel;
            gridControlConsultant.Visible = sender == navBtnConsultantTask;
            gridControlQuestion.Visible = sender == navBtnQuestion;
            gridControlAnalyse.Visible = sender == navBtnAnalyse;

            RefreshView();
        }

        private void defaultGridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            defaultGridView = sender as ColumnView;

            if (defaultGridView != null)
            {
                if (defaultGridView.IsRowSelected(e.ControllerRow))
                {
                    defaultGridView.SelectRow(e.ControllerRow);
                }
                //ButtonUpdate.Enabled = GridDefaultView.SelectedRowsCount > 0;
            }
        }

        private void defaultGridView_DoubleClick(object sender, EventArgs e)
        {
            btnUpdate_ItemClick(sender, null);
        }
        private void defaultGridView_MouseDown(object sender, MouseEventArgs e)
        {
            // 判断是否为左键双击
            if (e.Button != MouseButtons.Left || e.Clicks != 2)
                return;
            var gridView = (GridView)sender;
            GridHitInfo hInfo = gridView.CalcHitInfo(new Point(e.X, e.Y));
            //判断光标是否在行范围内  
            if (!hInfo.InRow || !hInfo.InRowCell)
                return;

            btnUpdate_ItemClick(sender, null);

        }

        private void defaultGridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "clmTaskStatus")
            {
                e.DisplayText = GlobalConstants.UserTaskStatus[(int)e.CellValue];
                return;
            }

            if (e.Column.Name == "clmQType")
            {
                e.DisplayText = GlobalCaches.Instance.ConstantInfos.FirstOrDefault(info => info.Id == (int)e.CellValue).Name;
                return;
            }

            if (e.Column.Name == "clmKValue")
            {
                var rowData = (AnalyseKPIInfo) defaultGridView.GetRow(e.RowHandle);
                e.DisplayText = rowData.KValue + rowData.KUnit;
            }

            if (e.Column.Name == "clmShopAddress")
            {
                var rowData = (ShopInfo)defaultGridView.GetRow(e.RowHandle);
                RegionInfo region = GlobalCaches.Instance.RegionInfos.FirstOrDefault(info => info.Id == rowData.RegionId);
                e.DisplayText = string.Format("{0} {1}", region, rowData.Address);
            }
        }

        
    }

    public class NavBarClickedArgs : EventArgs
    {
        public string NavMenuName { get; set; }
    }
}
