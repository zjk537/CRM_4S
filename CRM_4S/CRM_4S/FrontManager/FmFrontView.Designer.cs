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
            this.clmRecordCnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCustomerPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCNature = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCarLicence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPurposeCar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmDriveStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmIndustry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmConsultantName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmDurationTime = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.clmRecordCnt,
            this.clmCustomerName,
            this.clmCustomerPhone,
            this.clmCNature,
            this.clmCarLicence,
            this.clmPurposeCar,
            this.clmDriveStatus,
            this.clmIndustry,
            this.clmAddress,
            this.clmLevel,
            this.clmConsultantName,
            this.clmDurationTime,
            this.clmCustomerNum,
            this.clmRemark});
            this.gridViewFrontRecord.GridControl = this.gridControlFrontRecord;
            this.gridViewFrontRecord.Name = "gridViewFrontRecord";
            this.gridViewFrontRecord.OptionsBehavior.Editable = false;
            this.gridViewFrontRecord.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.defaultGridView_CustomDrawCell);
            this.gridViewFrontRecord.DoubleClick += new System.EventHandler(this.gridViewFrontRecord_DoubleClick);
            // 
            // clmShopName
            // 
            this.clmShopName.Caption = "店面名称";
            this.clmShopName.FieldName = "Shop.Name";
            this.clmShopName.Name = "clmShopName";
            this.clmShopName.Visible = true;
            this.clmShopName.VisibleIndex = 0;
            // 
            // clmArrivalTime
            // 
            this.clmArrivalTime.Caption = "到店时间";
            this.clmArrivalTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.clmArrivalTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clmArrivalTime.FieldName = "FrontRecord.ArrivalTime";
            this.clmArrivalTime.Name = "clmArrivalTime";
            this.clmArrivalTime.Visible = true;
            this.clmArrivalTime.VisibleIndex = 1;
            // 
            // clmLeaveTime
            // 
            this.clmLeaveTime.Caption = "离店时间";
            this.clmLeaveTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.clmLeaveTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clmLeaveTime.FieldName = "FrontRecord.LeaveTime";
            this.clmLeaveTime.Name = "clmLeaveTime";
            this.clmLeaveTime.Visible = true;
            this.clmLeaveTime.VisibleIndex = 2;
            // 
            // clmRecordCnt
            // 
            this.clmRecordCnt.AppearanceCell.Options.UseTextOptions = true;
            this.clmRecordCnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmRecordCnt.Caption = "进店次数";
            this.clmRecordCnt.FieldName = "RecordCnt";
            this.clmRecordCnt.Name = "clmRecordCnt";
            this.clmRecordCnt.Visible = true;
            this.clmRecordCnt.VisibleIndex = 3;
            // 
            // clmCustomerName
            // 
            this.clmCustomerName.Caption = "客户姓名";
            this.clmCustomerName.FieldName = "Customer.Name";
            this.clmCustomerName.Name = "clmCustomerName";
            this.clmCustomerName.Visible = true;
            this.clmCustomerName.VisibleIndex = 4;
            // 
            // clmCustomerPhone
            // 
            this.clmCustomerPhone.Caption = "联系电话";
            this.clmCustomerPhone.FieldName = "Customer.Phone";
            this.clmCustomerPhone.Name = "clmCustomerPhone";
            this.clmCustomerPhone.Visible = true;
            this.clmCustomerPhone.VisibleIndex = 5;
            // 
            // clmCNature
            // 
            this.clmCNature.AppearanceCell.Options.UseTextOptions = true;
            this.clmCNature.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmCNature.Caption = "客户性质";
            this.clmCNature.FieldName = "Customer.Nature";
            this.clmCNature.Name = "clmCNature";
            this.clmCNature.Visible = true;
            this.clmCNature.VisibleIndex = 6;
            // 
            // clmCarLicence
            // 
            this.clmCarLicence.AppearanceCell.Options.UseTextOptions = true;
            this.clmCarLicence.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmCarLicence.Caption = "牌照状况";
            this.clmCarLicence.FieldName = "FrontRecord.CarLicence";
            this.clmCarLicence.Name = "clmCarLicence";
            this.clmCarLicence.Visible = true;
            this.clmCarLicence.VisibleIndex = 7;
            // 
            // clmPurposeCar
            // 
            this.clmPurposeCar.AppearanceCell.Options.UseTextOptions = true;
            this.clmPurposeCar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmPurposeCar.Caption = "意向车型";
            this.clmPurposeCar.FieldName = "FrontRecord.PurposeCar";
            this.clmPurposeCar.Name = "clmPurposeCar";
            this.clmPurposeCar.Visible = true;
            this.clmPurposeCar.VisibleIndex = 8;
            // 
            // clmDriveStatus
            // 
            this.clmDriveStatus.AppearanceCell.Options.UseTextOptions = true;
            this.clmDriveStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmDriveStatus.Caption = "是否试驾";
            this.clmDriveStatus.FieldName = "FrontRecord.DriveStatus";
            this.clmDriveStatus.Name = "clmDriveStatus";
            this.clmDriveStatus.Visible = true;
            this.clmDriveStatus.VisibleIndex = 9;
            // 
            // clmIndustry
            // 
            this.clmIndustry.Caption = "行业";
            this.clmIndustry.FieldName = "Customer.Industry";
            this.clmIndustry.Name = "clmIndustry";
            this.clmIndustry.Visible = true;
            this.clmIndustry.VisibleIndex = 10;
            // 
            // clmAddress
            // 
            this.clmAddress.Caption = "居住区域";
            this.clmAddress.FieldName = "Customer.Address";
            this.clmAddress.Name = "clmAddress";
            this.clmAddress.Visible = true;
            this.clmAddress.VisibleIndex = 11;
            // 
            // clmLevel
            // 
            this.clmLevel.Caption = "客户级别";
            this.clmLevel.FieldName = "Customer.LevelCode";
            this.clmLevel.Name = "clmLevel";
            this.clmLevel.Visible = true;
            this.clmLevel.VisibleIndex = 12;
            // 
            // clmConsultantName
            // 
            this.clmConsultantName.Caption = "销售顾问";
            this.clmConsultantName.FieldName = "ConsultantUser.RealName";
            this.clmConsultantName.Name = "clmConsultantName";
            this.clmConsultantName.Visible = true;
            this.clmConsultantName.VisibleIndex = 13;
            // 
            // clmDurationTime
            // 
            this.clmDurationTime.Caption = "接待时长";
            this.clmDurationTime.FieldName = "FrontRecord.DurationTime";
            this.clmDurationTime.Name = "clmDurationTime";
            this.clmDurationTime.Visible = true;
            this.clmDurationTime.VisibleIndex = 14;
            // 
            // clmCustomerNum
            // 
            this.clmCustomerNum.AppearanceCell.Options.UseTextOptions = true;
            this.clmCustomerNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmCustomerNum.Caption = "接待人数";
            this.clmCustomerNum.FieldName = "FrontRecord.CustomerNum";
            this.clmCustomerNum.Name = "clmCustomerNum";
            this.clmCustomerNum.Visible = true;
            this.clmCustomerNum.VisibleIndex = 15;
            // 
            // clmRemark
            // 
            this.clmRemark.Caption = "需求描述";
            this.clmRemark.FieldName = "FrontRecord.Remark";
            this.clmRemark.Name = "clmRemark";
            this.clmRemark.Visible = true;
            this.clmRemark.VisibleIndex = 16;
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
        private DevExpress.XtraGrid.Columns.GridColumn clmRecordCnt;
        private DevExpress.XtraGrid.Columns.GridColumn clmShopName;

    }
}