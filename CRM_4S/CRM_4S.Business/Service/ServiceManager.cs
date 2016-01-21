

using CRM_4S.DataService;
using CRM_4S.DataService.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace CRM_4S.Business.Service
{
    class ServiceManager : IDisposable
    {
        private static ServiceManager instance;
        public static ServiceManager Instance
        {
            get
            {
                if (instance == null) instance = new ServiceManager();

                return instance;
            }
        }

        //private DataServiceClient dataService = new DataServiceClient();
        private IDataService dataServiceLocal;

        public IDataService ServiceClient
        {
            get
            {
                //if (ConfigurationManager.AppSettings["LocalService"] == "0")
                //{
                //    if (dataService == null
                //        || dataService.State.Equals(System.ServiceModel.CommunicationState.Closed)
                //        || dataService.State.Equals(System.ServiceModel.CommunicationState.Faulted))
                //    {
                //        //补充HeaderMessage（HeaerMessage用于验证用户与通道安全性）
                //        //currentUser.SessionId
                //        //currentUser.CurrentUser.UserId
                //        dataService = new DataServiceClient();
                //    }

                //    return dataService;
                //}
                //else
                //{
                    if (dataServiceLocal == null)
                    {
                        dataServiceLocal = new DataLocalService();
                    }

                    return dataServiceLocal;
                //}
                //return new DataService.DataService() as IDataService;
            }
        }

        public void Dispose()
        {
            //try
            //{
            //    if (ServiceClient != null
            //        && ServiceClient.State.Equals(System.ServiceModel.CommunicationState.Opened))
            //    {
            //        ServiceClient.Close();
            //    }
            //}
            //finally
            //{
            //    ServiceClient = null;
            //}
        }
    }

    class DataLocalService : IDataService
    {
        DataService.DataService localDataService = new CRM_4S.DataService.DataService();

        public ResultValue UserValidator(string userName, string pwd)
        {
            return localDataService.UserValidator(userName, pwd);
        }

        public ResultValue FuncSaveData(FunctionParms functionParms)
        {
            return localDataService.FuncSaveData(functionParms);
        }

        public ResultValue[] FuncBatchSaveData(FunctionParms[] functionParms)
        {
            return localDataService.FuncBatchSaveData(functionParms);
        }

        public ResultValue FuncGetResults(FunctionParms functionParms)
        {
            return localDataService.FuncGetResults(functionParms);
        }
    }
}
