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
    public partial class FmShopInfo : FormSimpleDialogBase
    {
        ShopInfo shopInfo = null;

        ShopInfo newShopInfo = new ShopInfo();
        public FmShopInfo(ShopInfo shop = null)
        {
            InitializeComponent();
            initForm(shop);
        }

        private bool IsNew { get { return shopInfo == null; } }

        private void initForm(ShopInfo shop)
        {
            if (shop != null)
            {
                DBModelBase.Clone<ShopInfo>(shop, ref newShopInfo);
                shopInfo = shop;
            }

            this.Text += IsNew ? "-添加" : "-修改";
            this.Btn_OK.Click += Btn_OK_Click;

            txtAddress.DataBindings.Add("Text", newShopInfo, "Address");//newShopInfo.Address
            txtName.DataBindings.Add("Text", newShopInfo, "Name");//newShopInfo.Name
            txtPhone.DataBindings.Add("Text", newShopInfo, "Phone");//newShopInfo.Phone
            txtDesc.DataBindings.Add("Text", newShopInfo, "Desc"); //newShopInfo.Desc;
            cbRegion.Properties.Items.AddRange(GloablCaches.Instance.RegionInfos);
            cbRegion.SelectedItem = GloablCaches.Instance.RegionInfos.FirstOrDefault(e => e.Id == newShopInfo.RegionId);
        }

        void Btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation()) return;

                RegionInfo region = (RegionInfo)cbRegion.SelectedItem;
                if (IsNew || newShopInfo.RegionId != region.Id)
                {
                    newShopInfo.RegionId = region.Id;
                }

                if (!newShopInfo.Equals(shopInfo))
                {
                    if (IsNew)
                    {
                        ShopBusiness.Instance.AddShop(newShopInfo);
                    }
                    else
                    {
                        newShopInfo.Id = shopInfo.Id;
                        ShopBusiness.Instance.UpdateShop(newShopInfo);
                    }

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (XtraMessageBox.Show("店面信息无更新，继续编辑请点击Y退出点击N", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
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

            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                errorProvider.SetError(this.txtName, "不能为空", ErrorType.Warning);
            }

            if (string.IsNullOrEmpty(this.txtPhone.Text.Trim()))
            {
                errorProvider.SetError(this.txtPhone, "不能为空", ErrorType.Warning);
            }


            if (string.IsNullOrEmpty(this.txtAddress.Text.Trim()))
            {
                errorProvider.SetError(this.txtAddress, "不能为空", ErrorType.Warning);
            }

            return !errorProvider.HasErrors;
        }

        private void TextEdit_Enter(object sender, EventArgs e)
        {
            Validation();
        }

        private void Combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validation();
        }
    }
}
