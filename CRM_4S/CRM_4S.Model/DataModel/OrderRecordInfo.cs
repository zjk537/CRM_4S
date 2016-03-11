/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-03-11 13:24
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;

namespace CRM_4S.Model.DataModel
{
    public class OrderRecordInfo : DBModelBase
    {

        private int id = 0;
        public bool IdSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("OrderRecordId")]
        public int Id { get { return id; } set { id = value; IdSpecify = true; } }


        private int customerId = 0;
        public bool CustomerIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 客户Id 
        /// </summary>
        [DBFieldAttribute("OrderRecordCustomerId")]
        public int CustomerId { get { return customerId; } set { customerId = value; CustomerIdSpecify = true; } }


        private int shopId = 0;
        public bool ShopIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 店面Id 
        /// </summary>
        [DBFieldAttribute("OrderRecordShopId")]
        public int ShopId { get { return shopId; } set { shopId = value; ShopIdSpecify = true; } }


        private int recorderId = 0;
        public bool RecorderIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 录入人员Id 
        /// </summary>
        [DBFieldAttribute("OrderRecordRecorderId")]
        public int RecorderId { get { return recorderId; } set { recorderId = value; RecorderIdSpecify = true; } }


        private int? consultantId = null;
        public bool ConsultantIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 销售顾问Id 
        /// </summary>
        [DBFieldAttribute("OrderRecordConsultantId")]
        public int? ConsultantId { get { return consultantId; } set { consultantId = value; ConsultantIdSpecify = true; } }


        private int? carType = null;
        public bool CarTypeSpecify { get; set; }
        /// <summary>
        /// 获取或设置 成交车型 
        /// </summary>
        [DBFieldAttribute("OrderRecordCarType")]
        public int? CarType { get { return carType; } set { carType = value; CarTypeSpecify = true; } }


        private decimal? price = null;
        public bool PriceSpecify { get; set; }
        /// <summary>
        /// 获取或设置 成交价格 
        /// </summary>
        [DBFieldAttribute("OrderRecordPrice")]
        public decimal? Price { get { return price; } set { price = value; PriceSpecify = true; } }


        private decimal? disPrice = null;
        public bool DisPriceSpecify { get; set; }
        /// <summary>
        /// 获取或设置 优惠金额 
        /// </summary>
        [DBFieldAttribute("OrderRecordDisPrice")]
        public decimal? DisPrice { get { return disPrice; } set { disPrice = value; DisPriceSpecify = true; } }


        private decimal? prevPay = null;
        public bool PrevPaySpecify { get; set; }
        /// <summary>
        /// 获取或设置 预付订金 
        /// </summary>
        [DBFieldAttribute("OrderRecordPrevPay")]
        public decimal? PrevPay { get { return prevPay; } set { prevPay = value; PrevPaySpecify = true; } }


        private int? toShopNum = null;
        public bool ToShopNumSpecify { get; set; }
        /// <summary>
        /// 获取或设置 第几次进店订交的 
        /// </summary>
        [DBFieldAttribute("OrderRecordToShopNum")]
        public int? ToShopNum { get { return toShopNum; } set { toShopNum = value; ToShopNumSpecify = true; } }


        private int? status = null;
        public bool StatusSpecify { get; set; }
        /// <summary>
        /// 获取或设置 订单状态：1 预付订金; 2 订单完成 3 订单取消 
        /// </summary>
        [DBFieldAttribute("OrderRecordStatus")]
        public int? Status { get { return status; } set { status = value; StatusSpecify = true; } }


        private string remark = string.Empty;
        public bool RemarkSpecify { get; set; }
        /// <summary>
        /// 获取或设置 成交备注 
        /// </summary>
        [DBFieldAttribute("OrderRecordRemark")]
        public string Remark { get { return remark; } set { remark = value; RemarkSpecify = true; } }


        private DateTime? updateDate = null;
        public bool UpdateDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 最后一次更新时间 
        /// </summary>
        [DBFieldAttribute("OrderRecordUpdateDate")]
        public DateTime? UpdateDate { get { return updateDate; } set { updateDate = value; UpdateDateSpecify = true; } }


        private DateTime? createdDate = null;
        public bool CreatedDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 成交时间 
        /// </summary>
        [DBFieldAttribute("OrderRecordCreatedDate")]
        public DateTime? CreatedDate { get { return createdDate; } set { createdDate = value; CreatedDateSpecify = true; } }


        public override string ToString()
        {
            return "";
        }

    }
}