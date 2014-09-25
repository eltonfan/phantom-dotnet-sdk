using Mavplus.Phantom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mavplus.Phantom.API
{
    partial class PhantomAPI
    {
        public Scenario[] GetScenarios()
        {
            return GET<Scenario[]>("scenarios.json");
        }
        public void SetScenarioAllOn()
        {
            this.SET<Scenario>("scenarios/all_on.json", null, new Argument("origin", 1));
        }
        public void SetScenarioAllOff()
        {
            this.SET<Scenario>("scenarios/all_off.json", null, new Argument("origin", 1));
        }
        public void SetScenario(int scenarioId)
        {
            this.SET<Scenario>("scenarios/{id}/apply.json",
                new UrlSegment[] { new UrlSegment("id", scenarioId.ToString()) });
        }
    }
}
