using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Model.EnumType
{
    public enum UserStatus
    {
        /// <summary>
        /// 在职
        /// </summary>
        OnWork = 1,

        /// <summary>
        /// 离职
        /// </summary>
        OffWork = 2,

        /// <summary>
        /// 休假
        /// </summary>
        OnRest = 3
    }
}
