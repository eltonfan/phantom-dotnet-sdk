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
            //txtPassword.Text = "";
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
            settings.Save();

            Token token = client.Login(userName, password);
            if(token == null)
            {
                MessageBox.Show(this, "登录失败，token == null。", "登录失败");
                return;
            }
            settings.AccessToken = token.AccessToken;
            settings.Save();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
