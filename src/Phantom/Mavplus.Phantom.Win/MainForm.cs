using Mavplus.Phantom.API;
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
    public partial class MainForm : Form
    {
        Properties.Settings settings = Properties.Settings.Default;
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            txtToken.Text = settings.AccessToken;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtToken.Text.Trim()))
                return;
            settings.AccessToken = txtToken.Text.Trim();
            settings.Save();

            PhantomAPI api = new PhantomAPI(PhantomConfiguration.Default);
            bool isOK = api.Ping();
            api.SetCredentials(settings.AccessToken);

            User user = api.GetUser();
            //api.RefreshToken();

            Bulb[] listBulbs = api.GetBulbs();
            Bulb bulb = api.GetBulb(listBulbs[0].Id);
            api.SetBulbSwitchOff(listBulbs[0].Id);
            api.SetBulbSwitchOn(listBulbs[0].Id);
            api.SetBulbTune(listBulbs[0].Id, 0.5F, 0.5F);

            Scenario[] listScenarios = api.GetScenarios();
            api.SetScenario(listScenarios[0].Id);
            api.SetScenarioAllOff();
            api.SetScenarioAllOn();
        }
    }
}
