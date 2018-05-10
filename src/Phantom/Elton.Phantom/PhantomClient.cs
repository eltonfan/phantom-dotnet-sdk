#region License

//   Copyright 2014 Elton FAN (eltonfan@live.cn, http://elton.io)
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

using Elton.Phantom.Rest;
using Elton.Phantom.Models;
using Elton.Phantom.Models.Version1;
using System;
using System.Collections.Generic;

namespace Elton.Phantom
{
    using Bulb = Models.Version1.Bulb;
    using Scenario = Models.Version1.Scenario;

    public class PhantomClient : PhantomApi
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

        public PhantomClient(PhantomConfiguration config)
            : base(config)
        {
        }

        void CheckControlResult(OperationResult result, [System.Runtime.CompilerServices.CallerMemberName] string callerName = null)
        {
            if (result == null)
                throw new ApiException();
            if (!result.Success)
                throw new PhantomException(result.Reason);
        }

        public void Ping(int apiVersion = 2)
        {
            switch(apiVersion)
            {
                case 1: (this as Api.Version1.IPingApi).GetPing(); break;
                case 2: (this as Api.Version2.IPingApi).GetPing(); break;
            }
        }

        public bool TryPing(int apiVersion = 2)
        {
            try
            {
                Ping(apiVersion);

                return true;
            }
            catch (Exception ex)
            {
                log.Error("Failed to Ping.", ex);

                return false;
            }
        }

        public Scenario AddScenario(string name)
        {
            var data = new
            {
                name = name,
                scenario_content_items_attributes = new[]
                {
                    new
                    {
                        generic_module_id = 741,
                         info = "[{\"type\":\"mode\",\"index\":0,\"value\":6}]",
                    },
                }
            };

            return this.Post<Scenario>(1, "scenarios.json", data);
        }
        public Scenario UpdateScenario(int scenarioId, string name, params object[] contentItems)
        {
            var data = new
            {
                name = name,
                scenario_content_items_attributes = contentItems,
            };

            return this.Put<Scenario>(1, $"scenarios/{scenarioId}", data);
        }

        public void SetScenario(Scenario scenario)
        {
            SetScenario(scenario?.Id);
        }

        public void SetScenario(int? scenarioId)
        {
            if (scenarioId == null)
                throw new ArgumentNullException("scenarioId", "scenarioId can not be null.");

            if (scenarioId == SCENARIO_ID_AllOff)//实际上是全关
                PostScenarioAllOff();
            else if (scenarioId == SCENARIO_ID_AllOn)
                PostScenarioAllOn();
            else
                PostScenarioApply(scenarioId);
        }

        public void SetBulb(int? bulbId, bool turnOn)
        {
            if (bulbId == null)
                throw new ArgumentNullException("bulbId", "bulbId can not be null.");

            OperationResult result = null;
            if (turnOn)
                result = PostBulbSwitchOn(bulbId);
            else
                result = PostBulbSwitchOff(bulbId);

            CheckControlResult(result);
        }

        public void SetBulb(Bulb bulb, bool turnOn)
        {
            SetBulb(bulb?.Id, turnOn);
        }

        public void SetBulb(int? bulbId, float brightness, float hue)
        {
            var result = PostBulbTune(bulbId, brightness, hue);
            CheckControlResult(result);
        }

        public void SetBulb(Bulb bulb, float brightness, float hue)
        {
            SetBulb(bulb?.Id, brightness, hue);
        }

        public void UpdateScenarioMode(int id, string name, byte mode)
        {
            var result = UpdateScenario(id, name,
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
            var old = GetScenario(id);

            var list = new List<object>();
            bool hasData = false;
            foreach (var item in old.ScenarioContentItems)
            {
                if (item.GenericModuleId != 741 || hasData)
                {//不正确，或者已经存在记录，则删除
                    list.Add(
                            new
                            {
                                id = item.Id,
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
                                id = item.Id,
                                generic_module_id = 741,
                                info = string.Format("[{{\"type\":\"data\",\"index\":0,\"value\":{0}}}]", data),
                            }
                        );
                }
            }
            if (!hasData)
            {//添加记录
                list.Add(
                    new
                    {
                        generic_module_id = 741,
                        info = string.Format("[{{\"type\":\"data\",\"index\":0,\"value\":{0}}}]", data),
                    });
            }


            Scenario result = UpdateScenario(id, name, list.ToArray());
        }
    }
}
