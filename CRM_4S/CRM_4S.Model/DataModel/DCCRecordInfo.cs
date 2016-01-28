/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-01-27 16:54
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;

namespace CRM_4S.Model.DataModel
{
    public class DCCRecordInfo : DBModelBase
    {

        private int id = 0;
        public bool IdSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("DccRecordId")]
        public int Id { get { return id; } set { id = value; IdSpecify = true; } }


        private int customerId = 0;
        public bool CustomerIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 客户Id 
        /// </summary>
        [DBFieldAttribute("DccRecordCustomerId")]
        public int CustomerId { get { return customerId; } set { customerId = value; CustomerIdSpecify = true; } }


        private int shopId = 0;
        public bool ShopIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 店面Id 
        /// </summary>
        [DBFieldAttribute("DccRecordShopId")]
        public int ShopId { get { return shopId; } set { shopId = value; ShopIdSpecify = true; } }


        private int? dCCRecallerId = null;
        public bool DCCRecallerIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 DCC专员Id 
        /// </summary>
        [DBFieldAttribute("DccRecordDCCRecallerId")]
        public int? DCCRecallerId { get { return dCCRecallerId; } set { dCCRecallerId = value; DCCRecallerIdSpecify = true; } }


        private DateTime? visitTime = null;
        public bool VisitTimeSpecify { get; set; }
        /// <summary>
        /// 获取或设置 DCC留言时间 
        /// </summary>
        [DBFieldAttribute("DccRecordVisitTime")]
        public DateTime? VisitTime { get { return visitTime; } set { visitTime = value; VisitTimeSpecify = true; } }


        private string durationTime = string.Empty;
        public bool DurationTimeSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("DccRecordDurationTime")]
        public string DurationTime { get { return durationTime; } set { durationTime = value; DurationTimeSpecify = true; } }


        private DateTime? recallTime = null;
        public bool RecallTimeSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("DccRecordRecallTime")]
        public DateTime? RecallTime { get { return recallTime; } set { recallTime = value; RecallTimeSpecify = true; } }


        private int? purposeCar = null;
        public bool PurposeCarSpecify { get; set; }
        /// <summary>
        /// 获取或设置 意向车型 
        /// </summary>
        [DBFieldAttribute("DccRecordPurposeCar")]
        public int? PurposeCar { get { return purposeCar; } set { purposeCar = value; PurposeCarSpecify = true; } }


        private int? source = null;
        public bool SourceSpecify { get; set; }
        /// <summary>
        /// 获取或设置 线索来源 
        /// </summary>
        [DBFieldAttribute("DccRecordSource")]
        public int? Source { get { return source; } set { source = value; SourceSpecify = true; } }


        private int? status = null;
        public bool StatusSpecify { get; set; }
        /// <summary>
        /// 获取或设置 DCC状态：有效；无效；重复 
        /// </summary>
        [DBFieldAttribute("DccRecordStatus")]
        public int? Status { get { return status; } set { status = value; StatusSpecify = true; } }


        private int? promiseShop = null;
        public bool PromiseShopSpecify { get; set; }
        /// <summary>
        /// 获取或设置 承诺到店：是；否；还需要跟进 
        /// </summary>
        [DBFieldAttribute("DccRecordPromiseShop")]
        public int? PromiseShop { get { return promiseShop; } set { promiseShop = value; PromiseShopSpecify = true; } }


        private int? isLogin = null;
        public bool IsLoginSpecify { get; set; }
        /// <summary>
        /// 获取或设置 是否登录 
        /// </summary>
        [DBFieldAttribute("DccRecordIsLogin")]
        public int? IsLogin { get { return isLogin; } set { isLogin = value; IsLoginSpecify = true; } }


        private string recallDesc = string.Empty;
        public bool RecallDescSpecify { get; set; }
        /// <summary>
        /// 获取或设置 回访详情记录 
        /// </summary>
        [DBFieldAttribute("DccRecordRecallDesc")]
        public string RecallDesc { get { return recallDesc; } set { recallDesc = value; RecallDescSpecify = true; } }


        private DateTime? toShopTime = null;
        public bool ToShopTimeSpecify { get; set; }
        /// <summary>
        /// 获取或设置 预约到店时间 
        /// </summary>
        [DBFieldAttribute("DccRecordToShopTime")]
        public DateTime? ToShopTime { get { return toShopTime; } set { toShopTime = value; ToShopTimeSpecify = true; } }


        private int? operatorId = null;
        public bool OperatorIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("DccRecordOperatorId")]
        public int? OperatorId { get { return operatorId; } set { operatorId = value; OperatorIdSpecify = true; } }


        private DateTime? updateDate = null;
        public bool UpdateDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("DccRecordUpdateDate")]
        public DateTime? UpdateDate { get { return updateDate; } set { updateDate = value; UpdateDateSpecify = true; } }


        private DateTime? createdDate = null;
        public bool CreatedDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 创建时间 
        /// </summary>
        [DBFieldAttribute("DccRecordCreatedDate")]
        public DateTime? CreatedDate { get { return createdDate; } set { createdDate = value; CreatedDateSpecify = true; } }


        public override string ToString()
        {
            return "";
        }

    }
}