namespace CRM_4S.FrontManager
{
    partial class FmFrontCustomTime
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
            this.labEndDate = new DevExpress.XtraEditors.LabelControl();
            this.DateEnd = new DevExpress.XtraEditors.DateEdit();
            this.labStartDate = new DevExpress.XtraEditors.LabelControl();
            this.DateStart = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateStart.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labEndDate
            // 
            this.labEndDate.Location = new System.Drawing.Point(14, 59);
            this.labEndDate.Name = "labEndDate";
            this.labEndDate.Size = new System.Drawing.Size(48, 14);
            this.labEndDate.TabIndex = 1005;
            this.labEndDate.Text = "结束时间";
            // 
            // DateEnd
            // 
            this.DateEnd.EditValue = null;
            this.DateEnd.Location = new System.Drawing.Point(68, 56);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DateEnd.Size = new System.Drawing.Size(229, 21);
            this.DateEnd.TabIndex = 1004;
            // 
            // labStartDate
            // 
            this.labStartDate.Location = new System.Drawing.Point(14, 15);
            this.labStartDate.Name = "labStartDate";
            this.labStartDate.Size = new System.Drawing.Size(48, 14);
            this.labStartDate.TabIndex = 1003;
            this.labStartDate.Text = "开始时间";
            // 
            // DateStart
            // 
            this.DateStart.EditValue = null;
            this.DateStart.Location = new System.Drawing.Point(68, 12);
            this.DateStart.Name = "DateStart";
            this.DateStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DateStart.Size = new System.Drawing.Size(229, 21);
            this.DateStart.TabIndex = 1002;
            // 
            // FmFrontCustomTime
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 152);
            this.Controls.Add(this.labEndDate);
            this.Controls.Add(this.DateEnd);
            this.Controls.Add(this.labStartDate);
            this.Controls.Add(this.DateStart);
            this.Name = "FmFrontCustomTime";
            this.Text = "自定义时间段";
            this.Controls.SetChildIndex(this.DateStart, 0);
            this.Controls.SetChildIndex(this.labStartDate, 0);
            this.Controls.SetChildIndex(this.DateEnd, 0);
            this.Controls.SetChildIndex(this.labEndDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DateEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateStart.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labEndDate;
        private DevExpress.XtraEditors.DateEdit DateEnd;
        private DevExpress.XtraEditors.LabelControl labStartDate;
        private DevExpress.XtraEditors.DateEdit DateStart;
    }
}