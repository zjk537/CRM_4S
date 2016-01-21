using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_4S.Business;
using CRM_4S.Model.DataModel;

namespace CRM_4S
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IList<RoleInfo> roleList = RoleBusiness.Instance.GetRoles();

            this.label1.Text = roleList.ToString();
        }
    }
}
