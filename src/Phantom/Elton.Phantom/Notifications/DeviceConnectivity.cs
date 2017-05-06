using System;
using System.Collections.Generic;
using System.Text;

namespace Elton.Phantom.Notifications
{
    /// <summary>
    /// 设备在线离线状态改变
    /// </summary>
    public class DeviceConnectivity : NotificationContent
    {
        public string device_identifier { get; set; }
        public string connectivity_string { get; set; }
        public string reason { get; set; }
        public int connectivity { get; set; }
    }
}
