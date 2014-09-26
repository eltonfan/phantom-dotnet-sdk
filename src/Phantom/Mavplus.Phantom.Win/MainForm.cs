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
        readonly PhantomClient client = null;
        readonly Button[] scenarioButtons = null;
        readonly Button[] bulbButtons = null;
        public MainForm()
        {
            InitializeComponent();

            client = new PhantomClient();

            client.NewScenario += client_NewScenario;
            client.ScenarioRemoved += client_ScenarioRemoved;
            client.ScenarioStateChanged += client_ScenarioStateChanged;

            client.NewBulb += client_NewBulb;
            client.BulbRemoved += client_BulbRemoved;
            client.BulbStateChanged += client_BulbStateChanged;

            scenarioButtons = new Button[] {
                btnScenario0,
                btnScenario1,
                btnScenario2,
                btnScenario3,
                btnScenario4,
                btnScenario5,
                btnScenario6,
                btnScenario7,
            };
            foreach (Button btn in scenarioButtons)
                btn.Click += scenarioButton_Click;

            bulbButtons = new Button[] {
                btnBulb0,
                btnBulb1,
                btnBulb2,
                btnBulb3,
                btnBulb4,
                btnBulb5,
                btnBulb6,
                btnBulb7,
                btnBulb8,
                btnBulb9,
                btnBulb10,
                btnBulb11,
            };
            foreach (Button btn in bulbButtons)
                btn.Click += bulbButton_Click;

            btnCreateToken.Click += btnCreateToken_Click;
        }

        void btnCreateToken_Click(object sender, EventArgs e)
        {
            try
            {
                Token token = client.Login(txtUserName.Text.Trim(), txtPassword.Text);

                txtToken.Text = token.AccessToken;
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "获取令牌失败：" + ex.Message, "提示");
            }
        }
        void client_BulbStateChanged(object sender, BulbEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler<BulbEventArgs>(client_BulbStateChanged), sender, e);
                return;
            }
            foreach (Button btn in this.bulbButtons)
            {
                if (btn.Tag == e.Bulb)
                {
                    RefreshBulb(btn, e.Bulb);
                    break;
                }
            }
        }

        void client_BulbRemoved(object sender, BulbEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler<BulbEventArgs>(client_BulbRemoved), sender, e);
                return;
            }
            RefreshBulbs();
        }

        void client_NewBulb(object sender, BulbEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler<BulbEventArgs>(client_NewBulb), sender, e);
                return;
            }
            RefreshBulbs();
        }

        void client_ScenarioStateChanged(object sender, ScenarioEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler<ScenarioEventArgs>(client_ScenarioStateChanged), sender, e);
                return;
            }

            foreach (Button btn in this.scenarioButtons)
            {
                if (btn.Tag == e.Scenario)
                {
                    RefreshScenario(btn, e.Scenario);
                    break;
                }
            }
        }

        void client_ScenarioRemoved(object sender, ScenarioEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler<ScenarioEventArgs>(client_ScenarioRemoved), sender, e);
                return;
            }

            RefreshScenarios();
        }

        void client_NewScenario(object sender, ScenarioEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler<ScenarioEventArgs>(client_NewScenario), sender, e);
                return;
            }

            RefreshScenarios();
        }

        void scenarioButton_Click(object sender, EventArgs e)
        {
            Scenario item = (sender as Button).Tag as Scenario;
            if (item == null)
                return;

            client.SetScenario(item);
        }
        void bulbButton_Click(object sender, EventArgs e)
        {
            Bulb item = (sender as Button).Tag as Bulb;
            if (item == null)
                return;

            if (item.TurnedOn)
                item.TurnOff();
            else
                item.TurnOn();
        }

        void RefreshBulbs()
        {
            foreach (Button btn in bulbButtons)
            {
                btn.Visible = false;
                btn.Enabled = false;
                btn.Tag = null;
                btn.Text = "";
            }

            int index = 0;
            foreach (Bulb item in client.Bulbs)
            {
                if (index >= bulbButtons.Length)
                    break;
                RefreshBulb(bulbButtons[index], item);

                index++;
            }
        }

        void RefreshBulb(Button button, Bulb bulb)
        {
            button.Tag = bulb;
            button.Enabled = (bulb.Connectivity == "在线");
            button.Visible = true;
            button.Text = string.Format("{0}({1:0}%)", bulb.Name, bulb.Brightness * 100);
            button.Image = bulb.TurnedOn ? Properties.Resources.bulb_on_48 : Properties.Resources.bulb_off_48;
        }

        void RefreshScenarios()
        {
            foreach (Button btn in scenarioButtons)
            {
                btn.Visible = false;
                btn.Enabled = false;
                btn.Tag = null;
                btn.Text = "";
            }
            int index = 0;
            foreach (Scenario item in client.Scenarios)
            {
                if (index >= scenarioButtons.Length)
                    break;
                RefreshScenario(scenarioButtons[index], item);

                index++;
            }
        }
        void RefreshScenario(Button button, Scenario scenario)
        {
            button.Tag = scenario;
            button.Enabled = true;
            button.Visible = true;
            button.Text = scenario.Name;
            button.Image = Properties.Resources.switch_48;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RefreshScenarios();
            RefreshBulbs();

            txtToken.Text = settings.AccessToken;
            btnConnect.Click += btnConnect_Click;
        }

        void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtToken.Text.Trim()))
                return;
            settings.AccessToken = txtToken.Text.Trim();
            settings.Save();

            client.Connect(settings.AccessToken);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtToken.Text.Trim()))
                return;
            settings.AccessToken = txtToken.Text.Trim();
            settings.Save();

            PhantomClient.TestAPI(settings.AccessToken);
        }
    }
}
