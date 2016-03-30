namespace CRM_4S.OrderManager
{
    partial class FmOrderView
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
            this.gridControlOrderRecord = new DevExpress.XtraGrid.GridControl();
            this.customerOrderRecordInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewOrderRecord = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCustomerPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmConsultantName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCarType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmDisPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPrePay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrderRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderRecordInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlOrderRecord
            // 
            this.gridControlOrderRecord.DataSource = this.customerOrderRecordInfoBindingSource;
            this.gridControlOrderRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOrderRecord.Location = new System.Drawing.Point(0, 0);
            this.gridControlOrderRecord.MainView = this.gridViewOrderRecord;
            this.gridControlOrderRecord.Name = "gridControlOrderRecord";
            this.gridControlOrderRecord.Size = new System.Drawing.Size(893, 430);
            this.gridControlOrderRecord.TabIndex = 0;
            this.gridControlOrderRecord.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrderRecord});
            // 
            // customerOrderRecordInfoBindingSource
            // 
            this.customerOrderRecordInfoBindingSource.DataSource = typeof(CRM_4S.Business.BusinessModel.CustomerOrderRecordInfo);
            // 
            // gridViewOrderRecord
            // 
            this.gridViewOrderRecord.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmCustomerName,
            this.clmCustomerPhone,
            this.clmConsultantName,
            this.clmCarType,
            this.clmStatus,
            this.clmPrice,
            this.clmDisPrice,
            this.clmPrePay,
            this.clmRemark});
            this.gridViewOrderRecord.GridControl = this.gridControlOrderRecord;
            this.gridViewOrderRecord.Name = "gridViewOrderRecord";
            this.gridViewOrderRecord.OptionsBehavior.Editable = false;
            this.gridViewOrderRecord.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewOrderRecord.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewOrderRecord_CustomDrawCell);
            this.gridViewOrderRecord.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewOrderRecord_RowStyle);
            this.gridViewOrderRecord.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridViewOrderRecord_MouseDown);
            // 
            // clmCustomerName
            // 
            this.clmCustomerName.Caption = "客户姓名";
            this.clmCustomerName.FieldName = "Customer.Name";
            this.clmCustomerName.Name = "clmCustomerName";
            this.clmCustomerName.Visible = true;
            this.clmCustomerName.VisibleIndex = 0;
            // 
            // clmCustomerPhone
            // 
            this.clmCustomerPhone.Caption = "客户电话";
            this.clmCustomerPhone.FieldName = "Customer.Phone";
            this.clmCustomerPhone.Name = "clmCustomerPhone";
            this.clmCustomerPhone.Visible = true;
            this.clmCustomerPhone.VisibleIndex = 1;
            // 
            // clmConsultantName
            // 
            this.clmConsultantName.Caption = "销售顾问";
            this.clmConsultantName.FieldName = "ConsultantUser.RealName";
            this.clmConsultantName.Name = "clmConsultantName";
            this.clmConsultantName.Visible = true;
            this.clmConsultantName.VisibleIndex = 2;
            // 
            // clmCarType
            // 
            this.clmCarType.Caption = "成交车型";
            this.clmCarType.FieldName = "CarType";
            this.clmCarType.Name = "clmCarType";
            this.clmCarType.Visible = true;
            this.clmCarType.VisibleIndex = 3;
            // 
            // clmStatus
            // 
            this.clmStatus.AppearanceCell.Options.UseTextOptions = true;
            this.clmStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmStatus.Caption = "状态";
            this.clmStatus.FieldName = "OrderRecord.Status";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.Visible = true;
            this.clmStatus.VisibleIndex = 4;
            // 
            // clmPrice
            // 
            this.clmPrice.AppearanceCell.Options.UseTextOptions = true;
            this.clmPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmPrice.Caption = "成交价格";
            this.clmPrice.DisplayFormat.FormatString = "c";
            this.clmPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.clmPrice.FieldName = "OrderRecord.Price";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.Visible = true;
            this.clmPrice.VisibleIndex = 5;
            // 
            // clmDisPrice
            // 
            this.clmDisPrice.AppearanceCell.Options.UseTextOptions = true;
            this.clmDisPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmDisPrice.Caption = "优惠金额";
            this.clmDisPrice.DisplayFormat.FormatString = "c";
            this.clmDisPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.clmDisPrice.FieldName = "OrderRecord.DisPrice";
            this.clmDisPrice.Name = "clmDisPrice";
            this.clmDisPrice.Visible = true;
            this.clmDisPrice.VisibleIndex = 6;
            // 
            // clmPrePay
            // 
            this.clmPrePay.AppearanceCell.Options.UseTextOptions = true;
            this.clmPrePay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmPrePay.Caption = "预付金额";
            this.clmPrePay.DisplayFormat.FormatString = "c";
            this.clmPrePay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.clmPrePay.FieldName = "OrderRecord.PrevPay";
            this.clmPrePay.Name = "clmPrePay";
            this.clmPrePay.Visible = true;
            this.clmPrePay.VisibleIndex = 7;
            // 
            // clmRemark
            // 
            this.clmRemark.Caption = "备注";
            this.clmRemark.FieldName = "OrderRecord.Remark";
            this.clmRemark.Name = "clmRemark";
            this.clmRemark.Visible = true;
            this.clmRemark.VisibleIndex = 8;
            // 
            // FmOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 430);
            this.Controls.Add(this.gridControlOrderRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmOrderView";
            this.Text = "FmOrderView";
            this.Load += new System.EventHandler(this.FmOrderView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrderRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderRecordInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlOrderRecord;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrderRecord;
        private System.Windows.Forms.BindingSource customerOrderRecordInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn clmCustomerPhone;
        private DevExpress.XtraGrid.Columns.GridColumn clmCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn clmCarType;
        private DevExpress.XtraGrid.Columns.GridColumn clmConsultantName;
        private DevExpress.XtraGrid.Columns.GridColumn clmPrice;
        private DevExpress.XtraGrid.Columns.GridColumn clmDisPrice;
        private DevExpress.XtraGrid.Columns.GridColumn clmPrePay;
        private DevExpress.XtraGrid.Columns.GridColumn clmRemark;
        private DevExpress.XtraGrid.Columns.GridColumn clmStatus;
    }
}