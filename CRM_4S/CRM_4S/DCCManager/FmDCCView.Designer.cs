namespace CRM_4S.DCCManager
{
    partial class FmDCCView
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
            this.gridControlDCCRecord = new DevExpress.XtraGrid.GridControl();
            this.sourceDCCRecord = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewDCCRecord = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmPurposeCar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmDCCSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCustomerAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmConsultantName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmlDCCStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPromiseShop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmRecallCnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmRecallDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmIsLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmToShopTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDCCRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceDCCRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDCCRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlDCCRecord
            // 
            this.gridControlDCCRecord.DataSource = this.sourceDCCRecord;
            this.gridControlDCCRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDCCRecord.Location = new System.Drawing.Point(0, 0);
            this.gridControlDCCRecord.MainView = this.gridViewDCCRecord;
            this.gridControlDCCRecord.Name = "gridControlDCCRecord";
            this.gridControlDCCRecord.Size = new System.Drawing.Size(817, 377);
            this.gridControlDCCRecord.TabIndex = 0;
            this.gridControlDCCRecord.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDCCRecord});
            // 
            // sourceDCCRecord
            // 
            this.sourceDCCRecord.DataSource = typeof(CRM_4S.Business.BusinessModel.DCCCustomerInfo);
            // 
            // gridViewDCCRecord
            // 
            this.gridViewDCCRecord.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmPurposeCar,
            this.clmDCCSource,
            this.clmCustomerAddress,
            this.clmConsultantName,
            this.cmlDCCStatus,
            this.clmPromiseShop,
            this.clmRecallCnt,
            this.clmRecallDesc,
            this.clmIsLogin,
            this.gridColumn10,
            this.clmToShopTime,
            this.gridColumn12,
            this.gridColumn13});
            this.gridViewDCCRecord.GridControl = this.gridControlDCCRecord;
            this.gridViewDCCRecord.Name = "gridViewDCCRecord";
            this.gridViewDCCRecord.OptionsView.ShowGroupPanel = false;
            // 
            // clmPurposeCar
            // 
            this.clmPurposeCar.Caption = "意向车型";
            this.clmPurposeCar.FieldName = "DCCRecord.PurposeCar";
            this.clmPurposeCar.Name = "clmPurposeCar";
            this.clmPurposeCar.Visible = true;
            this.clmPurposeCar.VisibleIndex = 0;
            // 
            // clmDCCSource
            // 
            this.clmDCCSource.Caption = "线索来源";
            this.clmDCCSource.FieldName = "DCCRecord.Source";
            this.clmDCCSource.Name = "clmDCCSource";
            this.clmDCCSource.Visible = true;
            this.clmDCCSource.VisibleIndex = 1;
            // 
            // clmCustomerAddress
            // 
            this.clmCustomerAddress.Caption = "居住区域";
            this.clmCustomerAddress.FieldName = "Customer.Address";
            this.clmCustomerAddress.Name = "clmCustomerAddress";
            this.clmCustomerAddress.Visible = true;
            this.clmCustomerAddress.VisibleIndex = 2;
            // 
            // clmConsultantName
            // 
            this.clmConsultantName.Caption = "回访人";
            this.clmConsultantName.FieldName = "ConsultantUser.RealName";
            this.clmConsultantName.Name = "clmConsultantName";
            this.clmConsultantName.Visible = true;
            this.clmConsultantName.VisibleIndex = 3;
            // 
            // cmlDCCStatus
            // 
            this.cmlDCCStatus.Caption = "线索甄别";
            this.cmlDCCStatus.FieldName = "DCCRecord.Status";
            this.cmlDCCStatus.Name = "cmlDCCStatus";
            this.cmlDCCStatus.Visible = true;
            this.cmlDCCStatus.VisibleIndex = 4;
            // 
            // clmPromiseShop
            // 
            this.clmPromiseShop.Caption = "承诺到店";
            this.clmPromiseShop.FieldName = "DCCRecord.PromiseShop.Value";
            this.clmPromiseShop.Name = "clmPromiseShop";
            this.clmPromiseShop.Visible = true;
            this.clmPromiseShop.VisibleIndex = 5;
            // 
            // clmRecallCnt
            // 
            this.clmRecallCnt.Caption = "回访次数";
            this.clmRecallCnt.FieldName = "DCCRecord.RecallCount";
            this.clmRecallCnt.Name = "clmRecallCnt";
            this.clmRecallCnt.Visible = true;
            this.clmRecallCnt.VisibleIndex = 6;
            // 
            // clmRecallDesc
            // 
            this.clmRecallDesc.Caption = "回访详情记录";
            this.clmRecallDesc.FieldName = "DCCRecord.RecallDesc";
            this.clmRecallDesc.Name = "clmRecallDesc";
            this.clmRecallDesc.Visible = true;
            this.clmRecallDesc.VisibleIndex = 7;
            // 
            // clmIsLogin
            // 
            this.clmIsLogin.Caption = "是否登录";
            this.clmIsLogin.FieldName = "DCCRecord.IsLogin";
            this.clmIsLogin.Name = "clmIsLogin";
            this.clmIsLogin.Visible = true;
            this.clmIsLogin.VisibleIndex = 8;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "到店接待";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            // 
            // clmToShopTime
            // 
            this.clmToShopTime.Caption = "到店时间";
            this.clmToShopTime.FieldName = "DCCRecord.SubscribeTime";
            this.clmToShopTime.Name = "clmToShopTime";
            this.clmToShopTime.Visible = true;
            this.clmToShopTime.VisibleIndex = 10;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "成交时间";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 11;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "成交车型";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 12;
            // 
            // FmDCCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 377);
            this.Controls.Add(this.gridControlDCCRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmDCCView";
            this.Text = "DCCView";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDCCRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceDCCRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDCCRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlDCCRecord;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDCCRecord;
        private DevExpress.XtraGrid.Columns.GridColumn clmPurposeCar;
        private DevExpress.XtraGrid.Columns.GridColumn clmDCCSource;
        private DevExpress.XtraGrid.Columns.GridColumn clmCustomerAddress;
        private DevExpress.XtraGrid.Columns.GridColumn clmConsultantName;
        private DevExpress.XtraGrid.Columns.GridColumn cmlDCCStatus;
        private DevExpress.XtraGrid.Columns.GridColumn clmPromiseShop;
        private DevExpress.XtraGrid.Columns.GridColumn clmRecallCnt;
        private DevExpress.XtraGrid.Columns.GridColumn clmRecallDesc;
        private DevExpress.XtraGrid.Columns.GridColumn clmIsLogin;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn clmToShopTime;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private System.Windows.Forms.BindingSource sourceDCCRecord;
    }
}