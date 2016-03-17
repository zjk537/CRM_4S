/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-03-16 14:22
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;

namespace CRM_4S.Model.DataModel
{
    public class AnalyseKPIInfo : DBModelBase
    {

        private int id = 0;
        public bool IdSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("AnalyseKpiId")]
        public int Id { get { return id; } set { id = value; IdSpecify = true; } }


        private string name = string.Empty;
        public bool NameSpecify { get; set; }
        /// <summary>
        /// 获取或设置 指标名称 
        /// </summary>
        [DBFieldAttribute("AnalyseKpiName")]
        public string Name { get { return name; } set { name = value; NameSpecify = true; } }


        private int basicId = 0;
        public bool BasicIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 对应basic_constant.TypeKey = FrontKPI | DCCKPI 
        /// </summary>
        [DBFieldAttribute("AnalyseKpiBasicId")]
        public int BasicId { get { return basicId; } set { basicId = value; BasicIdSpecify = true; } }


        private int? kValue = null;
        public bool KValueSpecify { get; set; }
        /// <summary>
        /// 获取或设置 指标临界值 
        /// </summary>
        [DBFieldAttribute("AnalyseKpiKValue")]
        public int? KValue { get { return kValue; } set { kValue = value; KValueSpecify = true; } }


        private string kUnit = string.Empty;
        public bool KUnitSpecify { get; set; }
        /// <summary>
        /// 获取或设置 指标临界值单位 
        /// </summary>
        [DBFieldAttribute("AnalyseKpiKUnit")]
        public string KUnit { get { return kUnit; } set { kUnit = value; KUnitSpecify = true; } }


        private string perform = string.Empty;
        public bool PerformSpecify { get; set; }
        /// <summary>
        /// 获取或设置 主要表现 
        /// </summary>
        [DBFieldAttribute("AnalyseKpiPerform")]
        public string Perform { get { return perform; } set { perform = value; PerformSpecify = true; } }


        private string reason = string.Empty;
        public bool ReasonSpecify { get; set; }
        /// <summary>
        /// 获取或设置 主要原因 
        /// </summary>
        [DBFieldAttribute("AnalyseKpiReason")]
        public string Reason { get { return reason; } set { reason = value; ReasonSpecify = true; } }


        private string suggest = string.Empty;
        public bool SuggestSpecify { get; set; }
        /// <summary>
        /// 获取或设置 主要建议 
        /// </summary>
        [DBFieldAttribute("AnalyseKpiSuggest")]
        public string Suggest { get { return suggest; } set { suggest = value; SuggestSpecify = true; } }


        private string desc = string.Empty;
        public bool DescSpecify { get; set; }
        /// <summary>
        /// 获取或设置 备注 
        /// </summary>
        [DBFieldAttribute("AnalyseKpiDesc")]
        public string Desc { get { return desc; } set { desc = value; DescSpecify = true; } }


        private int operatorId = 0;
        public bool OperatorIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 最后一次操作人 
        /// </summary>
        [DBFieldAttribute("AnalyseKpiOperatorId")]
        public int OperatorId { get { return operatorId; } set { operatorId = value; OperatorIdSpecify = true; } }


        private DateTime? updateDate = null;
        public bool UpdateDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 最后一次更新时间 
        /// </summary>
        [DBFieldAttribute("AnalyseKpiUpdateDate")]
        public DateTime? UpdateDate { get { return updateDate; } set { updateDate = value; UpdateDateSpecify = true; } }


        private DateTime? createdDate = null;
        public bool CreatedDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 创建时间 
        /// </summary>
        [DBFieldAttribute("AnalyseKpiCreatedDate")]
        public DateTime? CreatedDate { get { return createdDate; } set { createdDate = value; CreatedDateSpecify = true; } }


        public override string ToString()
        {
            return "";
        }

    }
}