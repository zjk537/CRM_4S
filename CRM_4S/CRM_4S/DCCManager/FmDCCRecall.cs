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
        public FmDCCRecall(DCCCustomerRecordInfo info)
        {
            InitializeComponent();
            initForm(info);
            DCCRecordBusiness.Instance.OnDataChanged += new EventHandler<CusEventArgs>((object sender, CusEventArgs args) => { RefreshDCCRecordView(newRecordInfo.DCCRecord); });
        }

        private void initForm(DCCCustomerRecordInfo info)
        {
            DCCRecordInfo dccInfo = new DCCRecordInfo();
            CustomerInfo customerInfo = new CustomerInfo();
            DBModelBase.Clone<DCCRecordInfo>(info.DCCRecord, ref dccInfo);
            DBModelBase.Clone<CustomerInfo>(info.Customer, ref customerInfo);
            newRecordInfo.Customer = customerInfo;
            newRecordInfo.DCCRecord = dccInfo;
            recordInfo = info;

            this.Btn_OK.Visible = false;

            this.txtCName.DataBindings.Add("Text", customerInfo, "Name");
            this.txtCPhone.DataBindings.Add("Text", customerInfo, "Phone");
            this.txtCIndustry.DataBindings.Add("Text", customerInfo, "Industry");
            this.txtCAddress.DataBindings.Add("Text", customerInfo, "Address");
            purposeLevels = PurposeLevelBusiness.Instance.GetPurposeLevels();
            this.cbCLevel.Properties.Items.AddRange(purposeLevels.ToArray());
            this.cbCNature.Properties.Items.AddRange(GloablCaches.Instance.ConstantInfos.Where(e => e.TypeValue == (int)BasicConstantType.CNature).ToArray());
            //this.cbCLevel.SelectedItem = purposeLevels.FirstOrDefault(e => e.Code == customerInfo.);
            this.cbCNature.SelectedIndex = customerInfo.Nature ?? 0;

            this.cbDCCSource.Properties.Items.AddRange(GloablCaches.Instance.ConstantInfos.Where(e => e.TypeValue == (int)BasicConstantType.DCCSource).ToArray());
            this.cbDCCStatus.Properties.Items.AddRange(GloablCaches.Instance.ConstantInfos.Where(e => e.TypeValue == (int)BasicConstantType.DCCStatus).ToArray());
            this.cbCarType.Properties.Items.AddRange(GloablCaches.Instance.CarTypes);
            this.cbIsLogin.Properties.Items.AddRange(GloablConstants.BooleanDesc);
            this.cbToShop.Properties.Items.AddRange(GloablConstants.BooleanDesc);
            this.cbRecaller.Properties.Items.AddRange(GloablCaches.Instance.ConsultantInfos);
            this.cbDCCSource.SelectedIndex = dccInfo.Source ?? 0;
            this.cbDCCStatus.SelectedIndex = dccInfo.Status ?? 0;
            this.cbCarType.SelectedItem = GloablCaches.Instance.CarTypes.FirstOrDefault(e => e.Id == dccInfo.PurposeCar);
            this.cbIsLogin.SelectedIndex = dccInfo.IsLogin ?? 0;
            this.cbToShop.SelectedIndex = dccInfo.ToShop ?? 0;
            this.cbRecaller.SelectedItem = GloablCaches.Instance.ConsultantInfos.FirstOrDefault(e => e.Id == dccInfo.DCCRecallerId);
            this.dtToShopTime.EditValue = dccInfo.ToShopTime ?? DateTime.Now.AddDays(7);
            this.dtRecallTime.EditValue = dccInfo.RecallTime ?? DateTime.Now;
            this.txtRemark.DataBindings.Add("Text", dccInfo, "RecallDesc");

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

            if (!string.IsNullOrEmpty(recordInfo.Customer.Phone) && string.IsNullOrEmpty(newRecordInfo.Customer.Phone))
            {
                errorProvider.SetError(this.txtCPhone, "不能为空", ErrorType.Warning);
                return;
            }

            try
            {
                newRecordInfo.Customer.IdSpecify = true;
                //newRecordInfo.Customer.LevelCode = this.cbCLevel.SelectedText;
                newRecordInfo.Customer.Nature = this.cbCNature.SelectedIndex;
                CustomerBusiness.Instance.UpdateCustomer(newRecordInfo.Customer);

                newRecordInfo.DCCRecord.IdSpecify = true;
                newRecordInfo.DCCRecord.Source = this.cbDCCSource.SelectedIndex;
                newRecordInfo.DCCRecord.Status = this.cbDCCStatus.SelectedIndex;
                newRecordInfo.DCCRecord.PurposeCar = ((CarTypeInfo)this.cbCarType.SelectedItem).Id;
                newRecordInfo.DCCRecord.IsLogin = this.cbIsLogin.SelectedIndex;
                newRecordInfo.DCCRecord.ToShop = this.cbToShop.SelectedIndex;
                newRecordInfo.DCCRecord.ToShopTime = (DateTime)this.dtToShopTime.EditValue;
                newRecordInfo.DCCRecord.RecallTime = (DateTime)this.dtRecallTime.EditValue;
                newRecordInfo.DCCUser = (UserInfo)this.cbRecaller.SelectedItem;
                TimeSpan durationTime = newRecordInfo.DCCRecord.RecallTime.Value - newRecordInfo.DCCRecord.VisitTime.Value;
                newRecordInfo.DCCRecord.DurationTime = durationTime.ToString(@"hh\:mm\:ss");
                DCCRecordBusiness.Instance.UpdateDCCRecord(newRecordInfo.DCCRecord);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("保存失败,请联系管理员，信息如下：\r\n{0}", ex.Message), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void RefreshDCCRecordView(DCCRecordInfo recordInfo)
        {
            var listResult = DCCRecordBusiness.Instance.GetDCCCustomerRecords(recordInfo.ShopId, recordInfo.CustomerId);
            gridControlDCCRecord.DataSource = listResult;
            gridControlDCCRecord.DefaultView.RefreshData();
        }

        private void defaultGridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            if (e.Column.Name == "clmDCCSource")
            {
                e.DisplayText = e.CellValue == null ? "" : GloablCaches.Instance.ConstantInfos.FirstOrDefault(info => info.Id == (int)e.CellValue).Name;
                return;
            }

            if (e.Column.Name == "clmPurposeCar")
            {
                e.DisplayText = e.CellValue == null ? "" : GloablCaches.Instance.CarTypes.FirstOrDefault(t => t.Id == (int)e.CellValue).ToString();
                return;
            }

            if (e.Column.Name == "clmToShop")
            {
                e.DisplayText = e.CellValue == null ? "" : GloablConstants.BooleanDesc[(int)e.CellValue];
                return;
            }

            if (e.Column.Name == "clmDCCStatus")
            {
                e.DisplayText = e.CellValue == null ? "" : GloablCaches.Instance.ConstantInfos.FirstOrDefault(info => info.Id == (int)e.CellValue).Name;
                return;
            }

            if (e.Column.Name == "clmIsLogin")
            {
                e.DisplayText = e.CellValue == null ? "" : GloablConstants.BooleanDesc[(int)e.CellValue];
                return;
            }

            if (e.Column.Name == "clmRecallerName")
            {
                e.DisplayText = e.CellValue == null ? "" : GloablCaches.Instance.ConsultantInfos.FirstOrDefault(t => t.Id == (int)e.CellValue).ToString();
            }
        }

        private void FmDCCRecall_Load(object sender, EventArgs e)
        {
            BindQuestions();
            RefreshDCCRecordView(recordInfo.DCCRecord);
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

            var customers = CustomerBusiness.Instance.GetCustomers(new CustomerInfo() { ShopId = GloablCaches.Instance.CurUser.ShopId, Phone = phone });
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

            newRecordInfo.Customer = info;
            newRecordInfo.DCCRecord.CustomerId = info.Id;
            // 如果根据 手机号查询出的顾客存在 就取顾客的记录，如果不存在 就取当前记录
            newRecordInfo.DCCRecord.Id = info.Id == 0 ? newRecordInfo.DCCRecord.Id : 0;

            this.txtCName.DataBindings.Clear();
            this.txtCPhone.DataBindings.Clear();
            this.txtCIndustry.DataBindings.Clear();
            this.txtCAddress.DataBindings.Clear();

            this.txtCName.DataBindings.Add("Text", info, "Name");
            this.txtCPhone.DataBindings.Add("Text", info, "Phone");
            this.txtCIndustry.DataBindings.Add("Text", info, "Industry");
            this.txtCAddress.DataBindings.Add("Text", info, "Address");
            //this.cbCLevel.SelectedItem = purposeLevels.FirstOrDefault(obj => obj.Code == info.LevelCode);
            this.cbCNature.SelectedIndex = info.Nature ?? 0;

            RefreshDCCRecordView(newRecordInfo.DCCRecord);
        }

        private void BindQuestions()
        {

            var listQuestions = EvaluateQuestionBusiness.Instance.GetEvaluateQuestions();
            if (listQuestions == null || listQuestions.Count == 0)
            {
                this.ckListQuestions.DataSource = new EvaluateQuestionInfo() { QDesc = "暂无评估问题" };
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
                this.txtLevelDesc.Text = "请选择评估问题后再点评估";
                return;
            }
            List<EvaluateQuestionInfo> eqInfos = new List<EvaluateQuestionInfo>();
            foreach (EvaluateQuestionInfo info in lists)
            {
                eqInfos.Add(info);
            }
            this.lblCLevel.Text = "B";
            this.txtLevelDesc.Text = "购买意向很高的客户，需要在细微处关怀提升期望值，促进成交（精品、保养等）";

        }
    }
}
