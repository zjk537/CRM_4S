using CRM_4S.Model.EnumType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_4S.Business
{
    public class GlobalConstants
    {
        public static List<string> SexList = new List<string>() { "男", "女" };

        public static List<string> UserStatus = new List<string>() { "在职", "离职", "休假" };

        public static List<string> DCCStatus = new List<string>() { "有效", "无效", "重复" };

        public static List<string> UserTaskStatus = new List<string>() { "未知", "未完成", "已完成" };

        public static List<string> BooleanDesc = new List<string>() { "是", "否" };

        /// <summary>
        /// 系统超级管理员角色Id
        /// </summary>
        public static int RoleIdSysAdmin = 1;

        /// <summary>
        /// 系统管理员 总经理
        /// </summary>
        public static int RoleIdSysManager = 2;

        /// <summary>
        /// 销售经理
        /// </summary>
        public static int RoleIdConsultManager = 3;

        /// <summary>
        /// 市场经理
        /// </summary>
        public static int RoleIdMarketManager = 4;

        /// <summary>
        /// 店面前台
        /// </summary>
        public static int RoleIdShopFront = 5;

        /// <summary>
        /// 销售顾问角色Id
        /// </summary>
        public static int RoleIdConsultant = 6;


    }
}
