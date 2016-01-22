/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-01-20 14:49
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;

namespace CRM_4S.Model.DataModel
{
    public class CarTypeInfo : DBModelBase
    {

        private int id = 0;
        public bool IdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 汽车类型Id  
        /// </summary>
        [DBFieldAttribute("CarTypeId")]
        public int Id { get { return id; } set { id = value; IdSpecify = true; } }


        private string brand = "";
        public bool BrandSpecify { get; set; }
        /// <summary>
        /// 获取或设置 汽车品牌 
        /// </summary>
        [DBFieldAttribute("CarTypeBrand")]
        public string Brand { get { return brand; } set { brand = value; BrandSpecify = true; } }


        private string name = string.Empty;
        public bool NameSpecify { get; set; }
        /// <summary>
        /// 获取或设置 汽车类型名称 
        /// </summary>
        [DBFieldAttribute("CarTypeName")]
        public string Name { get { return name; } set { name = value; NameSpecify = true; } }


        private string desc = string.Empty;
        public bool DescSpecify { get; set; }
        /// <summary>
        /// 获取或设置 汽车类型描述 
        /// </summary>
        [DBFieldAttribute("CarTypeDesc")]
        public string Desc { get { return desc; } set { desc = value; DescSpecify = true; } }


        private DateTime? updateDate = null;
        public bool UpdateDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("CarTypeUpdateDate")]
        public DateTime? UpdateDate { get { return updateDate; } set { updateDate = value; UpdateDateSpecify = true; } }


        private DateTime? createdDate = null;
        public bool CreatedDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 创建时间 
        /// </summary>
        [DBFieldAttribute("CarTypeCreatedDate")]
        public DateTime? CreatedDate { get { return createdDate; } set { createdDate = value; CreatedDateSpecify = true; } }


        public override string ToString()
        {
            return this.Brand + " "+ this.Name;
        }

    }
}