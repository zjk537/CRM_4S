using CRM_4S.Common.FormBase;
using CRM_4S.Business;
using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CRM_4S.Model;
using CRM_4S.Model.EnumType;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors;

namespace CRM_4S.BasicsManager
{
    public partial class FmQuestionInfo : FormSimpleDialogBase
    {
        EvaluateQuestionInfo qInfo = null;
        EvaluateQuestionInfo newQInfo = new EvaluateQuestionInfo();

        private bool IsNew { get { return qInfo == null; } }
        public FmQuestionInfo(EvaluateQuestionInfo info = null)
        {
            InitializeComponent();
            initForm(info);
        }

        private void initForm(EvaluateQuestionInfo info)
        {
            if (info != null)
            {
                DBModelBase.Clone<EvaluateQuestionInfo>(info, ref newQInfo);
                qInfo = info;
            }

            this.Text += IsNew ? "-����" : "-�޸�";
            this.Btn_OK.Click += Btn_OK_Click;

            cbQType.Properties.Items.AddRange(GloablCaches.Instance.ConstantInfos.Where(e => e.TypeValue == (int)BasicConstantType.QType).ToArray());

            txtQDesc.DataBindings.Add("Text", newQInfo, "QDesc");
            //txtQLevel.DataBindings.Add("EditValue", newQInfo, "QLevel");

            cbQType.SelectedItem = GloablCaches.Instance.ConstantInfos.FirstOrDefault(e => e.Id == newQInfo.QType);
            txtQLevel.EditValue = newQInfo.QLevel ?? 100;
        }

        void Btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation()) return;
                BasicConstantInfo questionInfo = (BasicConstantInfo)cbQType.SelectedItem;
                if (IsNew || newQInfo.QType != questionInfo.Id)
                {
                    newQInfo.QType = questionInfo.Id;
                }
                int qLevel = Convert.ToInt32(txtQLevel.EditValue);
                if (IsNew || newQInfo.QLevel != qLevel)
                {
                    newQInfo.QLevel = qLevel;
                }

                if (!newQInfo.Equals(qInfo))
                {
                    if (IsNew)
                    {
                        newQInfo.ShopId = GloablCaches.Instance.CurUser.ShopId;
                        EvaluateQuestionBusiness.Instance.AddEvaluateQuestion(newQInfo);
                    }
                    else
                    {
                        newQInfo.Id = qInfo.Id;
                        EvaluateQuestionBusiness.Instance.UpdateEvaluateQuestion(newQInfo);
                    }

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (XtraMessageBox.Show("���������޸��£������༭����Y�˳����N", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("����ʧ��,����ϵ����Ա����Ϣ���£�\r\n{0}", ex.Message), "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool Validation()
        {
            errorProvider.ClearErrors();

            if (string.IsNullOrEmpty(this.txtQDesc.Text.Trim()))
            {
                errorProvider.SetError(this.txtQDesc, "����Ϊ��", ErrorType.Warning);
            }

            return !errorProvider.HasErrors;
        }
    }
}
