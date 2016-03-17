/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-03-16 15:58
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Model.DataModel
{
    public class FrontKPIInfo : DBModelBase
    {
        /// <summary>
        /// 获取或设置 首次接待量 = 所有首次进店接待客户数
        /// </summary>
        [DBFieldAttribute("scjd")]
        public float Scjd { get; set; }

        /// <summary>
        /// 获取或设置 首次进店有效客户数
        /// </summary>
        [DBFieldAttribute("scyx")]
        public float Scyx { get; set; }

        /// <summary>
        /// 获取或设置 二次进店有效客户数
        /// </summary>
        [DBFieldAttribute("ecyx")]
        public float Ecyx { get; set; }

        /// <summary>
        /// 获取或设置 试乘试驾客户数
        /// </summary>
        [DBFieldAttribute("sjkh")]
        public float Sjkh { get; set; }

        /// <summary>
        /// 获取或设置 邀约进店量 (二次进店的客户数)
        /// </summary>
        [DBFieldAttribute("yyjd")]
        public float Yyjd { get; set; }

        /// <summary>
        /// 获取或设置 首次进店订交数
        /// </summary>
        [DBFieldAttribute("scdj")]
        public float Scdj { get; set; }

        /// <summary>
        /// 获取或设置 二次进店订交数
        /// </summary>
        [DBFieldAttribute("ecdj")]
        public float Ecdj { get; set; }

        /// <summary>
        /// 获取 首次有效率
        /// </summary>
        public float ScyxRate
        {
            get
            {
                if (this.Scjd > 0)
                    return (this.Scyx / this.Scjd) * 100;
                return 0.00f;
            }
        }

        /// <summary>
        /// 获取 试驾率 
        /// </summary>
        public float SjkhRate
        {
            get
            {
                if (this.Scyx > 0 || this.Ecyx > 0)
                    return (this.Sjkh / (this.Scyx + this.Ecyx)) * 100;
                return 0.00f;
            }
        }

        /// <summary>
        /// 获取 邀约到店率
        /// </summary>
        public float YyjdRate
        {
            get
            {
                if (this.Scyx > 0 || this.Ecyx > 0)
                    return (this.Yyjd / (this.Scyx + this.Ecyx)) * 100;
                return 0.00f;
            }
        }

        /// <summary>
        /// 获取 首次订交率
        /// </summary>
        public float ScdjRate
        {
            get
            {
                if (this.Scyx > 0)
                    return (this.Scdj / this.Scyx) * 100;
                return 0.00f;
            }
        }

        /// <summary>
        /// 获取 二次订交率
        /// </summary>
        public float EcdjRate
        {
            get
            {
                if (this.Ecyx > 0)
                    return (this.Ecdj / this.Ecyx) * 100;
                return 0.00f;
            }
        }

    }
}