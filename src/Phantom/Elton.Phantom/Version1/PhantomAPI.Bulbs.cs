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
        public Bulb[] GetBulbs(bool hasDetails = false)
        {
            Bulb[] arrayBulbs = this.GET<Bulb[]>("bulbs.json");
            if (!hasDetails || arrayBulbs == null || arrayBulbs.Length < 1)
                return arrayBulbs;

            List<Operation> list = new List<Operation>();
            foreach (Bulb item in arrayBulbs)
                list.Add(new Operation("GET", string.Format("/api/bulbs/{0}.json", item.Id)));

            OperationResult[] results = this.Batch(list.ToArray());
            List<Bulb> listDetails = new List<Bulb>();
            foreach (OperationResult item in results)
            {
                if (item.Status == 200)
                {
                    Bulb bulb = JsonConvert.DeserializeObject<Bulb>(item.Body);
                    listDetails.Add(bulb);
                }
            }
            return listDetails.ToArray();
        }
        public Bulb GetBulb(int id)
        {
            return GET<Bulb>("bulbs/{id}.json", new UrlSegment("id", id.ToString()));
        }

        public void SetBulbSwitchOn(int bulbId)
        {
            this.POST<Scenario>("bulbs/{id}/switch_on.json",
                new UrlSegment[] { new UrlSegment("id", bulbId.ToString()) });
        }
        public void SetBulbSwitchOff(int bulbId)
        {
            this.POST<Scenario>("bulbs/{id}/switch_off.json",
                new UrlSegment[] { new UrlSegment("id", bulbId.ToString()) });
        }
        public void SetBulbTune(int bulbId, float brightness, float hue)
        {
            this.POST<Scenario>("bulbs/{id}/tune.json",
                new UrlSegment[] { new UrlSegment("id", bulbId.ToString()) },
                new Argument("brightness", brightness.ToString()),
                new Argument("hue", hue.ToString()));
        }
    }
}
