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
        public object GetUserLog(string cursor, int count, out string nextCursor)
        {
            List<UrlSegment> list = new List<UrlSegment>();
            if (!string.IsNullOrEmpty(cursor))
                list.Add(new UrlSegment("next_cursor", cursor));
            list.Add(new UrlSegment("count", count.ToString()));
            dynamic data = GET("user_log.json?count={count}",
                list.ToArray());
            foreach(var item in data)
            {
                string message = item.message;
                long timestamp = item.timestamp;

                 DateTime now = new DateTime(1970, 1, 1).AddMilliseconds(timestamp).ToLocalTime();
            }

            nextCursor = null;// data.next_cursor;
            return null;
        }
/*
{
  "data": [
    {
      "message": "门磁启动了0A.冰箱门.开情景",
      "timestamp": 1477455511715
    },
    {
      "message": "凯旋.冰箱被打开",
      "timestamp": 1477455511000
    },
  ],
  "next_cursor": "1477442148000-12857765"
}
*/
    }
}
