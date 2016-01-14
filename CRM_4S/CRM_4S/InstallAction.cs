using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace CRM_4S
{
    [RunInstaller(true)]
    public partial class InstallAction : Installer
    {
        public InstallAction()
        {
            InitializeComponent();
        }

        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);

            try
            {
                string physicalRoot = this.Context.Parameters["targetdir"]; // 安装物理路径

                try
                {
                    //由于执行Register.bat文件的时候，gacutil.exe会以System目录作为起始目录，
                    //因此在Bat文件中设置一个参数，安装的时候替换为具体的目录
                    string Register = Path.Combine(physicalRoot, "Register.bat");
                    ReplaceName(Register, "{INSTALL_PATH}", physicalRoot);
                }
                catch { }

                string registerFile = Path.Combine(physicalRoot, "Register.bat");
                RunDos(registerFile, "", false);
            }
            catch (Exception ex)
            {
                //WriteLog(ex.ToString());
            }
        }

        /// <summary>
        /// 在运行脚本之前把脚本中的指定名称替换成新的名词
        /// </summary>
        /// <param name="filePath">脚本文件名</param>
        /// <param name="oldDBName">原有的名称</param>
        /// <param name="newDBName">新的名称</param>
        private void ReplaceName(string filePath, string oldName, string newName)
        {
            if (newName.CompareTo(oldName) != 0)
            {
                string fileText = string.Empty;
                using (StreamReader streamReader = new StreamReader(filePath, Encoding.Default))
                {
                    fileText = streamReader.ReadToEnd();
                    fileText = fileText.Replace(oldName, newName);
                }

                using (StreamWriter streamWriter = new StreamWriter(filePath, false, Encoding.Default))
                {
                    streamWriter.Write(fileText);
                }
            }
        }

        /// <summary>
        /// 后台执行DOS文件
        /// </summary>
        /// <param name="fileName">文件名(包含路径)</param>
        /// <param name="argument">运行参数</param>
        /// <param name="hidden">是否隐藏窗口</param>
        private void RunDos(string fileName, string argument, bool hidden)
        {
            Process process = new Process();
            process.EnableRaisingEvents = false;
            process.StartInfo.FileName = string.Format("\"{0}\"", fileName);
            process.StartInfo.Arguments = argument;
            if (hidden)
            {
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            }
            else
            {
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            }
            process.Start();
            process.WaitForExit();
        }
    }
}