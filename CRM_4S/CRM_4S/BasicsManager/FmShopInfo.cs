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

            this.Text += IsNew ? "-���" : "-�޸�";
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
                    if (XtraMessageBox.Show("������Ϣ�޸��£������༭����Y�˳����N", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
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

            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                errorProvider.SetError(this.txtName, "����Ϊ��", ErrorType.Warning);
            }

            if (string.IsNullOrEmpty(this.txtPhone.Text.Trim()))
            {
                errorProvider.SetError(this.txtPhone, "����Ϊ��", ErrorType.Warning);
            }


            if (string.IsNullOrEmpty(this.txtAddress.Text.Trim()))
            {
                errorProvider.SetError(this.txtAddress, "����Ϊ��", ErrorType.Warning);
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
