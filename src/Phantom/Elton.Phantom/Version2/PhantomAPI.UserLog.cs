// Coded by chuangen http://chuangen.name.

using Elton.Phantom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom.Version2
{
    partial class PhantomAPI
    {
        /// <summary>
        /// door_sensor
        /// </summary>
        /// <param name="device_type"></param>
        /// <returns></returns>
        public List<UserLog> GetUserLog(string cursor, int count, out string nextCursor)
        {
            var list = new Dictionary<string, string>();
            list.Add("count", count.ToString());

            dynamic data = null;
            data = Get(2, $"user_log.json?count={count}&next_cursor={cursor}", list.ToArray());

            List<UserLog> result = new List<UserLog>();
            foreach(var item in data.data)
            {
                result.Add(new UserLog {
                    Message = item.message,
                    Timestamp = item.timestamp,
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
      "timestamp": 1477455511715
    },
    {
      "message": "---",
      "timestamp": 1477455511000
    },
  ],
  "next_cursor": "1477442148000-12857765"
}
*/
    }
}
