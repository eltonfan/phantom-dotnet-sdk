using System;
using System.Collections.Generic;
using System.Text;

namespace Elton.Phantom.Notifications
{
    /// <summary>
    /// 随心开关
    /// </summary>
    public class SwitchesChanged : NotificationContent
    {
        public string switch_id { get; set; }
    }
}
