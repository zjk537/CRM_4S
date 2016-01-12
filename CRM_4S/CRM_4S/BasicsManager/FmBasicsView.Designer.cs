namespace CRM_4S.BasicsManager
{
    partial class FmBasicsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmBasicsView));
            this.navBarBasics = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBtnShop = new DevExpress.XtraNavBar.NavBarItem();
            this.navBtnCarType = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBtnRole = new DevExpress.XtraNavBar.NavBarItem();
            this.imageList32 = new System.Windows.Forms.ImageList(this.components);
            this.imageList16 = new System.Windows.Forms.ImageList(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlRole = new DevExpress.XtraGrid.GridControl();
            this.gridViewRole = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlCarType = new DevExpress.XtraGrid.GridControl();
            this.gridViewCarType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlShop = new DevExpress.XtraGrid.GridControl();
            this.gridViewShop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.navBarBasics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCarType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCarType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewShop)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarBasics
            // 
            this.navBarBasics.ActiveGroup = this.navBarGroup1;
            this.navBarBasics.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarBasics.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarBasics.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBtnShop,
            this.navBtnCarType,
            this.navBtnRole});
            this.navBarBasics.LargeImages = this.imageList32;
            this.navBarBasics.Location = new System.Drawing.Point(0, 0);
            this.navBarBasics.Name = "navBarBasics";
            this.navBarBasics.OptionsNavPane.ExpandedWidth = 156;
            this.navBarBasics.Size = new System.Drawing.Size(156, 444);
            this.navBarBasics.SmallImages = this.imageList16;
            this.navBarBasics.TabIndex = 0;
            this.navBarBasics.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "基础数据管理";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBtnShop),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBtnCarType)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBtnShop
            // 
            this.navBtnShop.Caption = "店面管理";
            this.navBtnShop.LargeImageIndex = 2;
            this.navBtnShop.Name = "navBtnShop";
            this.navBtnShop.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBtnItem_LinkClicked);
            // 
            // navBtnCarType
            // 
            this.navBtnCarType.Caption = "车型管理";
            this.navBtnCarType.LargeImageIndex = 1;
            this.navBtnCarType.Name = "navBtnCarType";
            this.navBtnCarType.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBtnItem_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "权限管理";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBtnRole)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBtnRole
            // 
            this.navBtnRole.Caption = "角色权限";
            this.navBtnRole.LargeImageIndex = 7;
            this.navBtnRole.Name = "navBtnRole";
            this.navBtnRole.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBtnItem_LinkClicked);
            // 
            // imageList32
            // 
            this.imageList32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList32.ImageStream")));
            this.imageList32.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList32.Images.SetKeyName(0, "Category_32.png");
            this.imageList32.Images.SetKeyName(1, "PayType_32.png");
            this.imageList32.Images.SetKeyName(2, "Shop_32.png");
            this.imageList32.Images.SetKeyName(3, "SystemConfig_32.png");
            this.imageList32.Images.SetKeyName(4, "Simple_Add_32.png");
            this.imageList32.Images.SetKeyName(5, "Simple_Edit_32.png");
            this.imageList32.Images.SetKeyName(6, "Simple_Remove_32.png");
            this.imageList32.Images.SetKeyName(7, "user_group.png");
            // 
            // imageList16
            // 
            this.imageList16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList16.ImageStream")));
            this.imageList16.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList16.Images.SetKeyName(0, "Category_16.png");
            this.imageList16.Images.SetKeyName(1, "PayType_16.png");
            this.imageList16.Images.SetKeyName(2, "Shop_16.png");
            this.imageList16.Images.SetKeyName(3, "SystemConfig_16.png");
            this.imageList16.Images.SetKeyName(4, "Simple_Add_16.png");
            this.imageList16.Images.SetKeyName(5, "Simple_Edit_16.png");
            this.imageList16.Images.SetKeyName(6, "Simple_Remove_16.png");
            this.imageList16.Images.SetKeyName(7, "user_group.png");
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControlRole);
            this.panelControl1.Controls.Add(this.gridControlCarType);
            this.panelControl1.Controls.Add(this.gridControlShop);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(156, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(795, 444);
            this.panelControl1.TabIndex = 1;
            // 
            // gridControlRole
            // 
            this.gridControlRole.Location = new System.Drawing.Point(6, 224);
            this.gridControlRole.MainView = this.gridViewRole;
            this.gridControlRole.Name = "gridControlRole";
            this.gridControlRole.Size = new System.Drawing.Size(369, 200);
            this.gridControlRole.TabIndex = 6;
            this.gridControlRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRole});
            // 
            // gridViewRole
            // 
            this.gridViewRole.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn11});
            this.gridViewRole.GridControl = this.gridControlRole;
            this.gridViewRole.Name = "gridViewRole";
            this.gridViewRole.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "角色名";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "权限";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            // 
            // gridControlCarType
            // 
            this.gridControlCarType.Location = new System.Drawing.Point(381, 18);
            this.gridControlCarType.MainView = this.gridViewCarType;
            this.gridControlCarType.Name = "gridControlCarType";
            this.gridControlCarType.Size = new System.Drawing.Size(360, 200);
            this.gridControlCarType.TabIndex = 5;
            this.gridControlCarType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCarType});
            // 
            // gridViewCarType
            // 
            this.gridViewCarType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn9,
            this.gridColumn10});
            this.gridViewCarType.GridControl = this.gridControlCarType;
            this.gridViewCarType.Name = "gridViewCarType";
            this.gridViewCarType.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "汽车品牌";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "汽车型号";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "备注";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "创建时间";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            // 
            // gridControlShop
            // 
            this.gridControlShop.Location = new System.Drawing.Point(6, 18);
            this.gridControlShop.MainView = this.gridViewShop;
            this.gridControlShop.Name = "gridControlShop";
            this.gridControlShop.Size = new System.Drawing.Size(369, 200);
            this.gridControlShop.TabIndex = 4;
            this.gridControlShop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewShop});
            // 
            // gridViewShop
            // 
            this.gridViewShop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridViewShop.GridControl = this.gridControlShop;
            this.gridViewShop.Name = "gridViewShop";
            this.gridViewShop.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "店面名称";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "电话";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "地址";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "备注";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "创建时间";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // FmBasicsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 444);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.navBarBasics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmBasicsView";
            this.Text = "BasicsDataManager";
            ((System.ComponentModel.ISupportInitialize)(this.navBarBasics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCarType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCarType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarBasics;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBtnCarType;
        private DevExpress.XtraNavBar.NavBarItem navBtnShop;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private System.Windows.Forms.ImageList imageList16;
        private System.Windows.Forms.ImageList imageList32;
        private DevExpress.XtraNavBar.NavBarItem navBtnRole;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlRole;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRole;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.GridControl gridControlCarType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCarType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.GridControl gridControlShop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewShop;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}