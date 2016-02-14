using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegLib;

namespace CRM_4S
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //if (RegUtil.Instance.RegStart() && RegUtil.Instance.RegEnd())
            //{
            //    Application.EnableVisualStyles();
            //    //Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new FmMain());
            //    //Application.Run(new Login());
            //}
            //else
            //{
            //    Application.Exit();
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FmMain());
            
        }
    }
}
