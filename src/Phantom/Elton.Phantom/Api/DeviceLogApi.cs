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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom
{
    partial class PhantomApi
    {
        /// <summary>
        /// door_sensor
        /// </summary>
        /// <param name="device_type"></param>
        /// <returns></returns>
        public List<DeviceLog> GetDeviceLog(string device_type, int? device_id, string cursor, int count, out string nextCursor)
        {
            var list = new Dictionary<string, string>();
            list.Add("device_type", device_type);
            if(device_id != null)
                list.Add("device_id", device_id.Value.ToString());
            if (!string.IsNullOrEmpty(cursor))
                list.Add("next_cursor", cursor);
            list.Add("count", count.ToString());
            var data = Get<dynamic>(2, $"device_log?device_type={device_type}&count={count}", list.ToArray());

            List<DeviceLog> result = new List<DeviceLog>();
            foreach(var item in data.data)
            {
                result.Add(new DeviceLog
                {
                    Message = item.message,
                    Timestamp = new DateTime(1970, 1, 1).AddMilliseconds((long)item.timestamp).ToLocalTime(),
                    IconUrl = item.icon,
                });
            }

            nextCursor = data.next_cursor;

            return result;
        }
        /*
        {
  "data": [
    {
      "message": "---",
      "timestamp": 1465918848000,
      "icon": "https://dn-huantengsmartpublic-four.qbox.me/assets/icons/door-sensor-close-9b589a99eddb1676840d90b668f3e844.png"
    },
    {
      "message": "---",
      "timestamp": 1465903308000,
      "icon": "https://dn-huantengsmartpublic-four.qbox.me/assets/icons/door-sensor-open-4e426504425454af8ba5e59395515757.png"
    }
  ],
  "next_cursor": "1465903031000-4860929"
}
         */
    }
}
