using CRM_4S.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business.ViewModel
{
    public class ViewQueryInfo : DBModelBase
    {
        private int shopId = 0;
        public bool ShopIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 店面Id
        /// </summary>
        [DBFieldAttribute("ShopId")]
        public int ShopId { get { return shopId; } set { shopId = value; ShopIdSpecify = true; } }

        private int customerId = 0;
        public bool CustomerIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 客户Id
        /// </summary>
        [DBFieldAttribute("CustomerId")]
        public int CustomerId { get { return customerId; } set { customerId = value; CustomerIdSpecify = true; } }

        private int recordId = 0;
        public bool RecordIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 记录Id
        /// </summary>
        [DBFieldAttribute("RecordId")]
        public int RecordId { get { return recordId; } set { recordId = value; RecordIdSpecify = true; } }


        private DateTime? startDate = null;
        public bool StartDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 起始时间
        /// </summary>
        [DBFieldAttribute("StartDate")]
        public DateTime? StartDate { get { return startDate; } set { startDate = value; StartDateSpecify = true; } }

        private DateTime? endDate = null;
        public bool EndDateSpecify { get; set; }

        /// <summary>
        /// 获取或设置 结束时间
        /// </summary>
        [DBFieldAttribute("EndDate")]
        public DateTime? EndDate { get { return endDate; } set { endDate = value; EndDateSpecify = true; } }

        public QueryDateRange DateRange { get; set; }
    }

    public enum QueryDateRange
    {
        ThisMonth,
        ThisQuarter,
        ThisYear,
        Customer
    }
}
