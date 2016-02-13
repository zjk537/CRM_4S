using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegLib
{
    public partial class FmReg : Form
    {
        public FmReg()
        {
            InitializeComponent();
        }

        private string regNum = string.Empty;
        public string RegNum
        {
            get
            {
                return this.regNum;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtRegNum.Text.Trim().Length != 24)
            {
                MessageBox.Show("注册码格式不正确!");
                return;
            }

            if (!string.IsNullOrEmpty(this.txtRegNum.Text.Trim()))
            {
                this.regNum = this.txtRegNum.Text.Trim();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
