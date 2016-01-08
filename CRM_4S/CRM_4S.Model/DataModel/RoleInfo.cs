/* ==============================================================================
 * 功能描述：角色实体类型
 * 创 建 者：zjk
 * 创建日期：2016-01-08 16:54
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Model.DataModel
{
    public class RoleInfo
    {
        /// <summary>
        /// 获取或设置 角色Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 获取或设置 角色名称
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// 获取或设置 角色描述
        /// </summary>
        public string RoleDesc { get; set; }

        /// <summary>
        /// 获取或设置 创建时间
        /// </summary>
        public DateTime? CreatedDate { get; set; }

    }
}