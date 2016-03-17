using CRM_4S.Business;
using CRM_4S.Business.BusinessModel;
using CRM_4S.Common.FormBase;
using CRM_4S.Model.DataModel;
using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRM_4S.DataAnalyse
{
    public partial class FmAnalyseResult : FormSimpleDialogBase
    {
        UserInfo consultantInfo = null;
        UserGroupInfo consultGroupInfo = null;


        private IList<AnalyseKPIInfo> kpiList = null;
        private IList<AnalyseKPIInfo> KPIList
        {
            get
            {
                if (kpiList == null)
                {
                    kpiList = AnalyseKPIBusiness.Instance.GetAnalyseKPIs();
                }
                return kpiList;
            }
        }
        public FmAnalyseResult(UserInfo info)
        {
            InitializeComponent();
            consultantInfo = info;
        }

        public FmAnalyseResult(UserInfo info, UserGroupInfo groupInfo)
        {
            InitializeComponent();
            consultantInfo = info;
            consultGroupInfo = groupInfo;

            this.Btn_OK.Click += Btn_OK_Click;
        }

        void Btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FmGroupResult_Load(object sender, EventArgs e)
        {
            if (consultantInfo.RoleId == GlobalConstants.RoleIdFrontConsultant)
            {

                if (consultGroupInfo == null)
                    BindFrontResult();
                else
                    BindFrontGroupResult();
            }
            else
            {
                if (consultGroupInfo == null)
                    BindDCCResult();
                else
                    BindDCCGroupResult();
            }

        }

        #region Front Consultant

        private void BindFrontResult()
        {
            //DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //DateTime endDate = DateTime.Now;
            DateTime startDate = new DateTime(2015, 12, 1);
            DateTime endDate = new DateTime(2015, 12, 31);
            var avgKPI = FrontAnalyseBusiness.Instance.GetFrontAvgAnalyseResult(startDate, endDate);
            this.chartControl1.SeriesSerializable[0].Points.AddRange(GetSeriesPoints(avgKPI));

            var kpi = FrontAnalyseBusiness.Instance.GetFrontAnalyseResult(consultantInfo.Id, startDate, endDate);
            this.chartControl1.SeriesSerializable[1].Points.AddRange(GetSeriesPoints(kpi));
            this.chartControl1.Update();

            ShowNotices(kpi, avgKPI);
        }

        private void BindFrontGroupResult()
        {
            DateTime startDate = new DateTime(2015, 12, 1);
            DateTime endDate = new DateTime(2015, 12, 31);
            var avgKPI = FrontAnalyseBusiness.Instance.GetFrontGroupAvgAnalyseResult(startDate, endDate);
            this.chartControl1.SeriesSerializable[0].Points.AddRange(GetSeriesPoints(avgKPI));

            var kpi = FrontAnalyseBusiness.Instance.GetFrontGroupAnalyseResult(consultantInfo.Id, startDate, endDate);
            this.chartControl1.SeriesSerializable[1].Points.AddRange(GetSeriesPoints(kpi));
            this.chartControl1.Update();

            ShowNotices(kpi, avgKPI);
        }

        private SeriesPoint[] GetSeriesPoints(FrontKPIInfo info)
        {
            List<SeriesPoint> points = new List<SeriesPoint>();
            points.Add(new SeriesPoint("首次接待量", new object[] { Math.Ceiling(info.Scjd) }));
            points.Add(new SeriesPoint("首次有效率", new object[] { info.ScyxRate.ToString("F2") }));
            points.Add(new SeriesPoint("客户试驾率", new object[] { info.SjkhRate.ToString("F2") }));
            points.Add(new SeriesPoint("邀约进店率", new object[] { info.YyjdRate.ToString("F2") }));
            points.Add(new SeriesPoint("首次转化率", new object[] { info.ScdjRate.ToString("F2") }));
            points.Add(new SeriesPoint("二次转化率", new object[] { info.EcdjRate.ToString("F2") }));
            return points.ToArray();
        }

        private void ShowNotices(FrontKPIInfo kpi, FrontKPIInfo avgKPI)
        {
            List<AnalyseKPIInfo> noticeKpiInfos = new List<AnalyseKPIInfo>();
            var scjdKpiInfo = this.KPIList.FirstOrDefault(e => e.BasicId == 33); // 首次接待量
            if (avgKPI.Scjd > 0)
            {
                float scjdRate = (kpi.Scjd - avgKPI.Scjd) / avgKPI.Scjd * 100;
                if (scjdRate < scjdKpiInfo.KValue)
                    noticeKpiInfos.Add(scjdKpiInfo);
            }
            var scyxKpiInfo = this.KPIList.FirstOrDefault(e => e.BasicId == 34); // 首次有效率
            if (avgKPI.ScyxRate > 0)
            {
                if ((kpi.ScyxRate - avgKPI.ScyxRate) < scyxKpiInfo.KValue)
                    noticeKpiInfos.Add(scyxKpiInfo);
            }


            //var sjkhKpiInfo = this.KPIList.FirstOrDefault(e => e.BasicId == 38); // 客户试驾率  无
            //if ((kpi.SjkhRate - avgKPI.SjkhRate) < sjkhKpiInfo.KValue)
            //    noticeKpiInfos.Add(sjkhKpiInfo);

            var yyjdKpiInfo = this.KPIList.FirstOrDefault(e => e.BasicId == 40); // 邀约到店率
            if (avgKPI.YyjdRate > 0)
            {
                if ((kpi.YyjdRate - avgKPI.YyjdRate) < yyjdKpiInfo.KValue)
                    noticeKpiInfos.Add(yyjdKpiInfo);
            }


            //var scdjKpiInfo = this.KPIList.FirstOrDefault(e => e.BasicId == 40); // 首次转化率 无
            //if ((kpi.ScdjRate - avgKPI.ScdjRate) < scdjKpiInfo.KValue)
            //    noticeKpiInfos.Add(scdjKpiInfo);

            //var ecdjKpiInfo = this.KPIList.FirstOrDefault(e => e.BasicId == 40); // 首次转化率 无
            //if ((kpi.EcdjRate - avgKPI.EcdjRate) < ecdjKpiInfo.KValue)
            //    noticeKpiInfos.Add(ecdjKpiInfo);

            if (noticeKpiInfos.Count > 0)
            {
                this.lblResultDesc.Text = string.Join("\r\n", noticeKpiInfos.Select(e => e.Perform).ToArray());
                this.lblReason.Text = string.Join("\r\n", noticeKpiInfos.Select(e => e.Reason.Replace(";", ";\r\n")).ToArray());
                this.lblSuggest.Text = string.Join("\r\n", noticeKpiInfos.Select(e => e.Suggest.Replace(";", ";\r\n")).ToArray());
            }
            else
            {
                this.lblResultDesc.Text = "暂无";
                this.lblReason.Text = "暂无";
                this.lblSuggest.Text = "暂无";
            }


        }
        #endregion

        #region DCC Consultant

        private void BindDCCResult()
        {

        }

        private void BindDCCGroupResult()
        {

        }
        #endregion
    }
}
