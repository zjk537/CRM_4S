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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 998;
            this.labelControl1.Text = "问题描述";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(66, 22);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(250, 59);
            this.textEdit1.TabIndex = 999;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 998;
            this.labelControl2.Text = "问题权重";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(66, 99);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(250, 21);
            this.textEdit2.TabIndex = 1000;
            // 
            // FmQuestionInfo
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 190);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit1);
            this.Margin = new System.Windows.Forms.Padding(21, 32, 21, 32);
            this.Name = "FmQuestionInfo";
            this.Text = "顾客评估问题";
            this.Controls.SetChildIndex(this.textEdit1, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.textEdit2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
    }
}