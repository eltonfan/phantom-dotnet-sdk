using System;
using System.Collections.Generic;
using System.Text;

namespace Elton.Phantom.Notifications
{
    /// <summary>
    /// 墙壁开关发生变化
    /// </summary>
    public class WallSwitchesChanged : NotificationContent
    {
        public int wall_switch_id { get; set; }
        public string device_identifier { get; set; }
        public bool[] status { get; set; }
        public byte change_mask { get; set; }
    }
}
