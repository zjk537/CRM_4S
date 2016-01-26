/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-01-21 16:49
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;

namespace CRM_4S.Model.DataModel
{
    public class UserTaskInfo : DBModelBase
    {

        private int id = 0;
        public bool IdSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("UserTaskId")]
        public int Id { get { return id; } set { id = value; IdSpecify = true; } }

        private int consultantId = 0;
        public bool ConsultantIdSpecify { get; set; }

        /// <summary>
        /// 获取或设置 销售顾问Id 
        /// </summary>
        [DBFieldAttribute("UserTaskConsultantId")]
        public int ConsultantId { get { return consultantId; } set { consultantId = value; ConsultantIdSpecify = true; } }


        private string consultantName;
        public bool ConsultantNameSpecify { get; set; }

        /// <summary>
        /// 获取或设置 销售顾问名字 
        /// </summary>
        [DBFieldAttribute("UserTaskConsultantName")]
        public string ConsultantName { get { return consultantName; } set { consultantName = value; ConsultantNameSpecify = true;} }


        private DateTime? startDate = null;
        public bool StartDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 任务开始时间 
        /// </summary>
        [DBFieldAttribute("UserTaskStartDate")]
        public DateTime? StartDate { get { return startDate; } set { startDate = value; StartDateSpecify = true; } }


        private DateTime? endDate = null;
        public bool EndDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 任务结束时间 
        /// </summary>
        [DBFieldAttribute("UserTaskEndDate")]
        public DateTime? EndDate { get { return endDate; } set { endDate = value; EndDateSpecify = true; } }


        private int? carTypeId = null;
        public bool CarTypeIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 汽车类型Id 
        /// </summary>
        [DBFieldAttribute("UserTaskCarTypeId")]
        public int? CarTypeId { get { return carTypeId; } set { carTypeId = value; CarTypeIdSpecify = true; } }


        private int? status = null;
        public bool StatusSpecify { get; set; }
        /// <summary>
        /// 获取或设置 完成状态：1 未完成 2 已完成 
        /// </summary>
        [DBFieldAttribute("UserTaskStatus")]
        public int? Status { get { return status; } set { status = value; StatusSpecify = true; } }


        private int? cnt = null;
        public bool CntSpecify { get; set; }
        /// <summary>
        /// 获取或设置 任务数量 
        /// </summary>
        [DBFieldAttribute("UserTaskCnt")]
        public int? Cnt { get { return cnt; } set { cnt = value; CntSpecify = true; } }


        private int? finishCnt = null;
        public bool FinishCntSpecify { get; set; }
        /// <summary>
        /// 获取或设置 已完成数量 
        /// </summary>
        [DBFieldAttribute("UserTaskFinishCnt")]
        public int? FinishCnt { get { return finishCnt; } set { finishCnt = value; FinishCntSpecify = true; } }


        private string desc = string.Empty;
        public bool DescSpecify { get; set; }
        /// <summary>
        /// 获取或设置 任务描述 
        /// </summary>
        [DBFieldAttribute("UserTaskDesc")]
        public string Desc { get { return desc; } set { desc = value; DescSpecify = true; } }


        private int? operatorId = null;
        public bool OperatorIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 安排任务者 
        /// </summary>
        [DBFieldAttribute("UserTaskOperatorId")]
        public int? OperatorId { get { return operatorId; } set { operatorId = value; OperatorIdSpecify = true; } }


        private DateTime? updateDate = null;
        public bool UpdateDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 最后一次更新时间 
        /// </summary>
        [DBFieldAttribute("UserTaskUpdateDate")]
        public DateTime? UpdateDate { get { return updateDate; } set { updateDate = value; UpdateDateSpecify = true; } }


        private DateTime? createdDate = null;
        public bool CreatedDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 创建时间 
        /// </summary>
        [DBFieldAttribute("UserTaskCreatedDate")]
        public DateTime? CreatedDate { get { return createdDate; } set { createdDate = value; CreatedDateSpecify = true; } }


        public override string ToString()
        {
            return "";
        }

    }
}