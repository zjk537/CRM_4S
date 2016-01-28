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
    public class DCCRecordBusiness : BusinessBase<DCCRecordBusiness>
    {
        public IList<DCCCustomerRecordInfo> GetDCCRecords(int shopId = 0)
        {
            var customerRecords = GetDCCCustomerRecords(shopId);
            var customers = CustomerBusiness.Instance.GetCustomers(new CustomerInfo() { ShopId = shopId });
            List<DCCCustomerRecordInfo> listResults = new List<DCCCustomerRecordInfo>();
            DCCCustomerRecordInfo customerRecord = null;
            foreach (DCCRecordInfo info in customerRecords)
            {
                if (customerRecord == null || customerRecord.DCCRecord.CustomerId != info.CustomerId)
                {
                    customerRecord = new DCCCustomerRecordInfo()
                    {
                        Customer = customers.FirstOrDefault(e => e.Id == info.CustomerId),
                        DCCRecord = info,
                        RecordCnt = 1
                    };
                    listResults.Add(customerRecord);
                    continue;
                }
                customerRecord.RecordCnt++;
            }
            return listResults;
        }


        public IList<DCCRecordInfo> GetDCCCustomerRecords(int shopId = 0, int customerId = 0)
        {
            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspGetDCCCustomerRecords";
                funcParms.Pams = new Dictionary<string, object>();
                funcParms.Pams.Add("DccRecordCustomerId", customerId);
                funcParms.Pams.Add("DccRecordShopId", shopId);

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

    }
}
