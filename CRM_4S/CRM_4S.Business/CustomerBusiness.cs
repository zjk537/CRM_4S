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
    public class CustomerBusiness : BusinessBase<CustomerBusiness>
    {
        /// <summary>
        /// ��ȡ�˿���Ϣ
        /// </summary>
        /// <param name="info">shopIdΪ0 ʱ ��ȡ����ϵͳ����������û� </param>
        /// <returns></returns>
        public IList<CustomerInfo> GetCustomers(CustomerInfo info)
        {
            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspGetCustomers";
                funcParms.Pams = info.GetPams();

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetCustomers.uspGetCustomers", true);

            return DoFunctionWithLog<List<CustomerInfo>>(() =>
            {
                return ConvertToList<CustomerInfo>(result);

            }, null, "GetCustomers.ConvertToList", true);
        }

        public IList<CustomerInfo> GetCustomerByIds(int[] ids)
        {
            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspGetCustomerByIds";
                funcParms.Pams = new Dictionary<string, object>();
                funcParms.Pams.Add("CustomerIds", string.Join(",", ids));

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetCustomerByIds.uspGetCustomerByIds", true);

            return DoFunctionWithLog<List<CustomerInfo>>(() =>
            {
                return ConvertToList<CustomerInfo>(result);

            }, null, "GetCustomerByIds.ConvertToList", true);
        }

        public void AddCustomer(CustomerInfo info)
        {
            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspAddCustomer";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncGetResults(functionParms);
            }, new ResultValue(), "AddCustomer.uspAddCustomer", true);

            if (!result.Faild)
            {
                info.Id = Convert.ToInt32(result.ResultTable.Rows[0][0]);
            }
        }

        public void UpdateCustomer(CustomerInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspUpdateCustomer";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "AddCustomer.uspUpdateCustomer", true);
        }
    }
}
