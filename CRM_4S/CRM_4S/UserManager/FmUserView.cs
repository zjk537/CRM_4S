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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace CRM_4S.UserManager
{
    public partial class FmUserView : XtraForm
    {

        private IList<UserGroupInfo> groupList = null;
        private IList<UserGroupInfo> GroupList
        {
            get
            {
                if (groupList == null)
                {
                    groupList = UserBusiness.Instance.GetGroups(GlobalCaches.Instance.CurUser.ShopId);
                }
                return groupList;
            }
        }
        public FmUserView()
        {
            InitializeComponent();
            clmShopName.Group();
            BindPopGroupMenu();
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
            if (SelectedUser == null) return;

            try
            {
                SelectedUser.User.IdSpecify = true;
                SelectedUser.User.Pwd = "49ba59abbe56e057";// 123456
                UserBusiness.Instance.UpdateUser(SelectedUser.User);

                XtraMessageBox.Show("密码重置成功，默认为123456", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (SelectedUser.User.Id == GlobalCaches.Instance.CurUser.Id)
                {
                    GlobalCaches.Instance.CurUser.Pwd = SelectedUser.User.Pwd;
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
            var dataSource = UserBusiness.Instance.GetUserShopRoleInfos(GlobalCaches.Instance.CurUser.ShopId);
            userGridControl.DataSource = dataSource;
            userGridControl.MainView.RefreshData();
            userGridView.ExpandAllGroups();
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
        }

        private void userGridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "clmSex")
            {
                e.DisplayText = e.CellValue == null ? "" : GlobalConstants.SexList[(int)e.CellValue - 1];
            }
            if (e.Column.Name == "clmUserGroup" && this.GroupList != null)
            {
                int cValue = (int)e.CellValue;
                e.DisplayText = cValue == 0 ? "" : this.GroupList.FirstOrDefault(m => m.Id == cValue).Name;
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

        #region 用户分组

        //用于记录，鼠标是否已按下
        bool isMouseDown = false;
        //用于鼠标拖动多选，标记是否记录开始行
        bool isSetStartRow = false;
        //用于鼠标拖动多选，记录开始行
        private int StartRowHandle = -1;
        //用于鼠标拖动多选，记录现在行
        private int CurrentRowHandle = -1;

        //用于实现鼠标拖动选择多行功能中的一个方法，对单元格区域进行选中
        private void SelectRows(int startRow, int endRow)
        {
            if (startRow > -1 && endRow > -1)
            {
                userGridView.BeginSelection();
                userGridView.ClearSelection();
                userGridView.SelectRange(startRow, endRow);
                userGridView.EndSelection();
            }
        }

        private void userGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isMouseDown = true;

            //判断光标是否在行范围内  
            GridHitInfo hInfo = userGridView.CalcHitInfo(new Point(e.X, e.Y));
            if (!hInfo.InRow || !hInfo.InRowCell)
                return;

            if (e.Button == MouseButtons.Right)
            {
                Point p = new Point(Cursor.Position.X, Cursor.Position.Y);
                popMenuGroup.ShowPopup(p);
                return;
            }
            // 判断是否为左键双击
            if (e.Button != MouseButtons.Left || e.Clicks != 2)
                return;

            btnUpdate_ItemClick(sender, null);

        }

        private void userGridView_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                GridHitInfo info = userGridView.CalcHitInfo(e.X, e.Y);
                //如果鼠标落在单元格里
                if (info.InRow)
                {
                    if (!isSetStartRow)
                    {
                        StartRowHandle = info.RowHandle;
                        isSetStartRow = true;
                    }
                    else
                    {
                        //获得当前的单元格
                        int newRowHandle = info.RowHandle;
                        if (CurrentRowHandle != newRowHandle)
                        {
                            CurrentRowHandle = newRowHandle;
                            //选定 区域 单元格
                            SelectRows(StartRowHandle, CurrentRowHandle);
                        }
                    }
                }
            }
        }

        private void userGridView_MouseUp(object sender, MouseEventArgs e)
        {
            StartRowHandle = -1;
            CurrentRowHandle = -1;
            isMouseDown = false;
            isSetStartRow = false;
        }

        private void BindPopGroupMenu()
        {
            if (this.GroupList != null && this.GroupList.Count > 0)
            {
                for (int i = 0; i < this.GroupList.Count; i++)
                {
                    UserGroupInfo groupInfo = this.GroupList[i];
                    BarButtonItem btnItem = new BarButtonItem();
                    btnItem.Id = i + 2;
                    btnItem.Caption = groupInfo.Name;
                    btnItem.Name = string.Format("popMenu_{0}", groupInfo.Id);
                    btnItem.Tag = groupInfo;

                    btnItem.ItemClick += popMenu_ItemClick;
                    this.popMenuGroup.LinksPersistInfo.Add(new LinkPersistInfo(btnItem, i == 0));
                    this.barManager1.Items.Add(btnItem);
                }
            }
        }

        void popMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            // 设置用户分组
            BarButtonItem btnItem = ((BarManager)sender).PressedLink.Item as BarButtonItem;
            UserGroupInfo groupInfo = (UserGroupInfo)btnItem.Tag;
            int[] rowHandles = userGridView.GetSelectedRows();


            if (rowHandles.Length == 1)
            {
                var info = userGridView.GetRow(rowHandles[0]) as UserShopRoleInfo;
                info.User.GroupId = groupInfo.Id;
                info.User.IdSpecify = true;
                UserBusiness.Instance.UpdateUser(info.User);
                return;
            }

            List<UserShopRoleInfo> userList = new List<UserShopRoleInfo>();
            for (int i = 0; i < rowHandles.Length; i++)
            {
                var info = userGridView.GetRow(rowHandles[i]) as UserShopRoleInfo;
                userList.Add(info);
            }

            bool isSave = true;
            var hasGroupUsers = userList.Where(m => m.User.GroupId > 0).ToList();
            if (hasGroupUsers.Count > 0)
            {
                string msg = string.Format("用户 {0} 已有在其他分组,确定要更新他们的分组？", string.Join(",", hasGroupUsers.Select(m => m.User.RealName).ToArray()));
                DialogResult result = XtraMessageBox.Show(msg, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                isSave = result == DialogResult.OK;
            }
            if (isSave)
            {
                int[] userIds = userList.Select(m => m.User.Id).ToArray();
                UserBusiness.Instance.UpdateUserGroup(userIds, groupInfo.Id);
            }
        }

        private void txtGroupName_Leave(object sender, EventArgs e)
        {
            // create new group
            TextEdit txtName = (TextEdit)sender;
            string groupName = txtName.Text.Trim();
            if (string.IsNullOrEmpty(groupName)) return;
            // 判断是否重名
            for (int i = 0; i < barManager1.Items.Count; i++)
            {
                BarItem item = barManager1.Items[i];
                if (item.Caption == groupName)
                {
                    txtName.Text = "";
                    return;
                }
            }

            UserGroupInfo groupInfo = new UserGroupInfo()
            {
                ShopId = GlobalCaches.Instance.CurUser.ShopId,
                Name = groupName,
                Desc = "添加分组-" + groupName
            };
            UserBusiness.Instance.AddGroup(groupInfo);

            if (groupInfo.Id > 0)
            {
                BarButtonItem btnItem = new BarButtonItem();
                btnItem.Id = barManager1.Items.Count + 1;
                btnItem.Caption = groupInfo.Name;
                btnItem.Name = string.Format("popMenu_{0}", groupInfo.Id);
                btnItem.Tag = groupInfo;
                btnItem.ItemClick += popMenu_ItemClick;
                this.popMenuGroup.AddItem(btnItem);
                txtName.Text = "";
            }
        }
        #endregion

    }
}
