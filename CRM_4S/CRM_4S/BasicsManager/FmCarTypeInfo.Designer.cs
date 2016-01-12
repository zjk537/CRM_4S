﻿namespace CRM_4S.BasicsManager
{
    partial class FmCarTypeInfo
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
            this.txtCarType = new DevExpress.XtraEditors.TextEdit();
            this.cbCarBrand = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCarBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 998;
            this.labelControl1.Text = "汽车品牌";
            // 
            // txtCarType
            // 
            this.txtCarType.Location = new System.Drawing.Point(66, 40);
            this.txtCarType.Name = "txtCarType";
            this.txtCarType.Size = new System.Drawing.Size(219, 21);
            this.txtCarType.TabIndex = 999;
            // 
            // cbCarBrand
            // 
            this.cbCarBrand.EnterMoveNextControl = true;
            this.cbCarBrand.Location = new System.Drawing.Point(66, 9);
            this.cbCarBrand.Name = "cbCarBrand";
            this.cbCarBrand.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCarBrand.Size = new System.Drawing.Size(219, 21);
            this.cbCarBrand.TabIndex = 1000;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 998;
            this.labelControl2.Text = "类型";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 79);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 998;
            this.labelControl3.Text = "备注";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(66, 72);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(219, 21);
            this.textEdit1.TabIndex = 999;
            // 
            // FmCarTypeInfo
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 157);
            this.Controls.Add(this.cbCarBrand);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.txtCarType);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FmCarTypeInfo";
            this.Text = "汽车类型";
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.txtCarType, 0);
            this.Controls.SetChildIndex(this.textEdit1, 0);
            this.Controls.SetChildIndex(this.cbCarBrand, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtCarType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCarBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCarType;
        private DevExpress.XtraEditors.ComboBoxEdit cbCarBrand;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit1;

    }
}