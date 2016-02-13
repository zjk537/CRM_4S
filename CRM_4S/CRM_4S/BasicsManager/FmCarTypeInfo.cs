using CRM_4S.Business;
using CRM_4S.Common.FormBase;
using CRM_4S.Model;
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

            this.Text += IsNew ? "-新增" : "-修改";
            this.Btn_OK.Click += Btn_OK_Click;

            cbCarBrand.Properties.Items.AddRange(GlobalCaches.Instance.ConstantInfos.Where(e => e.TypeValue == (int)BasicConstantType.CarBrand).ToArray());
            txtCarType.DataBindings.Add("Text", newCarTypeInfo, "Name");
            txtDesc.DataBindings.Add("Text", newCarTypeInfo, "Desc");
            cbCarBrand.SelectedItem = GlobalCaches.Instance.ConstantInfos.FirstOrDefault(e => e.TypeValue == newCarTypeInfo.BrandId);
        }

        void Btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation()) return;

                BasicConstantInfo carBrandInfo = (BasicConstantInfo)cbCarBrand.SelectedItem;
                if (IsNew || newCarTypeInfo.BrandId != carBrandInfo.Id)
                {
                    newCarTypeInfo.BrandId = carBrandInfo.Id;
                    newCarTypeInfo.Brand = carBrandInfo.Name;
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
                    if (XtraMessageBox.Show("汽车类型无更新，继续编辑请点击Y退出点击N", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
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

            if (string.IsNullOrEmpty(this.cbCarBrand.SelectedText.Trim()))
            {
                errorProvider.SetError(this.cbCarBrand, "不能为空", ErrorType.Warning);
            }
            if (string.IsNullOrEmpty(this.txtCarType.Text.Trim()))
            {
                errorProvider.SetError(this.txtCarType, "不能为空", ErrorType.Warning);
            }
            return !errorProvider.HasErrors;
        }

    }
}
