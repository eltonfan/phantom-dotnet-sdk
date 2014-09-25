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
        public Bulb[] GetBulbs()
        {
            return GET<Bulb[]>("bulbs.json");
        }
        public Bulb GetBulb(int id)
        {
            return GET<Bulb>("bulbs/{id}.json", new UrlSegment("id", id.ToString()));
        }

        public void SetBulbSwitchOn(int bulbId)
        {
            this.SET<Scenario>("bulbs/{id}/switch_on.json",
                new UrlSegment[] { new UrlSegment("id", bulbId.ToString()) });
        }
        public void SetBulbSwitchOff(int bulbId)
        {
            this.SET<Scenario>("bulbs/{id}/switch_off.json",
                new UrlSegment[] { new UrlSegment("id", bulbId.ToString()) });
        }
        public void SetBulbTune(int bulbId, float brightness, float hue)
        {
            this.SET<Scenario>("bulbs/{id}/tune.json",
                new UrlSegment[] { new UrlSegment("id", bulbId.ToString()) },
                new Argument("brightness", brightness.ToString()),
                new Argument("hue", hue.ToString()));
        }
    }
}
