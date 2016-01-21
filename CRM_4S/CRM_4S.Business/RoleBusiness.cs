using CRM_4S.Business.Service;
using CRM_4S.DataService.Model;
using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business
{
    public class RoleBusiness : BusinessBase<RoleBusiness>
    {

        public IList<RoleInfo> GetRoles()
        {
            var result = DoFunctionWithLog<ResultValue>(() =>
            {
                var funcParms = new FunctionParms();
                funcParms.FunctionName = "uspGetRoles";

                return ServiceManager.Instance.ServiceClient.FuncGetResults(funcParms);
            }, new ResultValue(), "GetRoles.uspGetRoles", true);

            return DoFunctionWithLog<List<RoleInfo>>(() =>
            {
                return ConvertToList<RoleInfo>(result);

            }, null, "GetRoles.ConvertToList", true);
        }
    }
}
