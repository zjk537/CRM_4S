/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-02-03 12:26
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;

namespace CRM_4S.Model.DataModel
{
    public class CustomerInfo : DBModelBase
    {

        private int id = 0;
        public bool IdSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("CustomerId")]
        public int Id { get { return id; } set { id = value; IdSpecify = true; } }


        private int shopId = 0;
        public bool ShopIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 店面Id 
        /// </summary>
        [DBFieldAttribute("CustomerShopId")]
        public int ShopId { get { return shopId; } set { shopId = value; ShopIdSpecify = true; } }


        private string name = string.Empty;
        public bool NameSpecify { get; set; }
        /// <summary>
        /// 获取或设置 客户名称 
        /// </summary>
        [DBFieldAttribute("CustomerName")]
        public string Name { get { return name; } set { name = value; NameSpecify = true; } }


        private string phone = string.Empty;
        public bool PhoneSpecify { get; set; }
        /// <summary>
        /// 获取或设置 客户联系方式 
        /// </summary>
        [DBFieldAttribute("CustomerPhone")]
        public string Phone { get { return phone; } set { phone = value; PhoneSpecify = true; } }


        private string curCar = string.Empty;
        public bool CurCarSpecify { get; set; }
        /// <summary>
        /// 获取或设置 现有车型 
        /// </summary>
        [DBFieldAttribute("CustomerCurCar")]
        public string CurCar { get { return curCar; } set { curCar = value; CurCarSpecify = true; } }


        private int? nature = null;
        public bool NatureSpecify { get; set; }
        /// <summary>
        /// 获取或设置 客户性质：对应 basic_constant.TypeKey = CNature 
        /// </summary>
        [DBFieldAttribute("CustomerNature")]
        public int? Nature { get { return nature; } set { nature = value; NatureSpecify = true; } }


        private int? originNature = null;
        public bool OriginNatureSpecify { get; set; }
        /// <summary>
        /// 获取或设置 原始客户性质 
        /// </summary>
        [DBFieldAttribute("CustomerOriginNature")]
        public int? OriginNature { get { return originNature; } set { originNature = value; OriginNatureSpecify = true; } }


        private int? type = null;
        public bool TypeSpecify { get; set; }
        /// <summary>
        /// 获取或设置 客户类型：前台客户 DCC客户 
        /// </summary>
        [DBFieldAttribute("CustomerType")]
        public int? Type { get { return type; } set { type = value; TypeSpecify = true; } }


        private string industry = string.Empty;
        public bool IndustrySpecify { get; set; }
        /// <summary>
        /// 获取或设置 行业 
        /// </summary>
        [DBFieldAttribute("CustomerIndustry")]
        public string Industry { get { return industry; } set { industry = value; IndustrySpecify = true; } }


        private int? regionId = null;
        public bool RegionIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 所在区域Id 
        /// </summary>
        [DBFieldAttribute("CustomerRegionId")]
        public int? RegionId { get { return regionId; } set { regionId = value; RegionIdSpecify = true; } }


        private string address = string.Empty;
        public bool AddressSpecify { get; set; }
        /// <summary>
        /// 获取或设置 居住地址 
        /// </summary>
        [DBFieldAttribute("CustomerAddress")]
        public string Address { get { return address; } set { address = value; AddressSpecify = true; } }


        private DateTime? updateDate = null;
        public bool UpdateDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 最后一次更新时间 
        /// </summary>
        [DBFieldAttribute("CustomerUpdateDate")]
        public DateTime? UpdateDate { get { return updateDate; } set { updateDate = value; UpdateDateSpecify = true; } }


        private DateTime? createdDate = null;
        public bool CreatedDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 创建时间 
        /// </summary>
        [DBFieldAttribute("CustomerCreatedDate")]
        public DateTime? CreatedDate { get { return createdDate; } set { createdDate = value; CreatedDateSpecify = true; } }


        public override string ToString()
        {
            return this.Name;
        }

    }
}