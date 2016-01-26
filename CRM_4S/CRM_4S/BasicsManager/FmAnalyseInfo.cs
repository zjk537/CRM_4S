using CRM_4S.Common.FormBase;
using CRM_4S.Model.DataModel;
using CRM_4S.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CRM_4S.Business;
using DevExpress.XtraEditors.DXErrorProvider;

namespace CRM_4S.BasicsManager
{
    public partial class FmAnalyseInfo : FormSimpleDialogBase
    {
        AnalyseKPIInfo kpiInfo = null;
        AnalyseKPIInfo newKpiInfo = new AnalyseKPIInfo();

        private bool IsNew { get { return kpiInfo == null; } }
        public FmAnalyseInfo(AnalyseKPIInfo info = null)
        {
            InitializeComponent();

            initForm(info);
        }

        private void initForm(AnalyseKPIInfo info)
        {
            if (info != null)
            {
                DBModelBase.Clone<AnalyseKPIInfo>(info, ref newKpiInfo);
                kpiInfo = info;
            }

            this.Text += IsNew ? "-新增" : "-修改";
            this.Btn_OK.Click += Btn_OK_Click;

            this.txtName.DataBindings.Add("Text", newKpiInfo, "Name");
            this.cbKUnit.DataBindings.Add("EditValue", newKpiInfo, "KUnit");
            this.txtPerform.DataBindings.Add("Text", newKpiInfo, "Perform");
            this.txtReason.DataBindings.Add("Text", newKpiInfo, "Reason");
            this.txtSuggest.DataBindings.Add("Text", newKpiInfo, "Suggest");
            this.txtKDesc.DataBindings.Add("Text", newKpiInfo, "Desc");
            this.txtKValue.EditValue = newKpiInfo.KValue ?? 0;
            //this.cbKUnit.SelectedText = newKpiInfo.KUnit;
        }

        void Btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation()) return;

                int kvalue = Convert.ToInt32(this.txtKValue.EditValue);
                if (IsNew || newKpiInfo.KValue != kvalue)
                {
                    newKpiInfo.KValue = kvalue;
                }

                if (!newKpiInfo.Equals(kpiInfo))
                {
                    newKpiInfo.OperatorId = GloableCaches.Instance.CurUser.Id;
                    if (IsNew)
                    {
                        AnalyseKPIBusiness.Instance.AddAnalyseKPI(newKpiInfo);
                    }
                    else
                    {
                        newKpiInfo.Id = kpiInfo.Id;
                        AnalyseKPIBusiness.Instance.UpdateAnalyseKPI(newKpiInfo);
                    }

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (XtraMessageBox.Show("销顾分析指标信息无更新，继续编辑请点击Y退出点击N", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
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

            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                errorProvider.SetError(this.txtName, "不能为空", ErrorType.Warning);
            }

            if (string.IsNullOrEmpty(this.txtKValue.Text.Trim()))
            {
                errorProvider.SetError(this.txtKValue, "不能为空", ErrorType.Warning);
            }

            if (string.IsNullOrEmpty(this.txtPerform.Text.Trim()))
            {
                errorProvider.SetError(this.txtPerform, "不能为空", ErrorType.Warning);
            }

            if (string.IsNullOrEmpty(this.txtReason.Text.Trim()))
            {
                errorProvider.SetError(this.txtReason, "不能为空", ErrorType.Warning);
            }

            if (string.IsNullOrEmpty(this.txtSuggest.Text.Trim()))
            {
                errorProvider.SetError(this.txtSuggest, "不能为空", ErrorType.Warning);
            }
            return !errorProvider.HasErrors;
        }
    }
}
