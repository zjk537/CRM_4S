/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-01-27 11:16
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
        /// 获取或设置 牌照状况：已有牌照；待拍牌照；旧车退牌；郊区牌照；外省上牌 
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


        private int? driveStatus = null;
        public bool DriveStatusSpecify { get; set; }
        /// <summary>
        /// 获取或设置 试驾状态：0""; 1是; 2否; 
        /// </summary>
        [DBFieldAttribute("FrontRecordDriveStatus")]
        public int? DriveStatus { get { return driveStatus; } set { driveStatus = value; DriveStatusSpecify = true; } }


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


        private int operatorId = 0;
        public bool OperatorIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 录入人员Id 
        /// </summary>
        [DBFieldAttribute("FrontRecordOperatorId")]
        public int OperatorId { get { return operatorId; } set { operatorId = value; OperatorIdSpecify = true; } }


        private DateTime? updateDate = null;
        public bool UpdateDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("FrontRecordUpdateDate")]
        public DateTime? UpdateDate { get { return updateDate; } set { updateDate = value; UpdateDateSpecify = true; } }


        private DateTime? createdDate = null;
        public bool CreatedDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("FrontRecordCreatedDate")]
        public DateTime? CreatedDate { get { return createdDate; } set { createdDate = value; CreatedDateSpecify = true; } }


        public override string ToString()
        {
            return "";
        }

    }
}