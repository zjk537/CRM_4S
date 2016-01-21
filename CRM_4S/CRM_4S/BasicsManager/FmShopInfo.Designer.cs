namespace CRM_4S.BasicsManager
{
    partial class FmShopInfo
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDesc = new DevExpress.XtraEditors.MemoEdit();
            this.errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 75);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 1015;
            this.labelControl3.Text = "描述";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAddress.EditValue = "";
            this.TxtAddress.Location = new System.Drawing.Point(41, 42);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Properties.NullValuePrompt = "<必填>";
            this.TxtAddress.Properties.NullValuePromptShowForEmptyValue = true;
            this.TxtAddress.Size = new System.Drawing.Size(390, 21);
            this.TxtAddress.TabIndex = 1012;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 1013;
            this.labelControl2.Text = "地址";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPhone.EditValue = "";
            this.TxtPhone.Location = new System.Drawing.Point(266, 12);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Properties.NullValuePrompt = "<必填>";
            this.TxtPhone.Properties.NullValuePromptShowForEmptyValue = true;
            this.TxtPhone.Size = new System.Drawing.Size(166, 21);
            this.TxtPhone.TabIndex = 1010;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(236, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 1011;
            this.labelControl1.Text = "电话";
            // 
            // TxtName
            // 
            this.TxtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtName.EditValue = "";
            this.TxtName.Location = new System.Drawing.Point(41, 12);
            this.TxtName.Name = "TxtName";
            this.TxtName.Properties.NullValuePrompt = "<必填>";
            this.TxtName.Properties.NullValuePromptShowForEmptyValue = true;
            this.TxtName.Size = new System.Drawing.Size(188, 21);
            this.TxtName.TabIndex = 1008;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(11, 13);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 14);
            this.labelControl7.TabIndex = 1009;
            this.labelControl7.Text = "名称";
            // 
            // TxtDesc
            // 
            this.TxtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDesc.EditValue = "";
            this.TxtDesc.Location = new System.Drawing.Point(41, 72);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(390, 47);
            this.TxtDesc.TabIndex = 1014;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FmShopInfo
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 181);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.TxtDesc);
            this.Name = "FmShopInfo";
            this.Text = "店面信息";
            this.Controls.SetChildIndex(this.TxtDesc, 0);
            this.Controls.SetChildIndex(this.labelControl7, 0);
            this.Controls.SetChildIndex(this.TxtName, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.TxtPhone, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.TxtAddress, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtAddress;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtPhone;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.MemoEdit TxtDesc;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;

    }
}