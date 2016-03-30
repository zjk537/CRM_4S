namespace CRM_4S.FrontManager
{
    partial class FmFrontView
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
            this.gridControlFrontRecord = new DevExpress.XtraGrid.GridControl();
            this.sourceFrontCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewFrontRecord = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmShopName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmArrivalTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmLeaveTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmConsultantName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCustomerPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCNature = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmToShopNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCurCar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPurposeCar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmInstallment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmReplace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmDriveStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCarLicence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmIndustry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmDurationTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCustomerNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFrontRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceFrontCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFrontRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlFrontRecord
            // 
            this.gridControlFrontRecord.DataSource = this.sourceFrontCustomer;
            this.gridControlFrontRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFrontRecord.Location = new System.Drawing.Point(0, 0);
            this.gridControlFrontRecord.MainView = this.gridViewFrontRecord;
            this.gridControlFrontRecord.Name = "gridControlFrontRecord";
            this.gridControlFrontRecord.Size = new System.Drawing.Size(990, 421);
            this.gridControlFrontRecord.TabIndex = 0;
            this.gridControlFrontRecord.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFrontRecord});
            // 
            // sourceFrontCustomer
            // 
            this.sourceFrontCustomer.DataSource = typeof(CRM_4S.Business.BusinessModel.FrontCustomerRecordInfo);
            // 
            // gridViewFrontRecord
            // 
            this.gridViewFrontRecord.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmShopName,
            this.clmArrivalTime,
            this.clmLeaveTime,
            this.clmConsultantName,
            this.clmCustomerName,
            this.clmCustomerPhone,
            this.clmCNature,
            this.clmToShopNum,
            this.clmCurCar,
            this.clmPurposeCar,
            this.clmInstallment,
            this.clmReplace,
            this.clmDriveStatus,
            this.clmLevel,
            this.clmCarLicence,
            this.clmSource,
            this.clmIndustry,
            this.clmDurationTime,
            this.clmAddress,
            this.clmCustomerNum,
            this.clmRemark});
            this.gridViewFrontRecord.GridControl = this.gridControlFrontRecord;
            this.gridViewFrontRecord.Name = "gridViewFrontRecord";
            this.gridViewFrontRecord.OptionsBehavior.Editable = false;
            this.gridViewFrontRecord.OptionsPrint.AutoWidth = false;
            this.gridViewFrontRecord.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewFrontRecord.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewFrontRecord_CustomDrawRowIndicator);
            this.gridViewFrontRecord.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridViewFrontRecord_MouseDown);
            // 
            // clmShopName
            // 
            this.clmShopName.Caption = "店面名称";
            this.clmShopName.FieldName = "Shop.Name";
            this.clmShopName.Name = "clmShopName";
            // 
            // clmArrivalTime
            // 
            this.clmArrivalTime.Caption = "到店时间";
            this.clmArrivalTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.clmArrivalTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clmArrivalTime.FieldName = "FrontRecord.ArrivalTime";
            this.clmArrivalTime.Name = "clmArrivalTime";
            this.clmArrivalTime.Visible = true;
            this.clmArrivalTime.VisibleIndex = 0;
            // 
            // clmLeaveTime
            // 
            this.clmLeaveTime.Caption = "离店时间";
            this.clmLeaveTime.DisplayFormat.FormatString = "d";
            this.clmLeaveTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clmLeaveTime.FieldName = "FrontRecord.LeaveTime";
            this.clmLeaveTime.Name = "clmLeaveTime";
            // 
            // clmConsultantName
            // 
            this.clmConsultantName.Caption = "销售顾问";
            this.clmConsultantName.FieldName = "ConsultantUser.RealName";
            this.clmConsultantName.Name = "clmConsultantName";
            this.clmConsultantName.Visible = true;
            this.clmConsultantName.VisibleIndex = 1;
            // 
            // clmCustomerName
            // 
            this.clmCustomerName.Caption = "客户姓名";
            this.clmCustomerName.FieldName = "Customer.Name";
            this.clmCustomerName.Name = "clmCustomerName";
            this.clmCustomerName.Visible = true;
            this.clmCustomerName.VisibleIndex = 2;
            // 
            // clmCustomerPhone
            // 
            this.clmCustomerPhone.Caption = "联系电话";
            this.clmCustomerPhone.FieldName = "Customer.Phone";
            this.clmCustomerPhone.Name = "clmCustomerPhone";
            this.clmCustomerPhone.Visible = true;
            this.clmCustomerPhone.VisibleIndex = 3;
            // 
            // clmCNature
            // 
            this.clmCNature.AppearanceCell.Options.UseTextOptions = true;
            this.clmCNature.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmCNature.Caption = "客户性质";
            this.clmCNature.FieldName = "CNatureName";
            this.clmCNature.Name = "clmCNature";
            this.clmCNature.Visible = true;
            this.clmCNature.VisibleIndex = 4;
            // 
            // clmToShopNum
            // 
            this.clmToShopNum.AppearanceCell.Options.UseTextOptions = true;
            this.clmToShopNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmToShopNum.Caption = "到店次数";
            this.clmToShopNum.FieldName = "Customer.ToShopNum";
            this.clmToShopNum.Name = "clmToShopNum";
            // 
            // clmCurCar
            // 
            this.clmCurCar.Caption = "现有车型";
            this.clmCurCar.FieldName = "Customer.CurCar";
            this.clmCurCar.Name = "clmCurCar";
            // 
            // clmPurposeCar
            // 
            this.clmPurposeCar.AppearanceCell.Options.UseTextOptions = true;
            this.clmPurposeCar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmPurposeCar.Caption = "意向车型";
            this.clmPurposeCar.FieldName = "PurposeCarName";
            this.clmPurposeCar.Name = "clmPurposeCar";
            this.clmPurposeCar.Visible = true;
            this.clmPurposeCar.VisibleIndex = 5;
            // 
            // clmInstallment
            // 
            this.clmInstallment.AppearanceCell.Options.UseTextOptions = true;
            this.clmInstallment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmInstallment.Caption = "是否分期";
            this.clmInstallment.FieldName = "Installment";
            this.clmInstallment.Name = "clmInstallment";
            // 
            // clmReplace
            // 
            this.clmReplace.AppearanceCell.Options.UseTextOptions = true;
            this.clmReplace.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmReplace.Caption = "是否置换";
            this.clmReplace.FieldName = "Replace";
            this.clmReplace.Name = "clmReplace";
            // 
            // clmDriveStatus
            // 
            this.clmDriveStatus.AppearanceCell.Options.UseTextOptions = true;
            this.clmDriveStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmDriveStatus.Caption = "是否试驾";
            this.clmDriveStatus.FieldName = "DriveStatus";
            this.clmDriveStatus.Name = "clmDriveStatus";
            this.clmDriveStatus.Visible = true;
            this.clmDriveStatus.VisibleIndex = 6;
            // 
            // clmLevel
            // 
            this.clmLevel.Caption = "意向级别";
            this.clmLevel.FieldName = "FrontRecord.LevelCode";
            this.clmLevel.Name = "clmLevel";
            this.clmLevel.Visible = true;
            this.clmLevel.VisibleIndex = 7;
            // 
            // clmCarLicence
            // 
            this.clmCarLicence.AppearanceCell.Options.UseTextOptions = true;
            this.clmCarLicence.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmCarLicence.Caption = "牌照状况";
            this.clmCarLicence.FieldName = "CarLicence";
            this.clmCarLicence.Name = "clmCarLicence";
            // 
            // clmSource
            // 
            this.clmSource.AppearanceCell.Options.UseTextOptions = true;
            this.clmSource.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmSource.Caption = "客户来源";
            this.clmSource.FieldName = "CSource";
            this.clmSource.Name = "clmSource";
            this.clmSource.Visible = true;
            this.clmSource.VisibleIndex = 8;
            // 
            // clmIndustry
            // 
            this.clmIndustry.Caption = "行业";
            this.clmIndustry.FieldName = "Customer.Industry";
            this.clmIndustry.Name = "clmIndustry";
            // 
            // clmDurationTime
            // 
            this.clmDurationTime.Caption = "接待时长";
            this.clmDurationTime.FieldName = "FrontRecord.DurationTime";
            this.clmDurationTime.Name = "clmDurationTime";
            this.clmDurationTime.Visible = true;
            this.clmDurationTime.VisibleIndex = 9;
            // 
            // clmAddress
            // 
            this.clmAddress.Caption = "居住地址";
            this.clmAddress.FieldName = "Customer.Address";
            this.clmAddress.Name = "clmAddress";
            this.clmAddress.Visible = true;
            this.clmAddress.VisibleIndex = 10;
            // 
            // clmCustomerNum
            // 
            this.clmCustomerNum.AppearanceCell.Options.UseTextOptions = true;
            this.clmCustomerNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmCustomerNum.Caption = "接待人数";
            this.clmCustomerNum.FieldName = "FrontRecord.CustomerNum";
            this.clmCustomerNum.Name = "clmCustomerNum";
            // 
            // clmRemark
            // 
            this.clmRemark.Caption = "需求描述";
            this.clmRemark.FieldName = "FrontRecord.Remark";
            this.clmRemark.Name = "clmRemark";
            this.clmRemark.Visible = true;
            this.clmRemark.VisibleIndex = 11;
            // 
            // popMenu
            // 
            this.popMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.popMenu.Manager = this.barManager1;
            this.popMenu.Name = "popMenu";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(990, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 421);
            this.barDockControlBottom.Size = new System.Drawing.Size(990, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 421);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(990, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 421);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "下单";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // FmFrontView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 421);
            this.Controls.Add(this.gridControlFrontRecord);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmFrontView";
            this.Text = "FrontView";
            this.Load += new System.EventHandler(this.FmFrontView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFrontRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceFrontCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFrontRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlFrontRecord;
        private System.Windows.Forms.BindingSource sourceFrontCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFrontRecord;
        private DevExpress.XtraGrid.Columns.GridColumn clmShopName;
        private DevExpress.XtraGrid.Columns.GridColumn clmArrivalTime;
        private DevExpress.XtraGrid.Columns.GridColumn clmLeaveTime;
        private DevExpress.XtraGrid.Columns.GridColumn clmConsultantName;
        private DevExpress.XtraGrid.Columns.GridColumn clmCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn clmCustomerPhone;
        private DevExpress.XtraGrid.Columns.GridColumn clmCNature;
        private DevExpress.XtraGrid.Columns.GridColumn clmToShopNum;
        private DevExpress.XtraGrid.Columns.GridColumn clmCurCar;
        private DevExpress.XtraGrid.Columns.GridColumn clmPurposeCar;
        private DevExpress.XtraGrid.Columns.GridColumn clmInstallment;
        private DevExpress.XtraGrid.Columns.GridColumn clmReplace;
        private DevExpress.XtraGrid.Columns.GridColumn clmDriveStatus;
        private DevExpress.XtraGrid.Columns.GridColumn clmLevel;
        private DevExpress.XtraGrid.Columns.GridColumn clmCarLicence;
        private DevExpress.XtraGrid.Columns.GridColumn clmSource;
        private DevExpress.XtraGrid.Columns.GridColumn clmIndustry;
        private DevExpress.XtraGrid.Columns.GridColumn clmDurationTime;
        private DevExpress.XtraGrid.Columns.GridColumn clmAddress;
        private DevExpress.XtraGrid.Columns.GridColumn clmCustomerNum;
        private DevExpress.XtraGrid.Columns.GridColumn clmRemark;
        private DevExpress.XtraBars.PopupMenu popMenu;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;

    }
}