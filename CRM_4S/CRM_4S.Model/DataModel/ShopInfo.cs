/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-01-19 16:36
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;

namespace CRM_4S.Model.DataModel
{
    public class ShopInfo : DBModelBase
    {

        private int id = 0;
        public bool IdSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("ShopId")]
        public int Id { get { return id; } set { id = value; IdSpecify = true; } }


        private string name = string.Empty;
        public bool NameSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("ShopName")]
        public string Name { get { return name; } set { name = value; NameSpecify = true; } }


        private string phone = string.Empty;
        public bool PhoneSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("ShopPhone")]
        public string Phone { get { return phone; } set { phone = value; PhoneSpecify = true; } }


        private string address = string.Empty;
        public bool AddressSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("ShopAddress")]
        public string Address { get { return address; } set { address = value; AddressSpecify = true; } }


        private string desc = string.Empty;
        public bool DescSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("ShopDesc")]
        public string Desc { get { return desc; } set { desc = value; DescSpecify = true; } }


        private DateTime? updateDate = null;
        public bool UpdateDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("ShopUpdateDate")]
        public DateTime? UpdateDate { get { return updateDate; } set { updateDate = value; UpdateDateSpecify = true; } }


        private DateTime? createdDate = null;
        public bool CreatedDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 创建时间 
        /// </summary>
        [DBFieldAttribute("ShopCreatedDate")]
        public DateTime? CreatedDate { get { return createdDate; } set { createdDate = value; CreatedDateSpecify = true; } }
        
        

        public override string ToString()
        {
            return this.Name;
        }

    }
}