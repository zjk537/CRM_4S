/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-02-02 10:07
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;

namespace CRM_4S.Model.DataModel
{
    public class RegionInfo : DBModelBase
    {

        private int id = 0;
        public bool IdSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("RegionId")]
        public int Id { get { return id; } set { id = value; IdSpecify = true; } }


        private int shopId = 0;
        public bool ShopIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 店面Id 
        /// </summary>
        [DBFieldAttribute("RegionShopId")]
        public int ShopId { get { return shopId; } set { shopId = value; ShopIdSpecify = true; } }


        private string province = string.Empty;
        public bool ProvinceSpecify { get; set; }
        /// <summary>
        /// 获取或设置 省 
        /// </summary>
        [DBFieldAttribute("RegionProvince")]
        public string Province { get { return province; } set { province = value; ProvinceSpecify = true; } }


        private string city = string.Empty;
        public bool CitySpecify { get; set; }
        /// <summary>
        /// 获取或设置 市 
        /// </summary>
        [DBFieldAttribute("RegionCity")]
        public string City { get { return city; } set { city = value; CitySpecify = true; } }


        private string region = string.Empty;
        public bool RegionSpecify { get; set; }
        /// <summary>
        /// 获取或设置 县/区 
        /// </summary>
        [DBFieldAttribute("RegionRegion")]
        public string Region { get { return region; } set { region = value; RegionSpecify = true; } }


        private DateTime? updateDate = null;
        public bool UpdateDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 最后一次更新时间 
        /// </summary>
        [DBFieldAttribute("RegionUpdateDate")]
        public DateTime? UpdateDate { get { return updateDate; } set { updateDate = value; UpdateDateSpecify = true; } }


        private DateTime? createdDate = null;
        public bool CreatedDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 创建时间 
        /// </summary>
        [DBFieldAttribute("RegionCreatedDate")]
        public DateTime? CreatedDate { get { return createdDate; } set { createdDate = value; CreatedDateSpecify = true; } }


        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.Province, this.City, this.Region).Trim();
        }

    }
}