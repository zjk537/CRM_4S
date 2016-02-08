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
using CRM_4S.Business.BusinessModel;
using CRM_4S.Model.DataModel;

namespace CRM_4S.UserManager
{
    public partial class FmUserView : XtraForm
    {
        public FmUserView()
        {
            InitializeComponent();

            clmShopName.Group();
            UserBusiness.Instance.OnDataChanged += new EventHandler<CusEventArgs>((object sender, CusEventArgs args) => { RefreshView(); });
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
            if (SelectedUser == null)
            {
                return;
            }

            try
            {
                SelectedUser.User.IdSpecify = true;
                SelectedUser.User.Pwd = "123456";
                UserBusiness.Instance.UpdateUser(SelectedUser.User);

                XtraMessageBox.Show("密码重置成功，默认为123456", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (SelectedUser.User.Id == GloablCaches.Instance.CurUser.Id)
                {
                    GloablCaches.Instance.CurUser.Pwd = SelectedUser.User.Pwd;
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("密码重置失败：\r\n{0}", ex.Message), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshView();
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
            FmUserInfo fmUserInfo = new FmUserInfo();
            fmUserInfo.ShowDialog();
        }


        #endregion


        private void RefreshView()
        {
            try
            {
                var dataSource = UserBusiness.Instance.GetUserShopRoleInfos(GloablCaches.Instance.CurUser.ShopId);
                userGridControl.DataSource = dataSource;
                userGridControl.MainView.RefreshData();
                userGridView.ExpandAllGroups();
            }
            catch (Exception e)
            {
                
                throw;
            }
            

        }

        UserShopRoleInfo SelectedUser
        {
            get
            {
                return userGridView.GetRow(userGridView.GetSelectedRows().FirstOrDefault()) as UserShopRoleInfo;
            }
        }


        private void FmUserView_Load(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void userGridView_DoubleClick(object sender, EventArgs e)
        {
            btnUpdate_ItemClick(sender, null);
        }

        private void userGridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "clmSex")
            {
                e.DisplayText = e.CellValue == null ? "" : GloablConstants.SexList[(int)e.CellValue - 1];
            }
        }

        private void userGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // button 权限设置
            if (SelectedUser == null)
            {
                return;
            }


        }


    }
}
