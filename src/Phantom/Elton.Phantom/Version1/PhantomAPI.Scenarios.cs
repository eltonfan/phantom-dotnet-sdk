// Coded by chuangen http://chuangen.name.

using Elton.Phantom.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom.Version1
{
    partial class PhantomAPI
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

            OperationResult[] results = this.Batch(1, list.ToArray());
            List<Scenario> listDetails = new List<Scenario>();
            foreach (OperationResult item in results)
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
        public void SetScenario(int scenarioId)
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
