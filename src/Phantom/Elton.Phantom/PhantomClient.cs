// Coded by chuangen http://chuangen.name.

using Elton.Phantom.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elton.Phantom
{
    public partial class PhantomClient
    {
        static readonly Common.Logging.ILog log = Common.Logging.LogManager.GetLogger(typeof(PhantomClient));

        /// <summary>
        /// 全关的情景ID。
        /// </summary>
        const int SCENARIO_ID_AllOff = 0x0000;
        /// <summary>
        /// 全开的情景ID。
        /// </summary>
        const int SCENARIO_ID_AllOn = 0xFFFF;
        readonly Version1.PhantomAPI api1 = null;
        readonly Version2.PhantomAPI api2 = null;
        readonly Dictionary<int, Bulb> dicBulbs = new Dictionary<int, Bulb>();
        readonly Dictionary<int, Scenario> dicScenarios = new Dictionary<int, Scenario>();

        User currentUser = null;
        //Image image = null;
        string token = null;

        readonly System.Threading.Timer timerRefresh = null;
        public PhantomClient()
        {
            this.api1 = new Version1.PhantomAPI(PhantomConfiguration.Default);
            this.api2 = new Version2.PhantomAPI(PhantomConfiguration.Default);

            this.timerRefresh = new System.Threading.Timer(RefreshTimerCallback, null, Timeout.Infinite, Timeout.Infinite);
        }

        volatile int refreshCount = 0;
        void RefreshTimerCallback(object state)
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

                if (this.Connected)
                {
                    timerRefresh.Change(PhantomConfiguration.Default.RequestInterval, Timeout.Infinite);
                }
            }
        }

        public void Connect(string accessToken)
        {
            api1.Ping();

            this.token = accessToken;
            this.api1.SetCredentials(token);
            this.api2.SetCredentials(token);
            this.currentUser = api1.GetUser();
            if (this.currentUser.Name == null)
                throw new Exception();

            timerRefresh.Change(0, Timeout.Infinite);
            this.Connected = true;
        }

        public void Connect(string accessToken, string refreshToken, out string newAccessToken, out string newRefreshToken)
        {
            newAccessToken = null;
            newRefreshToken = null;

            api1.Ping();

            this.token = accessToken;
            this.api1.SetCredentials(token);
            this.api2.SetCredentials(token);
            this.currentUser = api1.GetUser();
            if (this.currentUser.Name == null)
                throw new Exception();

            if (string.IsNullOrEmpty(refreshToken))
            {
                newAccessToken = accessToken;
                newRefreshToken = refreshToken;
            }
            else
            {//尝试刷新令牌
                Token newToken = this.api1.RefreshToken(refreshToken);
                newAccessToken = newToken.AccessToken;
                newRefreshToken = newToken.RefreshToken;

                this.token = newAccessToken;
                this.api1.SetCredentials(token);
                this.currentUser = api1.GetUser();
                if (this.currentUser.Name == null)
                    throw new Exception();
            }
            
            timerRefresh.Change(0, Timeout.Infinite);
            this.Connected = true;
        }
        public void Disconnect()
        {
            this.Connected = false;
            timerRefresh.Change(Timeout.Infinite, Timeout.Infinite);
        }

        public void UpdateScenarioMode(int id, string name, byte mode)
        {
            var result = api1.UpdateScenario(id, name,
                new[]
                {
                    new
                    {
                        generic_module_id = 741,
                        info = string.Format("[{{\"type\":\"mode\",\"index\":0,\"value\":{0}}}]", mode),
                    },
                });
        }
        public void UpdateScenarioData(int id, string name, int data)
        {
            var old = api1.GetScenario(id);

            var list = new List<object>();
            bool hasData = false;
            foreach(var item in old.ContentItems)
            {
                if (item.generic_module_id != 741 || hasData)
                {//不正确，或者已经存在记录，则删除
                    list.Add(
                            new
                            {
                                id = item.id,
                                _destroy = true,
                            }
                        );
                }
                else
                {
                    hasData = true;
                    list.Add(
                            new
                            {
                                id = item.id,
                                generic_module_id = 741,
                                info = string.Format("[{{\"type\":\"data\",\"index\":0,\"value\":{0}}}]", data),
                            }
                        );
                }
            }
            if(!hasData)
            {//添加记录
                list.Add(
                    new
                    {
                        generic_module_id = 741,
                        info = string.Format("[{{\"type\":\"data\",\"index\":0,\"value\":{0}}}]", data),
                    });
            }
            

            Scenario result = api1.UpdateScenario(id, name, list.ToArray());
        }


        public bool Connected { get; private set; }

        public void SetScenario(Scenario scenario)
        {
            if (scenario.Id == SCENARIO_ID_AllOff)//实际上是全关
                api1.SetScenarioAllOff();
            else if (scenario.Id == SCENARIO_ID_AllOn)
                api1.SetScenarioAllOn();
            else
                api1.SetScenario(scenario.Id);
        }

        public void SetScenario(int scenarioId)
        {
            if (scenarioId == SCENARIO_ID_AllOff)//实际上是全关
                api1.SetScenarioAllOff();
            else if (scenarioId == SCENARIO_ID_AllOn)
                api1.SetScenarioAllOn();
            else
                api1.SetScenario(scenarioId);
        }


        public void SetBulb(Bulb bulb, bool isOn)
        {
            if (isOn)
                api1.SetBulbSwitchOn(bulb.Id);
            else
                api1.SetBulbSwitchOff(bulb.Id);
        }
        public void SetBulb(Bulb bulb, float brightness, float hue)
        {
            api1.SetBulbTune(bulb.Id, brightness, hue);
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
            Scenario[] response = api1.GetScenarios(0, hasDetails);
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

            Bulb[] listCurrent = api1.GetBulbs(hasDetails);
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

        public User UserInfo
        {
            get { return this.currentUser; }
        }
        //public Image UserImage
        //{
        //    get { return this.image; }
        //}

        public ICollection<Bulb> Bulbs
        {
            get { return dicBulbs.Values; }
        }

        public ICollection<Scenario> Scenarios
        {
            get { return dicScenarios.Values; }
        }
        
        public List<UserLog> GetUserLog(string cursor, int count, out string nextCursor)
        {
            List<UserLog> result = api2.GetUserLog(cursor, count, out nextCursor);
            return result;
        }
        public void GetDeviceLog()
        {
            string nextCursor;
            List<DeviceLog> result = api2.GetDeviceLog("door_sensor", null, null, 20, out nextCursor);
        }
    }
}
