/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-01-12 14:05
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Model.DataModel
{
    public class VisitRecordInfo
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
        /// 获取或设置 接待人数
        /// </summary>
        public int CustomerNum { get; set; }

        /// <summary>
        /// 获取或设置 牌照状况：已有牌照；待拍牌照；旧车退牌；郊区牌照；外省上牌
        /// </summary>
        public int CarLicence { get; set; }

        /// <summary>
        /// 获取或设置 意向车型
        /// </summary>
        public int PurposeCar { get; set; }

        /// <summary>
        /// 获取或设置 试驾状态：1试驾 2未试驾 3未知
        /// </summary>
        public int DriveStatus { get; set; }

        /// <summary>
        /// 获取或设置 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 获取或设置 到店时间
        /// </summary>
        public DateTime? ArrivalTime { get; set; }

        /// <summary>
        /// 获取或设置 离开时间
        /// </summary>
        public DateTime? LeaveTime { get; set; }

        /// <summary>
        /// 获取或设置 接待时长
        /// </summary>
        public string DurationTime { get; set; }

        /// <summary>
        /// 获取或设置 
        /// </summary>
        public DateTime? CreatedDate { get; set; }

    }
}