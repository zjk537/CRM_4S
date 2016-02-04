/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-02-04 14:13
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
        /// 获取或设置 回访间隔时间 
        /// </summary>
        [DBFieldAttribute("DccRecordDurationTime")]
        public string DurationTime { get { return durationTime; } set { durationTime = value; DurationTimeSpecify = true; } }


        private DateTime? recallTime = null;
        public bool RecallTimeSpecify { get; set; }
        /// <summary>
        /// 获取或设置 回访时间 
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


        private string levelCode = string.Empty;
        public bool LevelCodeSpecify { get; set; }
        /// <summary>
        /// 获取或设置 意向级别 
        /// </summary>
        [DBFieldAttribute("DccRecordLevelCode")]
        public string LevelCode { get { return levelCode; } set { levelCode = value; LevelCodeSpecify = true; } }


        private int? source = null;
        public bool SourceSpecify { get; set; }
        /// <summary>
        /// 获取或设置 线索来源：对应 basic_constant.TypeKey = DCCSource 
        /// </summary>
        [DBFieldAttribute("DccRecordSource")]
        public int? Source { get { return source; } set { source = value; SourceSpecify = true; } }


        private int? status = null;
        public bool StatusSpecify { get; set; }
        /// <summary>
        /// 获取或设置 DCC状态：对应 basic_constant.TypeKey = DCCStatus 
        /// </summary>
        [DBFieldAttribute("DccRecordStatus")]
        public int? Status { get { return status; } set { status = value; StatusSpecify = true; } }


        private int? toShop = null;
        public bool ToShopSpecify { get; set; }
        /// <summary>
        /// 获取或设置 承诺到店：1:是；2:否 
        /// </summary>
        [DBFieldAttribute("DccRecordToShop")]
        public int? ToShop { get { return toShop; } set { toShop = value; ToShopSpecify = true; } }


        private DateTime? toShopTime = null;
        public bool ToShopTimeSpecify { get; set; }
        /// <summary>
        /// 获取或设置 预约到店时间 
        /// </summary>
        [DBFieldAttribute("DccRecordToShopTime")]
        public DateTime? ToShopTime { get { return toShopTime; } set { toShopTime = value; ToShopTimeSpecify = true; } }


        private int? installment = null;
        public bool InstallmentSpecify { get; set; }
        /// <summary>
        /// 获取或设置 是否分期还款 1 是； 2 否 
        /// </summary>
        [DBFieldAttribute("DccRecordInstallment")]
        public int? Installment { get { return installment; } set { installment = value; InstallmentSpecify = true; } }


        private string recallDesc = string.Empty;
        public bool RecallDescSpecify { get; set; }
        /// <summary>
        /// 获取或设置 回访详情记录 
        /// </summary>
        [DBFieldAttribute("DccRecordRecallDesc")]
        public string RecallDesc { get { return recallDesc; } set { recallDesc = value; RecallDescSpecify = true; } }


        private string recorder = string.Empty;
        public bool RecorderSpecify { get; set; }
        /// <summary>
        /// 获取或设置 录入人员 
        /// </summary>
        [DBFieldAttribute("DccRecordRecorder")]
        public string Recorder { get { return recorder; } set { recorder = value; RecorderSpecify = true; } }


        private DateTime? updateDate = null;
        public bool UpdateDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 最后一次更新时间 
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