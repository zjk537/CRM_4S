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
            this.clmCName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPurposeCar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmDCCSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmRecallerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmRecallDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridColumn1,
            this.clmDCCSource,
            this.clmPurposeCar,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.clmRecallerName,
            this.clmCAddress,
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
            // clmCName
            // 
            this.clmCName.Caption = "客户姓名";
            this.clmCName.FieldName = "Customer.Name";
            this.clmCName.Name = "clmCName";
            this.clmCName.Visible = true;
            this.clmCName.VisibleIndex = 1;
            // 
            // clmCPhone
            // 
            this.clmCPhone.Caption = "客户电话";
            this.clmCPhone.FieldName = "Customer.Phone";
            this.clmCPhone.Name = "clmCPhone";
            this.clmCPhone.Visible = true;
            this.clmCPhone.VisibleIndex = 0;
            // 
            // clmCAddress
            // 
            this.clmCAddress.Caption = "居住区域";
            this.clmCAddress.FieldName = "Customer.Address";
            this.clmCAddress.Name = "clmCAddress";
            this.clmCAddress.Visible = true;
            this.clmCAddress.VisibleIndex = 9;
            // 
            // clmPurposeCar
            // 
            this.clmPurposeCar.AppearanceCell.Options.UseTextOptions = true;
            this.clmPurposeCar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmPurposeCar.Caption = "意向车型";
            this.clmPurposeCar.FieldName = "DCCRecord.PurposeCar";
            this.clmPurposeCar.Name = "clmPurposeCar";
            this.clmPurposeCar.Visible = true;
            this.clmPurposeCar.VisibleIndex = 4;
            // 
            // clmDCCSource
            // 
            this.clmDCCSource.AppearanceCell.Options.UseTextOptions = true;
            this.clmDCCSource.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmDCCSource.Caption = "客户来源";
            this.clmDCCSource.FieldName = "DCCRecord.Source";
            this.clmDCCSource.Name = "clmDCCSource";
            this.clmDCCSource.Visible = true;
            this.clmDCCSource.VisibleIndex = 3;
            // 
            // clmRecallerName
            // 
            this.clmRecallerName.Caption = "销售顾问";
            this.clmRecallerName.FieldName = "DCCUser.RealName";
            this.clmRecallerName.Name = "clmRecallerName";
            this.clmRecallerName.Visible = true;
            this.clmRecallerName.VisibleIndex = 8;
            // 
            // clmRecallDesc
            // 
            this.clmRecallDesc.Caption = "备注";
            this.clmRecallDesc.FieldName = "DCCRecord.RecallDesc";
            this.clmRecallDesc.Name = "clmRecallDesc";
            this.clmRecallDesc.Visible = true;
            this.clmRecallDesc.VisibleIndex = 10;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "性别";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "分期全款";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "意向级别";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "预计到店时间";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}