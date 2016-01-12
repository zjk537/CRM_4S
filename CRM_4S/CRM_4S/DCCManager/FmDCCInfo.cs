using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRM_4S.DCCManager
{
    public partial class FmDCCInfo : Form
    {
        public FmDCCInfo()
        {
            InitializeComponent();
            initView();
        }

        private void initView()
        {
            cbCustomerNature.Properties.Items.AddRange(GloableConstants.CustomerNature);
            cbCustomerLevel.Properties.Items.AddRange(GloableConstants.CustomerLevel);
            cbCarBrand.Properties.Items.AddRange(GloableConstants.CarBrand);
            cbCarType.Properties.Items.AddRange(GloableCaches.Instance.CarTypes);
            cbDCCStatus.Properties.Items.AddRange(GloableConstants.BooleanDesc);
            cbDCCSource.Properties.Items.AddRange(GloableConstants.DCCSource);
        }
    }
}
