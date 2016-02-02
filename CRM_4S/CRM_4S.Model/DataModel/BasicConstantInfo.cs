/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-02-01 16:17
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;

namespace CRM_4S.Model.DataModel
{
    public class BasicConstantInfo : DBModelBase
    {

        private int id = 0;
        public bool IdSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("BasicConstantId")]
        public int Id { get { return id; } set { id = value; IdSpecify = true; } }


        private int shopId = 0;
        public bool ShopIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 店面Id 
        /// </summary>
        [DBFieldAttribute("BasicConstantShopId")]
        public int ShopId { get { return shopId; } set { shopId = value; ShopIdSpecify = true; } }


        private string name = string.Empty;
        public bool NameSpecify { get; set; }
        /// <summary>
        /// 获取或设置 基础数据描述 
        /// </summary>
        [DBFieldAttribute("BasicConstantName")]
        public string Name { get { return name; } set { name = value; NameSpecify = true; } }


        private int order = 0;
        public bool OrderSpecify { get; set; }
        /// <summary>
        /// 获取或设置 展示排序 
        /// </summary>
        [DBFieldAttribute("BasicConstantOrder")]
        public int Order { get { return order; } set { order = value; OrderSpecify = true; } }


        private string typeKey = string.Empty;
        public bool TypeKeySpecify { get; set; }
        /// <summary>
        /// 获取或设置 分类Key 
        /// </summary>
        [DBFieldAttribute("BasicConstantTypeKey")]
        public string TypeKey { get { return typeKey; } set { typeKey = value; TypeKeySpecify = true; } }


        private int typeValue = 0;
        public bool TypeValueSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("BasicConstantTypeValue")]
        public int TypeValue { get { return typeValue; } set { typeValue = value; TypeValueSpecify = true; } }


        private string remark = string.Empty;
        public bool RemarkSpecify { get; set; }
        /// <summary>
        /// 获取或设置 备注 
        /// </summary>
        [DBFieldAttribute("BasicConstantRemark")]
        public string Remark { get { return remark; } set { remark = value; RemarkSpecify = true; } }


        private DateTime? updateDate = null;
        public bool UpdateDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 最后一次更新时间 
        /// </summary>
        [DBFieldAttribute("BasicConstantUpdateDate")]
        public DateTime? UpdateDate { get { return updateDate; } set { updateDate = value; UpdateDateSpecify = true; } }


        private DateTime? createdDate = null;
        public bool CreatedDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 创建时间 
        /// </summary>
        [DBFieldAttribute("BasicConstantCreatedDate")]
        public DateTime? CreatedDate { get { return createdDate; } set { createdDate = value; CreatedDateSpecify = true; } }


        public override string ToString()
        {
            return this.Name;
        }

    }
}