// Coded by chuangen http://chuangen.name.

using Mavplus.Phantom.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mavplus.Phantom.Win
{
    public partial class LoginForm : Form
    {
        static readonly Common.Logging.ILog log = Common.Logging.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        Properties.Settings settings = Properties.Settings.Default;
        readonly PhantomClient client = null;
        public LoginForm(PhantomClient client)
        {
            this.client = client;
            InitializeComponent();

            btnOK.Click += btnOK_Click;
        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            txtUserName.Text = settings.UserName;
            chkRememberPassword.Checked = settings.RememberPassword;
            if(settings.RememberPassword)
                txtPassword.Text = settings.LoginPassword;

            txtPassword.Focus();
        }


        void btnOK_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            if(string.IsNullOrEmpty(userName))
            {
                MessageBox.Show(this, "用户名不能为空。", "提示");
                return;
            }
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show(this, "密码不能为空。", "提示");
                return;
            }
            settings.UserName = userName;
            settings.RememberPassword = chkRememberPassword.Checked;
            settings.LoginPassword = settings.RememberPassword ? password : "";
            settings.Save();

            Token token = null;
            try
            {
                token = client.Login(userName, password);
                if (token == null)
                {
                    MessageBox.Show(this, "登录失败，token == null。", "登录失败");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "登录失败，" + ex.Message, "登录失败");
                return;
            }
            settings.AccessToken = token.AccessToken;
            settings.RefreshToken = token.RefreshToken;
            settings.Save();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
