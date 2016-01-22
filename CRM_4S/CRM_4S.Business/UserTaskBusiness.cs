using CRM_4S.Business.Service;
using CRM_4S.DataService.Model;
using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business
{
    public class UserTaskBusiness : BusinessBase<UserTaskBusiness>
    {
        public IList<UserTaskInfo> GetUserTasks()
        {
            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspGetUserTasks";

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetUserTasks.uspGetUserTasks", true);

            return DoFunctionWithLog<List<UserTaskInfo>>(() =>
            {
                return ConvertToList<UserTaskInfo>(result);

            }, null, "GetUserTasks.ConvertToList", true);
        }

        public void AddUserTask(UserTaskInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspAddUserTask";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "AddUserTask.uspAddUserTask", true);
        }

        public void UpdateUserTask(UserTaskInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspUpdateUserTask";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "UpdateUserTask.uspUpdateUserTask", true);
        }

        public void DeleteUserTask(UserTaskInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspDeleteUserTask";
                functionParms.Pams = new Dictionary<string, object>();
                functionParms.Pams.Add("UserTaskId", info.Id);

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "DeleteUserTask.uspDeleteUserTask", true);
        }
    }
}
