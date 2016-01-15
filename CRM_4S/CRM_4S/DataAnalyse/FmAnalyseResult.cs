using RibbonSkin.Common.FormBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRM_4S.DataAnalyse
{
    public partial class FmAnalyseResult : FormSimpleDialogBase
    {
        public FmAnalyseResult()
        {
            InitializeComponent();
        }

        private void FmGroupResult_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
