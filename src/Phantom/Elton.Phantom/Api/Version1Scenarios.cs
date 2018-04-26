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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom
{
    partial class PhantomApi
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hasDetails">如果为true，则同时获取详细信息。</param>
        /// <returns></returns>
        public Scenario[] GetScenarios(int zoneId, bool hasDetails = false)
        {
            Scenario[] arrayScenarios = this.Get<Scenario[]>(0, $"scenarios?zone_id={zoneId}");
            if (!hasDetails || arrayScenarios == null || arrayScenarios.Length < 1)
                return arrayScenarios;

            List<Operation> list = new List<Operation>();
            foreach (Scenario item in arrayScenarios)
                list.Add(new Operation("GET", $"/api/scenarios/{item.Id}"));

            var result = this.Batch(1, list.ToArray());
            List<Scenario> listDetails = new List<Scenario>();
            foreach (var item in result.Results)
            {
                if (item.Status == 200)
                {
                    Scenario Scenario = JsonConvert.DeserializeObject<Scenario>(item.Body);
                    listDetails.Add(Scenario);
                }
            }
            return listDetails.ToArray();
        }
        public Scenario GetScenario(int scenarioId)
        {
            return Get<Scenario>(1, $"scenarios/{scenarioId}.json");
        }
        public void SetScenarioAllOn()
        {
            this.Post<Scenario>(1, "scenarios/all_on.json", new Argument("origin", 1));
        }
        public void SetScenarioAllOff()
        {
            this.Post<Scenario>(1, "scenarios/all_off.json", new Argument("origin", 1));
        }
        protected void SetScenarioInternal(int scenarioId)
        {
            this.Post<Scenario>(1, $"scenarios/{scenarioId}/apply");
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
        public bool DeleteScenario(int scenarioId)
        {
            return Delete(1, $"scenarios/{scenarioId}");
        }
    }
}
