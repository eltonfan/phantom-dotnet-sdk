using System;
using System.Collections.Generic;
using System.Text;

namespace Elton.Phantom.Notifications
{
    /// <summary>
    /// 创建灯组
    /// </summary>
    public class GroupCreated : NotificationContent
    {
        public string group_id { get; set; }
        public string bulb_ids { get; set; }
    }
}
