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
using System.Collections.Generic;

namespace Elton.Phantom
{
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

        public void SetScenario(Scenario scenario)
        {
            if (scenario.Id == SCENARIO_ID_AllOff)//实际上是全关
                SetScenarioAllOff();
            else if (scenario.Id == SCENARIO_ID_AllOn)
                SetScenarioAllOn();
            else
                SetScenarioInternal(scenario.Id);
        }

        public void SetScenario(int scenarioId)
        {
            if (scenarioId == SCENARIO_ID_AllOff)//实际上是全关
                SetScenarioAllOff();
            else if (scenarioId == SCENARIO_ID_AllOn)
                SetScenarioAllOn();
            else
                SetScenarioInternal(scenarioId);
        }

        public void SetBulb(BulbDetails bulb, bool isOn)
        {
            if (isOn)
                SetBulbSwitchOn(bulb.Id);
            else
                SetBulbSwitchOff(bulb.Id);
        }

        public void SetBulb(BulbDetails bulb, float brightness, float hue)
        {
            SetBulbTune(bulb.Id, brightness, hue);
        }

        public void SetBulb(int bulbId, bool isOn)
        {
            if (isOn)
                SetBulbSwitchOn(bulbId);
            else
                SetBulbSwitchOff(bulbId);
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
            foreach (var item in old.ContentItems)
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
