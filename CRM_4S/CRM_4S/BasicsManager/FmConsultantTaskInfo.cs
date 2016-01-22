using CRM_4S.Business;
using CRM_4S.Common.FormBase;
using CRM_4S.Model;
using CRM_4S.Model.DataModel;
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

namespace CRM_4S.BasicsManager
{
    public partial class FmConsultantTaskInfo : FormSimpleDialogBase
    {
        UserTaskInfo taskInfo = null;
        UserTaskInfo newTaskInfo = new UserTaskInfo();

        private bool IsNew { get { return taskInfo == null; } }
        public FmConsultantTaskInfo(UserTaskInfo info = null)
        {
            InitializeComponent();

            initForm(info);
        }

        private void initForm(UserTaskInfo info)
        {
            if (info != null)
            {
                DBModelBase.Clone<UserTaskInfo>(info, ref newTaskInfo);
                taskInfo = info;
            }

            this.Text += IsNew ? "-新增" : "-修改";
            this.Btn_OK.Click += Btn_OK_Click;

            cbConsultant.Properties.Items.AddRange(UserBusiness.Instance.GetUsers(new UserInfo()
            {
                ShopId = GloableCaches.Instance.CurUser.ShopId,
                RoleId = GloableConstants.RoleIdConsultant
            }).ToArray());
            cbCarType.Properties.Items.AddRange(GloableCaches.Instance.CarTypes);
            cbConsultant.EditValue = IsNew ? "" : newTaskInfo.ConsultantName;

            //cbConsultant.DataBindings.Add("EditValue", newTaskInfo, "ConsultantName");
            //dtStartDate.DataBindings.Add("EditValue", newTaskInfo, "StartDate");
            //dtEndDate.DataBindings.Add("EditValue", newTaskInfo, "EndDate");
            //cbCarType.DataBindings.Add("EditValue", newTaskInfo, "CarType");
            //txtTaskNum.DataBindings.Add("Text", newTaskInfo, "Num");

            txtTaskDesc.DataBindings.Add("Text", newTaskInfo, "Desc");
            dtStartDate.EditValue = newTaskInfo.StartDate.HasValue ? newTaskInfo.StartDate.Value : DateTime.Now;
            dtEndDate.EditValue = newTaskInfo.EndDate.HasValue ? newTaskInfo.EndDate : DateTime.Now.AddMonths(1);
            txtTaskNum.EditValue = newTaskInfo.Num;

            cbConsultant.SelectedText = IsNew ? "" : newTaskInfo.ConsultantName;
            cbCarType.SelectedItem = IsNew ? null : newTaskInfo.CarType;



        }

        void Btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation()) return;
                if (IsNew || newTaskInfo.ConsultantName != cbConsultant.EditValue.ToString())
                {
                    newTaskInfo.ConsultantId = ((UserInfo)cbConsultant.SelectedItem).Id;
                }
                if (IsNew || newTaskInfo.StartDate.Value.ToString() != dtStartDate.EditValue.ToString())
                {
                    newTaskInfo.StartDate = (DateTime)dtStartDate.EditValue;
                }
                if (IsNew || newTaskInfo.EndDate.Value.ToString() != dtEndDate.EditValue.ToString())
                {
                    newTaskInfo.EndDate = (DateTime)dtEndDate.EditValue;
                }
                if (IsNew || newTaskInfo.CarType.Value != ((CarTypeInfo)cbCarType.SelectedItem).Id)
                {
                    newTaskInfo.CarType = ((CarTypeInfo)cbCarType.SelectedItem).Id;
                }
                if (IsNew || taskInfo.Num != (int)txtTaskNum.EditValue)
                {
                    newTaskInfo.Num = (int)txtTaskNum.EditValue;
                }

                if (!newTaskInfo.Equals(taskInfo))
                {
                    if (IsNew)
                    {
                        UserTaskBusiness.Instance.AddUserTask(newTaskInfo);
                    }
                    else
                    {
                        newTaskInfo.Id = taskInfo.Id;
                        UserTaskBusiness.Instance.UpdateUserTask(newTaskInfo);
                    }

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (XtraMessageBox.Show("销顾任务无更新，继续编辑请点击Y退出点击N", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("保存失败,请联系管理员，信息如下：\r\n{0}", ex.Message), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool Validation()
        {
            errorProvider.ClearErrors();

            if (string.IsNullOrEmpty(this.cbConsultant.Text.Trim()))
            {
                errorProvider.SetError(this.cbConsultant, "不能为空", ErrorType.Warning);
            }

            if (string.IsNullOrEmpty(this.txtTaskNum.Text.Trim()))
            {
                errorProvider.SetError(this.txtTaskNum, "不能为空", ErrorType.Warning);
            }

            //if (string.IsNullOrEmpty(this.txtTaskDesc.Text.Trim()))
            //{
            //    errorProvider.SetError(this.txtTaskDesc, "不能为空", ErrorType.Warning);
            //}

            return !errorProvider.HasErrors;
        }
    }
}
