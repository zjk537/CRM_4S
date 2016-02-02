using CRM_4S.Business.Service;
using CRM_4S.DataService.Model;
using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business
{
    public class BasicsConstantBusiness : BusinessBase<BasicsConstantBusiness>
    {
        public IList<RegionInfo> GetRegions(int shopId = 0)
        {
            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspGetRegions";
                funcParms.Pams = new Dictionary<string, object>();
                funcParms.Pams.Add("RegionShopId", shopId);

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetRegions.uspGetRegions", true);

            return DoFunctionWithLog<List<RegionInfo>>(() =>
            {
                return ConvertToList<RegionInfo>(result);

            }, null, "GetRegions.ConvertToList", true);
        }

        public IList<BasicConstantInfo> GetBasicConstants(int shopId)
        {
            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspGetBasicConstants";
                funcParms.Pams = new Dictionary<string, object>();
                funcParms.Pams.Add("BasicConstantShopId", shopId);

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetBasicConstants.uspGetBasicConstants", true);

            return DoFunctionWithLog<List<BasicConstantInfo>>(() =>
            {
                return ConvertToList<BasicConstantInfo>(result);

            }, null, "GetBasicConstants.ConvertToList", true);
        }
    }
}
