using CRM_4S.Business.Service;
using CRM_4S.DataService.Model;
using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business
{
    public class CustomerLevelBusiness : BusinessBase<CustomerLevelBusiness>
    {
        public IList<CustomerLevelInfo> GetCustomerLevels()
        {
            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspGetCustomerLevels";

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetCustomerLevels.uspGetCustomerLevels", true);

            return DoFunctionWithLog<List<CustomerLevelInfo>>(() =>
            {
                return ConvertToList<CustomerLevelInfo>(result);

            }, null, "GetCustomerLevels.ConvertToList", true);
        }

        public void AddCustomerLevel(CustomerLevelInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspAddCustomerLevel";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "AddCustomerLevel.uspAddCustomerLevel", true);
        }

        public void UpdateCustomerLevel(CustomerLevelInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspUpdateCustomerLevel";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "UpdateCustomerLevel.uspUpdateCustomerLevel", true);
        }

        public void DeleteCustomerLevel(CustomerLevelInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspDeleteCustomerLevel";
                functionParms.Pams = new Dictionary<string, object>();
                functionParms.Pams.Add("CustomerLevelId", info.Id);

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "DeleteCustomerLevel.uspDeleteCustomerLevel", true);

        }
    }
}
