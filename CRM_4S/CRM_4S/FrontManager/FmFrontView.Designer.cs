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
            this.clmArrivalTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmLeaveTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCustomerPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCustomerNature = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCarLicence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPurposeCar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmDriveStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmIndustry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.sourceFrontCustomer.DataSource = typeof(CRM_4S.Business.Model.FrontCustomerInfo);
            // 
            // gridViewFrontRecord
            // 
            this.gridViewFrontRecord.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmArrivalTime,
            this.clmLeaveTime,
            this.clmCustomerName,
            this.clmCustomerPhone,
            this.clmCustomerNature,
            this.clmCarLicence,
            this.clmPurposeCar,
            this.clmDriveStatus,
            this.clmIndustry,
            this.clmAddress,
            this.clmLevel,
            this.gridColumn12,
            this.clmDurationTime,
            this.clmCustomerNum,
            this.clmRemark});
            this.gridViewFrontRecord.GridControl = this.gridControlFrontRecord;
            this.gridViewFrontRecord.Name = "gridViewFrontRecord";
            this.gridViewFrontRecord.OptionsView.ShowGroupPanel = false;
            // 
            // clmArrivalTime
            // 
            this.clmArrivalTime.Caption = "到店时间";
            this.clmArrivalTime.FieldName = "VisitRecord.ArrivalTime.Value";
            this.clmArrivalTime.Name = "clmArrivalTime";
            this.clmArrivalTime.Visible = true;
            this.clmArrivalTime.VisibleIndex = 0;
            // 
            // clmLeaveTime
            // 
            this.clmLeaveTime.Caption = "离店时间";
            this.clmLeaveTime.FieldName = "VisitRecord.LeaveTime.Value";
            this.clmLeaveTime.Name = "clmLeaveTime";
            this.clmLeaveTime.Visible = true;
            this.clmLeaveTime.VisibleIndex = 1;
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
            // clmCustomerNature
            // 
            this.clmCustomerNature.Caption = "客户性质";
            this.clmCustomerNature.FieldName = "Customer.Nature";
            this.clmCustomerNature.Name = "clmCustomerNature";
            this.clmCustomerNature.Visible = true;
            this.clmCustomerNature.VisibleIndex = 4;
            // 
            // clmCarLicence
            // 
            this.clmCarLicence.Caption = "牌照状况";
            this.clmCarLicence.FieldName = "VisitRecord.CarLicence";
            this.clmCarLicence.Name = "clmCarLicence";
            this.clmCarLicence.Visible = true;
            this.clmCarLicence.VisibleIndex = 5;
            // 
            // clmPurposeCar
            // 
            this.clmPurposeCar.Caption = "意向车型";
            this.clmPurposeCar.FieldName = "VisitRecord.PurposeCar";
            this.clmPurposeCar.Name = "clmPurposeCar";
            this.clmPurposeCar.Visible = true;
            this.clmPurposeCar.VisibleIndex = 6;
            // 
            // clmDriveStatus
            // 
            this.clmDriveStatus.Caption = "是否试驾";
            this.clmDriveStatus.FieldName = "VisitRecord.DriveStatus";
            this.clmDriveStatus.Name = "clmDriveStatus";
            this.clmDriveStatus.Visible = true;
            this.clmDriveStatus.VisibleIndex = 7;
            // 
            // clmIndustry
            // 
            this.clmIndustry.Caption = "行业";
            this.clmIndustry.FieldName = "Customer.Industry";
            this.clmIndustry.Name = "clmIndustry";
            this.clmIndustry.Visible = true;
            this.clmIndustry.VisibleIndex = 8;
            // 
            // clmAddress
            // 
            this.clmAddress.Caption = "居住区域";
            this.clmAddress.FieldName = "Customer.Address";
            this.clmAddress.Name = "clmAddress";
            this.clmAddress.Visible = true;
            this.clmAddress.VisibleIndex = 9;
            // 
            // clmLevel
            // 
            this.clmLevel.Caption = "客户级别";
            this.clmLevel.FieldName = "Customer.Level";
            this.clmLevel.Name = "clmLevel";
            this.clmLevel.Visible = true;
            this.clmLevel.VisibleIndex = 10;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "销售顾问";
            this.gridColumn12.FieldName = "ConsultantUser.RealName";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 11;
            // 
            // clmDurationTime
            // 
            this.clmDurationTime.Caption = "接待时长";
            this.clmDurationTime.FieldName = "VisitRecord.DurationTime";
            this.clmDurationTime.Name = "clmDurationTime";
            this.clmDurationTime.Visible = true;
            this.clmDurationTime.VisibleIndex = 12;
            // 
            // clmCustomerNum
            // 
            this.clmCustomerNum.Caption = "接待人数";
            this.clmCustomerNum.FieldName = "VisitRecord.CustomerNum";
            this.clmCustomerNum.Name = "clmCustomerNum";
            this.clmCustomerNum.Visible = true;
            this.clmCustomerNum.VisibleIndex = 13;
            // 
            // clmRemark
            // 
            this.clmRemark.Caption = "需求描述";
            this.clmRemark.FieldName = "VisitRecord.Remark";
            this.clmRemark.Name = "clmRemark";
            this.clmRemark.Visible = true;
            this.clmRemark.VisibleIndex = 14;
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
        private DevExpress.XtraGrid.Columns.GridColumn clmCustomerNature;
        private DevExpress.XtraGrid.Columns.GridColumn clmCarLicence;
        private DevExpress.XtraGrid.Columns.GridColumn clmPurposeCar;
        private DevExpress.XtraGrid.Columns.GridColumn clmDriveStatus;
        private DevExpress.XtraGrid.Columns.GridColumn clmIndustry;
        private DevExpress.XtraGrid.Columns.GridColumn clmAddress;
        private DevExpress.XtraGrid.Columns.GridColumn clmLevel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn clmDurationTime;
        private DevExpress.XtraGrid.Columns.GridColumn clmCustomerNum;
        private DevExpress.XtraGrid.Columns.GridColumn clmRemark;
        private System.Windows.Forms.BindingSource sourceFrontCustomer;

    }
}