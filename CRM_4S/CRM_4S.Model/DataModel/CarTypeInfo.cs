/* ==============================================================================
 * 功能描述：汽车类型实体
 * 创 建 者：zjk
 * 创建日期：2016-01-08 16:56
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Model.DataModel
{
    public class CarTypeInfo
    {
        /// <summary>
        /// 获取或设置 汽车类型Id 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 获取或设置 汽车类型父Id
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// 获取或设置 汽车类型名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 获取或设置 汽车类型描述
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 获取或设置 创建时间
        /// </summary>
        public DateTime? CreateDate { get; set; }

    }
}