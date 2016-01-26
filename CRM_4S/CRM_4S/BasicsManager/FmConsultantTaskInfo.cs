using CRM_4S.Business;
using CRM_4S.Business.BusinessModel;
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
        UserCarTypeTaskInfo taskInfo = null;
        UserCarTypeTaskInfo newTaskInfo = new UserCarTypeTaskInfo();

        private bool IsNew { get { return taskInfo == null; } }
        public FmConsultantTaskInfo(UserCarTypeTaskInfo info = null)
        {
            InitializeComponent();

            initForm(info);
        }

        private void initForm(UserCarTypeTaskInfo info)
        {
            if (info != null)
            {
                UserTaskInfo tmpUserTask = new UserTaskInfo();
                DBModelBase.Clone<UserTaskInfo>(info.UserTask, ref tmpUserTask);
                newTaskInfo.UserTask = tmpUserTask;
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

            UserTaskInfo tmpUserTaskInfo = newTaskInfo.UserTask;
            cbConsultant.EditValue = tmpUserTaskInfo.ConsultantName;

            cbCarType.DataBindings.Add("EditValue", newTaskInfo, "CarType");
            txtTaskDesc.DataBindings.Add("Text", tmpUserTaskInfo, "Desc");
            dtStartDate.EditValue = tmpUserTaskInfo.StartDate.HasValue ? tmpUserTaskInfo.StartDate.Value : DateTime.Now;
            dtEndDate.EditValue = tmpUserTaskInfo.EndDate.HasValue ? tmpUserTaskInfo.EndDate : DateTime.Now.AddMonths(1);
            txtTaskNum.EditValue = tmpUserTaskInfo.Cnt ?? 1;

            cbConsultant.SelectedText = tmpUserTaskInfo.ConsultantName;
        }

        void Btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation()) return;


                if (IsNew || newTaskInfo.UserTask.ConsultantName != cbConsultant.EditValue.ToString())
                {
                    newTaskInfo.UserTask.ConsultantId = ((UserInfo)cbConsultant.SelectedItem).Id;
                }
                if (IsNew || newTaskInfo.UserTask.StartDate.Value.ToString() != dtStartDate.EditValue.ToString())
                {
                    newTaskInfo.UserTask.StartDate = (DateTime)dtStartDate.EditValue;
                }
                if (IsNew || newTaskInfo.UserTask.EndDate.Value.ToString() != dtEndDate.EditValue.ToString())
                {
                    newTaskInfo.UserTask.EndDate = (DateTime)dtEndDate.EditValue;
                }
                if (IsNew || newTaskInfo.CarType != (CarTypeInfo)cbCarType.SelectedItem)
                {
                    newTaskInfo.CarType = ((CarTypeInfo)cbCarType.SelectedItem);
                }
                if (IsNew || newTaskInfo.UserTask.Cnt != (int)txtTaskNum.EditValue)
                {
                    newTaskInfo.UserTask.Cnt = (int)txtTaskNum.EditValue;
                }

                if (!newTaskInfo.Equals(taskInfo))
                {
                    if (IsNew)
                    {
                        UserTaskBusiness.Instance.AddUserTask(newTaskInfo.UserTask);
                    }
                    else
                    {
                        newTaskInfo.UserTask.Id = taskInfo.UserTask.Id;
                        UserTaskBusiness.Instance.UpdateUserTask(newTaskInfo.UserTask);
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
