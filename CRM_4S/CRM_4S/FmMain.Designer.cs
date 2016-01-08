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
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.pageViewContainer = new DevExpress.XtraEditors.PanelControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.rPageFront = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.rPageDCC = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem6,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barButtonItem13,
            this.barButtonItem15,
            this.barButtonItem16,
            this.barButtonItem4});
            this.ribbon.MaxItemId = 39;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rPageUser,
            this.rPageFront,
            this.rPageDCC,
            this.ribbonPage3,
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4});
            this.ribbon.SelectedPage = this.rPageUser;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem10),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7, true)});
            this.btnCurUserName.Name = "btnCurUserName";
            // 
            // barButtonItem9
            // 
            resources.ApplyResources(this.barButtonItem9, "barButtonItem9");
            this.barButtonItem9.Id = 17;
            this.barButtonItem9.ImageIndex = 25;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            resources.ApplyResources(this.barButtonItem10, "barButtonItem10");
            this.barButtonItem10.Id = 18;
            this.barButtonItem10.ImageIndex = 36;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem7
            // 
            resources.ApplyResources(this.barButtonItem7, "barButtonItem7");
            this.barButtonItem7.Id = 22;
            this.barButtonItem7.ImageIndex = 37;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // barButtonItem1
            // 
            resources.ApplyResources(this.barButtonItem1, "barButtonItem1");
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.LargeImageIndex = 40;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            resources.ApplyResources(this.barButtonItem2, "barButtonItem2");
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.LargeImageIndex = 42;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            resources.ApplyResources(this.barButtonItem3, "barButtonItem3");
            this.barButtonItem3.Id = 10;
            this.barButtonItem3.LargeImageIndex = 45;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            resources.ApplyResources(this.ribbonPageGroup3, "ribbonPageGroup3");
            // 
            // barButtonItem6
            // 
            resources.ApplyResources(this.barButtonItem6, "barButtonItem6");
            this.barButtonItem6.Id = 13;
            this.barButtonItem6.LargeImageIndex = 21;
            this.barButtonItem6.Name = "barButtonItem6";
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
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem12);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem8, true);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            resources.ApplyResources(this.ribbonPageGroup4, "ribbonPageGroup4");
            // 
            // barButtonItem12
            // 
            resources.ApplyResources(this.barButtonItem12, "barButtonItem12");
            this.barButtonItem12.Id = 26;
            this.barButtonItem12.LargeImageIndex = 34;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem8
            // 
            resources.ApplyResources(this.barButtonItem8, "barButtonItem8");
            this.barButtonItem8.Id = 24;
            this.barButtonItem8.LargeImageIndex = 29;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            resources.ApplyResources(this.ribbonPageGroup8, "ribbonPageGroup8");
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            resources.ApplyResources(this.ribbonPageGroup6, "ribbonPageGroup6");
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem13);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem11, true);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            resources.ApplyResources(this.ribbonPageGroup5, "ribbonPageGroup5");
            // 
            // barButtonItem13
            // 
            resources.ApplyResources(this.barButtonItem13, "barButtonItem13");
            this.barButtonItem13.Id = 27;
            this.barButtonItem13.LargeImageIndex = 34;
            this.barButtonItem13.Name = "barButtonItem13";
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
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            resources.ApplyResources(this.ribbonPageGroup9, "ribbonPageGroup9");
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            resources.ApplyResources(this.ribbonPageGroup7, "ribbonPageGroup7");
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup10});
            this.ribbonPage3.Name = "ribbonPage3";
            resources.ApplyResources(this.ribbonPage3, "ribbonPage3");
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.barButtonItem15);
            this.ribbonPageGroup10.ItemLinks.Add(this.barButtonItem16);
            this.ribbonPageGroup10.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup10.ItemLinks.Add(this.barButtonItem6, true);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            resources.ApplyResources(this.ribbonPageGroup10, "ribbonPageGroup10");
            // 
            // barButtonItem15
            // 
            resources.ApplyResources(this.barButtonItem15, "barButtonItem15");
            this.barButtonItem15.Id = 31;
            this.barButtonItem15.LargeImageIndex = 29;
            this.barButtonItem15.Name = "barButtonItem15";
            // 
            // barButtonItem16
            // 
            resources.ApplyResources(this.barButtonItem16, "barButtonItem16");
            this.barButtonItem16.Id = 32;
            this.barButtonItem16.LargeImageIndex = 31;
            this.barButtonItem16.Name = "barButtonItem16";
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
            // barButtonItem4
            // 
            resources.ApplyResources(this.barButtonItem4, "barButtonItem4");
            this.barButtonItem4.Id = 38;
            this.barButtonItem4.LargeImageIndex = 32;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            resources.ApplyResources(this.ribbonPage1, "ribbonPage1");
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            resources.ApplyResources(this.ribbonPageGroup2, "ribbonPageGroup2");
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.PanelControl pageViewContainer;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPageFront;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.BarButtonItem barButtonItem16;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPageDCC;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;

    }
}