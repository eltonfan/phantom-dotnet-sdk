#region License

//   Copyright 2014 Elton FAN
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 

#endregion

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
    public partial class PhantomClientEx
    {
        static readonly Common.Logging.ILog log = Common.Logging.LogManager.GetLogger(typeof(PhantomClientEx));

        /// <summary>
        /// 全关的情景ID。
        /// </summary>
        const int SCENARIO_ID_AllOff = 0x0000;
        /// <summary>
        /// 全开的情景ID。
        /// </summary>
        const int SCENARIO_ID_AllOn = 0xFFFF;

        readonly Dictionary<int, BulbDetails> dicBulbs = new Dictionary<int, BulbDetails>();
        readonly Dictionary<int, Scenario> dicScenarios = new Dictionary<int, Scenario>();

        User currentUser = null;
        //Image image = null;
        string token = null;

        readonly PhantomConfiguration config;
        readonly PhantomClient api;
        readonly System.Threading.Timer timerRefresh;
        public PhantomClientEx(PhantomConfiguration config)
        {
            this.config = config;
            this.api = new PhantomClient(config);

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
                    timerRefresh.Change(config.RequestInterval, Timeout.Infinite);
                }
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

            timerRefresh.Change(0, Timeout.Infinite);
            this.Connected = true;
        }

        public void Connect(string accessToken, string refreshToken, out string newAccessToken, out string newRefreshToken)
        {
            newAccessToken = null;
            newRefreshToken = null;

            api.Ping();

            this.token = accessToken;
            this.api.SetCredentials(token);
            this.currentUser = api.GetUser();
            if (this.currentUser.Name == null)
                throw new Exception();

            if (string.IsNullOrEmpty(refreshToken))
            {
                newAccessToken = accessToken;
                newRefreshToken = refreshToken;
            }
            else
            {//尝试刷新令牌
                var newToken = api.RefreshToken(refreshToken);
                newAccessToken = newToken.AccessToken;
                newRefreshToken = newToken.RefreshToken;

                this.token = newAccessToken;
                this.api.SetCredentials(token);
                this.currentUser = api.GetUser();
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

        public bool Connected { get; private set; }

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
            Scenario[] response = api.GetScenarios(0, hasDetails);
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
            List<BulbDetails> listRemoved = new List<BulbDetails>();
            List<BulbDetails> listNew = new List<BulbDetails>();
            List<BulbDetails> listChanged = new List<BulbDetails>();

            BulbDetails[] listCurrent = api.GetBulbs(hasDetails);
            foreach (KeyValuePair<int, BulbDetails> pair in this.dicBulbs)
            {
                bool removed = true;
                foreach (BulbDetails item in listCurrent)
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
            foreach (BulbDetails item in listRemoved)
                this.dicBulbs.Remove(item.Id);

            foreach (BulbDetails item in listCurrent)
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
                    //item.SetClient(this);
                    dicBulbs.Add(item.Id, item);
                    listNew.Add(item);
                }
            }

            if (this.NewBulb != null)
            {
                foreach (BulbDetails item in listNew)
                    this.NewBulb(this, new BulbEventArgs(item));
            }
            if (this.BulbRemoved != null)
            {
                foreach (BulbDetails item in listRemoved)
                    this.BulbRemoved(this, new BulbEventArgs(item));
            }
            if (this.BulbStateChanged != null)
            {
                foreach (BulbDetails item in listChanged)
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

        public ICollection<BulbDetails> Bulbs
        {
            get { return dicBulbs.Values; }
        }

        public ICollection<Scenario> Scenarios
        {
            get { return dicScenarios.Values; }
        }

        public PhantomClient Api => api;
    }
}
