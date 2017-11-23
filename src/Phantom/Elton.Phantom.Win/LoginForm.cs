// Coded by chuangen http://chuangen.name.

using Elton.Phantom.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elton.Phantom.Win
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class LoginForm : Form
    {
        static readonly Common.Logging.ILog log = Common.Logging.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        Properties.Settings settings = Properties.Settings.Default;
        readonly PhantomClient client = null;
        readonly string urlString = null;
        public LoginForm(PhantomClient client, string urlString)
        {
            this.client = client;
            this.urlString = urlString;
            InitializeComponent();

            webBrowser.ObjectForScripting = this;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            webBrowser.Navigate(urlString);
        }

        public void OnFinished()
        {
            this.DialogResult = DialogResult.OK;
        }

        public void OnError()
        {
            //
        }
    }
}
