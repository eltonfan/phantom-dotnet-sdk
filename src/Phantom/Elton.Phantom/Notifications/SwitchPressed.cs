using System;
using System.Collections.Generic;
using System.Text;

namespace Elton.Phantom.Notifications
{
    /// <summary>
    /// 随心开关长按
    /// </summary>
    public class SwitchPressed : NotificationContent
    {
        public string type { get; set; }
        public string switch_id { get; set; }
    }
}
