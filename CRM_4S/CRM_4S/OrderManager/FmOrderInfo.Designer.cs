namespace CRM_4S.OrderManager
{
    partial class FmOrderInfo
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
            this.txtCPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbCarType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDisPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrevPay = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.cbConsultant = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCarType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrevPay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbConsultant.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCPhone
            // 
            this.txtCPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPhone.EditValue = "";
            this.txtCPhone.EnterMoveNextControl = true;
            this.txtCPhone.Location = new System.Drawing.Point(80, 13);
            this.txtCPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.Properties.Mask.EditMask = "<必填>";
            this.txtCPhone.Size = new System.Drawing.Size(254, 21);
            this.txtCPhone.TabIndex = 0;
            this.txtCPhone.Leave += new System.EventHandler(this.txtCPhone_Leave);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 16);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 1000;
            this.labelControl3.Text = "客户手机";
            // 
            // cbCarType
            // 
            this.cbCarType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCarType.EnterMoveNextControl = true;
            this.cbCarType.Location = new System.Drawing.Point(80, 77);
            this.cbCarType.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.cbCarType.Name = "cbCarType";
            this.cbCarType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCarType.Properties.NullValuePrompt = "<必填>";
            this.cbCarType.Properties.NullValuePromptShowForEmptyValue = true;
            this.cbCarType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbCarType.Size = new System.Drawing.Size(254, 21);
            this.cbCarType.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 80);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 1001;
            this.labelControl4.Text = "车型";
            // 
            // txtCName
            // 
            this.txtCName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCName.EditValue = "";
            this.txtCName.EnterMoveNextControl = true;
            this.txtCName.Location = new System.Drawing.Point(80, 45);
            this.txtCName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCName.Name = "txtCName";
            this.txtCName.Properties.ReadOnly = true;
            this.txtCName.Size = new System.Drawing.Size(254, 21);
            this.txtCName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 48);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 1004;
            this.labelControl1.Text = "客户名称";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 112);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1006;
            this.labelControl2.Text = "实付金额";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.EnterMoveNextControl = true;
            this.txtPrice.Location = new System.Drawing.Point(80, 109);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPrice.Properties.Mask.EditMask = "c";
            this.txtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPrice.Properties.MaxLength = 11;
            this.txtPrice.Properties.NullValuePrompt = "数字格式<必填>";
            this.txtPrice.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtPrice.Size = new System.Drawing.Size(254, 21);
            this.txtPrice.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(24, 144);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 1006;
            this.labelControl5.Text = "优惠金额";
            // 
            // txtDisPrice
            // 
            this.txtDisPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisPrice.EnterMoveNextControl = true;
            this.txtDisPrice.Location = new System.Drawing.Point(80, 141);
            this.txtDisPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDisPrice.Name = "txtDisPrice";
            this.txtDisPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDisPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDisPrice.Properties.Mask.EditMask = "c";
            this.txtDisPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDisPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDisPrice.Properties.MaxLength = 11;
            this.txtDisPrice.Properties.NullValuePrompt = "数字格式<必填>";
            this.txtDisPrice.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtDisPrice.Size = new System.Drawing.Size(254, 21);
            this.txtDisPrice.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(24, 176);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 1006;
            this.labelControl6.Text = "预付订金";
            // 
            // txtPrevPay
            // 
            this.txtPrevPay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrevPay.EnterMoveNextControl = true;
            this.txtPrevPay.Location = new System.Drawing.Point(80, 173);
            this.txtPrevPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrevPay.Name = "txtPrevPay";
            this.txtPrevPay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPrevPay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPrevPay.Properties.Mask.EditMask = "c";
            this.txtPrevPay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrevPay.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPrevPay.Properties.MaxLength = 11;
            this.txtPrevPay.Properties.NullValuePrompt = "数字格式<必填>";
            this.txtPrevPay.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtPrevPay.Size = new System.Drawing.Size(254, 21);
            this.txtPrevPay.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(24, 246);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 14);
            this.labelControl7.TabIndex = 1006;
            this.labelControl7.Text = "备注";
            // 
            // txtRemark
            // 
            this.txtRemark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemark.Location = new System.Drawing.Point(80, 243);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(254, 66);
            this.txtRemark.TabIndex = 6;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cbConsultant
            // 
            this.cbConsultant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbConsultant.EnterMoveNextControl = true;
            this.cbConsultant.Location = new System.Drawing.Point(80, 208);
            this.cbConsultant.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.cbConsultant.Name = "cbConsultant";
            this.cbConsultant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbConsultant.Properties.NullValuePrompt = "<必填>";
            this.cbConsultant.Properties.NullValuePromptShowForEmptyValue = true;
            this.cbConsultant.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbConsultant.Size = new System.Drawing.Size(254, 21);
            this.cbConsultant.TabIndex = 1007;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(24, 206);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 14);
            this.labelControl8.TabIndex = 1008;
            this.labelControl8.Text = "销售顾问";
            // 
            // FmOrderInfo
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 376);
            this.Controls.Add(this.cbConsultant);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtPrevPay);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtDisPrice);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbCarType);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtCPhone);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtRemark);
            this.Margin = new System.Windows.Forms.Padding(21, 32, 21, 32);
            this.Name = "FmOrderInfo";
            this.Text = "客户订单";
            this.Controls.SetChildIndex(this.txtRemark, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.txtCPhone, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.cbCarType, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.txtCName, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.txtPrice, 0);
            this.Controls.SetChildIndex(this.labelControl5, 0);
            this.Controls.SetChildIndex(this.txtDisPrice, 0);
            this.Controls.SetChildIndex(this.labelControl6, 0);
            this.Controls.SetChildIndex(this.labelControl7, 0);
            this.Controls.SetChildIndex(this.txtPrevPay, 0);
            this.Controls.SetChildIndex(this.labelControl8, 0);
            this.Controls.SetChildIndex(this.cbConsultant, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtCPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCarType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrevPay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbConsultant.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtCPhone;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbCarType;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtDisPrice;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtPrevPay;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;
        private DevExpress.XtraEditors.ComboBoxEdit cbConsultant;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}