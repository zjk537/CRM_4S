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
            this.dCCCustomerRecordInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewDCCRecord = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmShopName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmVisitTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmRecallTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmRecallCnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPurposeCar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmDCCSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmlDCCStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmIsLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPromiseShop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmToShopTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmRecallerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmRecallDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDCCRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCCCustomerRecordInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDCCRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlDCCRecord
            // 
            this.gridControlDCCRecord.DataSource = this.dCCCustomerRecordInfoBindingSource;
            this.gridControlDCCRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDCCRecord.Location = new System.Drawing.Point(0, 0);
            this.gridControlDCCRecord.MainView = this.gridViewDCCRecord;
            this.gridControlDCCRecord.Name = "gridControlDCCRecord";
            this.gridControlDCCRecord.Size = new System.Drawing.Size(817, 377);
            this.gridControlDCCRecord.TabIndex = 0;
            this.gridControlDCCRecord.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDCCRecord});
            // 
            // dCCCustomerRecordInfoBindingSource
            // 
            this.dCCCustomerRecordInfoBindingSource.DataSource = typeof(CRM_4S.Business.BusinessModel.DCCCustomerRecordInfo);
            // 
            // gridViewDCCRecord
            // 
            this.gridViewDCCRecord.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmShopName,
            this.clmVisitTime,
            this.clmRecallTime,
            this.clmRecallCnt,
            this.clmCName,
            this.clmCPhone,
            this.clmCAddress,
            this.clmPurposeCar,
            this.clmDCCSource,
            this.cmlDCCStatus,
            this.clmIsLogin,
            this.clmPromiseShop,
            this.clmToShopTime,
            this.clmRecallerName,
            this.clmRecallDesc});
            this.gridViewDCCRecord.GridControl = this.gridControlDCCRecord;
            this.gridViewDCCRecord.Name = "gridViewDCCRecord";
            this.gridViewDCCRecord.OptionsBehavior.Editable = false;
            this.gridViewDCCRecord.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.defaultGridView_CustomDrawCell);
            this.gridViewDCCRecord.DoubleClick += new System.EventHandler(this.gridViewFrontRecord_DoubleClick);
            // 
            // clmShopName
            // 
            this.clmShopName.Caption = "店面";
            this.clmShopName.FieldName = "Shop.Name";
            this.clmShopName.Name = "clmShopName";
            this.clmShopName.Visible = true;
            this.clmShopName.VisibleIndex = 0;
            // 
            // clmVisitTime
            // 
            this.clmVisitTime.Caption = "访问时间";
            this.clmVisitTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.clmVisitTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clmVisitTime.FieldName = "DCCRecord.VisitTime";
            this.clmVisitTime.Name = "clmVisitTime";
            this.clmVisitTime.Visible = true;
            this.clmVisitTime.VisibleIndex = 1;
            // 
            // clmRecallTime
            // 
            this.clmRecallTime.Caption = "回访时间";
            this.clmRecallTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.clmRecallTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clmRecallTime.FieldName = "DCCRecord.RecallTime";
            this.clmRecallTime.Name = "clmRecallTime";
            this.clmRecallTime.Visible = true;
            this.clmRecallTime.VisibleIndex = 2;
            // 
            // clmRecallCnt
            // 
            this.clmRecallCnt.AppearanceCell.Options.UseTextOptions = true;
            this.clmRecallCnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmRecallCnt.Caption = "回访次数";
            this.clmRecallCnt.FieldName = "RecordCnt";
            this.clmRecallCnt.Name = "clmRecallCnt";
            this.clmRecallCnt.Visible = true;
            this.clmRecallCnt.VisibleIndex = 3;
            // 
            // clmCName
            // 
            this.clmCName.Caption = "顾客姓名";
            this.clmCName.FieldName = "Customer.Name";
            this.clmCName.Name = "clmCName";
            this.clmCName.Visible = true;
            this.clmCName.VisibleIndex = 4;
            // 
            // clmCPhone
            // 
            this.clmCPhone.Caption = "联系电话";
            this.clmCPhone.FieldName = "Customer.Phone";
            this.clmCPhone.Name = "clmCPhone";
            this.clmCPhone.Visible = true;
            this.clmCPhone.VisibleIndex = 5;
            // 
            // clmCAddress
            // 
            this.clmCAddress.Caption = "居住区域";
            this.clmCAddress.FieldName = "Customer.Address";
            this.clmCAddress.Name = "clmCAddress";
            this.clmCAddress.Visible = true;
            this.clmCAddress.VisibleIndex = 6;
            // 
            // clmPurposeCar
            // 
            this.clmPurposeCar.AppearanceCell.Options.UseTextOptions = true;
            this.clmPurposeCar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmPurposeCar.Caption = "意向车型";
            this.clmPurposeCar.FieldName = "DCCRecord.PurposeCar";
            this.clmPurposeCar.Name = "clmPurposeCar";
            this.clmPurposeCar.Visible = true;
            this.clmPurposeCar.VisibleIndex = 7;
            // 
            // clmDCCSource
            // 
            this.clmDCCSource.AppearanceCell.Options.UseTextOptions = true;
            this.clmDCCSource.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmDCCSource.Caption = "线索来源";
            this.clmDCCSource.FieldName = "DCCRecord.Source";
            this.clmDCCSource.Name = "clmDCCSource";
            this.clmDCCSource.Visible = true;
            this.clmDCCSource.VisibleIndex = 8;
            // 
            // cmlDCCStatus
            // 
            this.cmlDCCStatus.AppearanceCell.Options.UseTextOptions = true;
            this.cmlDCCStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cmlDCCStatus.Caption = "线索甄别";
            this.cmlDCCStatus.FieldName = "DCCRecord.Status";
            this.cmlDCCStatus.Name = "cmlDCCStatus";
            this.cmlDCCStatus.Visible = true;
            this.cmlDCCStatus.VisibleIndex = 9;
            // 
            // clmIsLogin
            // 
            this.clmIsLogin.AppearanceCell.Options.UseTextOptions = true;
            this.clmIsLogin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmIsLogin.Caption = "是否登录";
            this.clmIsLogin.FieldName = "DCCRecord.IsLogin";
            this.clmIsLogin.Name = "clmIsLogin";
            this.clmIsLogin.Visible = true;
            this.clmIsLogin.VisibleIndex = 10;
            // 
            // clmPromiseShop
            // 
            this.clmPromiseShop.AppearanceCell.Options.UseTextOptions = true;
            this.clmPromiseShop.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmPromiseShop.Caption = "是否到店";
            this.clmPromiseShop.FieldName = "DCCRecord.ToShop";
            this.clmPromiseShop.Name = "clmPromiseShop";
            this.clmPromiseShop.Visible = true;
            this.clmPromiseShop.VisibleIndex = 11;
            // 
            // clmToShopTime
            // 
            this.clmToShopTime.Caption = "到店时间";
            this.clmToShopTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.clmToShopTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clmToShopTime.FieldName = "DCCRecord.ToShopTime";
            this.clmToShopTime.Name = "clmToShopTime";
            this.clmToShopTime.Visible = true;
            this.clmToShopTime.VisibleIndex = 12;
            // 
            // clmRecallerName
            // 
            this.clmRecallerName.Caption = "回访人";
            this.clmRecallerName.FieldName = "DCCUser.RealName";
            this.clmRecallerName.Name = "clmRecallerName";
            this.clmRecallerName.Visible = true;
            this.clmRecallerName.VisibleIndex = 13;
            // 
            // clmRecallDesc
            // 
            this.clmRecallDesc.Caption = "回访详情记录";
            this.clmRecallDesc.FieldName = "DCCRecord.RecallDesc";
            this.clmRecallDesc.Name = "clmRecallDesc";
            this.clmRecallDesc.Visible = true;
            this.clmRecallDesc.VisibleIndex = 14;
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
            this.Load += new System.EventHandler(this.FmDCCView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDCCRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCCCustomerRecordInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDCCRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlDCCRecord;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDCCRecord;
        private DevExpress.XtraGrid.Columns.GridColumn clmPurposeCar;
        private DevExpress.XtraGrid.Columns.GridColumn clmDCCSource;
        private DevExpress.XtraGrid.Columns.GridColumn clmCAddress;
        private DevExpress.XtraGrid.Columns.GridColumn clmRecallerName;
        private DevExpress.XtraGrid.Columns.GridColumn cmlDCCStatus;
        private DevExpress.XtraGrid.Columns.GridColumn clmPromiseShop;
        private DevExpress.XtraGrid.Columns.GridColumn clmRecallDesc;
        private DevExpress.XtraGrid.Columns.GridColumn clmIsLogin;
        private DevExpress.XtraGrid.Columns.GridColumn clmToShopTime;
        private DevExpress.XtraGrid.Columns.GridColumn clmShopName;
        private DevExpress.XtraGrid.Columns.GridColumn clmVisitTime;
        private DevExpress.XtraGrid.Columns.GridColumn clmRecallTime;
        private DevExpress.XtraGrid.Columns.GridColumn clmRecallCnt;
        private DevExpress.XtraGrid.Columns.GridColumn clmCName;
        private DevExpress.XtraGrid.Columns.GridColumn clmCPhone;
        private System.Windows.Forms.BindingSource dCCCustomerRecordInfoBindingSource;
    }
}