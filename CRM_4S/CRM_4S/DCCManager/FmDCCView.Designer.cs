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
            this.clmCPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmDCCSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPurposeCar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmInstallment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmToShopTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmRecallerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCAddress = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.clmCPhone,
            this.clmCName,
            this.clmCSex,
            this.clmDCCSource,
            this.clmPurposeCar,
            this.clmInstallment,
            this.clmLevel,
            this.clmToShopTime,
            this.clmRecallerName,
            this.clmCAddress,
            this.clmRecallDesc});
            this.gridViewDCCRecord.GridControl = this.gridControlDCCRecord;
            this.gridViewDCCRecord.Name = "gridViewDCCRecord";
            this.gridViewDCCRecord.OptionsBehavior.Editable = false;
            this.gridViewDCCRecord.OptionsPrint.AutoWidth = false;
            this.gridViewDCCRecord.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewDCCRecord.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewDCCRecord_CustomDrawRowIndicator);
            this.gridViewDCCRecord.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridViewDCCRecord_MouseDown);
            // 
            // clmShopName
            // 
            this.clmShopName.Caption = "店面";
            this.clmShopName.FieldName = "Shop.Name";
            this.clmShopName.Name = "clmShopName";
            // 
            // clmVisitTime
            // 
            this.clmVisitTime.Caption = "创建时间";
            this.clmVisitTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.clmVisitTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clmVisitTime.FieldName = "DCCRecord.VisitTime";
            this.clmVisitTime.Name = "clmVisitTime";
            // 
            // clmRecallTime
            // 
            this.clmRecallTime.Caption = "回访时间";
            this.clmRecallTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.clmRecallTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clmRecallTime.FieldName = "DCCRecord.RecallTime";
            this.clmRecallTime.Name = "clmRecallTime";
            // 
            // clmCPhone
            // 
            this.clmCPhone.Caption = "客户电话";
            this.clmCPhone.FieldName = "Customer.Phone";
            this.clmCPhone.Name = "clmCPhone";
            this.clmCPhone.Visible = true;
            this.clmCPhone.VisibleIndex = 0;
            // 
            // clmCName
            // 
            this.clmCName.Caption = "客户姓名";
            this.clmCName.FieldName = "Customer.Name";
            this.clmCName.Name = "clmCName";
            this.clmCName.Visible = true;
            this.clmCName.VisibleIndex = 1;
            // 
            // clmCSex
            // 
            this.clmCSex.AppearanceCell.Options.UseTextOptions = true;
            this.clmCSex.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmCSex.Caption = "性别";
            this.clmCSex.FieldName = "Sex";
            this.clmCSex.Name = "clmCSex";
            this.clmCSex.Visible = true;
            this.clmCSex.VisibleIndex = 2;
            // 
            // clmDCCSource
            // 
            this.clmDCCSource.AppearanceCell.Options.UseTextOptions = true;
            this.clmDCCSource.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmDCCSource.Caption = "客户来源";
            this.clmDCCSource.FieldName = "DCCSource";
            this.clmDCCSource.Name = "clmDCCSource";
            this.clmDCCSource.Visible = true;
            this.clmDCCSource.VisibleIndex = 3;
            // 
            // clmPurposeCar
            // 
            this.clmPurposeCar.AppearanceCell.Options.UseTextOptions = true;
            this.clmPurposeCar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmPurposeCar.Caption = "意向车型";
            this.clmPurposeCar.FieldName = "PurposeCar";
            this.clmPurposeCar.Name = "clmPurposeCar";
            this.clmPurposeCar.Visible = true;
            this.clmPurposeCar.VisibleIndex = 4;
            // 
            // clmInstallment
            // 
            this.clmInstallment.AppearanceCell.Options.UseTextOptions = true;
            this.clmInstallment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmInstallment.Caption = "分期全款";
            this.clmInstallment.FieldName = "Installment";
            this.clmInstallment.Name = "clmInstallment";
            this.clmInstallment.Visible = true;
            this.clmInstallment.VisibleIndex = 5;
            // 
            // clmLevel
            // 
            this.clmLevel.Caption = "意向级别";
            this.clmLevel.FieldName = "DCCRecord.LevelCode";
            this.clmLevel.Name = "clmLevel";
            this.clmLevel.Visible = true;
            this.clmLevel.VisibleIndex = 6;
            // 
            // clmToShopTime
            // 
            this.clmToShopTime.AppearanceCell.Options.UseTextOptions = true;
            this.clmToShopTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmToShopTime.Caption = "预计到店时间";
            this.clmToShopTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.clmToShopTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clmToShopTime.FieldName = "DCCRecord.ToShopTime";
            this.clmToShopTime.Name = "clmToShopTime";
            this.clmToShopTime.Visible = true;
            this.clmToShopTime.VisibleIndex = 7;
            // 
            // clmRecallerName
            // 
            this.clmRecallerName.Caption = "销售顾问";
            this.clmRecallerName.FieldName = "DCCUser.RealName";
            this.clmRecallerName.Name = "clmRecallerName";
            this.clmRecallerName.Visible = true;
            this.clmRecallerName.VisibleIndex = 8;
            // 
            // clmCAddress
            // 
            this.clmCAddress.Caption = "居住区域";
            this.clmCAddress.FieldName = "Customer.Address";
            this.clmCAddress.Name = "clmCAddress";
            this.clmCAddress.Visible = true;
            this.clmCAddress.VisibleIndex = 9;
            // 
            // clmRecallDesc
            // 
            this.clmRecallDesc.Caption = "备注";
            this.clmRecallDesc.FieldName = "DCCRecord.RecallDesc";
            this.clmRecallDesc.Name = "clmRecallDesc";
            this.clmRecallDesc.Visible = true;
            this.clmRecallDesc.VisibleIndex = 10;
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
        private DevExpress.XtraGrid.Columns.GridColumn clmRecallDesc;
        private DevExpress.XtraGrid.Columns.GridColumn clmShopName;
        private DevExpress.XtraGrid.Columns.GridColumn clmVisitTime;
        private DevExpress.XtraGrid.Columns.GridColumn clmRecallTime;
        private DevExpress.XtraGrid.Columns.GridColumn clmCName;
        private DevExpress.XtraGrid.Columns.GridColumn clmCPhone;
        private System.Windows.Forms.BindingSource dCCCustomerRecordInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn clmCSex;
        private DevExpress.XtraGrid.Columns.GridColumn clmInstallment;
        private DevExpress.XtraGrid.Columns.GridColumn clmLevel;
        private DevExpress.XtraGrid.Columns.GridColumn clmToShopTime;
    }
}