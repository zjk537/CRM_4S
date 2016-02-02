using CRM_4S.Model.EnumType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_4S.Business
{
    public class GloablConstants
    {

        public static List<string> UserTaskStatus = new List<string>() { "未知", "未完成", "已完成" };

        public static List<string> BooleanDesc = new List<string>() { "是", "否" };

        /// <summary>
        /// 系统管理员角色Id
        /// </summary>
        public static int RoleIdSysAdmin = 1;
        /// <summary>
        /// 销售顾问角色Id
        /// </summary>
        public static int RoleIdConsultant = 6;


    }
}
