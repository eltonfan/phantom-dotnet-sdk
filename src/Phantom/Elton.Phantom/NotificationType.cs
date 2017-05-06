using System;
using System.Collections.Generic;
using System.Text;

namespace Elton.Phantom
{
    public enum NotificationType
    {
        /// <summary>
        /// 未知。
        /// </summary>
        Unknown,
        /// <summary>
        /// 门磁
        /// </summary>
        DoorSensorsChanged,
        /// <summary>
        /// 开关量采集器
        /// </summary>
        IoDetectorChanged,
        /// <summary>
        /// 设备在线离线状态改变
        /// </summary>
        DeviceConnectivity,
        /// <summary>
        /// 灯泡状态改变
        /// </summary>
        BulbsChanged,
        /// <summary>
        /// 红外
        /// </summary>
        InfraredSensorsChanged,
        /// <summary>
        /// 随心开关
        /// </summary>
        SwitchesChanged,
        /// <summary>
        /// 墙壁开关长按
        /// </summary>
        WallSwitchPressed,
        /// <summary>
        /// 随心开关长按
        /// </summary>
        SwitchPressed,
        /// <summary>
        /// 墙壁开关发生变化
        /// </summary>
        WallSwitchesChanged,
        /// <summary>
        /// 创建灯组
        /// </summary>
        GroupCreated,
        /// <summary>
        /// 安防模式变化
        /// </summary>
        SecurityPatternsChanged,
        /// <summary>
        /// 通用模块发生变化
        /// </summary>
        // ******
        /// <summary>
        /// 用户离家回家
        /// </summary>
        UserEvent,
    }
}
