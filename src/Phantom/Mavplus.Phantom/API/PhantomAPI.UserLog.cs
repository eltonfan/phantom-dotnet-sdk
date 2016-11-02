// Coded by chuangen http://chuangen.name.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mavplus.Phantom.API
{
    public class UserLog
    {
        public string Message { get; set; }
        public long Timestamp { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} {2}",
                this.DateTime, this.Timestamp, this.Message);
        }

        public DateTime DateTime
        {
            get
            {
                return new DateTime(1970, 1, 1).AddMilliseconds((long)this.Timestamp).ToLocalTime();
            }
            set
            {
                this.Timestamp = (long)value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
            }
        }
    }

    partial class PhantomAPI
    {
        /// <summary>
        /// door_sensor
        /// </summary>
        /// <param name="device_type"></param>
        /// <returns></returns>
        public List<UserLog> GetUserLog(string cursor, int count, out string nextCursor)
        {
            List<UrlSegment> list = new List<UrlSegment>();
            list.Add(new UrlSegment("count", count.ToString()));

            dynamic data = null;
            if (string.IsNullOrEmpty(cursor))
            {
                data = GET2("user_log.json?count={count}",
                    list.ToArray());
            }
            else
            {
                list.Add(new UrlSegment("next_cursor", cursor));
                data = GET2("user_log.json?count={count}&next_cursor={next_cursor}",
                    list.ToArray());
            }

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
