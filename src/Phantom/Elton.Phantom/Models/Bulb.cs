using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elton.Phantom.Models
{
    public class Bulb
    {
        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// 是否已开机
        /// </summary>
        [JsonProperty("turned_on")]
        public bool TurnedOn { get; set; }
        /// <summary>
        /// 是不是自己的设备
        /// </summary>
        [JsonProperty("own_device?")]
        public bool OwnDevice { get; set; }
        /// <summary>
        /// 设备的名字
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// 房子ID
        /// </summary>
        [JsonProperty("house_id")]
        public int HouseId { get; set; }
        /// <summary>
        /// 在线状态说明 cf. 总则§?
        /// </summary>
        [JsonProperty("connectivity")]
        public string Connectivity { get; set; }
        /// <summary>
        /// 亮度
        /// </summary>
        [JsonProperty("brightness")]
        public float Brightness { get; set; }
        /// <summary>
        /// 色温
        /// </summary>
        [JsonProperty("hue")]
        public float Hue { get; set; }
        /// <summary>
        /// 位于墙面开关的第几路
        /// </summary>
        [JsonProperty("channel")]
        public int? Channel { get; set; }
        /// <summary>
        /// 墙面开关ID
        /// </summary>
        [JsonProperty("wall_switch_id")]
        public int? WallSwitchId { get; set; }

        [JsonConstructor]
        public Bulb()
        {

        }

        public override string ToString()
        {
            return string.Format("{0} {1} (亮度{2}, 色温{3}) {4}",
                this.Id, this.Name, this.Brightness, this.Hue, this.Connectivity);
        }
    }
/*
[
    {
        "device_identifier": "N7295",
        "id": 7295,
        "turned_on": false,
        "own_device?": true,
        "name": "室外.筒灯",
        "house_id": 4536,
        "brightness": 1.0,
        "hue": 0.5,
        "channel": null,
        "wall_switch_id": null,
        "alias_bulb_group_id": null,
        "position": 0,
        "auto_hue": false,
        "connectivity": "在线",
        "script_end_time": null
    }
]
*/
}
