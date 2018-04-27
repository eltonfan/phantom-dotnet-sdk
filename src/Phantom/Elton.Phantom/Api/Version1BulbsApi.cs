﻿#region License

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

using Elton.Phantom.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom
{
    using Bulb = Models.Version1.Bulb;
    using Scenario = Models.Version1.Scenario;

    partial class PhantomApi
    {
        readonly Dictionary<int, Bulb> dicBulbs = new Dictionary<int, Bulb>();

        public Bulb[] GetBulbs()
        {
            return this.Get<Bulb[]>(1, "bulbs");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hasDetails">如果为true，则同时获取详细信息。</param>
        /// <returns></returns>
        public Bulb[] GetBulbs(bool hasDetails = false)
        {
            Bulb[] arrayBulbs = this.Get<Bulb[]>(1, "bulbs");
            if (!hasDetails || arrayBulbs == null || arrayBulbs.Length < 1)
                return arrayBulbs;

            List<Operation> list = new List<Operation>();
            foreach (var item in arrayBulbs)
                list.Add(new Operation("GET", string.Format("/api/bulbs/{0}", item.Id)));

            var result = this.Batch(1, list.ToArray());
            var listDetails = new List<Bulb>();
            foreach (var item in result.Results)
            {
                if (item.Status == 200)
                {
                    var bulb = JsonConvert.DeserializeObject<Bulb>(item.Body);
                    listDetails.Add(bulb);
                }
            }
            return listDetails.ToArray();
        }

        public Bulb GetBulb(int id)
        {
            return Get<Bulb>(1, $"bulbs/{id}");
        }

        public void SetBulbSwitchOn(int bulbId)
        {
            this.Post<Scenario>(1, $"bulbs/{bulbId}/switch_on");
        }
        public void SetBulbSwitchOff(int bulbId)
        {
            var result = Post<OperationResult>(1, $"bulbs/{bulbId}/switch_off");

            CheckControlResult(result);
        }
        public void SetBulbTune(int bulbId, float brightness, float hue)
        {
            this.Post<Scenario>(1, $"bulbs/{bulbId}/tune",
                new KeyValuePair<string, object>("brightness", brightness),
                new KeyValuePair<string, object>("hue", hue));
        }
    }
}