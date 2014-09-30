using Mavplus.Phantom.API;
using Mavplus.Phantom.Models;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mavplus.Phantom
{
    public partial class PhantomClient
    {
        /// <summary>
        /// 全关的情景ID。
        /// </summary>
        const int SCENARIO_ID_AllOff = 0x0000;
        /// <summary>
        /// 全开的情景ID。
        /// </summary>
        const int SCENARIO_ID_AllOn = 0xFFFF;
        readonly PhantomAPI api = null;
        readonly Dictionary<int, Bulb> dicBulbs = new Dictionary<int, Bulb>();
        readonly Dictionary<int, Scenario> dicScenarios = new Dictionary<int, Scenario>();

        User currentUser = null;
        Image image = null;
        string token = null;

        readonly System.Timers.Timer timerRefresh = null;
        public PhantomClient()
        {
            this.api = new PhantomAPI(PhantomConfiguration.Default);

            this.timerRefresh = new System.Timers.Timer(PhantomConfiguration.Default.RequestInterval);
            this.timerRefresh.AutoReset = false;
            this.timerRefresh.Elapsed += timerRefresh_Elapsed;
        }

        volatile int refreshCount = 0;
        void timerRefresh_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                RefreshScenarios();
                //if (refreshCount % 5 == 4)
                //    RefreshBulbs(true);
                //else
                //    RefreshBulbs(false);

                if (refreshCount <= 0)//仅第一次快速刷新
                    RefreshBulbs(false);
                else
                    RefreshBulbs(true);
            }
            catch(Exception ex)
            { }
            finally
            {
                refreshCount++;

                if(this.Connected)
                    timerRefresh.Start();
            }
        }

        public void Connect(string accessToken)
        {
            api.Ping();

            this.token = accessToken;
            this.api.SetCredentials(token);
            this.currentUser = api.GetUser();
            if (this.currentUser.Name == null)
                throw new Exception();

            try
            {//尝试获取用户头像
                string email = this.currentUser.Email;
                string imageUrl = null;
                using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
                {
                    byte[] dataEmail = Encoding.UTF8.GetBytes(email.Trim().ToLower());
                    string hashString = BitConverter.ToString(md5.ComputeHash(dataEmail)).Replace("-", "").ToLower();
                    imageUrl = "https://gravatar.com/avatar/" + hashString + ".png";
                }
                using (WebClient client = new WebClient())
                {
                    byte[] imageData = client.DownloadData(imageUrl);
                    this.image = Image.FromStream(new MemoryStream(imageData));
                }
            }
            catch(Exception ex)
            {
                this.image = null;
            }

            timerRefresh.Start();
            this.Connected = true;
        }
        public void Disconnect()
        {
            this.Connected = false;
            timerRefresh.Stop();
        }

        public bool Connected { get; private set; }

        public void SetScenario(Scenario scenario)
        {
            if (scenario.Id == SCENARIO_ID_AllOff)//实际上是全关
                api.SetScenarioAllOff();
            else if (scenario.Id == SCENARIO_ID_AllOn)
                api.SetScenarioAllOn();
            else
                api.SetScenario(scenario.Id);
        }
        public void SetBulb(Bulb bulb, bool isOn)
        {
            if (isOn)
                api.SetBulbSwitchOn(bulb.Id);
            else
                api.SetBulbSwitchOff(bulb.Id);
        }
        public void SetBulb(Bulb bulb, float brightness, float hue)
        {
            api.SetBulbTune(bulb.Id, brightness, hue);
        }

        public void RefreshScenarios(bool hasDetails = false)
        {
            List<Scenario> listRemoved = new List<Scenario>();
            List<Scenario> listNew = new List<Scenario>();
            List<Scenario> listChanged = new List<Scenario>();

            List<Scenario> listCurrent = new List<Scenario>();
            listCurrent.Add(new Scenario
            {
                Id = SCENARIO_ID_AllOff,
                Name = "全关",
                DateCreated = DateTime.MinValue,
                DateUpdated = DateTime.MinValue,
                ContentItems = new ScenarioContentItem[0],
            });
            listCurrent.Add(new Scenario
            {
                Id = SCENARIO_ID_AllOn,
                Name = "全开",
                DateCreated = DateTime.MinValue,
                DateUpdated = DateTime.MinValue,
                ContentItems = new ScenarioContentItem[0],
            });
            Scenario[] response = api.GetScenarios(hasDetails);
            if(response != null)
                listCurrent.AddRange(response);

            foreach(KeyValuePair<int, Scenario> pair in this.dicScenarios)
            {
                bool removed = true;
                foreach(Scenario item in listCurrent)
                {
                    if(item.Id == pair.Key)
                    {//仍然存在
                        removed = false;
                        break;
                    }
                }
                if (removed)
                    listRemoved.Add(pair.Value);
            }
            foreach (Scenario item in listRemoved)
                this.dicScenarios.Remove(item.Id);

            foreach(Scenario item in listCurrent)
            {
                if(dicScenarios.ContainsKey(item.Id))
                {//本来就存在
                    if (dicScenarios[item.Id].Equals(item))
                        continue;
                    dicScenarios[item.Id].CopyFrom(item);
                    listChanged.Add(dicScenarios[item.Id]);
                }
                else
                {
                    dicScenarios.Add(item.Id, item);
                    listNew.Add(item);
                }
            }

            if (this.NewScenario != null)
            {
                foreach (Scenario item in listNew)
                    this.NewScenario(this, new ScenarioEventArgs(item));
            }
            if (this.ScenarioRemoved != null)
            {
                foreach (Scenario item in listRemoved)
                    this.ScenarioRemoved(this, new ScenarioEventArgs(item));
            }
            if (this.ScenarioStateChanged != null)
            {
                foreach (Scenario item in listChanged)
                    this.ScenarioStateChanged(this, new ScenarioEventArgs(item));
            }
        }

        public void RefreshBulbs(bool hasDetails = false)
        {
            List<Bulb> listRemoved = new List<Bulb>();
            List<Bulb> listNew = new List<Bulb>();
            List<Bulb> listChanged = new List<Bulb>();

            Bulb[] listCurrent = api.GetBulbs(hasDetails);
            foreach (KeyValuePair<int, Bulb> pair in this.dicBulbs)
            {
                bool removed = true;
                foreach (Bulb item in listCurrent)
                {
                    if (item.Id == pair.Key)
                    {//仍然存在
                        removed = false;
                        break;
                    }
                }
                if (removed)
                    listRemoved.Add(pair.Value);
            }
            foreach (Bulb item in listRemoved)
                this.dicBulbs.Remove(item.Id);

            foreach (Bulb item in listCurrent)
            {
                if (dicBulbs.ContainsKey(item.Id))
                {//本来就存在
                    if(hasDetails)
                    {
                        if (dicBulbs[item.Id].Equals(item))
                            continue;
                        dicBulbs[item.Id].CopyFrom(item);
                        listChanged.Add(dicBulbs[item.Id]);
                    }
                    else
                    {
                        if (dicBulbs[item.Id].Id == item.Id && dicBulbs[item.Id].TurnedOn == item.TurnedOn && dicBulbs[item.Id].OwnDevice == item.OwnDevice && dicBulbs[item.Id].Name == item.Name)
                            continue;
                        dicBulbs[item.Id].TurnedOn = item.TurnedOn;
                        dicBulbs[item.Id].OwnDevice = item.OwnDevice;
                        dicBulbs[item.Id].Name = item.Name;
                        listChanged.Add(dicBulbs[item.Id]);
                    }
                }
                else
                {
                    item.SetClient(this);
                    dicBulbs.Add(item.Id, item);
                    listNew.Add(item);
                }
            }

            if (this.NewBulb != null)
            {
                foreach (Bulb item in listNew)
                    this.NewBulb(this, new BulbEventArgs(item));
            }
            if (this.BulbRemoved != null)
            {
                foreach (Bulb item in listRemoved)
                    this.BulbRemoved(this, new BulbEventArgs(item));
            }
            if (this.BulbStateChanged != null)
            {
                foreach (Bulb item in listChanged)
                    this.BulbStateChanged(this, new BulbEventArgs(item));
            }
        }
        public Token Login(string userName, string password)
        {
            Token token = api.CreateToken(userName, password);
            this.token = token.AccessToken;

            return token;
        }

        public User UserInfo
        {
            get { return this.currentUser; }
        }
        public Image UserImage
        {
            get { return this.image; }
        }

        public ICollection<Bulb> Bulbs
        {
            get { return dicBulbs.Values; }
        }

        public ICollection<Scenario> Scenarios
        {
            get { return dicScenarios.Values; }
        }

        [Obsolete("仅供测试。")]
        public static void TestAPI(string token)
        {
            PhantomAPI api = new PhantomAPI(PhantomConfiguration.Default);
            bool isOK = api.Ping();
            api.SetCredentials(token);

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
