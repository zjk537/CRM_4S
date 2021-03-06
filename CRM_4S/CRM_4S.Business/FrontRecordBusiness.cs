﻿using CRM_4S.Business.BusinessModel;
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
    public class FrontRecordBusiness : BusinessBase<FrontRecordBusiness>
    {

        public IList<FrontCustomerRecordInfo> GetFrontRecords(ViewQueryInfo qInfo)
        {
            var customerRecords = GetFrontCustomerRecords(qInfo);
            var customers = CustomerBusiness.Instance.GetCustomerByIds(customerRecords.Select(e=>e.CustomerId).Distinct().ToArray());
            List<FrontCustomerRecordInfo> listResults = new List<FrontCustomerRecordInfo>();
            foreach (FrontRecordInfo info in customerRecords)
            {
                // 新进店用户 还未完善信息
                if (info.CustomerId == 0)
                {
                    listResults.Add(new FrontCustomerRecordInfo
                    {
                        Customer = new CustomerInfo(),
                        FrontRecord = info,
                    });
                    continue;
                }
                // 多次进店用户
                listResults.Add(new FrontCustomerRecordInfo()
                {
                    Customer = customers.FirstOrDefault(e => e.Id == info.CustomerId),
                    FrontRecord = info,
                });
            }
            return listResults;
        }

        public IList<FrontRecordInfo> GetFrontCustomerRecords(ViewQueryInfo info)
        {
            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspGetFrontCustomerRecords";
                funcParms.Pams = info.GetPams();

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetFrontCustomerRecords.uspGetFrontCustomerRecords", true);

            return DoFunctionWithLog<List<FrontRecordInfo>>(() =>
            {
                return ConvertToList<FrontRecordInfo>(result);

            }, null, "GetFrontCustomerRecords.ConvertToList", true);
        }

        public void AddFrontRecord(FrontRecordInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspAddFrontRecord";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "AddFrontRecord.uspAddFrontRecord", true);
        }

        public void UpdateFrontRecord(FrontRecordInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspUpdateFrontRecord";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "UpdateFrontRecord.uspUpdateFrontRecord", true);
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
                functionParms.Pams.Add("typeName", "Front");
                functionParms.Pams.Add("resource", source);

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "BulkInsertData.ufcBulkInsert", true);
        }
    }
}
