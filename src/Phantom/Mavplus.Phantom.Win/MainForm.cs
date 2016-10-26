// Coded by chuangen http://chuangen.name.

using Mavplus.Phantom.API;
using Mavplus.Phantom.Models;
using Mavplus.Phantom.Win.Controls;
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
        static readonly Common.Logging.ILog log = Common.Logging.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        Properties.Settings settings = Properties.Settings.Default;
        readonly PhantomClient client = null;
        readonly Button[] scenarioButtons = null;
        readonly BulbView[] bulbViews = null;
        public MainForm()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            client = new PhantomClient();

            client.NewScenario += client_NewScenario;
            client.ScenarioRemoved += client_ScenarioRemoved;
            client.ScenarioStateChanged += client_ScenarioStateChanged;

            client.NewBulb += client_NewBulb;
            client.BulbRemoved += client_BulbRemoved;

            scenarioButtons = new Button[] {
                btnScenario0,
                btnScenario1,
                btnScenario2,
                btnScenario3,
                btnScenario4,
                btnScenario5,
                btnScenario6,
                btnScenario7,
                btnScenario8,
                btnScenario9,
                btnScenario10,
                btnScenario11,
                btnScenario12,
                btnScenario13,
                btnScenario14,
                btnScenario15,
                btnScenario16,
                btnScenario17,
                btnScenario18,
                btnScenario19,
            };
            foreach (Button btn in scenarioButtons)
                btn.Click += scenarioButton_Click;

            bulbViews = new BulbView[] {
                bulbView1,
                bulbView2,
                bulbView3,
                bulbView4,
                bulbView5,
                bulbView6,
                bulbView7,
                bulbView8,
                bulbView9,
                bulbView10,
            };
            foreach (BulbView item in bulbViews)
                item.SetClient(this.client);
            house1.SetClient(this.client);
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

        void RefreshBulbs()
        {
            foreach (BulbView item in bulbViews)
                item.Bulb = null;

            int index = 0;
            foreach (Bulb item in client.Bulbs)
            {
                if (index >= bulbViews.Length)
                    break;
                bulbViews[index].Bulb = item;

                index++;
            }
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

            btnConnect.Click += btnConnect_Click;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            btnConnect_Click(btnConnect, EventArgs.Empty);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            try
            {
                client.Disconnect();
            }
            catch (Exception)
            { }
            base.OnClosing(e);
        }

        void btnConnect_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {//已连接，则断开
                try
                {
                    client.Disconnect();
                }
                catch (Exception)
                { }
            }
            else
            {
                if (string.IsNullOrEmpty(settings.AccessToken))
                {//获取新的令牌
                    LoginForm form = new LoginForm(this.client);
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.ShowInTaskbar = false;
                    if (form.ShowDialog(this) != System.Windows.Forms.DialogResult.OK)
                        return;
                }

                try
                {
                    string newAccessToken, newRefreshToken;
                    client.Connect(settings.AccessToken, settings.RefreshToken, out newAccessToken, out newRefreshToken);
                    settings.AccessToken = newAccessToken;
                    settings.RefreshToken = newRefreshToken;
                    settings.Save();
                }
                catch(PhantomUnauthorizedException)
                {
                    LoginForm form = new LoginForm(this.client);
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.ShowInTaskbar = false;
                    if (form.ShowDialog(this) != System.Windows.Forms.DialogResult.OK)
                        return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "连接到服务器时发生错误：" + ex.Message, "提示");
                }
            }
            RefreshUI();
        }
        void RefreshUI()
        {
            if (client.Connected)
            {
                btnConnect.Text = "退出";
            }
            else
            {
                btnConnect.Text = "登录";
            }

            if (client.UserInfo == null)
            {
                pictureBoxUser.Image = null;
                labelDisplayName.Text = "";
            }
            else
            {
                pictureBoxUser.Image = client.UserImage;
                labelDisplayName.Text = client.UserInfo.Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //client.UpdateScenario();
            //client.GetUserLog();
            client.GetDeviceLog();
        }
    }
}
