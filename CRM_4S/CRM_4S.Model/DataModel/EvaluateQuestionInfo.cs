/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-01-21 10:33
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;

namespace CRM_4S.Model.DataModel
{
    public class EvaluateQuestionInfo : DBModelBase
    {

        private int id = 0;
        public bool IdSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("EvaluateQuestionId")]
        public int Id { get { return id; } set { id = value; IdSpecify = true; } }


        private string qDesc = string.Empty;
        public bool QDescSpecify { get; set; }
        /// <summary>
        /// 获取或设置 顾客评估问题描述 
        /// </summary>
        [DBFieldAttribute("EvaluateQuestionQDesc")]
        public string QDesc { get { return qDesc; } set { qDesc = value; QDescSpecify = true; } }


        private int? qType = null;
        public bool QTypeSpecify { get; set; }
        /// <summary>
        /// 获取或设置 问题类型：1、店面；2、DCC 3：all
        /// </summary>
        [DBFieldAttribute("EvaluateQuestionQType")]
        public int? QType { get { return qType; } set { qType = value; QTypeSpecify = true; } }


        private int? qLevel = null;
        public bool QLevelSpecify { get; set; }
        /// <summary>
        /// 获取或设置 问题权重 
        /// </summary>
        [DBFieldAttribute("EvaluateQuestionQLevel")]
        public int? QLevel { get { return qLevel; } set { qLevel = value; QLevelSpecify = true; } }


        private DateTime? updateDate = null;
        public bool UpdateDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 最后一次更新时间 
        /// </summary>
        [DBFieldAttribute("EvaluateQuestionUpdateDate")]
        public DateTime? UpdateDate { get { return updateDate; } set { updateDate = value; UpdateDateSpecify = true; } }


        private DateTime? createdDate = null;
        public bool CreatedDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 创建时间 
        /// </summary>
        [DBFieldAttribute("EvaluateQuestionCreatedDate")]
        public DateTime? CreatedDate { get { return createdDate; } set { createdDate = value; CreatedDateSpecify = true; } }


        public override string ToString()
        {
            return this.QDesc;
        }

    }
}