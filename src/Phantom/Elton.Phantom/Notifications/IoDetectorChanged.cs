using System;
using System.Collections.Generic;
using System.Text;

namespace Elton.Phantom.Notifications
{
    /// <summary>
    /// 开关量采集器
    /// </summary>
    public class IoDetectorChanged : NotificationContent
    {
        public string device_identifier { get; set; }
        public string io_detector_id { get; set; }
        public string state { get; set; }
    }
}