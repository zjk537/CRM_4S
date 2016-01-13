using RibbonSkin.Common.FormBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRM_4S.FrontManager
{
    public partial class FmFrontEvaluate : FormSimpleDialogBase
    {
        public FmFrontEvaluate()
        {
            InitializeComponent();
        }

        private void FmEvaluate_Load(object sender, EventArgs e)
        {
            lblLevelDesc.Text = "预计 15 天购买；\r\n回访周期;\r\n需要有好的价格支持;";
        }
    }
}
