using CRM_4S.Business;
using CRM_4S.Business.BusinessModel;
using CRM_4S.Common.FormBase;
using CRM_4S.Model;
using CRM_4S.Model.DataModel;
using CRM_4S.Model.EnumType;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
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
        UserShopRoleInfo userShopRoleInfo = null;

        UserShopRoleInfo newUserShopRoleInfo = new UserShopRoleInfo();

        private bool IsNew { get { return userShopRoleInfo == null; } }
        public FmUserInfo(UserShopRoleInfo info = null)
        {
            InitializeComponent();
            initForm(info);
        }

        private void initForm(UserShopRoleInfo info)
        {
            if (info != null)
            {
                UserInfo tmpUser = new UserInfo();
                DBModelBase.Clone<UserInfo>(info.User, ref tmpUser);
                newUserShopRoleInfo.User = tmpUser;

                userShopRoleInfo = info;
            }
            cbRole.Properties.Items.AddRange(GloablCaches.Instance.RoleInfos);
            cbShop.Properties.Items.AddRange(GloablCaches.Instance.ShopInfos);

            this.Text += IsNew ? "-����" : "-�޸�";
            this.Btn_OK.Click += Btn_OK_Click;

            if (IsNew)
                newUserShopRoleInfo.User = new UserInfo() { ShopId = GloablCaches.Instance.CurUser.ShopId };
            cbShop.DataBindings.Add("EditValue", newUserShopRoleInfo, "Shop");
            cbRole.DataBindings.Add("EditValue", newUserShopRoleInfo, "Role");

            var userInfo = newUserShopRoleInfo.User;
            rdSex.SelectedIndex = userInfo.Sex.HasValue ? userInfo.Sex.Value - 1 : -1;
            txtRealName.DataBindings.Add("Text", userInfo, "RealName");
            txtPhone.DataBindings.Add("Text", userInfo, "Phone");
            txtUserName.DataBindings.Add("Text", userInfo, "UserName");
            txtPwd.DataBindings.Add("Text", userInfo, "Pwd");

            // Ȩ��
            //cbShop.Enabled = cbRole.Enabled = GloablCaches.Instance.CurUser.RoleId == GloablConstants.RoleIdSysAdmin;
        }

        void Btn_OK_Click(object sender, EventArgs e)
        {
            if (!ValidatFail())
            {
                if (IsNew || newUserShopRoleInfo.User.Sex != (rdSex.SelectedIndex + 1))
                {
                    newUserShopRoleInfo.User.Sex = rdSex.SelectedIndex + 1;
                }

                if (!newUserShopRoleInfo.User.Equals(userShopRoleInfo == null ? null : userShopRoleInfo.User ?? null))
                {
                    if (!UserBusiness.Instance.ValidateUserName(newUserShopRoleInfo.User.Id, newUserShopRoleInfo.User.UserName))
                    {
                        errorProvider.SetError(this.txtUserName, "�û����ѱ�ռ��!", ErrorType.Warning);
                        return;
                    }

                    if (IsNew)
                    {
                        newUserShopRoleInfo.User.Status = (int)UserStatus.OnWork;
                        UserBusiness.Instance.AddUser(newUserShopRoleInfo.User);
                    }
                    else
                    {
                        newUserShopRoleInfo.User.IdSpecify = true;
                        newUserShopRoleInfo.User.PwdSpecify = false;
                        UserBusiness.Instance.UpdateUser(newUserShopRoleInfo.User);
                    }

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (XtraMessageBox.Show("�û���Ϣ�޸��£������༭����Y�˳����N", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
            }
        }

        private bool ValidatFail()
        {
            errorProvider.ClearErrors();

            if (cbShop.SelectedIndex < 0)
            {
                errorProvider.SetError(this.cbShop, "����Ϊ��", ErrorType.Warning);
            }
            if (string.IsNullOrEmpty(this.txtRealName.Text.Trim()))
            {
                errorProvider.SetError(this.txtRealName, "����Ϊ��", ErrorType.Warning);
            }
            if (string.IsNullOrEmpty(this.txtPhone.Text.Trim()))
            {
                errorProvider.SetError(this.txtPhone, "����Ϊ��", ErrorType.Warning);
            }
            if (this.cbRole.SelectedIndex < 0)
            {
                errorProvider.SetError(this.cbRole, "����Ϊ��", ErrorType.Warning);
            }

            if (string.IsNullOrEmpty(this.txtUserName.Text.Trim()))
            {
                errorProvider.SetError(this.txtUserName, "����Ϊ��", ErrorType.Warning);
            }

            if (userShopRoleInfo == null || newUserShopRoleInfo.User.PwdSpecify)
            {
                if (string.IsNullOrEmpty(this.txtPwd.Text.Trim()))
                    errorProvider.SetError(this.txtPwd, "����Ϊ��", ErrorType.Warning);
                if (!this.txtPwd.Text.Equals(this.txtAgainPwd.Text))
                    errorProvider.SetError(this.txtAgainPwd, "�����������벻��ͬ", ErrorType.Warning);
            }
            return errorProvider.HasErrors;
        }
    }
}
