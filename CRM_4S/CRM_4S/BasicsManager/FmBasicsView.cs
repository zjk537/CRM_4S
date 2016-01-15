using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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
        public FmBasicsView()
        {
            InitializeComponent();
            initView();
        }

        private void initView()
        {
            navBarBasics.AllowSelectedLink = true;
            gridControlShop.Dock = gridControlCarType.Dock = gridControlLevel.Dock = 
                gridControlConsultant.Dock = gridControlQuestion.Dock = gridControlAnalyse.Dock = DockStyle.Fill;
            gridControlShop.Visible = gridControlCarType.Visible = gridControlLevel.Visible = 
                gridControlConsultant.Visible = gridControlQuestion.Visible = gridControlAnalyse.Visible = false;

            gridControlShop.Visible = true;
        }


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
            
            XtraMessageBox.Show("刷新");
        }

        void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (navBtnShop.Links[0].State == ObjectState.Selected)
            {
                
            }
            else if (navBtnCarType.Links[0].State == ObjectState.Selected)
            {
                
            }
            else if (navBtnLevel.Links[0].State == ObjectState.Selected)
            {

            }
            else if (navBtnConsultantTask.Links[0].State == ObjectState.Selected)
            {
               
            }
            else if (navBtnQuestion.Links[0].State == ObjectState.Selected)
            {

            }
            else if (navBtnAnalyse.Links[0].State == ObjectState.Selected)
            {
                
            }
            XtraMessageBox.Show("删除");
        }
        void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
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
                NavBtnItemClicked(this, new NavBarClickedArgs() { NavMenuName = ((NavBarItem)sender).Caption});
            }
            gridControlShop.Visible = sender == navBtnShop;
            gridControlCarType.Visible = sender == navBtnCarType;
            gridControlLevel.Visible = sender == navBtnLevel;
            gridControlConsultant.Visible = sender == navBtnConsultantTask;
            gridControlQuestion.Visible = sender == navBtnQuestion;
            gridControlAnalyse.Visible = sender == navBtnAnalyse;
        }


    }

    public class NavBarClickedArgs : EventArgs
    {
        public string NavMenuName { get; set; }
    }
}
