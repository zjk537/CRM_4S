namespace CRM_4S.BasicsManager
{
    partial class FmConsultantTaskInfo
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
            this.cbConsultant = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtEndDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbCarType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTaskNum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTaskDesc = new DevExpress.XtraEditors.MemoEdit();
            this.errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cbConsultant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCarType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaskNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaskDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 23);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "销售顾问";
            // 
            // cbConsultant
            // 
            this.cbConsultant.Location = new System.Drawing.Point(100, 18);
            this.cbConsultant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbConsultant.Name = "cbConsultant";
            this.cbConsultant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbConsultant.Size = new System.Drawing.Size(258, 21);
            this.cbConsultant.TabIndex = 1;
            // 
            // dtStartDate
            // 
            this.dtStartDate.EditValue = new System.DateTime(2016, 1, 22, 11, 26, 28, 0);
            this.dtStartDate.Location = new System.Drawing.Point(100, 49);
            this.dtStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtStartDate.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.dtStartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtStartDate.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.dtStartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtStartDate.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm";
            this.dtStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtStartDate.Size = new System.Drawing.Size(258, 21);
            this.dtStartDate.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 54);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "开始时间";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 85);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "结束时间";
            // 
            // dtEndDate
            // 
            this.dtEndDate.EditValue = new System.DateTime(2016, 1, 22, 11, 29, 5, 28);
            this.dtEndDate.Location = new System.Drawing.Point(100, 80);
            this.dtEndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEndDate.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.dtEndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtEndDate.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.dtEndDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtEndDate.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm";
            this.dtEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtEndDate.Size = new System.Drawing.Size(258, 21);
            this.dtEndDate.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 117);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "车型";
            // 
            // cbCarType
            // 
            this.cbCarType.Location = new System.Drawing.Point(100, 111);
            this.cbCarType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCarType.Name = "cbCarType";
            this.cbCarType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCarType.Size = new System.Drawing.Size(258, 21);
            this.cbCarType.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(20, 147);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "任务数量";
            // 
            // txtTaskNum
            // 
            this.txtTaskNum.Location = new System.Drawing.Point(100, 142);
            this.txtTaskNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaskNum.Name = "txtTaskNum";
            this.txtTaskNum.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTaskNum.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTaskNum.Properties.Mask.EditMask = "##0";
            this.txtTaskNum.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTaskNum.Properties.Mask.SaveLiteral = false;
            this.txtTaskNum.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTaskNum.Size = new System.Drawing.Size(258, 21);
            this.txtTaskNum.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(20, 178);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "任务描述";
            // 
            // txtTaskDesc
            // 
            this.txtTaskDesc.Location = new System.Drawing.Point(100, 173);
            this.txtTaskDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaskDesc.Name = "txtTaskDesc";
            this.txtTaskDesc.Size = new System.Drawing.Size(258, 61);
            this.txtTaskDesc.TabIndex = 3;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FmConsultantTaskInfo
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 283);
            this.Controls.Add(this.txtTaskNum);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.cbCarType);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cbConsultant);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtTaskDesc);
            this.Margin = new System.Windows.Forms.Padding(21, 32, 21, 32);
            this.Name = "FmConsultantTaskInfo";
            this.Text = "销售顾问任务安排";
            this.Controls.SetChildIndex(this.txtTaskDesc, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.cbConsultant, 0);
            this.Controls.SetChildIndex(this.labelControl5, 0);
            this.Controls.SetChildIndex(this.cbCarType, 0);
            this.Controls.SetChildIndex(this.labelControl6, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.dtStartDate, 0);
            this.Controls.SetChildIndex(this.dtEndDate, 0);
            this.Controls.SetChildIndex(this.txtTaskNum, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cbConsultant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCarType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaskNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaskDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbConsultant;
        private DevExpress.XtraEditors.DateEdit dtStartDate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtEndDate;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbCarType;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtTaskNum;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit txtTaskDesc;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;
    }
}