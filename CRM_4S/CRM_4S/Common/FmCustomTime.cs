using CRM_4S.Common.FormBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRM_4S.Common
{
    public partial class FmCustomTime : FormSimpleDialogBase
    {
        public FmCustomTime()
        {
            InitializeComponent();

            this.Btn_OK.Click += BtnOK_Click;
        }

        void BtnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }


        public DateTime StartDate { get { return this.DateStart.DateTime; } set { this.DateStart.DateTime = value; } }
        public DateTime EndDate { get { return this.DateEnd.DateTime; } set { this.DateEnd.DateTime = value; } }

    }
}
