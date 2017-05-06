using System;
using System.Collections.Generic;
using System.Text;

namespace Elton.Phantom.Notifications
{
    /// <summary>
    /// 红外
    /// </summary>
    public class InfraredSensorsChanged : NotificationContent
    {
        public string infrared_sensor_id { get; set; }
        public string channel { get; set; }
        public string active { get; set; }
        public string time { get; set; }
        public string cfg_parameters_7 { get; set; }
        public string version { get; set; }
    }
}
