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


        private DateTime? startDate = null;
        public bool StartDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 任务开始时间 
        /// </summary>
        [DBFieldAttribute("UserTaskStartDate")]
        public DateTime? StartDate { get { return startDate; } set { startDate = value; StartDateSpecify = true; } }


        private DateTime? enddate = null;
        public bool EnddateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 任务结束时间 
        /// </summary>
        [DBFieldAttribute("UserTaskEnddate")]
        public DateTime? Enddate { get { return enddate; } set { enddate = value; EnddateSpecify = true; } }


        private int? carType = null;
        public bool CarTypeSpecify { get; set; }
        /// <summary>
        /// 获取或设置 汽车类型 
        /// </summary>
        [DBFieldAttribute("UserTaskCarType")]
        public int? CarType { get { return carType; } set { carType = value; CarTypeSpecify = true; } }


        private int? status = null;
        public bool StatusSpecify { get; set; }
        /// <summary>
        /// 获取或设置 完成状态：1 未完成 2 已完成 
        /// </summary>
        [DBFieldAttribute("UserTaskStatus")]
        public int? Status { get { return status; } set { status = value; StatusSpecify = true; } }


        private int? num = null;
        public bool NumSpecify { get; set; }
        /// <summary>
        /// 获取或设置 任务数量 
        /// </summary>
        [DBFieldAttribute("UserTaskNum")]
        public int? Num { get { return num; } set { num = value; NumSpecify = true; } }


        private int? finishNum = null;
        public bool FinishNumSpecify { get; set; }
        /// <summary>
        /// 获取或设置 已完成数量 
        /// </summary>
        [DBFieldAttribute("UserTaskFinishNum")]
        public int? FinishNum { get { return finishNum; } set { finishNum = value; FinishNumSpecify = true; } }


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