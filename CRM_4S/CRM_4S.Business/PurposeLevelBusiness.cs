using CRM_4S.Business.Service;
using CRM_4S.DataService.Model;
using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business
{
    public class PurposeLevelBusiness : BusinessBase<PurposeLevelBusiness>
    {
        public IList<PurposeLevelInfo> GetPurposeLevels()
        {
            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspGetPurposeLevels";

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetCustomerLevels.uspGetPurposeLevels", true);

            return DoFunctionWithLog<List<PurposeLevelInfo>>(() =>
            {
                return ConvertToList<PurposeLevelInfo>(result);

            }, null, "GetPurposeLevels.ConvertToList", true);
        }

        public void AddPurposeLevel(PurposeLevelInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspAddPurposeLevel";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "AddPurposeLevel.uspAddPurposeLevel", true);
        }

        public void UpdatePurposeLevel(PurposeLevelInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspUpdatePurposeLevel";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "UpdatePurposeLevel.uspUpdatePurposeLevel", true);
        }

        public void DeletePurposeLevel(PurposeLevelInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspDeletePurposeLevel";
                functionParms.Pams = new Dictionary<string, object>();
                functionParms.Pams.Add("PurposeLevelId", info.Id);

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "DeletePurposeLevel.uspDeletePurposeLevel", true);

        }
    }
}
