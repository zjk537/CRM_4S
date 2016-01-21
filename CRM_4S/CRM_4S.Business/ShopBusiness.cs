using CRM_4S.Business.Service;
using CRM_4S.DataService.Model;
using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business
{
    public class ShopBusiness : BusinessBase<ShopBusiness>
    {

        /// <summary>
        /// 获取所有店面
        /// </summary>
        /// <returns></returns>
        public IList<ShopInfo> GetShops()
        {
            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspGetShops";

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetShops.uspGetShops", true);

            return DoFunctionWithLog<List<ShopInfo>>(() =>
            {
                return ConvertToList<ShopInfo>(result);

            }, null, "GetShops.ConvertToList", true);
        }


        public void AddShop(ShopInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspAddShop";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "AddShop.uspAddShop", true);
        }

        public void UpdateShop(ShopInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspUpdateShop";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "UpdateShop.uspUpdateShop", true);
        }

        public void DeleteShop(ShopInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspDeleteShop";
                functionParms.Pams = new Dictionary<string, object>();
                functionParms.Pams.Add("ShopId", info.Id);

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "DeleteShop.uspDeleteShop", true);
        }
    }
}
