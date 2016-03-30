namespace CRM_4S.UserManager
{
    partial class FmUserView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.userGridControl = new DevExpress.XtraGrid.GridControl();
            this.userShopRoleInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmShopName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmRealName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmUserGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmUpdateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popMenuGroup = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnAddGroup = new DevExpress.XtraBars.BarEditItem();
            this.txtGroupName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.userGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userShopRoleInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popMenuGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // userGridControl
            // 
            this.userGridControl.DataSource = this.userShopRoleInfoBindingSource;
            this.userGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userGridControl.Location = new System.Drawing.Point(0, 0);
            this.userGridControl.MainView = this.userGridView;
            this.userGridControl.Name = "userGridControl";
            this.userGridControl.Size = new System.Drawing.Size(702, 361);
            this.userGridControl.TabIndex = 0;
            this.userGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.userGridView});
            // 
            // userShopRoleInfoBindingSource
            // 
            this.userShopRoleInfoBindingSource.DataSource = typeof(CRM_4S.Business.BusinessModel.UserShopRoleInfo);
            // 
            // userGridView
            // 
            this.userGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmShopName,
            this.clmUserName,
            this.clmRealName,
            this.clmRole,
            this.clmSex,
            this.clmPhone,
            this.clmUserGroup,
            this.clmUpdateDate,
            this.clmCreatedDate});
            this.userGridView.GridControl = this.userGridControl;
            this.userGridView.Name = "userGridView";
            this.userGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.userGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.userGridView.OptionsBehavior.Editable = false;
            this.userGridView.OptionsBehavior.ReadOnly = true;
            this.userGridView.OptionsSelection.MultiSelect = true;
            this.userGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.userGridView.OptionsView.ShowGroupPanel = false;
            this.userGridView.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.userGridView_CustomDrawCell);
            this.userGridView.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.userGridView_RowStyle);
            this.userGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.userGridView_FocusedRowChanged);
            this.userGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.userGridView_MouseDown);
            this.userGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.userGridView_MouseUp);
            this.userGridView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.userGridView_MouseMove);
            // 
            // clmShopName
            // 
            this.clmShopName.Caption = "所属店铺";
            this.clmShopName.FieldName = "Shop.Name";
            this.clmShopName.Name = "clmShopName";
            this.clmShopName.Visible = true;
            this.clmShopName.VisibleIndex = 0;
            // 
            // clmUserName
            // 
            this.clmUserName.Caption = "登录用户名";
            this.clmUserName.FieldName = "User.UserName";
            this.clmUserName.Name = "clmUserName";
            this.clmUserName.Visible = true;
            this.clmUserName.VisibleIndex = 1;
            // 
            // clmRealName
            // 
            this.clmRealName.Caption = "真实姓名";
            this.clmRealName.FieldName = "User.RealName";
            this.clmRealName.Name = "clmRealName";
            this.clmRealName.Visible = true;
            this.clmRealName.VisibleIndex = 2;
            // 
            // clmRole
            // 
            this.clmRole.Caption = "用户角色";
            this.clmRole.FieldName = "Role.Name";
            this.clmRole.Name = "clmRole";
            this.clmRole.Visible = true;
            this.clmRole.VisibleIndex = 3;
            // 
            // clmSex
            // 
            this.clmSex.AppearanceCell.Options.UseTextOptions = true;
            this.clmSex.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmSex.Caption = "性别";
            this.clmSex.FieldName = "User.Sex";
            this.clmSex.Name = "clmSex";
            this.clmSex.Visible = true;
            this.clmSex.VisibleIndex = 4;
            // 
            // clmPhone
            // 
            this.clmPhone.Caption = "联系方式";
            this.clmPhone.FieldName = "User.Phone";
            this.clmPhone.Name = "clmPhone";
            this.clmPhone.Visible = true;
            this.clmPhone.VisibleIndex = 5;
            // 
            // clmUserGroup
            // 
            this.clmUserGroup.AppearanceCell.Options.UseTextOptions = true;
            this.clmUserGroup.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmUserGroup.Caption = "分组";
            this.clmUserGroup.FieldName = "User.GroupId";
            this.clmUserGroup.Name = "clmUserGroup";
            this.clmUserGroup.Visible = true;
            this.clmUserGroup.VisibleIndex = 6;
            // 
            // clmUpdateDate
            // 
            this.clmUpdateDate.Caption = "最近更新";
            this.clmUpdateDate.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.clmUpdateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clmUpdateDate.FieldName = "User.UpdateDate";
            this.clmUpdateDate.Name = "clmUpdateDate";
            this.clmUpdateDate.Visible = true;
            this.clmUpdateDate.VisibleIndex = 8;
            // 
            // clmCreatedDate
            // 
            this.clmCreatedDate.Caption = "创建时间";
            this.clmCreatedDate.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.clmCreatedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clmCreatedDate.FieldName = "User.CreatedDate";
            this.clmCreatedDate.Name = "clmCreatedDate";
            this.clmCreatedDate.Visible = true;
            this.clmCreatedDate.VisibleIndex = 7;
            // 
            // clmRoleName
            // 
            this.clmRoleName.Caption = "用户职位";
            this.clmRoleName.FieldName = "Role.Name";
            this.clmRoleName.Name = "clmRoleName";
            this.clmRoleName.Visible = true;
            this.clmRoleName.VisibleIndex = 3;
            // 
            // popMenuGroup
            // 
            this.popMenuGroup.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAddGroup, DevExpress.XtraBars.BarItemPaintStyle.Standard)});
            this.popMenuGroup.Manager = this.barManager1;
            this.popMenuGroup.Name = "popMenuGroup";
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Caption = "名称";
            this.btnAddGroup.Edit = this.txtGroupName;
            this.btnAddGroup.Id = 3;
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Width = 100;
            // 
            // txtGroupName
            // 
            this.txtGroupName.AutoHeight = false;
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Leave += new System.EventHandler(this.txtGroupName_Leave);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAddGroup});
            this.barManager1.MaxItemId = 9;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtGroupName});
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(702, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 361);
            this.barDockControlBottom.Size = new System.Drawing.Size(702, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 361);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(702, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 361);
            // 
            // FmUserView
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(702, 361);
            this.Controls.Add(this.userGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmUserView";
            this.Text = "FmUserMainView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FmUserView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userShopRoleInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popMenuGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl userGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView userGridView;
        private DevExpress.XtraGrid.Columns.GridColumn clmShopName;
        private DevExpress.XtraGrid.Columns.GridColumn clmUserName;
        private DevExpress.XtraGrid.Columns.GridColumn clmPhone;
        private DevExpress.XtraGrid.Columns.GridColumn clmCreatedDate;
        private System.Windows.Forms.BindingSource userShopRoleInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn clmRealName;
        private DevExpress.XtraGrid.Columns.GridColumn clmUserGroup;
        private DevExpress.XtraGrid.Columns.GridColumn clmUpdateDate;
        private DevExpress.XtraGrid.Columns.GridColumn clmSex;
        private DevExpress.XtraGrid.Columns.GridColumn clmRoleName;
        private DevExpress.XtraBars.PopupMenu popMenuGroup;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarEditItem btnAddGroup;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtGroupName;
        private DevExpress.XtraGrid.Columns.GridColumn clmRole;
    }
}