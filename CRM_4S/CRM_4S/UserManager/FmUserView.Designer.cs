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
            this.SourceUserShopRole = new System.Windows.Forms.BindingSource(this.components);
            this.userGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmShopName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceUserShopRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userGridControl
            // 
            this.userGridControl.DataSource = this.SourceUserShopRole;
            this.userGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userGridControl.Location = new System.Drawing.Point(0, 0);
            this.userGridControl.MainView = this.userGridView;
            this.userGridControl.Name = "userGridControl";
            this.userGridControl.Size = new System.Drawing.Size(702, 361);
            this.userGridControl.TabIndex = 0;
            this.userGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.userGridView});
            // 
            // SourceUserShopRole
            // 
            this.SourceUserShopRole.DataSource = typeof(CRM_4S.Business.Model.UserShopRoleInfo);
            // 
            // userGridView
            // 
            this.userGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmShopName,
            this.clmUserName,
            this.clmRoleName,
            this.clmPhone,
            this.clmCreatedDate});
            this.userGridView.GridControl = this.userGridControl;
            this.userGridView.Name = "userGridView";
            this.userGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.userGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.userGridView.OptionsBehavior.Editable = false;
            this.userGridView.OptionsBehavior.ReadOnly = true;
            this.userGridView.OptionsView.ShowGroupPanel = false;
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
            this.clmUserName.Caption = "用户名";
            this.clmUserName.FieldName = "User.UserName";
            this.clmUserName.Name = "clmUserName";
            this.clmUserName.Visible = true;
            this.clmUserName.VisibleIndex = 1;
            // 
            // clmRoleName
            // 
            this.clmRoleName.Caption = "用户职位";
            this.clmRoleName.FieldName = "Role.RoleName";
            this.clmRoleName.Name = "clmRoleName";
            this.clmRoleName.Visible = true;
            this.clmRoleName.VisibleIndex = 2;
            // 
            // clmPhone
            // 
            this.clmPhone.Caption = "联系方式";
            this.clmPhone.FieldName = "User.Phone";
            this.clmPhone.Name = "clmPhone";
            this.clmPhone.Visible = true;
            this.clmPhone.VisibleIndex = 3;
            // 
            // clmCreatedDate
            // 
            this.clmCreatedDate.Caption = "创建时间";
            this.clmCreatedDate.FieldName = "User.CreatedDate.Value";
            this.clmCreatedDate.Name = "clmCreatedDate";
            this.clmCreatedDate.Visible = true;
            this.clmCreatedDate.VisibleIndex = 4;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmUserView";
            this.Text = "FmUserMainView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FmUserView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceUserShopRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl userGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView userGridView;
        private DevExpress.XtraGrid.Columns.GridColumn clmShopName;
        private DevExpress.XtraGrid.Columns.GridColumn clmUserName;
        private DevExpress.XtraGrid.Columns.GridColumn clmRoleName;
        private DevExpress.XtraGrid.Columns.GridColumn clmPhone;
        private System.Windows.Forms.BindingSource SourceUserShopRole;
        private DevExpress.XtraGrid.Columns.GridColumn clmCreatedDate;
    }
}