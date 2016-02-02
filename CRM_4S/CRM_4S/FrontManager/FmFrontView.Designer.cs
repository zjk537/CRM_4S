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
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFrontRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceFrontCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFrontRecord)).BeginInit();
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
            this.gridViewFrontRecord.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewFrontRecord.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewFrontRecord_CustomDrawRowIndicator);
            this.gridViewFrontRecord.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.defaultGridView_CustomDrawCell);
            this.gridViewFrontRecord.DoubleClick += new System.EventHandler(this.gridViewFrontRecord_DoubleClick);
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
            // 
            // clmLeaveTime
            // 
            this.clmLeaveTime.Caption = "离店时间";
            this.clmLeaveTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
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
            this.clmConsultantName.VisibleIndex = 0;
            // 
            // clmCustomerName
            // 
            this.clmCustomerName.Caption = "客户姓名";
            this.clmCustomerName.FieldName = "Customer.Name";
            this.clmCustomerName.Name = "clmCustomerName";
            this.clmCustomerName.Visible = true;
            this.clmCustomerName.VisibleIndex = 1;
            // 
            // clmCustomerPhone
            // 
            this.clmCustomerPhone.Caption = "联系电话";
            this.clmCustomerPhone.FieldName = "Customer.Phone";
            this.clmCustomerPhone.Name = "clmCustomerPhone";
            this.clmCustomerPhone.Visible = true;
            this.clmCustomerPhone.VisibleIndex = 2;
            // 
            // clmCNature
            // 
            this.clmCNature.AppearanceCell.Options.UseTextOptions = true;
            this.clmCNature.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmCNature.Caption = "客户性质";
            this.clmCNature.FieldName = "Customer.Nature";
            this.clmCNature.Name = "clmCNature";
            this.clmCNature.Visible = true;
            this.clmCNature.VisibleIndex = 3;
            // 
            // clmPurposeCar
            // 
            this.clmPurposeCar.AppearanceCell.Options.UseTextOptions = true;
            this.clmPurposeCar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmPurposeCar.Caption = "意向车型";
            this.clmPurposeCar.FieldName = "FrontRecord.PurposeCar";
            this.clmPurposeCar.Name = "clmPurposeCar";
            this.clmPurposeCar.Visible = true;
            this.clmPurposeCar.VisibleIndex = 4;
            // 
            // clmInstallment
            // 
            this.clmInstallment.AppearanceCell.Options.UseTextOptions = true;
            this.clmInstallment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmInstallment.Caption = "是否分期";
            this.clmInstallment.FieldName = "FrontRecord.Installment";
            this.clmInstallment.Name = "clmInstallment";
            // 
            // clmReplace
            // 
            this.clmReplace.AppearanceCell.Options.UseTextOptions = true;
            this.clmReplace.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmReplace.Caption = "是否置换";
            this.clmReplace.FieldName = "FrontRecord.Replace";
            this.clmReplace.Name = "clmReplace";
            // 
            // clmDriveStatus
            // 
            this.clmDriveStatus.AppearanceCell.Options.UseTextOptions = true;
            this.clmDriveStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmDriveStatus.Caption = "是否试驾";
            this.clmDriveStatus.FieldName = "FrontRecord.DriveStatus";
            this.clmDriveStatus.Name = "clmDriveStatus";
            this.clmDriveStatus.Visible = true;
            this.clmDriveStatus.VisibleIndex = 5;
            // 
            // clmLevel
            // 
            this.clmLevel.Caption = "客户级别";
            this.clmLevel.FieldName = "Customer.LevelCode";
            this.clmLevel.Name = "clmLevel";
            this.clmLevel.Visible = true;
            this.clmLevel.VisibleIndex = 6;
            // 
            // clmCarLicence
            // 
            this.clmCarLicence.AppearanceCell.Options.UseTextOptions = true;
            this.clmCarLicence.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmCarLicence.Caption = "牌照状况";
            this.clmCarLicence.FieldName = "FrontRecord.CarLicence";
            this.clmCarLicence.Name = "clmCarLicence";
            // 
            // clmSource
            // 
            this.clmSource.AppearanceCell.Options.UseTextOptions = true;
            this.clmSource.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmSource.Caption = "客户来源";
            this.clmSource.FieldName = "FrontRecord.Source";
            this.clmSource.Name = "clmSource";
            this.clmSource.Visible = true;
            this.clmSource.VisibleIndex = 7;
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
            this.clmDurationTime.VisibleIndex = 8;
            // 
            // clmAddress
            // 
            this.clmAddress.Caption = "居住地址";
            this.clmAddress.FieldName = "Customer.Address";
            this.clmAddress.Name = "clmAddress";
            this.clmAddress.Visible = true;
            this.clmAddress.VisibleIndex = 9;
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
            this.clmRemark.VisibleIndex = 10;
            // 
            // FmFrontView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 421);
            this.Controls.Add(this.gridControlFrontRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmFrontView";
            this.Text = "FrontView";
            this.Load += new System.EventHandler(this.FmFrontView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFrontRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceFrontCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFrontRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlFrontRecord;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFrontRecord;
        private DevExpress.XtraGrid.Columns.GridColumn clmArrivalTime;
        private DevExpress.XtraGrid.Columns.GridColumn clmLeaveTime;
        private DevExpress.XtraGrid.Columns.GridColumn clmCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn clmCustomerPhone;
        private DevExpress.XtraGrid.Columns.GridColumn clmCNature;
        private DevExpress.XtraGrid.Columns.GridColumn clmCarLicence;
        private DevExpress.XtraGrid.Columns.GridColumn clmPurposeCar;
        private DevExpress.XtraGrid.Columns.GridColumn clmDriveStatus;
        private DevExpress.XtraGrid.Columns.GridColumn clmIndustry;
        private DevExpress.XtraGrid.Columns.GridColumn clmAddress;
        private DevExpress.XtraGrid.Columns.GridColumn clmLevel;
        private DevExpress.XtraGrid.Columns.GridColumn clmConsultantName;
        private DevExpress.XtraGrid.Columns.GridColumn clmDurationTime;
        private DevExpress.XtraGrid.Columns.GridColumn clmCustomerNum;
        private DevExpress.XtraGrid.Columns.GridColumn clmRemark;
        private System.Windows.Forms.BindingSource sourceFrontCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn clmShopName;
        private DevExpress.XtraGrid.Columns.GridColumn clmInstallment;
        private DevExpress.XtraGrid.Columns.GridColumn clmReplace;
        private DevExpress.XtraGrid.Columns.GridColumn clmSource;

    }
}