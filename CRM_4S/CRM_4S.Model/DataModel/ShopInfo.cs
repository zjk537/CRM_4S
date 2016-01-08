/* ==============================================================================
 * 功能描述：店面实体类型
 * 创 建 者：zjk
 * 创建日期：2016-01-08 16:53
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Model.DataModel
{
    public class ShopInfo
    {
        /// <summary>
        /// 获取或设置 店铺Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 获取或设置 店铺名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 获取或设置 店铺联系方式
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 获取或设置 店铺地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 获取或设置 店铺介绍
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 获取或设置 店铺信息最近一次更新
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// 获取或设置 创建时间
        /// </summary>
        public DateTime? CreateDate { get; set; }

    }
}