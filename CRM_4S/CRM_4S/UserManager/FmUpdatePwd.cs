using CRM_4S.Business;
using CRM_4S.Common;
using CRM_4S.Common.FormBase;
using CRM_4S.Model.DataModel;
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
    public partial class FmUpdatePwd : FormSimpleDialogBase
    {
        public FmUpdatePwd()
        {
            InitializeComponent();

            this.Btn_OK.Click += Btn_OK_Click;
        }


        void Btn_OK_Click(object sender, EventArgs e)
        {
            if (!Validation()) return;
            string newMd5Pwd = EncryptHelper.MD5(this.txtNewPwd.Text.Trim());
            UserBusiness.Instance.UpdateUser(new UserInfo() { Id = GlobalCaches.Instance.CurUser.Id, Pwd = newMd5Pwd });
            GlobalCaches.Instance.CurUser.Pwd = newMd5Pwd;
        }


        private bool Validation()
        {
            errorProvider.ClearErrors();
            if (string.IsNullOrEmpty(this.txtOldPwd.Text.Trim()))
            {
                errorProvider.SetError(this.txtOldPwd, "不能为空");
            }
            else
            {
                string md5Pwd = EncryptHelper.MD5(this.txtOldPwd.Text.Trim());
                if (GlobalCaches.Instance.CurUser.Pwd != md5Pwd)
                {
                    errorProvider.SetError(this.txtOldPwd, "原始密码错误");
                }
            }
            if (string.IsNullOrEmpty(this.txtNewPwd.Text.Trim()))
            {
                errorProvider.SetError(this.txtNewPwd, "不能为空");
            }
            else
            {
                if (this.txtNewPwd.Text.Trim() != this.txtNewPwd2.Text.Trim())
                {
                    errorProvider.SetError(this.txtNewPwd2, "两次输入的密码不一致");
                }
            }

            return !errorProvider.HasErrors;
        }
    }
}
