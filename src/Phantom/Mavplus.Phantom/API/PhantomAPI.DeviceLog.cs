// Coded by chuangen http://chuangen.name.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mavplus.Phantom.API
{
    partial class PhantomAPI
    {
        /// <summary>
        /// door_sensor
        /// </summary>
        /// <param name="device_type"></param>
        /// <returns></returns>
        public object GetDeviceLog(string device_type, int? device_id, string cursor, int count, out string nextCursor)
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
            foreach(var item in data.data)
            {
                string message = item.message;
                long timestamp = item.timestamp;
                string icon = item.icon;
            }

            nextCursor = data.next_cursor;

            return null;
        }
        /*
        {
  "data": [
    {
      "message": "冰箱被关闭",
      "timestamp": 1465918848000,
      "icon": "https://dn-huantengsmartpublic-four.qbox.me/assets/icons/door-sensor-close-9b589a99eddb1676840d90b668f3e844.png"
    },
    {
      "message": "冰箱被打开",
      "timestamp": 1465903308000,
      "icon": "https://dn-huantengsmartpublic-four.qbox.me/assets/icons/door-sensor-open-4e426504425454af8ba5e59395515757.png"
    }
  ],
  "next_cursor": "1465903031000-4860929"
}
         */
    }
}
