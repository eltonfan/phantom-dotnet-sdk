using System;
using System.Collections.Generic;
using System.Text;

namespace Elton.Phantom.Notifications
{
    public class DoorSensorsBehaviors
    {
        public string action { get; set; }
        public long timestamp { get; set; }
    }

    /// <summary>
    /// 门磁
    /// </summary>
    public class DoorSensorsChanged : NotificationContent
    {
        public int door_sensor_id { get; set; }
        public string door_sensor_name { get; set; }
        public bool is_open { get; set; }
        public int alert_mode { get; set; }
        public int alert_status { get; set; }
        public DoorSensorsBehaviors[] behaviors { get; set; }
    }
}
