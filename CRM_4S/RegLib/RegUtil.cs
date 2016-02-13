using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RegLib
{
    public class RegUtil
    {
        // Fields
        private string lastDate = "";
        private string pathDate = (Application.StartupPath + @"\Enc.k");
        private string pathRegDate = (Application.StartupPath + @"\Engi.p");
        private string rpx = "pPpPp";

        private static RegUtil instance = null;
        public static RegUtil Instance
        {
            get
            {
                if (instance == null)
                    instance = new RegUtil();
                return instance;
            }
        }
        // Methods
        private RegUtil()
        {
            this.lastDate = System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetAssembly(typeof(RegUtil)).Location).ToShortDateString();
        }

        private static string Decrypt(string MiWen, string KeyString)
        {
            byte[] inputBuffer = Convert.FromBase64String(MiWen);
            byte[] bytes = Encoding.Default.GetBytes(KeyString);
            TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
            provider.Key = MakeMD5(bytes);
            provider.Mode = CipherMode.ECB;
            return Encoding.Default.GetString(provider.CreateDecryptor().TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
        }

        private static string Encrypt(string MingWen, string KeyString)
        {
            byte[] bytes = Encoding.Default.GetBytes(MingWen);
            byte[] original = Encoding.Default.GetBytes(KeyString);
            TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
            provider.Key = MakeMD5(original);
            provider.Mode = CipherMode.ECB;
            return Convert.ToBase64String(provider.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length));
        }

        private static byte[] MakeMD5(byte[] original)
        {
            byte[] buffer = new MD5CryptoServiceProvider().ComputeHash(original);
            return buffer;
        }

        public bool RegEnd()
        {
            DateTime time;
            FmReg fmReg = new FmReg();
            if (!File.Exists(this.pathRegDate))
            {
                this.ShowMsg("缺少系统文件，程序无法运行，请联系管理员！");
                return false;
            }
            if (string.IsNullOrEmpty(File.ReadAllText(this.pathRegDate, Encoding.Default)))
            {
                if (fmReg.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }
                if (!DateTime.TryParse(Decrypt(fmReg.RegNum, this.rpx), out time))
                {
                    this.ShowMsg("注册码不正确！");
                    return false;
                }
                File.WriteAllText(this.pathRegDate, fmReg.RegNum);
                if ((DateTime.Compare(DateTime.Now.Date, DateTime.Parse(this.lastDate)) < 0) 
                    || (DateTime.Compare(DateTime.Now.Date, DateTime.Parse(Decrypt(fmReg.RegNum, this.rpx))) > 0))
                {
                    this.ShowMsg("注册码无效或已经过期！");
                    return false;
                }
            }
            else if ((DateTime.Compare(DateTime.Now.Date, DateTime.Parse(this.lastDate)) < 0) 
                || (DateTime.Compare(DateTime.Now.Date, DateTime.Parse(Decrypt(File.ReadAllText(this.pathRegDate, Encoding.Default), this.rpx))) > 0))
            {
                if (fmReg.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }
                if (!DateTime.TryParse(Decrypt(fmReg.RegNum, this.rpx), out time))
                {
                    this.ShowMsg("注册码不正确！");
                    return false;
                }
                File.WriteAllText(this.pathRegDate, fmReg.RegNum);
                if ((DateTime.Compare(DateTime.Now.Date, DateTime.Parse(this.lastDate)) < 0) 
                    || (DateTime.Compare(DateTime.Now.Date, DateTime.Parse(Decrypt(fmReg.RegNum, this.rpx))) > 0))
                {
                    this.ShowMsg("注册码无效或已经过期！");
                    return false;
                }
            }
            return true;
        }

        public bool RegStart()
        {
            if (!File.Exists(this.pathDate))
            {
                this.ShowMsg("缺少系统文件，程序无法运行，请联系管理员");
                return false;
            }
            if (string.IsNullOrEmpty(File.ReadAllText(this.pathDate, Encoding.Default)))
            {
                File.WriteAllText(this.pathDate, Encrypt(this.lastDate, this.rpx));
            }
            else
            {
                if (DateTime.Compare(DateTime.Parse(Decrypt(File.ReadAllText(this.pathDate, Encoding.Default), this.rpx)), DateTime.Now.Date) > 0)
                {
                    this.ShowMsg("您的系统时间设置错误！");
                    return false;
                }
                File.WriteAllText(this.pathDate, Encrypt(DateTime.Now.ToShortDateString(), this.rpx));
                this.lastDate = DateTime.Now.ToShortDateString();
            }
            return true;
        }

        private void ShowMsg(string msg)
        {
            MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private bool ShowMsgReturn(string msg)
        {
            return (MessageBox.Show(msg, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }
    }


}
