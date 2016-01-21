/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-01-11 15:27
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Model.DataModel
{
    public class CustomerInfo
    {
        /// <summary>
        /// 获取或设置 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 获取或设置 客户名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 获取或设置 客户联系方式
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 获取或设置 客户性质：新增到店；再次到店；电销邀约；外展留档；二级网点；其它到店
        /// </summary>
        public int Nature { get; set; }

        /// <summary>
        /// 获取或设置 原始客户性质
        /// </summary>
        public int OriginNature { get; set; }

        /// <summary>
        /// 获取或设置 行业
        /// </summary>
        public string Industry { get; set; }

        /// <summary>
        /// 获取或设置 居住地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 获取或设置 客户级别
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// 获取或设置 创建时间
        /// </summary>
        public DateTime? CreatedDate { get; set; }

    }
}