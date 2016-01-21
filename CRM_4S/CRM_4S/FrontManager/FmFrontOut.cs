using CRM_4S.Business;
using CRM_4S.Common.FormBase;
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
    public partial class FmFrontOut : FormSimpleDialogBase
    {
        public FmFrontOut()
        {
            InitializeComponent();
            initView();
        }

        private void initView()
        {
            cbCustomerNature.Properties.Items.AddRange(GloableConstants.CustomerNature);
            cbCustomerLevel.Properties.Items.AddRange(GloableConstants.CustomerLevel);
            cbDriveStatus.Properties.Items.AddRange(GloableConstants.BooleanDesc);
            cbCarLicence.Properties.Items.AddRange(GloableConstants.CarLicence);
            cbCarBrand.Properties.Items.AddRange(GloableConstants.CarBrands);
            cbCarType.Properties.Items.AddRange(GloableCaches.Instance.CarTypes);

        }
    }
}
