/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-01-12 12:50
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Model.DataModel
{
    public class TradeRecordInfo
    {
        /// <summary>
        /// 获取或设置 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 获取或设置 客户Id
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// 获取或设置 店面Id
        /// </summary>
        public int ShopId { get; set; }

        /// <summary>
        /// 获取或设置 录入人员Id
        /// </summary>
        public int RecorderId { get; set; }

        /// <summary>
        /// 获取或设置 销售顾问Id
        /// </summary>
        public int? ConsultantId { get; set; }

        /// <summary>
        /// 获取或设置 成交车型
        /// </summary>
        public string CarType { get; set; }

        /// <summary>
        /// 获取或设置 成交备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 获取或设置 成交时间
        /// </summary>
        public DateTime? CreatedDate { get; set; }

    }
}