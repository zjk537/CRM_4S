/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-01-12 14:04
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Model.DataModel
{
    public class DCCRecordInfo
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
        /// 获取或设置 录入人员Id
        /// </summary>
        public int RecorderId { get; set; }

        /// <summary>
        /// 获取或设置 销售顾问Id
        /// </summary>
        public int? ConsultantId { get; set; }

        /// <summary>
        /// 获取或设置 意向车型
        /// </summary>
        public int PurposeCar { get; set; }

        /// <summary>
        /// 获取或设置 线索来源
        /// </summary>
        public int Source { get; set; }

        /// <summary>
        /// 获取或设置 线索状态：有效；无效；重复
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置 承诺到店：是；否；还需要跟进
        /// </summary>
        public int? PromiseShop { get; set; }

        /// <summary>
        /// 获取或设置 是否登录
        /// </summary>
        public int IsLogin { get; set; }

        /// <summary>
        /// 获取或设置 回访次数
        /// </summary>
        public int RecallCount { get; set; }

        /// <summary>
        /// 获取或设置 回访详情记录
        /// </summary>
        public string RecallDesc { get; set; }

        /// <summary>
        /// 获取或设置 预约到店时间
        /// </summary>
        public DateTime? SubscribeTime { get; set; }

        /// <summary>
        /// 获取或设置 创建时间
        /// </summary>
        public DateTime? CreatedDate { get; set; }

    }
}