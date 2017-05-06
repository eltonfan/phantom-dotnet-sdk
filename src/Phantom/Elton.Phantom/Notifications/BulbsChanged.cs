using System;
using System.Collections.Generic;
using System.Text;

namespace Elton.Phantom.Notifications
{
    /// <summary>
    /// 灯泡状态改变
    /// </summary>
    public class BulbsChanged : NotificationContent
    {
        public string device_identifier { get; set; }
        public int house_id { get; set; }
        public int bulb_id { get; set; }
        public int? wall_switch_id { get; set; }
        public int? channel { get; set; }
        public float hue { get; set; }
        public float brightness { get; set; }
        public bool turned_on { get; set; }
        public string script_end_time { get; set; }
    }
}
