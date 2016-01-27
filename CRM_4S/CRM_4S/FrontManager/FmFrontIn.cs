using CRM_4S.Business;
using CRM_4S.Common.FormBase;
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

namespace CRM_4S.FrontManager
{
    public partial class FmFrontIn : FormSimpleDialogBase
    {
        public FmFrontIn()
        {
            InitializeComponent();
            initForm();
        }

        private void initForm()
        {
            this.Btn_OK.Click += Btn_OK_Click;

            this.dtArralTime.EditValue = DateTime.Now;
            cbConsultant.Properties.Items.AddRange(GloableCaches.Instance.ConsultantInfos);
        }

        void Btn_OK_Click(object sender, EventArgs e)
        {
            if (!Validate()) return;

            try
            {
                FrontRecordInfo recordInfo = new FrontRecordInfo()
                {
                    ShopId = GloableCaches.Instance.CurUser.ShopId,
                    ArrivalTime = (DateTime)this.dtArralTime.EditValue,
                    CustomerNum = Convert.ToInt32(this.txtCNum.Text),
                    ConsultantId = ((UserInfo)this.cbConsultant.SelectedItem).Id,
                    Remark = this.txtDesc.Text,
                    OperatorId = GloableCaches.Instance.CurUser.Id
                };
                FrontRecordBusiness.Instance.AddFrontRecord(recordInfo);

                this.DialogResult = DialogResult.OK;
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
            return !errorProvider.HasErrors;
        }

        private void ComboxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validation();
        }

        private void TextEdit_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void TextEdit_Enter(object sender, EventArgs e)
        {
            ((TextEdit)sender).SelectAll();
        }
    }
}
