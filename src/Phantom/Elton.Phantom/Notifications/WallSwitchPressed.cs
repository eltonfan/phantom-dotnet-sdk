using System;
using System.Collections.Generic;
using System.Text;

namespace Elton.Phantom.Notifications
{
    /// <summary>
    /// 墙壁开关长按
    /// </summary>
    public class WallSwitchPressed : NotificationContent
    {
        public string type { get; set; }
        public byte channel { get; set; }
        public int switch_id { get; set; }
    }
}