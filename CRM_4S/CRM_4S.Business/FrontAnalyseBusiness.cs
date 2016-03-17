using CRM_4S.Business.BusinessModel;
using CRM_4S.Business.Service;
using CRM_4S.DataService.Model;
using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business
{
    public class FrontAnalyseBusiness : BusinessBase<FrontAnalyseBusiness>
    {
        public FrontKPIInfo GetFrontAnalyseResult(int consultantId, DateTime startDate, DateTime endDate)
        {

            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspFrontAnalyse";
                funcParms.Pams = new Dictionary<string, object>();
                funcParms.Pams.Add("ConsultantId", consultantId);
                funcParms.Pams.Add("StartDate", startDate);
                funcParms.Pams.Add("EndDate", endDate);

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetFrontAnalyseResult.uspFrontAnalyse", true);


            var kpiInfo = DoFunctionWithLog<FrontKPIInfo>(() =>
            {
                return ConvertToList<FrontKPIInfo>(result).FirstOrDefault();

            }, null, "GetFrontAnalyseResult.ConvertToList", true);

            return kpiInfo;
        }

        public FrontKPIInfo GetFrontAvgAnalyseResult(DateTime startDate, DateTime endDate)
        {

            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspFrontAvgAnalyse";
                funcParms.Pams = new Dictionary<string, object>();
                funcParms.Pams.Add("StartDate", startDate);
                funcParms.Pams.Add("EndDate", endDate);

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetFrontAvgAnalyseResult.uspFrontAvgAnalyse", true);


            var kpiInfo = DoFunctionWithLog<FrontKPIInfo>(() =>
            {
                return ConvertToList<FrontKPIInfo>(result).FirstOrDefault();

            }, null, "GetFrontAvgAnalyseResult.ConvertToList", true);

            return kpiInfo;
        }

        public FrontKPIInfo GetFrontGroupAnalyseResult(int groupId, DateTime startDate, DateTime endDate)
        {

            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspFrontGroupAnalyse";
                funcParms.Pams = new Dictionary<string, object>();
                funcParms.Pams.Add("GroupId", groupId);
                funcParms.Pams.Add("StartDate", startDate);
                funcParms.Pams.Add("EndDate", endDate);

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetFrontGroupAnalyseResult.uspFrontGroupAnalyse", true);


            var kpiInfo = DoFunctionWithLog<FrontKPIInfo>(() =>
            {
                return ConvertToList<FrontKPIInfo>(result).FirstOrDefault();

            }, null, "GetFrontGroupAnalyseResult.ConvertToList", true);

            return kpiInfo;
        }

        public FrontKPIInfo GetFrontGroupAvgAnalyseResult(DateTime startDate, DateTime endDate)
        {

            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspFrontGroupAvgAnalyse";
                funcParms.Pams = new Dictionary<string, object>();
                funcParms.Pams.Add("StartDate", startDate);
                funcParms.Pams.Add("EndDate", endDate);

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetFrontGroupAvgAnalyseResult.uspFrontGroupAvgAnalyse", true);


            var kpiInfo = DoFunctionWithLog<FrontKPIInfo>(() =>
            {
                return ConvertToList<FrontKPIInfo>(result).FirstOrDefault();

            }, null, "GetFrontGroupAvgAnalyseResult.ConvertToList", true);

            return kpiInfo;
        }

    }
}
