using System;
using System.Collections.Generic;
using System.Text;

namespace Elton.Phantom.Notifications
{
    /// <summary>
    /// 安防模式变化
    /// </summary>
    public class SecurityPatternsChanged : NotificationContent
    {
        public string id { get; set; }
        public string state { get; set; }
        public string state_summary { get; set; }
    }
}
