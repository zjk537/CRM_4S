namespace CRM_4S.DataAnalyse
{
    partial class FmDataAnalyseView
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
            this.gridControlConsultant = new DevExpress.XtraGrid.GridControl();
            this.userShopRoleInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewConsultant = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmConsultantName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmUserGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConsultant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userShopRoleInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsultant)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlConsultant
            // 
            this.gridControlConsultant.DataSource = this.userShopRoleInfoBindingSource;
            this.gridControlConsultant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlConsultant.Location = new System.Drawing.Point(0, 0);
            this.gridControlConsultant.MainView = this.gridViewConsultant;
            this.gridControlConsultant.Name = "gridControlConsultant";
            this.gridControlConsultant.Size = new System.Drawing.Size(746, 439);
            this.gridControlConsultant.TabIndex = 0;
            this.gridControlConsultant.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConsultant});
            // 
            // userShopRoleInfoBindingSource
            // 
            this.userShopRoleInfoBindingSource.DataSource = typeof(CRM_4S.Business.BusinessModel.UserShopRoleInfo);
            // 
            // gridViewConsultant
            // 
            this.gridViewConsultant.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmConsultantName,
            this.clmRole,
            this.clmPhone,
            this.clmUserGroup,
            this.clmCreatedDate});
            this.gridViewConsultant.GridControl = this.gridControlConsultant;
            this.gridViewConsultant.Name = "gridViewConsultant";
            this.gridViewConsultant.OptionsBehavior.Editable = false;
            this.gridViewConsultant.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewConsultant.OptionsView.ShowGroupPanel = false;
            this.gridViewConsultant.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewConsultant_CustomDrawCell);
            this.gridViewConsultant.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridViewConsultant_MouseDown);
            // 
            // clmConsultantName
            // 
            this.clmConsultantName.Caption = "销顾姓名";
            this.clmConsultantName.FieldName = "User.RealName";
            this.clmConsultantName.Name = "clmConsultantName";
            this.clmConsultantName.Visible = true;
            this.clmConsultantName.VisibleIndex = 0;
            // 
            // clmPhone
            // 
            this.clmPhone.Caption = "联系方式";
            this.clmPhone.FieldName = "User.Phone";
            this.clmPhone.Name = "clmPhone";
            this.clmPhone.Visible = true;
            this.clmPhone.VisibleIndex = 1;
            // 
            // clmRole
            // 
            this.clmRole.Caption = "销顾角色";
            this.clmRole.FieldName = "Role.Name";
            this.clmRole.Name = "clmRole";
            this.clmRole.Visible = true;
            this.clmRole.VisibleIndex = 1;
            // 
            // clmUserGroup
            // 
            this.clmUserGroup.AppearanceCell.Options.UseTextOptions = true;
            this.clmUserGroup.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmUserGroup.Caption = "团队名称";
            this.clmUserGroup.FieldName = "User.GroupId";
            this.clmUserGroup.Name = "clmUserGroup";
            this.clmUserGroup.Visible = true;
            this.clmUserGroup.VisibleIndex = 3;
            // 
            // clmCreatedDate
            // 
            this.clmCreatedDate.Caption = "进店时间";
            this.clmCreatedDate.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.clmCreatedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clmCreatedDate.FieldName = "User.CreatedDate";
            this.clmCreatedDate.Name = "clmCreatedDate";
            this.clmCreatedDate.Visible = true;
            this.clmCreatedDate.VisibleIndex = 4;
            // 
            // FmDataAnalyseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 439);
            this.Controls.Add(this.gridControlConsultant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmDataAnalyseView";
            this.Text = "FmConsultantView";
            this.Load += new System.EventHandler(this.FmDataAnalyseView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConsultant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userShopRoleInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsultant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlConsultant;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewConsultant;
        private DevExpress.XtraGrid.Columns.GridColumn clmConsultantName;
        private DevExpress.XtraGrid.Columns.GridColumn clmCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn clmUserGroup;
        private DevExpress.XtraGrid.Columns.GridColumn clmPhone;
        private DevExpress.XtraGrid.Columns.GridColumn clmRole;
        private System.Windows.Forms.BindingSource userShopRoleInfoBindingSource;
    }
}