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
    public partial class FmPurposeLevelInfo : FormSimpleDialogBase
    {
        PurposeLevelInfo levelInfo = null;

        PurposeLevelInfo newLevelInfo = new PurposeLevelInfo();
        public FmPurposeLevelInfo(PurposeLevelInfo info = null)
        {
            InitializeComponent();
            initForm(info);
        }

        private bool IsNew { get { return levelInfo == null; } }
        private void initForm(PurposeLevelInfo info)
        {
            if (info != null)
            {
                DBModelBase.Clone<PurposeLevelInfo>(info, ref newLevelInfo);
                levelInfo = info;
            }

            this.Text += IsNew ? "-新增" : "-修改";
            this.Btn_OK.Click += Btn_OK_Click;

            txtCode.DataBindings.Add("Text", newLevelInfo, "Code");//newLevelInfo.Code
            txtDesc.DataBindings.Add("Text", newLevelInfo, "Desc"); //newLevelInfo.Desc;
        }

        void Btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation()) return;

                if (!newLevelInfo.Equals(levelInfo))
                {
                    if (IsNew)
                    {
                        PurposeLevelBusiness.Instance.AddPurposeLevel(newLevelInfo);
                    }
                    else
                    {
                        newLevelInfo.Id = levelInfo.Id;
                        PurposeLevelBusiness.Instance.UpdatePurposeLevel(newLevelInfo);
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

            if (string.IsNullOrEmpty(this.txtCode.Text.Trim()))
            {
                errorProvider.SetError(this.txtCode, "不能为空", ErrorType.Warning);
            }

            return !errorProvider.HasErrors;
        }
        
    }
}
