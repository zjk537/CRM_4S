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
    public class UserBusiness : BusinessBase<UserBusiness>
    {

        public IList<UserInfo> GetUsers(UserInfo info = null)
        {
            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspGetUsers";
                if (info != null)
                {
                    funcParms.Pams = info.GetPams();
                }
                else
                {
                    funcParms.Pams = new Dictionary<string, object>();
                    funcParms.Pams.Add("UserShopId", null);
                    funcParms.Pams.Add("UserRoleId", null);
                }

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetUsers.uspGetUsers", true);

            return DoFunctionWithLog<List<UserInfo>>(() =>
            {
                return ConvertToList<UserInfo>(result);

            }, null, "GetUsers.ConvertToList", true);
        }

        public void AddUser(UserInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspAddUser";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "AddUser.uspAddUser", true);
        }

        public void UpdateUser(UserInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspUpdateUser";
                functionParms.Pams = info.GetPams();

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "UpdateUser.uspUpdateUser", true);
        }

        public void DeleteUser(UserInfo info)
        {
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspDeleteUser";
                functionParms.Pams = new Dictionary<string, object>();
                functionParms.Pams.Add("UserId", info.Id);

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "DeleteUser.uspDeleteUser", true);
        }

        public bool ValidateUserName(int uid, string userName)
        {
            ResultValue result = DoFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "uspValidateUserName";
                functionParms.Pams = new Dictionary<string, object>();
                functionParms.Pams.Add("UserId", uid);
                functionParms.Pams.Add("UserUserName", userName);

                return ServiceManager.Instance.ServiceClient.FuncGetResults(functionParms);
            }, null, "ValidateUserName.uspValidateUserName", false);

            var dbUserId = 0;
            if (result.ResultTable.Rows.Count() > 0)
            {
                dbUserId = Convert.ToInt32(result.ResultTable.Rows[0][0]);
            }

            return dbUserId == 0;
        }

        public IList<UserShopRoleInfo> GetUserShopRoleInfos(int shopId)
        {
            var users = GetUsers(new UserInfo() { ShopId = shopId });
            List<UserShopRoleInfo> results = new List<UserShopRoleInfo>();

            foreach (UserInfo user in users)
            {
                results.Add(new UserShopRoleInfo() { User = user });
            }

            return results;
        }

        public UserInfo GetUserByName(string userName, string pwd)
        {
            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspGetUserByName";
                funcParms.Pams = new Dictionary<string, object>();
                funcParms.Pams.Add("UserUserName", userName);
                funcParms.Pams.Add("UserPwd", pwd);

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetUserByName.uspGetUserByName", true);


            var user = DoFunctionWithLog<UserInfo>(() =>
            {
                return ConvertToList<UserInfo>(result).FirstOrDefault();

            }, null, "GetUserByName.ConvertToList", true);

            return user;
        }
    }
}
