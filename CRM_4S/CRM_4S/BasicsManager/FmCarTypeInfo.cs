using CRM_4S.Business;
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

namespace CRM_4S.BasicsManager
{
    public partial class FmCarTypeInfo : FormSimpleDialogBase
    {
        CarTypeInfo carTypeInfo = null;

        CarTypeInfo newCarTypeInfo = new CarTypeInfo();
        public FmCarTypeInfo(CarTypeInfo info = null)
        {
            InitializeComponent();
            initForm(info);
        }

        private bool IsNew { get { return carTypeInfo == null; } }
        private void initForm(CarTypeInfo info)
        {
            if (info != null)
            {
                DBModelBase.Clone<CarTypeInfo>(info, ref newCarTypeInfo);
                carTypeInfo = info;
            }

            this.Text += IsNew ? "-����" : "-�޸�";
            this.Btn_OK.Click += Btn_OK_Click;

            cbCarBrand.Properties.Items.AddRange(GloablConstants.CarBrands);
            txtCarType.DataBindings.Add("Text", newCarTypeInfo, "Name");
            txtDesc.DataBindings.Add("Text", newCarTypeInfo, "Desc");

            int brandIndex = IsNew ? 0 : GloablConstants.CarBrands.IndexOf(newCarTypeInfo.Brand);
            cbCarBrand.SelectedIndex = brandIndex;
        }

        void Btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation()) return;

                if (newCarTypeInfo.Brand != cbCarBrand.SelectedItem.ToString())
                {
                    newCarTypeInfo.Brand = cbCarBrand.SelectedItem.ToString() ;
                }

                if (!newCarTypeInfo.Equals(carTypeInfo))
                {
                    if (IsNew)
                    {
                        CarTypeBusiness.Instance.AddCarType(newCarTypeInfo);
                    }
                    else
                    {
                        newCarTypeInfo.Id = carTypeInfo.Id;
                        CarTypeBusiness.Instance.UpdateCarType(newCarTypeInfo);
                    }

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (XtraMessageBox.Show("���������޸��£������༭����Y�˳����N", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
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

            if (string.IsNullOrEmpty(this.txtCarType.Text.Trim()))
            {
                errorProvider.SetError(this.txtCarType, "����Ϊ��", ErrorType.Warning);
            }

            if (string.IsNullOrEmpty(this.txtDesc.Text.Trim()))
            {
                errorProvider.SetError(this.txtDesc, "����Ϊ��", ErrorType.Warning);
            }
            return !errorProvider.HasErrors;
        }

    }
}
