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

namespace CRM_4S.OrderManager
{
    public partial class FmOrderInfo : FormSimpleDialogBase
    {
        OrderRecordInfo recordInfo = null;
        CustomerInfo customerInfo = null;

        OrderRecordInfo newRecordInfo = new OrderRecordInfo();
        public FmOrderInfo(OrderRecordInfo info = null, CustomerInfo cInfo = null)
        {
            InitializeComponent();
            customerInfo = cInfo == null ? new CustomerInfo() : cInfo;
            initForm(info);
        }

        private bool IsNew { get { return recordInfo == null || recordInfo.Id == 0; } }
        private void initForm(OrderRecordInfo info)
        {
            if (info != null)
            {
                DBModelBase.Clone<OrderRecordInfo>(info, ref newRecordInfo);
                recordInfo = info;
            }

            this.Text += IsNew ? "-新增" : "-修改";
            this.Btn_OK.Click += Btn_OK_Click;

            this.txtCPhone.Text = customerInfo.Phone;
            this.txtCName.Text = customerInfo.Name;
            //this.txtCPhone.DataBindings.Add("Text", customerInfo, "Phone");
            //this.txtCName.DataBindings.Add("Text", customerInfo, "Name");
            this.txtRemark.DataBindings.Add("Text", newRecordInfo, "Remark");
            //this.txtPrice.DataBindings.Add("Text", newRecordInfo, "Price");
            //this.txtDisPrice.DataBindings.Add("Text", newRecordInfo, "DisPrice");
            //this.txtPrevPay.DataBindings.Add("Text", newRecordInfo, "PrevPay");

            this.txtPrice.EditValue = newRecordInfo.Price ?? 0;
            this.txtDisPrice.EditValue = newRecordInfo.DisPrice ?? 0;
            this.txtPrevPay.EditValue = newRecordInfo.PrevPay ?? 0;

            this.cbCarType.Properties.Items.AddRange(GlobalCaches.Instance.CarTypes);
            this.cbConsultant.Properties.Items.AddRange(GlobalCaches.Instance.ConsultantInfos);

            if (!IsNew && newRecordInfo.CarType.HasValue)
                this.cbCarType.SelectedItem = GlobalCaches.Instance.CarTypes.FirstOrDefault(e => e.Id == newRecordInfo.CarType);
            else
                this.cbCarType.SelectedIndex = 0;

            if (!IsNew && newRecordInfo.ConsultantId.HasValue)
                this.cbConsultant.SelectedItem = GlobalCaches.Instance.ConsultantInfos.FirstOrDefault(e => e.Id == newRecordInfo.ConsultantId);
            else
                this.cbConsultant.SelectedIndex = 0;


            this.txtCPhone.Properties.ReadOnly = !string.IsNullOrEmpty(customerInfo.Phone);
            // 只有店内经理可以修改客户的销售顾问
            this.cbConsultant.Enabled = GlobalCaches.Instance.CurUser.RoleId <= GlobalConstants.RoleIdSysManager;
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (!Validation()) return;

            if (string.IsNullOrEmpty(customerInfo.Phone))
            {
                XtraMessageBox.Show("客户信息不存在！", "提示", MessageBoxButtons.OK);
                return;
            }

            try
            {
                newRecordInfo.ShopId = GlobalCaches.Instance.CurUser.ShopId;
                newRecordInfo.CustomerId = customerInfo.Id;
                newRecordInfo.RecorderId = GlobalCaches.Instance.CurUser.Id;
                newRecordInfo.Price = Convert.ToDecimal(this.txtPrice.EditValue);
                newRecordInfo.DisPrice = Convert.ToDecimal(this.txtDisPrice.EditValue);
                newRecordInfo.PrevPay = Convert.ToDecimal(this.txtPrevPay.EditValue);
                if (newRecordInfo.Price > 0)
                    newRecordInfo.Status = 2;
                else if (newRecordInfo.PrevPay > 0)
                    newRecordInfo.Status = 1;
                else
                {
                    XtraMessageBox.Show("实付金额与预付订金不能同时为0！", "提示", MessageBoxButtons.OK);
                    return;
                }


                var carType = (CarTypeInfo)this.cbCarType.SelectedItem;
                if (carType != null)
                    newRecordInfo.CarType = carType.Id;

                var consultant = (UserInfo)this.cbConsultant.SelectedItem;
                if (consultant != null)
                    newRecordInfo.ConsultantId = consultant.Id;

                if (IsNew)
                {
                    OrderRecordBusiness.Instance.AddOrderRecord(newRecordInfo);
                }
                else
                {
                    newRecordInfo.IdSpecify = true;
                    OrderRecordBusiness.Instance.UpdateOrderRecord(newRecordInfo);
                }
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

            if (string.IsNullOrEmpty(this.txtCPhone.Text.Trim()))
            {
                errorProvider.SetError(this.txtCPhone, "不能为空", ErrorType.Warning);
            }
            return !errorProvider.HasErrors;
        }

        private void txtCPhone_Leave(object sender, EventArgs e)
        {
            string phone = this.txtCPhone.Text.Trim();
            if (string.IsNullOrEmpty(phone))
            {
                return;
            }

            var customers = CustomerBusiness.Instance.GetCustomers(new CustomerInfo() { ShopId = GlobalCaches.Instance.CurUser.ShopId, Phone = phone });
            if (customers == null || customers.Count == 0)
            {
                errorProvider.SetError(this.txtCPhone, "客户信息不存在", ErrorType.Warning);
                return;
            }

            customerInfo = customers.FirstOrDefault();
            this.txtCName.Text = customerInfo.Name;
        }
    }
}
