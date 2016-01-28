namespace CRM_4S.DCCManager
{
    partial class FmDCCIn
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
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtCName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cbDCCSource = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cbCarType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtVisitTime = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtCPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDCCSource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCarType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVisitTime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVisitTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 1012;
            this.labelControl1.Text = "联系方式";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(18, 15);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 1013;
            this.labelControl5.Text = "顾客姓名";
            // 
            // txtCPhone
            // 
            this.txtCPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPhone.EditValue = "";
            this.txtCPhone.EnterMoveNextControl = true;
            this.txtCPhone.Location = new System.Drawing.Point(72, 41);
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.Properties.NullValuePrompt = "默认为空";
            this.txtCPhone.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCPhone.Size = new System.Drawing.Size(183, 21);
            this.txtCPhone.TabIndex = 1;
            this.txtCPhone.Leave += new System.EventHandler(this.txtCPhone_Leave);
            // 
            // txtCName
            // 
            this.txtCName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCName.EditValue = "";
            this.txtCName.EnterMoveNextControl = true;
            this.txtCName.Location = new System.Drawing.Point(72, 12);
            this.txtCName.Name = "txtCName";
            this.txtCName.Properties.NullValuePrompt = "默认为空";
            this.txtCName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCName.Size = new System.Drawing.Size(183, 21);
            this.txtCName.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(17, 98);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(48, 14);
            this.labelControl7.TabIndex = 1015;
            this.labelControl7.Text = "线索来源";
            // 
            // cbDCCSource
            // 
            this.cbDCCSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDCCSource.EnterMoveNextControl = true;
            this.cbDCCSource.Location = new System.Drawing.Point(72, 96);
            this.cbDCCSource.Name = "cbDCCSource";
            this.cbDCCSource.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDCCSource.Size = new System.Drawing.Size(183, 21);
            this.cbDCCSource.TabIndex = 3;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(17, 126);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 14);
            this.labelControl8.TabIndex = 1018;
            this.labelControl8.Text = "意向车型";
            // 
            // cbCarType
            // 
            this.cbCarType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCarType.EditValue = "";
            this.cbCarType.EnterMoveNextControl = true;
            this.cbCarType.Location = new System.Drawing.Point(72, 124);
            this.cbCarType.Name = "cbCarType";
            this.cbCarType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCarType.Size = new System.Drawing.Size(183, 21);
            this.cbCarType.TabIndex = 4;
            // 
            // dtVisitTime
            // 
            this.dtVisitTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtVisitTime.EditValue = new System.DateTime(2016, 1, 15, 9, 58, 7, 0);
            this.dtVisitTime.Location = new System.Drawing.Point(72, 69);
            this.dtVisitTime.Name = "dtVisitTime";
            this.dtVisitTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtVisitTime.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.dtVisitTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtVisitTime.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.dtVisitTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtVisitTime.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtVisitTime.Size = new System.Drawing.Size(183, 21);
            this.dtVisitTime.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1020;
            this.labelControl2.Text = "访问时间";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FmDCCIn
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 204);
            this.Controls.Add(this.dtVisitTime);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.cbCarType);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.cbDCCSource);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtCPhone);
            this.Controls.Add(this.txtCName);
            this.Name = "FmDCCIn";
            this.Text = "新增访问";
            this.Controls.SetChildIndex(this.txtCName, 0);
            this.Controls.SetChildIndex(this.txtCPhone, 0);
            this.Controls.SetChildIndex(this.labelControl5, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.cbDCCSource, 0);
            this.Controls.SetChildIndex(this.labelControl7, 0);
            this.Controls.SetChildIndex(this.cbCarType, 0);
            this.Controls.SetChildIndex(this.labelControl8, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.dtVisitTime, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtCPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDCCSource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCarType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVisitTime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVisitTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtCPhone;
        private DevExpress.XtraEditors.TextEdit txtCName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit cbDCCSource;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit cbCarType;
        private DevExpress.XtraEditors.DateEdit dtVisitTime;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;
    }
}