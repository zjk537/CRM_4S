using CRM_4S.Business.BusinessModel;
using CRM_4S.Business.Service;
using CRM_4S.Business.ViewModel;
using CRM_4S.DataService.Model;
using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business
{
    public class OrderRecordBusiness : BusinessBase<OrderRecordBusiness>
    {
        public IList<CustomerOrderRecordInfo> GetCustomerOrderRecords(ViewQueryInfo qInfo)
        {
            var customerRecords = GetOrderRecords(qInfo);
            var customers = CustomerBusiness.Instance.GetCustomerByIds(customerRecords.Select(e => e.CustomerId).Distinct().ToArray());
            List<CustomerOrderRecordInfo> listResults = new List<CustomerOrderRecordInfo>();
            foreach (OrderRecordInfo info in customerRecords)
            {
                listResults.Add(new CustomerOrderRecordInfo()
                {
                    Customer = customers.FirstOrDefault(e => e.Id == info.CustomerId),
                    OrderRecord = info
                });
            }
            return listResults;
        }

        public IList<OrderRecordInfo> GetOrderRecords(ViewQueryInfo qInfo)
        {
            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspGetOrderRecords";
                funcParms.Pams = qInfo.GetPams();

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetOrderRecords.uspGetOrderRecords", true);

            return DoFunctionWithLog<List<OrderRecordInfo>>(() =>
            {
                return ConvertToList<OrderRecordInfo>(result);

            }, null, "GetOrderRecords.ConvertToList", true);
        }


        public void AddOrderRecord(OrderRecordInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspAddOrderRecord";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "AddOrderRecord.uspAddOrderRecord", true);
        }

        public void UpdateOrderRecord(OrderRecordInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspUpdateOrderRecord";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "UpdateOrderRecord.uspUpdateOrderRecord", true);
        }

        public void CancelOrderRecord(int recordId)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspUpdateOrderRecord";
                functionParms.Pams = new Dictionary<string, object>();
                functionParms.Pams.Add("OrderRecordId", recordId);
                functionParms.Pams.Add("OrderRecordStatus", 3); //1 预付订金; 2 订单完成 3 订单取消 

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "UpdateOrderRecord.uspUpdateOrderRecord", true);
        }
    }
}
