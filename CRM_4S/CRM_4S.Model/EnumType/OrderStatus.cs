using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Model.EnumType
{
    /// <summary>
    /// 订单状态
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// 预付订金
        /// </summary>
        PrePay = 1,
        /// <summary>
        /// 交易完成
        /// </summary>
        Finish = 2,
        /// <summary>
        /// 订单取消
        /// </summary>
        Cancel = 3
    }
}
