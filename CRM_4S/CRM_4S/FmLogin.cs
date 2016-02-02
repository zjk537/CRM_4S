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
using DevExpress.XtraEditors.DXErrorProvider;
using System.Threading;
using System.Runtime.Remoting.Messaging;
using DevExpress.XtraEditors;

namespace CRM_4S
{
    public partial class FmLogin : Form
    {
        private ManualResetEvent waitMdiInitializeHandler = null;
        public ManualResetEvent waitLoginHandler = new ManualResetEvent(false);
        private delegate void LoginHandler();
        public delegate void SetDialogResultHandler(DialogResult dialogResult);
        public event SetDialogResultHandler SetDialogResult;


        public FmLogin(ManualResetEvent waitMdiInitializeHandler)
        {
            InitializeComponent();
            this.waitMdiInitializeHandler = waitMdiInitializeHandler;
            initForm();
        }


        private void initForm()
        {
            this.TopMost = true;
            this.ShowInTaskbar = true;
        }

        private void LoginCallBack(IAsyncResult ar)
        {
            try
            {
                ((LoginHandler)((AsyncResult)ar).AsyncDelegate).EndInvoke(ar);
            }
            catch
            {

            }
        }
        private void Login()
        {
            EndLogin(DialogResult.OK);
        }

        private void EndLogin(DialogResult dialogResult)
        {
            try
            {
                //֪ͨMain�����¼���
                if (SetDialogResult != null)
                {
                    SetDialogResult(dialogResult);
                }

                //�ͷ�Main�����ʼ���ź�
                waitMdiInitializeHandler.Set();
                //�ȴ�Main�����ʼ�����
                waitLoginHandler.WaitOne();

                //���ص�¼��������ͷŵ�¼����
                this.DialogResult = dialogResult;
            }
            catch (Exception e)
            {

            }

        }

        private bool Validation()
        {
            errorProvider.ClearErrors();

            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                errorProvider.SetError(txtUserName, "�û�������Ϊ��", ErrorType.Warning);
            }

            if (string.IsNullOrEmpty(txtPwd.Text.Trim()))
            {
                errorProvider.SetError(txtPwd, "���벻��Ϊ��", ErrorType.Warning);
            }

            return errorProvider.HasErrors;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Validation())
            {
                UserInfo user = UserBusiness.Instance.GetUserByName(this.txtUserName.Text.Trim(), this.txtPwd.Text.Trim());
                if (user == null)
                {
                    XtraMessageBox.Show("�û��������벻��ȷ�����������룡");
                    return;
                }

                GloablCaches.Instance.CurUser = user;

                new LoginHandler(Login).BeginInvoke(new AsyncCallback(LoginCallBack), null);
            }
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            EndLogin(DialogResult.Cancel);
        }

        private void FmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.btnCanel.PerformClick();
        }

        private void TextEdit_TextChanged(object sender, EventArgs e)
        {
            Validation();
        }
    }
}
