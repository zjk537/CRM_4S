using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DemoApp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            RegDLL.RegClass reg = new RegDLL.RegClass(System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetAssembly(typeof(Form1)).Location).ToShortDateString());
            if (reg.MiStart_Infos() && reg.MiEnd_Infos())
            {
                Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(true);
                Application.Run(new Form1());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
