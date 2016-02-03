/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-02-03 12:34
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;

namespace CRM_4S.Model.DataModel
{
    public class PurposeLevelInfo : DBModelBase
    {

        private int id = 0;
        public bool IdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 意向级别Id 
        /// </summary>
        [DBFieldAttribute("PurposeLevelId")]
        public int Id { get { return id; } set { id = value; IdSpecify = true; } }


        private string code = string.Empty;
        public bool CodeSpecify { get; set; }
        /// <summary>
        /// 获取或设置 意向级别代码 
        /// </summary>
        [DBFieldAttribute("PurposeLevelCode")]
        public string Code { get { return code; } set { code = value; CodeSpecify = true; } }


        private string desc = string.Empty;
        public bool DescSpecify { get; set; }
        /// <summary>
        /// 获取或设置 意向级别描述 
        /// </summary>
        [DBFieldAttribute("PurposeLevelDesc")]
        public string Desc { get { return desc; } set { desc = value; DescSpecify = true; } }


        private DateTime? updateDate = null;
        public bool UpdateDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 最后一次更新时间 
        /// </summary>
        [DBFieldAttribute("PurposeLevelUpdateDate")]
        public DateTime? UpdateDate { get { return updateDate; } set { updateDate = value; UpdateDateSpecify = true; } }


        private DateTime? createdDate = null;
        public bool CreatedDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 创建时间 
        /// </summary>
        [DBFieldAttribute("PurposeLevelCreatedDate")]
        public DateTime? CreatedDate { get { return createdDate; } set { createdDate = value; CreatedDateSpecify = true; } }


        public override string ToString()
        {
            return this.Code;
        }

    }
}