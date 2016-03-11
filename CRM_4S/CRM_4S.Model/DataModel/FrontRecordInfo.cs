/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-03-10 16:23
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;

namespace CRM_4S.Model.DataModel
{
    public class FrontRecordInfo : DBModelBase
    {

        private int id = 0;
        public bool IdSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("FrontRecordId")]
        public int Id { get { return id; } set { id = value; IdSpecify = true; } }


        private int customerId = 0;
        public bool CustomerIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 客户Id 
        /// </summary>
        [DBFieldAttribute("FrontRecordCustomerId")]
        public int CustomerId { get { return customerId; } set { customerId = value; CustomerIdSpecify = true; } }


        private int shopId = 0;
        public bool ShopIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 店面Id 
        /// </summary>
        [DBFieldAttribute("FrontRecordShopId")]
        public int ShopId { get { return shopId; } set { shopId = value; ShopIdSpecify = true; } }


        private int consultantId = 0;
        public bool ConsultantIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 销售顾问Id 
        /// </summary>
        [DBFieldAttribute("FrontRecordConsultantId")]
        public int ConsultantId { get { return consultantId; } set { consultantId = value; ConsultantIdSpecify = true; } }


        private int customerNum = 0;
        public bool CustomerNumSpecify { get; set; }
        /// <summary>
        /// 获取或设置 接待人数 
        /// </summary>
        [DBFieldAttribute("FrontRecordCustomerNum")]
        public int CustomerNum { get { return customerNum; } set { customerNum = value; CustomerNumSpecify = true; } }


        private int? carLicence = null;
        public bool CarLicenceSpecify { get; set; }
        /// <summary>
        /// 获取或设置 牌照状况：对应 basic_constant.TypeKey = CarLicence 
        /// </summary>
        [DBFieldAttribute("FrontRecordCarLicence")]
        public int? CarLicence { get { return carLicence; } set { carLicence = value; CarLicenceSpecify = true; } }


        private int? purposeCar = null;
        public bool PurposeCarSpecify { get; set; }
        /// <summary>
        /// 获取或设置 意向车型 
        /// </summary>
        [DBFieldAttribute("FrontRecordPurposeCar")]
        public int? PurposeCar { get { return purposeCar; } set { purposeCar = value; PurposeCarSpecify = true; } }


        private string levelCode = string.Empty;
        public bool LevelCodeSpecify { get; set; }
        /// <summary>
        /// 获取或设置 意向级别 
        /// </summary>
        [DBFieldAttribute("FrontRecordLevelCode")]
        public string LevelCode { get { return levelCode; } set { levelCode = value; LevelCodeSpecify = true; } }


        private int? toShopNum = null;
        public bool ToShopNumSpecify { get; set; }
        /// <summary>
        /// 获取或设置 到店次数 
        /// </summary>
        [DBFieldAttribute("FrontRecordToShopNum")]
        public int? ToShopNum { get { return toShopNum; } set { toShopNum = value; ToShopNumSpecify = true; } }


        private int? phoneStatus = null;
        public bool PhoneStatusSpecify { get; set; }
        /// <summary>
        /// 获取或设置 是否留下有手机号 1是 2 否 
        /// </summary>
        [DBFieldAttribute("FrontRecordPhoneStatus")]
        public int? PhoneStatus { get { return phoneStatus; } set { phoneStatus = value; PhoneStatusSpecify = true; } }


        private int? driveStatus = null;
        public bool DriveStatusSpecify { get; set; }
        /// <summary>
        /// 获取或设置 试驾状态：1是 2否 
        /// </summary>
        [DBFieldAttribute("FrontRecordDriveStatus")]
        public int? DriveStatus { get { return driveStatus; } set { driveStatus = value; DriveStatusSpecify = true; } }


        private int? source = null;
        public bool SourceSpecify { get; set; }
        /// <summary>
        /// 获取或设置 客户来源 
        /// </summary>
        [DBFieldAttribute("FrontRecordSource")]
        public int? Source { get { return source; } set { source = value; SourceSpecify = true; } }


        private int? replace = null;
        public bool ReplaceSpecify { get; set; }
        /// <summary>
        /// 获取或设置 是否二手置换 1是2否 
        /// </summary>
        [DBFieldAttribute("FrontRecordReplace")]
        public int? Replace { get { return replace; } set { replace = value; ReplaceSpecify = true; } }


        private int? installment = null;
        public bool InstallmentSpecify { get; set; }
        /// <summary>
        /// 获取或设置 是否分期付款 1是 2 否 
        /// </summary>
        [DBFieldAttribute("FrontRecordInstallment")]
        public int? Installment { get { return installment; } set { installment = value; InstallmentSpecify = true; } }


        private string remark = string.Empty;
        public bool RemarkSpecify { get; set; }
        /// <summary>
        /// 获取或设置 备注 
        /// </summary>
        [DBFieldAttribute("FrontRecordRemark")]
        public string Remark { get { return remark; } set { remark = value; RemarkSpecify = true; } }


        private DateTime? arrivalTime = null;
        public bool ArrivalTimeSpecify { get; set; }
        /// <summary>
        /// 获取或设置 到店时间 
        /// </summary>
        [DBFieldAttribute("FrontRecordArrivalTime")]
        public DateTime? ArrivalTime { get { return arrivalTime; } set { arrivalTime = value; ArrivalTimeSpecify = true; } }


        private DateTime? leaveTime = null;
        public bool LeaveTimeSpecify { get; set; }
        /// <summary>
        /// 获取或设置 离开时间 
        /// </summary>
        [DBFieldAttribute("FrontRecordLeaveTime")]
        public DateTime? LeaveTime { get { return leaveTime; } set { leaveTime = value; LeaveTimeSpecify = true; } }


        private string durationTime = string.Empty;
        public bool DurationTimeSpecify { get; set; }
        /// <summary>
        /// 获取或设置 接待时长 
        /// </summary>
        [DBFieldAttribute("FrontRecordDurationTime")]
        public string DurationTime { get { return durationTime; } set { durationTime = value; DurationTimeSpecify = true; } }


        private string recorder = string.Empty;
        public bool RecorderSpecify { get; set; }
        /// <summary>
        /// 获取或设置 录入人员 姓名 
        /// </summary>
        [DBFieldAttribute("FrontRecordRecorder")]
        public string Recorder { get { return recorder; } set { recorder = value; RecorderSpecify = true; } }


        private DateTime? updateDate = null;
        public bool UpdateDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 最后一次更新时间 
        /// </summary>
        [DBFieldAttribute("FrontRecordUpdateDate")]
        public DateTime? UpdateDate { get { return updateDate; } set { updateDate = value; UpdateDateSpecify = true; } }


        private DateTime? createdDate = null;
        public bool CreatedDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 创建时间 
        /// </summary>
        [DBFieldAttribute("FrontRecordCreatedDate")]
        public DateTime? CreatedDate { get { return createdDate; } set { createdDate = value; CreatedDateSpecify = true; } }


        public override string ToString()
        {
            return "";
        }

    }
}