namespace CRM_4S
{
    partial class FmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMain));
            this.rPageUser = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rPageGroupCurUser = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnCurUserName = new DevExpress.XtraBars.BarSubItem();
            this.btnUpdatePwd = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdateUserInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnAddUser = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdateUser = new DevExpress.XtraBars.BarButtonItem();
            this.btnResetPwd = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.pageViewContainer = new DevExpress.XtraEditors.PanelControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.rPageFront = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnFrontCustomerIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnFrontCustomerOut = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnFrontCustomerImport = new DevExpress.XtraBars.BarButtonItem();
            this.btnFrontCustomerExport = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.rPageDCC = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rPageBasics = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnAddBasics = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdateBasics = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteBasics = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.rPageAnalyze = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageViewContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            // 
            // 
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnCurUserName,
            this.btnAddUser,
            this.btnUpdateUser,
            this.btnResetPwd,
            this.btnRefresh,
            this.btnUpdatePwd,
            this.btnUpdateUserInfo,
            this.btnLogout,
            this.btnFrontCustomerIn,
            this.barButtonItem11,
            this.btnAddBasics,
            this.btnUpdateBasics,
            this.btnDeleteBasics,
            this.btnFrontCustomerOut,
            this.btnFrontCustomerImport,
            this.btnFrontCustomerExport,
            this.barButtonItem1});
            this.ribbon.MaxItemId = 44;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rPageUser,
            this.rPageFront,
            this.rPageDCC,
            this.rPageBasics,
            this.rPageAnalyze});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4});
            this.ribbon.SelectedPage = this.rPageDCC;
            resources.ApplyResources(this.ribbon, "ribbon");
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.SelectedPageChanged += new System.EventHandler(this.ribbon_SelectedPageChanged);
            // 
            // rPageUser
            // 
            this.rPageUser.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rPageGroupCurUser,
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.rPageUser.Name = "rPageUser";
            resources.ApplyResources(this.rPageUser, "rPageUser");
            // 
            // rPageGroupCurUser
            // 
            this.rPageGroupCurUser.ItemLinks.Add(this.btnCurUserName);
            this.rPageGroupCurUser.Name = "rPageGroupCurUser";
            resources.ApplyResources(this.rPageGroupCurUser, "rPageGroupCurUser");
            // 
            // btnCurUserName
            // 
            resources.ApplyResources(this.btnCurUserName, "btnCurUserName");
            this.btnCurUserName.Id = 3;
            this.btnCurUserName.LargeImageIndex = 47;
            this.btnCurUserName.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUpdatePwd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUpdateUserInfo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLogout, true)});
            this.btnCurUserName.Name = "btnCurUserName";
            // 
            // btnUpdatePwd
            // 
            resources.ApplyResources(this.btnUpdatePwd, "btnUpdatePwd");
            this.btnUpdatePwd.Id = 17;
            this.btnUpdatePwd.ImageIndex = 25;
            this.btnUpdatePwd.Name = "btnUpdatePwd";
            this.btnUpdatePwd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdatePwd_ItemClick);
            // 
            // btnUpdateUserInfo
            // 
            resources.ApplyResources(this.btnUpdateUserInfo, "btnUpdateUserInfo");
            this.btnUpdateUserInfo.Id = 18;
            this.btnUpdateUserInfo.ImageIndex = 36;
            this.btnUpdateUserInfo.Name = "btnUpdateUserInfo";
            this.btnUpdateUserInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdateUserInfo_ItemClick);
            // 
            // btnLogout
            // 
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.Id = 22;
            this.btnLogout.ImageIndex = 37;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAddUser);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUpdateUser);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnResetPwd);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // btnAddUser
            // 
            resources.ApplyResources(this.btnAddUser, "btnAddUser");
            this.btnAddUser.Id = 8;
            this.btnAddUser.LargeImageIndex = 40;
            this.btnAddUser.Name = "btnAddUser";
            // 
            // btnUpdateUser
            // 
            resources.ApplyResources(this.btnUpdateUser, "btnUpdateUser");
            this.btnUpdateUser.Id = 9;
            this.btnUpdateUser.LargeImageIndex = 42;
            this.btnUpdateUser.Name = "btnUpdateUser";
            // 
            // btnResetPwd
            // 
            resources.ApplyResources(this.btnResetPwd, "btnResetPwd");
            this.btnResetPwd.Id = 10;
            this.btnResetPwd.LargeImageIndex = 45;
            this.btnResetPwd.Name = "btnResetPwd";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            resources.ApplyResources(this.ribbonPageGroup3, "ribbonPageGroup3");
            // 
            // btnRefresh
            // 
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Id = 13;
            this.btnRefresh.LargeImageIndex = 21;
            this.btnRefresh.Name = "btnRefresh";
            // 
            // pageViewContainer
            // 
            this.pageViewContainer.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("pageViewContainer.Appearance.BackColor")));
            this.pageViewContainer.Appearance.Options.UseBackColor = true;
            this.pageViewContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            resources.ApplyResources(this.pageViewContainer, "pageViewContainer");
            this.pageViewContainer.Name = "pageViewContainer";
            // 
            // repositoryItemTextEdit1
            // 
            resources.ApplyResources(this.repositoryItemTextEdit1, "repositoryItemTextEdit1");
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            resources.ApplyResources(this.repositoryItemTextEdit2, "repositoryItemTextEdit2");
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // rPageFront
            // 
            this.rPageFront.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup8,
            this.ribbonPageGroup6});
            this.rPageFront.Name = "rPageFront";
            resources.ApplyResources(this.rPageFront, "rPageFront");
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnFrontCustomerIn);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnFrontCustomerOut);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            resources.ApplyResources(this.ribbonPageGroup4, "ribbonPageGroup4");
            // 
            // btnFrontCustomerIn
            // 
            resources.ApplyResources(this.btnFrontCustomerIn, "btnFrontCustomerIn");
            this.btnFrontCustomerIn.Id = 24;
            this.btnFrontCustomerIn.LargeImageIndex = 29;
            this.btnFrontCustomerIn.Name = "btnFrontCustomerIn";
            // 
            // btnFrontCustomerOut
            // 
            resources.ApplyResources(this.btnFrontCustomerOut, "btnFrontCustomerOut");
            this.btnFrontCustomerOut.Id = 39;
            this.btnFrontCustomerOut.LargeImageIndex = 32;
            this.btnFrontCustomerOut.Name = "btnFrontCustomerOut";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnFrontCustomerImport);
            this.ribbonPageGroup8.ItemLinks.Add(this.btnFrontCustomerExport);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            resources.ApplyResources(this.ribbonPageGroup8, "ribbonPageGroup8");
            // 
            // btnFrontCustomerImport
            // 
            resources.ApplyResources(this.btnFrontCustomerImport, "btnFrontCustomerImport");
            this.btnFrontCustomerImport.Id = 40;
            this.btnFrontCustomerImport.LargeImageIndex = 35;
            this.btnFrontCustomerImport.Name = "btnFrontCustomerImport";
            // 
            // btnFrontCustomerExport
            // 
            resources.ApplyResources(this.btnFrontCustomerExport, "btnFrontCustomerExport");
            this.btnFrontCustomerExport.Id = 41;
            this.btnFrontCustomerExport.LargeImageIndex = 17;
            this.btnFrontCustomerExport.Name = "btnFrontCustomerExport";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            resources.ApplyResources(this.ribbonPageGroup6, "ribbonPageGroup6");
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem11);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            resources.ApplyResources(this.ribbonPageGroup5, "ribbonPageGroup5");
            // 
            // barButtonItem11
            // 
            resources.ApplyResources(this.barButtonItem11, "barButtonItem11");
            this.barButtonItem11.Id = 25;
            this.barButtonItem11.LargeImageIndex = 29;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // rPageDCC
            // 
            this.rPageDCC.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup9,
            this.ribbonPageGroup7});
            this.rPageDCC.Name = "rPageDCC";
            resources.ApplyResources(this.rPageDCC, "rPageDCC");
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnFrontCustomerImport);
            this.ribbonPageGroup9.ItemLinks.Add(this.btnFrontCustomerExport);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            resources.ApplyResources(this.ribbonPageGroup9, "ribbonPageGroup9");
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            resources.ApplyResources(this.ribbonPageGroup7, "ribbonPageGroup7");
            // 
            // rPageBasics
            // 
            this.rPageBasics.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup10});
            this.rPageBasics.Name = "rPageBasics";
            resources.ApplyResources(this.rPageBasics, "rPageBasics");
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btnAddBasics);
            this.ribbonPageGroup10.ItemLinks.Add(this.btnUpdateBasics);
            this.ribbonPageGroup10.ItemLinks.Add(this.btnDeleteBasics);
            this.ribbonPageGroup10.ItemLinks.Add(this.btnRefresh, true);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            resources.ApplyResources(this.ribbonPageGroup10, "ribbonPageGroup10");
            // 
            // btnAddBasics
            // 
            resources.ApplyResources(this.btnAddBasics, "btnAddBasics");
            this.btnAddBasics.Id = 31;
            this.btnAddBasics.LargeImageIndex = 29;
            this.btnAddBasics.Name = "btnAddBasics";
            // 
            // btnUpdateBasics
            // 
            resources.ApplyResources(this.btnUpdateBasics, "btnUpdateBasics");
            this.btnUpdateBasics.Id = 32;
            this.btnUpdateBasics.LargeImageIndex = 31;
            this.btnUpdateBasics.Name = "btnUpdateBasics";
            // 
            // btnDeleteBasics
            // 
            resources.ApplyResources(this.btnDeleteBasics, "btnDeleteBasics");
            this.btnDeleteBasics.Id = 38;
            this.btnDeleteBasics.LargeImageIndex = 32;
            this.btnDeleteBasics.Name = "btnDeleteBasics";
            // 
            // repositoryItemTextEdit3
            // 
            resources.ApplyResources(this.repositoryItemTextEdit3, "repositoryItemTextEdit3");
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // repositoryItemTextEdit4
            // 
            resources.ApplyResources(this.repositoryItemTextEdit4, "repositoryItemTextEdit4");
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // rPageAnalyze
            // 
            this.rPageAnalyze.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rPageAnalyze.Name = "rPageAnalyze";
            resources.ApplyResources(this.rPageAnalyze, "rPageAnalyze");
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            resources.ApplyResources(this.ribbonPageGroup2, "ribbonPageGroup2");
            // 
            // barButtonItem1
            // 
            resources.ApplyResources(this.barButtonItem1, "barButtonItem1");
            this.barButtonItem1.Id = 42;
            this.barButtonItem1.LargeImageIndex = 50;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // FmMain
            // 
            this.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("FmMain.Appearance.BackColor")));
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pageViewContainer);
            this.IsMdiContainer = true;
            this.Name = "FmMain";
            this.Load += new System.EventHandler(this.FmMain_Load);
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.pageViewContainer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageViewContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage rPageUser;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rPageGroupCurUser;
        private DevExpress.XtraBars.BarSubItem btnCurUserName;
        private DevExpress.XtraBars.BarButtonItem btnAddUser;
        private DevExpress.XtraBars.BarButtonItem btnUpdateUser;
        private DevExpress.XtraBars.BarButtonItem btnResetPwd;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.PanelControl pageViewContainer;
        private DevExpress.XtraBars.BarButtonItem btnUpdatePwd;
        private DevExpress.XtraBars.BarButtonItem btnUpdateUserInfo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPageFront;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnFrontCustomerIn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem btnAddBasics;
        private DevExpress.XtraBars.BarButtonItem btnUpdateBasics;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPageDCC;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPageBasics;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.BarButtonItem btnDeleteBasics;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPageAnalyze;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnFrontCustomerOut;
        private DevExpress.XtraBars.BarButtonItem btnFrontCustomerImport;
        private DevExpress.XtraBars.BarButtonItem btnFrontCustomerExport;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;

    }
}