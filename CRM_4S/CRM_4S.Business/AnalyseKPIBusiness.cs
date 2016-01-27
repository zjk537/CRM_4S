using CRM_4S.Business.Service;
using CRM_4S.DataService.Model;
using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business
{
    public class AnalyseKPIBusiness : BusinessBase<AnalyseKPIBusiness>
    {
        public IList<AnalyseKPIInfo> GetAnalyseKPIs()
        {
            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspGetAnalyseKPIs";

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetAnalyseKPIs.uspGetAnalyseKPIs", true);

            return DoFunctionWithLog<List<AnalyseKPIInfo>>(() =>
            {
                return ConvertToList<AnalyseKPIInfo>(result);

            }, null, "GetAnalyseKPIs.ConvertToList", true);
        }

        public void AddAnalyseKPI(AnalyseKPIInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspAddAnalyseKPI";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "AddAnalyseKPI.uspAddAnalyseKPI", true);
        }

        public void UpdateAnalyseKPI(AnalyseKPIInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspUpdateAnalyseKPI";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "UpdateAnalyseKPI.uspUpdateAnalyseKPI", true);
        }

        public void DeleteAnalyseKPI(AnalyseKPIInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspDeleteAnalyseKPI";
                functionParms.Pams = new Dictionary<string, object>();
                functionParms.Pams.Add("AnalyseKpiId", info.Id);

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "DeleteAnalyseKPI.uspDeleteAnalyseKPI", true);
        }
    }
}
