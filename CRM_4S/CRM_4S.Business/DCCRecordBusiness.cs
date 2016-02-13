using CRM_4S.Business.BusinessModel;
using CRM_4S.Business.Service;
using CRM_4S.Business.ViewModel;
using CRM_4S.DataService.Model;
using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CRM_4S.Business
{
    public class DCCRecordBusiness : BusinessBase<DCCRecordBusiness>
    {
        public IList<DCCCustomerRecordInfo> GetDCCRecords(ViewQueryInfo qInfo)
        {
            var customerRecords = GetDCCCustomerRecords(qInfo);
            var customers = CustomerBusiness.Instance.GetCustomerByIds(customerRecords.Select(e => e.CustomerId).Distinct().ToArray());
            List<DCCCustomerRecordInfo> listResults = new List<DCCCustomerRecordInfo>();
            foreach (DCCRecordInfo info in customerRecords)
            {
                listResults.Add(new DCCCustomerRecordInfo()
                {
                    Customer = customers.FirstOrDefault(e => e.Id == info.CustomerId),
                    DCCRecord = info,
                });
            }
            return listResults;
        }


        public IList<DCCRecordInfo> GetDCCCustomerRecords(ViewQueryInfo info)
        {
            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspGetDCCCustomerRecords";
                funcParms.Pams = info.GetPams();

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetDCCCustomerRecords.uspGetDCCCustomerRecords", true);

            return DoFunctionWithLog<List<DCCRecordInfo>>(() =>
            {
                return ConvertToList<DCCRecordInfo>(result);

            }, null, "GetDCCCustomerRecords.ConvertToList", true);
        }

        public void AddDCCRecord(DCCRecordInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspAddDCCRecord";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "AddDCCRecord.uspAddDCCRecord", true);
        }

        public void UpdateDCCRecord(DCCRecordInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspUpdateDCCRecord";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "UpdateDCCRecord.uspUpdateDCCRecord", true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        public void BulkInsertData(DataTable source)
        {
            // clear temp table
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "ufcBulkInsert";
                functionParms.Pams = new Dictionary<string, object>();
                functionParms.Pams.Add("typeName", "Dcc");
                functionParms.Pams.Add("resource", source);

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "BulkInsertData.ufcBulkInsert", true);
        }
    }
}
