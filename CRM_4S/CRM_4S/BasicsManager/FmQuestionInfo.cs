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

            this.Text += IsNew ? "-新增" : "-修改";
            this.Btn_OK.Click += Btn_OK_Click;

            cbQType.Properties.Items.AddRange(GloablConstants.QuestionTypes.Values);

            txtQDesc.DataBindings.Add("Text", newQInfo, "QDesc");
            //txtQLevel.DataBindings.Add("EditValue", newQInfo, "QLevel");

            cbQType.Text = IsNew ? GloablConstants.QuestionTypes[QuestionType.All] : GloablConstants.QuestionTypes[(QuestionType)newQInfo.QType];
            txtQLevel.EditValue = newQInfo.QLevel ?? 100;
        }

        void Btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation()) return;

                if (IsNew || GloablConstants.QuestionTypes[(QuestionType)newQInfo.QType] != cbQType.SelectedItem.ToString())
                {
                    QuestionType qType = GloablConstants.QuestionTypes.FirstOrDefault(qt => { return qt.Value == cbQType.SelectedItem.ToString(); }).Key;
                    newQInfo.QType = (int)qType;
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
                    if (XtraMessageBox.Show("评估问题无更新，继续编辑请点击Y退出点击N", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
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

            if (string.IsNullOrEmpty(this.txtQDesc.Text.Trim()))
            {
                errorProvider.SetError(this.txtQDesc, "不能为空", ErrorType.Warning);
            }

            return !errorProvider.HasErrors;
        }
    }
}
