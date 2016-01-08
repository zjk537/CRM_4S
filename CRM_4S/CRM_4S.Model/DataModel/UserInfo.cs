/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-01-08 13:28
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Model
{
    public class UserInfo
    {
        /// <summary>
        /// 获取或设置 用户Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 获取或设置 店面Id
        /// </summary>
        public int ShopId { get; set; }

        /// <summary>
        /// 获取或设置 用户角色Id
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// 获取或设置 登录用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 获取或设置 用户密码
        /// </summary>
        public string Pwd { get; set; }

        /// <summary>
        /// 获取或设置 用户真实姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 获取或设置 用户性别  1:男   2:女
        /// </summary>
        public int? Sex { get; set; }

        /// <summary>
        /// 获取或设置 用户手机号码
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 获取或设置 用户座机号码
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// 获取或设置 
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// 获取或设置 创建时间
        /// </summary>
        public DateTime? CreatedDate { get; set; }

    }
}