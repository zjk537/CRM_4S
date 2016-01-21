namespace CRM_4S.BasicsManager
{
    partial class FmQuestionInfo
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtQDesc = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtQLevel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbQType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtQDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbQType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 998;
            this.labelControl1.Text = "问题描述";
            // 
            // txtQDesc
            // 
            this.txtQDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQDesc.Location = new System.Drawing.Point(72, 56);
            this.txtQDesc.Name = "txtQDesc";
            this.txtQDesc.Size = new System.Drawing.Size(250, 59);
            this.txtQDesc.TabIndex = 999;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 136);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 998;
            this.labelControl2.Text = "问题权重";
            // 
            // txtQLevel
            // 
            this.txtQLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQLevel.EditValue = 1;
            this.txtQLevel.Location = new System.Drawing.Point(72, 133);
            this.txtQLevel.Name = "txtQLevel";
            this.txtQLevel.Size = new System.Drawing.Size(250, 21);
            this.txtQLevel.TabIndex = 1000;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 998;
            this.labelControl3.Text = "问题类型";
            // 
            // cbQType
            // 
            this.cbQType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbQType.Location = new System.Drawing.Point(72, 19);
            this.cbQType.Name = "cbQType";
            this.cbQType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbQType.Size = new System.Drawing.Size(250, 21);
            this.cbQType.TabIndex = 1001;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FmQuestionInfo
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 233);
            this.Controls.Add(this.cbQType);
            this.Controls.Add(this.txtQLevel);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtQDesc);
            this.Margin = new System.Windows.Forms.Padding(21, 32, 21, 32);
            this.Name = "FmQuestionInfo";
            this.Text = "顾客评估问题";
            this.Controls.SetChildIndex(this.txtQDesc, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.txtQLevel, 0);
            this.Controls.SetChildIndex(this.cbQType, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtQDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbQType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtQDesc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtQLevel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbQType;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;
    }
}