// Coded by chuangen http://chuangen.name.

using Mavplus.Phantom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mavplus.Phantom.ApiVersion2
{
    partial class PhantomAPI
    {
        /// <summary>
        /// door_sensor
        /// </summary>
        /// <param name="device_type"></param>
        /// <returns></returns>
        public List<DeviceLog> GetDeviceLog(string device_type, int? device_id, string cursor, int count, out string nextCursor)
        {
            List<UrlSegment> list = new List<UrlSegment>();
            list.Add(new UrlSegment("device_type", device_type));
            if(device_id != null)
                list.Add(new UrlSegment("device_id", device_id.Value.ToString()));
            if (!string.IsNullOrEmpty(cursor))
                list.Add(new UrlSegment("next_cursor", cursor));
            list.Add(new UrlSegment("count", count.ToString()));
            dynamic data = GET("device_log?device_type={device_type}&count={count}",
                list.ToArray());

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
