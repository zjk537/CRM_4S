using CRM_4S.Business;
using CRM_4S.Common.FormBase;
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

namespace CRM_4S.DCCManager
{
    public partial class FmDCCIn : FormSimpleDialogBase
    {
        CustomerInfo customerInfo = new CustomerInfo();
        DCCRecordInfo recordInfo = new DCCRecordInfo();
        public FmDCCIn()
        {
            InitializeComponent();
            initForm();
        }

        private void initForm()
        {
            this.txtCName.DataBindings.Add("Text", customerInfo, "Name");
            this.txtCPhone.DataBindings.Add("Text", customerInfo, "Phone");
            this.dtVisitTime.EditValue = DateTime.Now;
            this.cbDCCSource.Properties.Items.AddRange(GloablCaches.Instance.ConstantInfos.Where(e => e.TypeValue == (int)BasicConstantType.DCCSource).ToArray());
            this.cbCarType.Properties.Items.AddRange(GloablCaches.Instance.CarTypes);
            this.Btn_OK.Click += Btn_OK_Click;
        }

        void Btn_OK_Click(object sender, EventArgs e)
        {

            if (!Validate()) return;

            try
            {
                customerInfo.ShopId = GloablCaches.Instance.CurUser.ShopId;
                if (customerInfo.Id == 0)
                    CustomerBusiness.Instance.AddCustomer(customerInfo);
                else
                    CustomerBusiness.Instance.UpdateCustomer(customerInfo);

                recordInfo.CustomerId = customerInfo.Id;
                recordInfo.ShopId = GloablCaches.Instance.CurUser.ShopId;
                recordInfo.VisitTime = (DateTime)this.dtVisitTime.EditValue;
                recordInfo.Source = this.cbDCCSource.SelectedIndex;
                recordInfo.PurposeCar = ((CarTypeInfo)this.cbCarType.SelectedItem).Id;
                recordInfo.Recorder = GloablCaches.Instance.CurUser.RealName;
                DCCRecordBusiness.Instance.AddDCCRecord(recordInfo);

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

            if (string.IsNullOrEmpty(this.txtCName.Text.Trim()))
            {
                errorProvider.SetError(this.txtCName, "不能为空", ErrorType.Warning);
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

        private void txtCPhone_Leave(object sender, EventArgs e)
        {
            string phone = this.txtCPhone.Text.Trim();
            if (string.IsNullOrEmpty(phone))
                return;
            if (phone == customerInfo.Phone)
                return;

            var customers = CustomerBusiness.Instance.GetCustomers(new CustomerInfo() { ShopId = GloablCaches.Instance.CurUser.ShopId, Phone = phone });
            if (customers == null || customers.Count == 0)
                customerInfo = new CustomerInfo()
                {
                    Phone = phone,
                    Name = this.txtCName.Text.Trim()
                };
            else
                customerInfo = customers.FirstOrDefault();

            this.txtCName.DataBindings.Clear();
            this.txtCPhone.DataBindings.Clear();

            this.txtCName.DataBindings.Add("Text", customerInfo, "Name");
            this.txtCPhone.DataBindings.Add("Text", customerInfo, "Phone");
        }
    }
}
