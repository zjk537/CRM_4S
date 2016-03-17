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
using CRM_4S.Model.EnumType;

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

            this.Text += IsNew ? "-����" : "-�޸�";
            this.Btn_OK.Click += Btn_OK_Click;

            this.cbKPI.Properties.Items.AddRange(GlobalCaches.Instance.ConstantInfos
                .Where(e => e.TypeValue == (int)BasicConstantType.FrontKPI || e.TypeValue == (int)BasicConstantType.DCCKPI).ToArray());
            this.cbKUnit.DataBindings.Add("EditValue", newKpiInfo, "KUnit");
            this.txtPerform.DataBindings.Add("Text", newKpiInfo, "Perform");
            this.txtReason.DataBindings.Add("Text", newKpiInfo, "Reason");
            this.txtSuggest.DataBindings.Add("Text", newKpiInfo, "Suggest");
            this.txtKDesc.DataBindings.Add("Text", newKpiInfo, "Desc");
            this.txtKValue.EditValue = newKpiInfo.KValue ?? 0;

            if (string.IsNullOrEmpty(newKpiInfo.KUnit))
                this.cbKUnit.SelectedIndex = 0;

            if (newKpiInfo.BasicId > 0)
                this.cbKPI.SelectedItem = GlobalCaches.Instance.ConstantInfos.FirstOrDefault(e => e.Id == newKpiInfo.BasicId);
            else
                this.cbKPI.SelectedIndex = 0;

        }

        void Btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation()) return;

                var basicInfo = (BasicConstantInfo)this.cbKPI.SelectedItem;
                if (IsNew || kpiInfo.BasicId != basicInfo.Id)
                {
                    newKpiInfo.BasicId = basicInfo.Id;
                    newKpiInfo.Name = basicInfo.Name;
                }

                int kvalue = Convert.ToInt32(this.txtKValue.EditValue);
                if (IsNew || newKpiInfo.KValue != kvalue)
                    newKpiInfo.KValue = kvalue;

                if (!newKpiInfo.Equals(kpiInfo))
                {
                    newKpiInfo.OperatorId = GlobalCaches.Instance.CurUser.Id;
                    if (IsNew)
                        AnalyseKPIBusiness.Instance.AddAnalyseKPI(newKpiInfo);
                    else
                    {
                        newKpiInfo.Id = kpiInfo.Id;
                        AnalyseKPIBusiness.Instance.UpdateAnalyseKPI(newKpiInfo);
                    }

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (XtraMessageBox.Show("���˷���ָ����Ϣ�޸��£������༭����Y�˳����N", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
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

            if (string.IsNullOrEmpty(this.txtKValue.Text.Trim()))
            {
                errorProvider.SetError(this.txtKValue, "����Ϊ��", ErrorType.Warning);
            }

            if (string.IsNullOrEmpty(this.txtPerform.Text.Trim()))
            {
                errorProvider.SetError(this.txtPerform, "����Ϊ��", ErrorType.Warning);
            }

            if (string.IsNullOrEmpty(this.txtReason.Text.Trim()))
            {
                errorProvider.SetError(this.txtReason, "����Ϊ��", ErrorType.Warning);
            }

            if (string.IsNullOrEmpty(this.txtSuggest.Text.Trim()))
            {
                errorProvider.SetError(this.txtSuggest, "����Ϊ��", ErrorType.Warning);
            }
            return !errorProvider.HasErrors;
        }
    }
}
