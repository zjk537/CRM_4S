using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRM_4S.Common
{
    class UICommon
    {
        const string errCaption = "错误";
        const string infoCaption = "提示";
        const string warningCaption = "警告";

        /// <summary>
        /// show delete warning
        /// </summary>
        /// <returns></returns>
        public static bool DeleteConfirm()
        {
            return XtraMessageBox.Show("确定要删除？", infoCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
