using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom.Models
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
}
