using CRM_4S.Business.Model;
using RibbonSkin.Common.FormBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRM_4S.UserManager
{
    public partial class FmUserInfo : FormSimpleDialogBase
    {
        public FmUserInfo()
        {
            InitializeComponent();
        }
        public FmUserInfo(UserShopRoleInfo userShopRoleInfo = null)
        {
            InitializeComponent();
        }

        private void initForm(){

        }
    }
}
