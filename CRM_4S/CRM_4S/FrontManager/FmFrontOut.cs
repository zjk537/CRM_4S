using CRM_4S.Business;
using CRM_4S.Business.BusinessModel;
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
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors;

namespace CRM_4S.FrontManager
{
    public partial class FmFrontOut : FormSimpleDialogBase
    {
        FrontCustomerRecordInfo recordInfo = null;

        FrontCustomerRecordInfo newRecordInfo = new FrontCustomerRecordInfo();


        public FmFrontOut(FrontCustomerRecordInfo info)
        {
            InitializeComponent();
            initView(info);

            RefreshFrontRecordView(info.FrontRecord);

            FrontRecordBusiness.Instance.OnDataChanged += new EventHandler<CusEventArgs>((object sender, CusEventArgs args) => { RefreshFrontRecordView(newRecordInfo.FrontRecord); });
        }

        private void initView(FrontCustomerRecordInfo info)
        {
            FrontRecordInfo frontInfo = new FrontRecordInfo();
            CustomerInfo customerInfo = new CustomerInfo();
            DBModelBase.Clone<FrontRecordInfo>(info.FrontRecord, ref frontInfo);
            DBModelBase.Clone<CustomerInfo>(info.Customer, ref customerInfo);
            newRecordInfo.FrontRecord = frontInfo;
            newRecordInfo.Customer = customerInfo;
            recordInfo = info;

            this.txtCName.DataBindings.Add("Text", customerInfo, "Name");
            this.txtCPhone.DataBindings.Add("Text", customerInfo, "Phone");
            this.txtCIndustry.DataBindings.Add("Text", customerInfo, "Industry");
            this.txtCAddress.DataBindings.Add("Text", customerInfo, "Address");
            IList<CustomerLevelInfo> customerLevels = CustomerLevelBusiness.Instance.GetCustomerLevels();
            this.cbCLevel.Properties.Items.AddRange(customerLevels.ToArray());
            this.cbCNature.Properties.Items.AddRange(GloableConstants.CustomerNature);
            this.cbCLevel.SelectedItem = customerLevels.FirstOrDefault(e => e.Code == customerInfo.LevelCode);
            this.cbCNature.SelectedIndex = customerInfo.Nature ?? 0;

            this.cbCarLicence.Properties.Items.AddRange(GloableConstants.CarLicence);
            this.cbCarType.Properties.Items.AddRange(GloableCaches.Instance.CarTypes);
            this.cbDriveStatus.Properties.Items.AddRange(GloableConstants.BooleanDesc);
            this.cbCarLicence.SelectedIndex = frontInfo.CarLicence ?? 0;
            this.cbCarType.SelectedItem = GloableCaches.Instance.CarTypes.FirstOrDefault(e => e.Id == frontInfo.PurposeCar);
            this.cbDriveStatus.SelectedIndex = frontInfo.DriveStatus ?? 0;
            this.txtCustomerNum.EditValue = frontInfo.CustomerNum;
            this.txtRemark.DataBindings.Add("Text", frontInfo, "Remark");
            this.dtLeaveTime.EditValue = frontInfo.LeaveTime ?? DateTime.Now;

            this.Btn_OK.Visible = false;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(Validate())) return;

            try
            {
                newRecordInfo.Customer.LevelCode = this.cbCLevel.SelectedText;
                newRecordInfo.Customer.Nature = this.cbCNature.SelectedIndex;
                newRecordInfo.Customer.ShopId = GloableCaches.Instance.CurUser.ShopId;
                newRecordInfo.FrontRecord.CarLicence = this.cbCarLicence.SelectedIndex;
                newRecordInfo.FrontRecord.PurposeCar = ((CarTypeInfo)this.cbCarType.SelectedItem).Id;
                newRecordInfo.FrontRecord.DriveStatus = this.cbDriveStatus.SelectedIndex;
                newRecordInfo.FrontRecord.CustomerNum = Convert.ToInt32(this.txtCustomerNum.EditValue);

                // 在添加customer成功后，会给当前customer 赋Id
                if (recordInfo.Customer.Id == 0)
                    CustomerBusiness.Instance.AddCustomer(newRecordInfo.Customer);
                else
                {
                    if (!string.IsNullOrEmpty(recordInfo.Customer.Phone) && string.IsNullOrEmpty(newRecordInfo.Customer.Phone))
                    {
                        errorProvider.SetError(this.txtCPhone, "不能为空", ErrorType.Warning);
                        return;
                    }
                    CustomerBusiness.Instance.UpdateCustomer(newRecordInfo.Customer);
                }

                newRecordInfo.FrontRecord.IdSpecify = true;
                newRecordInfo.FrontRecord.CustomerId = newRecordInfo.Customer.Id;
                newRecordInfo.FrontRecord.LeaveTime = (DateTime)this.dtLeaveTime.EditValue;
                TimeSpan durationTime = newRecordInfo.FrontRecord.LeaveTime.Value - newRecordInfo.FrontRecord.ArrivalTime.Value;
                newRecordInfo.FrontRecord.DurationTime = durationTime.ToString(@"hh\:mm\:ss");
                FrontRecordBusiness.Instance.UpdateFrontRecord(newRecordInfo.FrontRecord);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("保存失败,请联系管理员，信息如下：\r\n{0}", ex.Message), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void RefreshFrontRecordView(FrontRecordInfo recordInfo)
        {
            int recordId = 0;
            if (recordInfo.CustomerId == 0)
            {
                recordId = recordInfo.Id;
            }
            var listResult = FrontRecordBusiness.Instance.GetFrontCustomerRecords(recordInfo.CustomerId, recordId);
            gridControlFrontRecord.DataSource = listResult;
            gridControlFrontRecord.DefaultView.RefreshData();
        }

        private void defaultGridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            if (e.Column.Name == "clmCarLicence")
            {
                e.DisplayText = e.CellValue == null ? "" : GloableConstants.CarLicence[(int)e.CellValue];
                return;
            }

            if (e.Column.Name == "clmPurposeCar")
            {
                e.DisplayText = e.CellValue == null ? "" : GloableCaches.Instance.CarTypes.FirstOrDefault(t => t.Id == (int)e.CellValue).ToString();
                return;
            }

            if (e.Column.Name == "clmDriveStatus")
            {
                e.DisplayText = e.CellValue == null ? "" : GloableConstants.DriveStatus[(int)e.CellValue];
                return;
            }
        }
    }
}
