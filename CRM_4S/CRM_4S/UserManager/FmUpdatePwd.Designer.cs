﻿namespace CRM_4S.UserManager
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
            this.TxtNewPwd2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtNewPwd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtOldPwd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewPwd2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOldPwd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNewPwd2
            // 
            this.TxtNewPwd2.EditValue = "";
            this.TxtNewPwd2.EnterMoveNextControl = true;
            this.TxtNewPwd2.Location = new System.Drawing.Point(71, 79);
            this.TxtNewPwd2.Name = "TxtNewPwd2";
            this.TxtNewPwd2.Properties.NullValuePrompt = "默认为空";
            this.TxtNewPwd2.Properties.NullValuePromptShowForEmptyValue = true;
            this.TxtNewPwd2.Properties.PasswordChar = '*';
            this.TxtNewPwd2.Size = new System.Drawing.Size(166, 21);
            this.TxtNewPwd2.TabIndex = 1018;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1021;
            this.labelControl2.Text = "再次输入";
            // 
            // TxtNewPwd
            // 
            this.TxtNewPwd.EditValue = "";
            this.TxtNewPwd.EnterMoveNextControl = true;
            this.TxtNewPwd.Location = new System.Drawing.Point(71, 52);
            this.TxtNewPwd.Name = "TxtNewPwd";
            this.TxtNewPwd.Properties.NullValuePrompt = "默认为空";
            this.TxtNewPwd.Properties.NullValuePromptShowForEmptyValue = true;
            this.TxtNewPwd.Properties.PasswordChar = '*';
            this.TxtNewPwd.Size = new System.Drawing.Size(166, 21);
            this.TxtNewPwd.TabIndex = 1017;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 1020;
            this.labelControl1.Text = "新密码";
            // 
            // TxtOldPwd
            // 
            this.TxtOldPwd.EditValue = "";
            this.TxtOldPwd.EnterMoveNextControl = true;
            this.TxtOldPwd.Location = new System.Drawing.Point(71, 12);
            this.TxtOldPwd.Name = "TxtOldPwd";
            this.TxtOldPwd.Properties.NullValuePrompt = "默认为空";
            this.TxtOldPwd.Properties.NullValuePromptShowForEmptyValue = true;
            this.TxtOldPwd.Properties.PasswordChar = '*';
            this.TxtOldPwd.Size = new System.Drawing.Size(166, 21);
            this.TxtOldPwd.TabIndex = 1016;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 1019;
            this.labelControl4.Text = "原始密码";
            // 
            // FmUpdatePwd
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 164);
            this.Controls.Add(this.TxtNewPwd2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxtNewPwd);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TxtOldPwd);
            this.Controls.Add(this.labelControl4);
            this.Name = "FmUpdatePwd";
            this.Text = "修改密码";
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.TxtOldPwd, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.TxtNewPwd, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.TxtNewPwd2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewPwd2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNewPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOldPwd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TxtNewPwd2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtNewPwd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtOldPwd;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}