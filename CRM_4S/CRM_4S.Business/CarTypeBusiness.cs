using CRM_4S.Business.Service;
using CRM_4S.DataService.Model;
using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business
{
    public class CarTypeBusiness : BusinessBase<CarTypeBusiness>
    {
        public IList<CarTypeInfo> GetCarTypes()
        {
            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspGetCarTypes";

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetCarTypes.uspGetCarTypes", true);

            return DoFunctionWithLog<List<CarTypeInfo>>(() =>
            {
                return ConvertToList<CarTypeInfo>(result);

            }, null, "GetCarTypes.ConvertToList", true);
        }

        public void AddCarType(CarTypeInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspAddCarType";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "AddCarType.uspAddCarType", true);
        }

        public void UpdateCarType(CarTypeInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspUpdateCarType";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "UpdateCarType.uspUpdateCarType", true);
        }

        public void DeleteCarType(CarTypeInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspDeleteCarType";
                functionParms.Pams = new Dictionary<string, object>();
                functionParms.Pams.Add("CarTypeId", info.Id);

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "DeleteCarType.uspDeleteCarType", true);

        }
    }
}
