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
using DevExpress.XtraEditors.Controls;
using CRM_4S.Model.EnumType;

namespace CRM_4S.FrontManager
{
    public partial class FmFrontOut : FormSimpleDialogBase
    {
        FrontCustomerRecordInfo recordInfo = null;

        FrontCustomerRecordInfo newRecordInfo = new FrontCustomerRecordInfo();

        IList<PurposeLevelInfo> customerLevels = null;
        public FmFrontOut(FrontCustomerRecordInfo info)
        {
            InitializeComponent();
            initForm(info);

        }

        private void initForm(FrontCustomerRecordInfo info)
        {
            FrontRecordInfo frontInfo = new FrontRecordInfo();
            CustomerInfo customerInfo = new CustomerInfo();
            DBModelBase.Clone<FrontRecordInfo>(info.FrontRecord, ref frontInfo);
            DBModelBase.Clone<CustomerInfo>(info.Customer, ref customerInfo);
            newRecordInfo.FrontRecord = frontInfo;
            newRecordInfo.Customer = customerInfo;
            recordInfo = info;

            this.Btn_OK.Click += Btn_OK_Click;

            this.txtCName.DataBindings.Add("Text", customerInfo, "Name");
            this.txtCPhone.DataBindings.Add("Text", customerInfo, "Phone");
            this.txtCIndustry.DataBindings.Add("Text", customerInfo, "Industry");
            this.txtCAddress.DataBindings.Add("Text", customerInfo, "Address");
            this.txtCurCar.DataBindings.Add("Text", customerInfo, "CurCar");
            customerLevels = PurposeLevelBusiness.Instance.GetPurposeLevels();
            this.cbCLevel.Properties.Items.AddRange(customerLevels.ToArray());
            this.cbRegion.Properties.Items.AddRange(GlobalCaches.Instance.RegionInfos);
            this.cbCNature.Properties.Items.AddRange(GlobalCaches.Instance.ConstantInfos.Where(e => e.TypeValue == (int)BasicConstantType.CNature).ToArray());

            //this.cbCarLicence.Properties.Items.AddRange(GloablCaches.Instance.ConstantInfos.Where(e => e.TypeValue == (int)BasicConstantType.CarLicence).ToArray());
            this.cbCarType.Properties.Items.AddRange(GlobalCaches.Instance.CarTypes);
            this.cbFrontSource.Properties.Items.AddRange(GlobalCaches.Instance.ConstantInfos.Where(e => e.TypeValue == (int)BasicConstantType.FrontSource).ToArray());

            

            if (customerInfo.Id == 0)
                this.cbCNature.SelectedIndex = 0;
            else
                this.cbCNature.SelectedItem = GlobalCaches.Instance.ConstantInfos.FirstOrDefault(e => e.Id == customerInfo.Nature);
            if (customerInfo.RegionId.HasValue)
                this.cbRegion.SelectedItem = GlobalCaches.Instance.RegionInfos.FirstOrDefault(e => e.Id == customerInfo.RegionId);
            else
                this.cbRegion.SelectedIndex = 0;

            //if (frontInfo.CarLicence == null)
            //    this.cbCarLicence.SelectedIndex = 0;
            //else
            //    this.cbCarLicence.SelectedItem = GloablCaches.Instance.ConstantInfos.FirstOrDefault(e => e.Id == frontInfo.CarLicence);

            if (string.IsNullOrEmpty(frontInfo.LevelCode))
                this.cbCLevel.SelectedIndex = 0;
            else
                this.cbCLevel.SelectedItem = customerLevels.FirstOrDefault(e => e.Code == frontInfo.LevelCode);

            if (frontInfo.PurposeCar.HasValue)
                this.cbCarType.SelectedItem = GlobalCaches.Instance.CarTypes.FirstOrDefault(e => e.Id == frontInfo.PurposeCar);
            else
                this.cbCarType.SelectedIndex = 0;

           
            if (frontInfo.Source.HasValue)
                this.cbFrontSource.SelectedItem = GlobalCaches.Instance.ConstantInfos.FirstOrDefault(e => e.Id == frontInfo.Source);
            else
                this.cbFrontSource.SelectedIndex = 0;
            this.txtRemark.DataBindings.Add("Text", frontInfo, "Remark");
            this.txtCNum.EditValue = frontInfo.CustomerNum;
            this.rdDriveStatus.SelectedIndex = frontInfo.DriveStatus.HasValue ? frontInfo.DriveStatus.Value - 1 : -1;
            this.rdInstallment.SelectedIndex = frontInfo.Installment.HasValue ? frontInfo.Installment.Value - 1 : -1;
            this.rdReplace.SelectedIndex = frontInfo.Replace.HasValue ? frontInfo.Replace.Value - 1 : -1;
        }


        private bool Validation()
        {
            errorProvider.ClearErrors();

            if (string.IsNullOrEmpty(this.txtCName.Text.Trim()))
            {
                errorProvider.SetError(this.txtCName, "����Ϊ��", ErrorType.Warning);
            }
            return !errorProvider.HasErrors;
        }

        private void ComboxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validation();
        }

        private void TextEdit_TextChanged(object sender, EventArgs e)
        {
            Validation();
        }

        private void TextEdit_Enter(object sender, EventArgs e)
        {
            ((TextEdit)sender).SelectAll();
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (!(Validation())) return;

            if (!string.IsNullOrEmpty(recordInfo.Customer.Phone) && string.IsNullOrEmpty(newRecordInfo.Customer.Phone))
            {
                errorProvider.SetError(this.txtCPhone, "����Ϊ��", ErrorType.Warning);
                return;
            }

            try
            {
                
                var cNatureInfo = (BasicConstantInfo)this.cbCNature.SelectedItem;
                if (cNatureInfo != null)
                    newRecordInfo.Customer.Nature = cNatureInfo.Id;
                var regionInfo = (RegionInfo)this.cbRegion.SelectedItem;
                if (regionInfo != null)
                    newRecordInfo.Customer.RegionId = regionInfo.Id;

                newRecordInfo.Customer.ShopId = GlobalCaches.Instance.CurUser.ShopId;
                newRecordInfo.Customer.Type = "front";
                // �����customer�ɹ��󣬻����ǰcustomer ��Id
                if (newRecordInfo.Customer.Id == 0)
                    CustomerBusiness.Instance.AddCustomer(newRecordInfo.Customer);
                else
                    CustomerBusiness.Instance.UpdateCustomer(newRecordInfo.Customer);


                newRecordInfo.FrontRecord.Id = recordInfo.FrontRecord.Id;
                var levelInfo = (PurposeLevelInfo)this.cbCLevel.SelectedItem;
                if (levelInfo != null)
                    newRecordInfo.FrontRecord.LevelCode = levelInfo.Code;
                //var carLicenceInfo = (BasicConstantInfo)this.cbCarLicence.SelectedItem;
                //if (carLicenceInfo != null)
                //    newRecordInfo.FrontRecord.CarLicence = carLicenceInfo.Id;

                var selCarType = (CarTypeInfo)this.cbCarType.SelectedItem;
                if (selCarType != null)
                    newRecordInfo.FrontRecord.PurposeCar = selCarType.Id;
                var sourceInfo = (BasicConstantInfo)this.cbFrontSource.SelectedItem;
                if (sourceInfo != null)
                    newRecordInfo.FrontRecord.Source = sourceInfo.Id;
                if (this.rdDriveStatus.SelectedIndex > -1)
                    newRecordInfo.FrontRecord.DriveStatus = this.rdDriveStatus.SelectedIndex + 1;
                if (this.rdReplace.SelectedIndex > -1)
                    newRecordInfo.FrontRecord.Replace = this.rdReplace.SelectedIndex + 1;
                if (this.rdInstallment.SelectedIndex > -1)
                    newRecordInfo.FrontRecord.Installment = this.rdInstallment.SelectedIndex + 1;
               

                newRecordInfo.FrontRecord.CustomerNum = Convert.ToInt32(this.txtCNum.EditValue);
                newRecordInfo.FrontRecord.CustomerId = newRecordInfo.Customer.Id;
                newRecordInfo.FrontRecord.LeaveTime = DateTime.Now;
                TimeSpan durationTime = newRecordInfo.FrontRecord.LeaveTime.Value - newRecordInfo.FrontRecord.ArrivalTime.Value;
                newRecordInfo.FrontRecord.DurationTime = durationTime.ToString(@"hh\:mm\:ss");
                FrontRecordBusiness.Instance.UpdateFrontRecord(newRecordInfo.FrontRecord);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("����ʧ��,����ϵ����Ա����Ϣ���£�\r\n{0}", ex.Message), "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FmFrontOut_Load(object sender, EventArgs e)
        {
            BindQuestions();

        }

        private void txtCPhone_Leave(object sender, EventArgs e)
        {
            string phone = this.txtCPhone.Text.Trim();
            if (string.IsNullOrEmpty(phone))
            {
                if (!string.IsNullOrEmpty(recordInfo.Customer.Phone))
                    errorProvider.SetError(this.txtCPhone, "����Ϊ��", ErrorType.Warning);
                return;
            }
            // δ���޸ģ�����ѯ
            if (newRecordInfo.Customer.Phone == phone)
            {
                return;
            }

            var customers = CustomerBusiness.Instance.GetCustomers(new CustomerInfo() { ShopId = GlobalCaches.Instance.CurUser.ShopId, Phone = phone });
            CustomerInfo info = null;
            if (customers == null || customers.Count == 0)
                info = new CustomerInfo()
                {
                    Phone = phone,
                    Name = this.txtCName.Text.Trim(),
                    Industry = this.txtCIndustry.Text.Trim(),
                    Address = this.txtCAddress.Text.Trim()
                };
            else
                info = customers.FirstOrDefault();

            newRecordInfo.FrontRecord.CustomerId = info.Id;
            // ������� �ֻ��Ų�ѯ���Ĺ˿ʹ��� ��ȡ�˿͵ļ�¼����������� ��ȡ��ǰ��¼
            newRecordInfo.FrontRecord.Id = info.Id == 0 ? newRecordInfo.FrontRecord.Id : 0;
            newRecordInfo.Customer = info;

            this.txtCName.DataBindings.Clear();
            this.txtCPhone.DataBindings.Clear();
            this.txtCIndustry.DataBindings.Clear();
            this.txtCAddress.DataBindings.Clear();

            this.txtCName.DataBindings.Add("Text", info, "Name");
            this.txtCPhone.DataBindings.Add("Text", info, "Phone");
            this.txtCIndustry.DataBindings.Add("Text", info, "Industry");
            this.txtCAddress.DataBindings.Add("Text", info, "Address");
            this.cbCNature.SelectedIndex = info.Nature ?? 0;

            if (info.Id == 0)
                this.cbCNature.SelectedIndex = 0;
            else
                this.cbCNature.SelectedItem = GlobalCaches.Instance.ConstantInfos.FirstOrDefault(m => m.Id == info.Nature);
            if (info.RegionId == null)
                this.cbRegion.SelectedIndex = 0;
            else
                this.cbRegion.SelectedItem = GlobalCaches.Instance.RegionInfos.FirstOrDefault(m => m.Id == info.RegionId);

        }

        private void txtCPhone_TextChanged(object sender, EventArgs e)
        {
            errorProvider.ClearErrors();
        }

        private void BindQuestions()
        {
            var listQuestions = EvaluateQuestionBusiness.Instance.GetEvaluateQuestions();
            if (listQuestions == null || listQuestions.Count == 0)
            {
                this.ckListQuestions.DataSource = new EvaluateQuestionInfo() { QDesc = "������������" };
                return;
            }

            this.ckListQuestions.DataSource = listQuestions;
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            var lists = this.ckListQuestions.CheckedItems;
            if (lists == null || lists.Count == 0)
            {
                this.lblCLevel.Text = "O";
                this.txtLevelDesc.Text = "��ѡ������������ٵ�����";
                return;
            }
            
            List<EvaluateQuestionInfo> eqInfos = new List<EvaluateQuestionInfo>();
            foreach (EvaluateQuestionInfo info in lists)
            {
                eqInfos.Add(info);
            }
            this.lblCLevel.Text = "B";
            this.txtLevelDesc.Text = "��������ܸߵĿͻ�����Ҫ��ϸ΢���ػ���������ֵ���ٽ��ɽ�����Ʒ�������ȣ�";

            var cLevelInfo = customerLevels.FirstOrDefault(m => m.Code == "B");
            this.cbCLevel.SelectedItem = cLevelInfo;

        }

        private void rdDriveStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.rdDriveStatus.SelectedIndex == 0)//�Լ��û����������ֻ�����
            {
                string phone = this.txtCPhone.Text.Trim();
                if (string.IsNullOrEmpty(phone))
                {
                    errorProvider.SetError(this.txtCPhone, "�Լ��û����������ֻ�����", ErrorType.Warning);
                    return;
                }
            }
            else
            {
                errorProvider.ClearErrors();
            }
        }

        

    }
}
