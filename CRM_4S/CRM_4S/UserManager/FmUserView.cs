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
using CRM_4S.Business;
using CRM_4S.Business.Model;

namespace CRM_4S.UserManager
{
    public partial class FmUserView : XtraForm
    {
        public FmUserView()
        {
            InitializeComponent();
        }

        #region Public Controls

        private BarButtonItem btnAdd = null;
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

        private BarButtonItem btnUpdate = null;
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

        private BarButtonItem btnResetPwd = null;
        public BarButtonItem BtnResetPwd
        {
            get { return btnResetPwd; }
            set
            {
                btnResetPwd = value;
                if (btnResetPwd != null)
                {
                    btnResetPwd.ItemClick += btnResetPwd_ItemClick;
                }
            }
        }

        private void btnResetPwd_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("密码重置成功，新密码为：123456");
        }

        void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            DataSource = UserBusiness.Instance.GetUserShopRoleInfos();
        }

        void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selectedRows = userGridView.GetSelectedRows();
            if (selectedRows.Count() == 0)
            {
                MessageBox.Show("请选择要修改的用户");
                return;
            }
            UserShopRoleInfo curSelUser = userGridView.GetRow(selectedRows.FirstOrDefault()) as UserShopRoleInfo;

            Form fmUserInfo = new FmUserInfo(curSelUser);
            fmUserInfo.ShowDialog();
        }


        void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form fmUserInfo = new FmUserInfo();
            fmUserInfo.ShowDialog();
        }


        #endregion

        List<UserShopRoleInfo> dataSource = null;
        IList<UserShopRoleInfo> DataSource
        {
            get
            {
                if (dataSource == null)
                {
                    dataSource = new List<UserShopRoleInfo>();
                    dataSource.AddRange(UserBusiness.Instance.GetUserShopRoleInfos());
                }
                return dataSource;
            }
            set
            {

                if (dataSource != null)
                    dataSource.Clear();
                else
                    dataSource = new List<UserShopRoleInfo>();
                dataSource.AddRange(value);
                userGridControl.MainView.RefreshData();
                userGridView.ExpandAllGroups();
            }
        }

        private void FmUserView_Load(object sender, EventArgs e)
        {
            userGridControl.DataSource = DataSource;
        }


    }
}
