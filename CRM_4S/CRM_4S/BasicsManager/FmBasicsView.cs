using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
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
        public EventHandler<NavBarClickedArgs> NavBtnLinkClicked;
        public FmBasicsView()
        {
            InitializeComponent();
            initView();
        }

        private void initView()
        {
            gridControlShop.Dock = gridControlCarType.Dock = gridControlRole.Dock = DockStyle.Fill;
            gridControlShop.Visible = gridControlCarType.Visible = gridControlRole.Visible = false;

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
            if (navBtnShop.Links[0].State == ObjectState.Selected)
            {
                new FmShopInfo().ShowDialog();
            }
            else if (navBtnCarType.Links[0].State == ObjectState.Selected)
            {
                new FmCarTypeInfo().ShowDialog();
            }
            else if (navBtnRole.Links[0].State == ObjectState.Selected)
            {

            }
        }

        void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (navBtnShop.Links[0].State == ObjectState.Selected)
            {
                new FmShopInfo().ShowDialog();
            }
            else if (navBtnCarType.Links[0].State == ObjectState.Selected)
            {
                new FmCarTypeInfo().ShowDialog();
            }
            else if (navBtnRole.Links[0].State == ObjectState.Selected)
            {

            }
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
            else if (navBtnRole.Links[0].State == ObjectState.Selected)
            {

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
            else if (navBtnRole.Links[0].State == ObjectState.Selected)
            {

            }
        }

        #endregion

        private void navBtnItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            gridControlShop.Visible = sender == navBtnShop;
            gridControlCarType.Visible = sender == navBtnCarType;
            gridControlRole.Visible = sender == navBtnRole;

        }


    }

    public class NavBarClickedArgs : EventArgs
    {
        public string NavMenuName { get; set; }
    }
}
