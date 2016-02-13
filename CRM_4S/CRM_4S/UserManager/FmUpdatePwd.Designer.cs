namespace CRM_4S.UserManager
{
    partial class FmUpdatePwd
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
            this.txtNewPwd2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNewPwd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtOldPwd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPwd2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewPwd2
            // 
            this.txtNewPwd2.EditValue = "";
            this.txtNewPwd2.EnterMoveNextControl = true;
            this.txtNewPwd2.Location = new System.Drawing.Point(71, 79);
            this.txtNewPwd2.Name = "txtNewPwd2";
            this.txtNewPwd2.Properties.NullValuePrompt = "默认为空";
            this.txtNewPwd2.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtNewPwd2.Properties.PasswordChar = '*';
            this.txtNewPwd2.Size = new System.Drawing.Size(166, 20);
            this.txtNewPwd2.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 1021;
            this.labelControl2.Text = "再次输入";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.EditValue = "";
            this.txtNewPwd.EnterMoveNextControl = true;
            this.txtNewPwd.Location = new System.Drawing.Point(71, 52);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Properties.NullValuePrompt = "默认为空";
            this.txtNewPwd.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtNewPwd.Properties.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(166, 20);
            this.txtNewPwd.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 1020;
            this.labelControl1.Text = "新密码";
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.EditValue = "";
            this.txtOldPwd.EnterMoveNextControl = true;
            this.txtOldPwd.Location = new System.Drawing.Point(71, 12);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.Properties.NullValuePrompt = "默认为空";
            this.txtOldPwd.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtOldPwd.Properties.PasswordChar = '*';
            this.txtOldPwd.Size = new System.Drawing.Size(166, 20);
            this.txtOldPwd.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 1019;
            this.labelControl4.Text = "原始密码";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FmUpdatePwd
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 164);
            this.Controls.Add(this.txtNewPwd2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtOldPwd);
            this.Controls.Add(this.labelControl4);
            this.Name = "FmUpdatePwd";
            this.Text = "修改密码";
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.txtOldPwd, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.txtNewPwd, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.txtNewPwd2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPwd2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNewPwd2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNewPwd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtOldPwd;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;
    }
}