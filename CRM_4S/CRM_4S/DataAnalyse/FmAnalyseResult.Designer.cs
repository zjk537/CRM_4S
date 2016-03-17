namespace CRM_4S.DataAnalyse
{
    partial class FmAnalyseResult
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
            DevExpress.XtraCharts.RadarDiagram radarDiagram1 = new DevExpress.XtraCharts.RadarDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.RadarPointSeriesLabel radarPointSeriesLabel1 = new DevExpress.XtraCharts.RadarPointSeriesLabel();
            DevExpress.XtraCharts.RadarLineSeriesView radarLineSeriesView1 = new DevExpress.XtraCharts.RadarLineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.RadarPointSeriesLabel radarPointSeriesLabel2 = new DevExpress.XtraCharts.RadarPointSeriesLabel();
            DevExpress.XtraCharts.RadarLineSeriesView radarLineSeriesView2 = new DevExpress.XtraCharts.RadarLineSeriesView();
            DevExpress.XtraCharts.RadarPointSeriesLabel radarPointSeriesLabel3 = new DevExpress.XtraCharts.RadarPointSeriesLabel();
            DevExpress.XtraCharts.RadarLineSeriesView radarLineSeriesView3 = new DevExpress.XtraCharts.RadarLineSeriesView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblSuggest = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblReason = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.lblResultDesc = new DevExpress.XtraEditors.LabelControl();
            this.styleController1 = new DevExpress.XtraEditors.StyleController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(radarDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(radarPointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(radarLineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(radarPointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(radarLineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(radarPointSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(radarLineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(807, 467);
            this.panelControl1.TabIndex = 998;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblSuggest);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(432, 255);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(373, 210);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "改善建议";
            // 
            // lblSuggest
            // 
            this.lblSuggest.Location = new System.Drawing.Point(29, 43);
            this.lblSuggest.Name = "lblSuggest";
            this.lblSuggest.Size = new System.Drawing.Size(252, 14);
            this.lblSuggest.TabIndex = 0;
            this.lblSuggest.Text = "建议增加接待时长，在销售流程中增加留档几率";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblReason);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(432, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(373, 253);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "原因分析";
            // 
            // lblReason
            // 
            this.lblReason.Location = new System.Drawing.Point(15, 45);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(324, 14);
            this.lblReason.TabIndex = 0;
            this.lblReason.Text = "接待非购车客户较多，具体可能表现为客户数高于均值较多，";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl5);
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(430, 463);
            this.panelControl3.TabIndex = 0;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.chartControl1);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(2, 92);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(426, 369);
            this.panelControl5.TabIndex = 1;
            // 
            // chartControl1
            // 
            radarDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = false;
            radarDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            radarDiagram1.AxisY.Range.SideMarginsEnabled = true;
            this.chartControl1.Diagram = radarDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chartControl1.Location = new System.Drawing.Point(2, 2);
            this.chartControl1.Name = "chartControl1";
            radarPointSeriesLabel1.LineVisible = true;
            series1.Label = radarPointSeriesLabel1;
            series1.LegendText = "平均值";
            series1.Name = "normalSeries";
            series1.View = radarLineSeriesView1;
            radarPointSeriesLabel2.LineVisible = true;
            series2.Label = radarPointSeriesLabel2;
            series2.LegendText = "当前值";
            series2.Name = "curSeries";
            series2.View = radarLineSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            radarPointSeriesLabel3.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = radarPointSeriesLabel3;
            this.chartControl1.SeriesTemplate.View = radarLineSeriesView3;
            this.chartControl1.Size = new System.Drawing.Size(422, 365);
            this.chartControl1.TabIndex = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.lblResultDesc);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(426, 90);
            this.panelControl4.TabIndex = 0;
            // 
            // lblResultDesc
            // 
            this.lblResultDesc.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblResultDesc.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.lblResultDesc.LineVisible = true;
            this.lblResultDesc.Location = new System.Drawing.Point(67, 34);
            this.lblResultDesc.Name = "lblResultDesc";
            this.lblResultDesc.Size = new System.Drawing.Size(223, 14);
            this.lblResultDesc.TabIndex = 0;
            this.lblResultDesc.Text = "新增客户留档率低于均值8%：留档率偏低";
            // 
            // FmAnalyseResult
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 511);
            this.Controls.Add(this.panelControl1);
            this.Name = "FmAnalyseResult";
            this.Text = "分析结果与建议";
            this.Load += new System.EventHandler(this.FmGroupResult_Load);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(radarDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(radarPointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(radarLineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(radarPointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(radarLineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(radarPointSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(radarLineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.LabelControl lblResultDesc;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl lblReason;
        private DevExpress.XtraEditors.LabelControl lblSuggest;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.StyleController styleController1;
    }
}