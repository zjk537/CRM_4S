using CRM_4S.Business.BusinessModel;
using CRM_4S.Common.FormBase;
using CRM_4S.Model.DataModel;
using CRM_4S.Model;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CRM_4S.Business;
using DevExpress.XtraEditors.DXErrorProvider;
using CRM_4S.Model.EnumType;

namespace CRM_4S.DCCManager
{
    public partial class FmDCCRecall : FormSimpleDialogBase
    {
        DCCCustomerRecordInfo recordInfo = null;

        DCCCustomerRecordInfo newRecordInfo = new DCCCustomerRecordInfo();
        IList<PurposeLevelInfo> purposeLevels = null;

        private bool IsNew { get { return recordInfo == null; } }
        public FmDCCRecall(DCCCustomerRecordInfo info = null)
        {
            InitializeComponent();
            initForm(info);
        }

        private void initForm(DCCCustomerRecordInfo info)
        {

            if (info != null)
            {
                DCCRecordInfo dccInfo = new DCCRecordInfo();
                CustomerInfo customerInfo = new CustomerInfo();
                DBModelBase.Clone<DCCRecordInfo>(info.DCCRecord, ref dccInfo);
                DBModelBase.Clone<CustomerInfo>(info.Customer, ref customerInfo);
                recordInfo = info;
                newRecordInfo.Customer = customerInfo;
                newRecordInfo.DCCRecord = dccInfo;
            }


            this.Btn_OK.Click += Btn_OK_Click;

            this.txtCName.DataBindings.Add("Text", newRecordInfo.Customer, "Name");
            this.txtCPhone.DataBindings.Add("Text", newRecordInfo.Customer, "Phone");
            this.txtCAddress.DataBindings.Add("Text", newRecordInfo.Customer, "Address");
            this.cbRegion.Properties.Items.AddRange(GlobalCaches.Instance.RegionInfos);

            if (newRecordInfo.Customer.RegionId.HasValue)
                this.cbRegion.SelectedItem = GlobalCaches.Instance.RegionInfos.FirstOrDefault(e => e.Id == newRecordInfo.Customer.RegionId);
            else
                this.cbRegion.SelectedIndex = 0;

            this.rbSex.SelectedIndex = newRecordInfo.Customer.Sex.HasValue ? newRecordInfo.Customer.Sex.Value - 1 : -1;

            purposeLevels = PurposeLevelBusiness.Instance.GetPurposeLevels();
            this.cbCarType.Properties.Items.AddRange(GlobalCaches.Instance.CarTypes);
            this.cbCLevel.Properties.Items.AddRange(purposeLevels.ToArray());
            this.cbDCCSource.Properties.Items.AddRange(GlobalCaches.Instance.ConstantInfos.Where(e => e.TypeValue == (int)BasicConstantType.DCCSource).ToArray());
            this.cbRecaller.Properties.Items.AddRange(GlobalCaches.Instance.ConsultantInfos);

            if (newRecordInfo.DCCRecord.PurposeCar.HasValue)
                this.cbCarType.SelectedItem = GlobalCaches.Instance.CarTypes.FirstOrDefault(e => e.Id == newRecordInfo.DCCRecord.PurposeCar);
            else
                this.cbCarType.SelectedIndex = 0;

            if (string.IsNullOrEmpty(newRecordInfo.DCCRecord.LevelCode))
                this.cbCLevel.SelectedIndex = 0;
            else
                this.cbCLevel.SelectedItem = purposeLevels.FirstOrDefault(e => e.Code == newRecordInfo.DCCRecord.LevelCode);

            if (newRecordInfo.DCCRecord.Source.HasValue)
                this.cbDCCSource.SelectedItem = GlobalCaches.Instance.ConstantInfos.FirstOrDefault(e => e.Id == newRecordInfo.DCCRecord.Source);
            else
                this.cbDCCSource.SelectedIndex = 0;

            this.rbDCCStatus.SelectedIndex = newRecordInfo.DCCRecord.Status.HasValue ? newRecordInfo.DCCRecord.Status.Value - 1 : -1;
            this.rbToShop.SelectedIndex = newRecordInfo.DCCRecord.ToShop.HasValue ? newRecordInfo.DCCRecord.ToShop.Value - 1 : -1;
            this.dtToShopTime.EditValue = newRecordInfo.DCCRecord.ToShopTime.HasValue ? newRecordInfo.DCCRecord.ToShopTime.Value : DateTime.Now.AddDays(3);
            this.rbInstallment.SelectedIndex = newRecordInfo.DCCRecord.Installment.HasValue ? newRecordInfo.DCCRecord.Installment.Value - 1 : -1;
            this.dtVisitTime.EditValue = newRecordInfo.DCCRecord.VisitTime.HasValue ? newRecordInfo.DCCRecord.VisitTime.Value : DateTime.Now.AddDays(-3);
            if (newRecordInfo.DCCRecord.DCCRecallerId.HasValue)
                this.cbRecaller.SelectedItem = GlobalCaches.Instance.ConsultantInfos.FirstOrDefault(e => e.Id == newRecordInfo.DCCRecord.DCCRecallerId);
            else
                this.cbRecaller.SelectedIndex = 0;
            this.txtRemark.DataBindings.Add("Text", newRecordInfo.DCCRecord, "RecallDesc");

            if (IsNew)
            {
                this.txtCPhone.Leave += txtCPhone_Leave;
            }
        }

        private bool Validation()
        {
            errorProvider.ClearErrors();

            if (string.IsNullOrEmpty(this.txtCName.Text.Trim()))
            {
                errorProvider.SetError(this.txtCName, "不能为空", ErrorType.Warning);
            }
            if (!IsNew && !string.IsNullOrEmpty(recordInfo.Customer.Phone) && string.IsNullOrEmpty(newRecordInfo.Customer.Phone))
            {
                errorProvider.SetError(this.txtCPhone, "不能为空", ErrorType.Warning);
            }
            return !errorProvider.HasErrors;
        }


        private void TextEdit_Enter(object sender, EventArgs e)
        {
            ((TextEdit)sender).SelectAll();
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (!(Validation())) return;

            try
            {
                if (this.rbSex.SelectedIndex > -1)
                    newRecordInfo.Customer.Sex = this.rbSex.SelectedIndex + 1;
                newRecordInfo.Customer.RegionId = ((RegionInfo)this.cbRegion.SelectedItem).Id;
                // 新用户
                if (newRecordInfo.Customer.Id == 0)
                {
                    newRecordInfo.Customer.ShopId = GlobalCaches.Instance.CurUser.ShopId;
                    CustomerBusiness.Instance.AddCustomer(newRecordInfo.Customer);
                }
                else
                {
                    newRecordInfo.Customer.IdSpecify = true;
                    CustomerBusiness.Instance.UpdateCustomer(newRecordInfo.Customer);
                }

                newRecordInfo.DCCRecord.ShopId = GlobalCaches.Instance.CurUser.ShopId;
                newRecordInfo.DCCRecord.CustomerId = newRecordInfo.Customer.Id;
                newRecordInfo.DCCRecord.PurposeCar = ((CarTypeInfo)this.cbCarType.SelectedItem).Id;
                newRecordInfo.DCCRecord.LevelCode = ((PurposeLevelInfo)this.cbCLevel.SelectedItem).Code;
                newRecordInfo.DCCRecord.Source = ((BasicConstantInfo)this.cbDCCSource.SelectedItem).Id;
                if (this.rbDCCStatus.SelectedIndex > -1)
                    newRecordInfo.DCCRecord.Status = this.rbDCCStatus.SelectedIndex + 1;
                if (this.rbToShop.SelectedIndex > -1)
                    newRecordInfo.DCCRecord.ToShop = this.rbToShop.SelectedIndex + 1;
                newRecordInfo.DCCRecord.ToShopTime = (DateTime)this.dtToShopTime.EditValue;
                if (this.rbInstallment.SelectedIndex > -1)
                    newRecordInfo.DCCRecord.Installment = this.rbInstallment.SelectedIndex + 1;
                newRecordInfo.DCCRecord.DCCRecallerId = ((UserInfo)this.cbRecaller.SelectedItem).Id;
                newRecordInfo.DCCRecord.RecallTime = DateTime.Now;
                newRecordInfo.DCCRecord.VisitTime = (DateTime)this.dtVisitTime.EditValue;
                TimeSpan durationTime = newRecordInfo.DCCRecord.RecallTime.Value - newRecordInfo.DCCRecord.VisitTime.Value;
                newRecordInfo.DCCRecord.DurationTime = durationTime.ToString(@"hh\:mm\:ss");

                if (IsNew)
                {
                    DCCRecordBusiness.Instance.AddDCCRecord(newRecordInfo.DCCRecord);
                }
                else
                {
                    newRecordInfo.DCCRecord.IdSpecify = true;
                    DCCRecordBusiness.Instance.UpdateDCCRecord(newRecordInfo.DCCRecord);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("保存失败,请联系管理员，信息如下：\r\n{0}", ex.Message), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtCPhone_Leave(object sender, EventArgs e)
        {
            string phone = this.txtCPhone.Text.Trim();
            if (string.IsNullOrEmpty(phone))
            {
                if (!string.IsNullOrEmpty(recordInfo.Customer.Phone))
                    errorProvider.SetError(this.txtCPhone, "不能为空", ErrorType.Warning);
                return;
            }
            if (newRecordInfo.Customer.Phone == phone)
                return;

            var customers = CustomerBusiness.Instance.GetCustomers(new CustomerInfo() { ShopId = GlobalCaches.Instance.CurUser.ShopId, Phone = phone });
            CustomerInfo info = null;
            if (customers == null || customers.Count == 0)
                info = new CustomerInfo()
                {
                    Phone = phone,
                    Name = this.txtCName.Text.Trim(),
                    RegionId = ((RegionInfo)this.cbRegion.SelectedItem).Id,
                    Sex = this.rbSex.SelectedIndex + 1,
                    Address = this.txtCAddress.Text.Trim()
                };
            else
                info = customers.FirstOrDefault();

            newRecordInfo.Customer = info;
            newRecordInfo.DCCRecord.CustomerId = info.Id;
            // 如果根据 手机号查询出的顾客存在 就取顾客的记录，如果不存在 就取当前记录
            newRecordInfo.DCCRecord.Id = IsNew ? 0 : recordInfo.DCCRecord.Id;

            this.txtCName.DataBindings.Clear();
            this.txtCPhone.DataBindings.Clear();
            this.txtCAddress.DataBindings.Clear();

            this.txtCName.DataBindings.Add("Text", info, "Name");
            this.txtCPhone.DataBindings.Add("Text", info, "Phone");
            this.txtCAddress.DataBindings.Add("Text", info, "Address");
            this.rbSex.SelectedIndex = info.Sex.HasValue ? info.Sex.Value - 1 : -1;
            if (info.RegionId.HasValue)
                this.cbRegion.SelectedItem = GlobalCaches.Instance.RegionInfos.FirstOrDefault(m => m.Id == info.RegionId.Value);
            else
                this.cbRegion.SelectedIndex = 0;

        }

        private void txtCPhone_TextChanged(object sender, EventArgs e)
        {
            errorProvider.ClearErrors();
        }


    }
}
