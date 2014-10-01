// Coded by chuangen http://chuangen.name.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mavplus.Phantom.Models
{
    /// <summary>
    /// 灯泡。
    /// </summary>
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
        /// 设备地址
        /// </summary>
        [JsonProperty("device_ip")]
        public int DeviceIp { get; set; }
        /// <summary>
        /// 路由ID
        /// </summary>
        [JsonProperty("router_id")]
        public int RouterId { get; set; }
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
        /// 累计使用时长
        /// </summary>
        [JsonProperty("accumulated_usage_time")]
        public int AccumulatedUsageTime { get; set; }
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
        /// <summary>
        /// 记录的创建日期
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// 记录的更新日期
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime DateUpdated { get; set; }
        /// <summary>
        /// 设备的死亡二维码，即删除后的设备会获得的一个二维码，这样误删或是送人都可以用这个二维码，或是自己的设备坏了也可以用
        /// </summary>
        [JsonProperty("death_qr_code")]
        public string DeathQrCode { get; set; }

        [JsonConstructor]
        public Bulb()
        {

        }

        public override string ToString()
        {
            return string.Format("{0} {1} (亮度{2}, 色温{3}) {4}",
                this.Id, this.Name, this.Brightness, this.Hue, this.Connectivity);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Bulb target = obj as Bulb;
            if (target == null)
                return false;

            return (this.Id == target.Id
                && this.TurnedOn == target.TurnedOn
                && this.OwnDevice == target.OwnDevice
                && this.Name == target.Name
                && this.DeviceIp == target.DeviceIp
                && this.RouterId == target.RouterId
                && this.HouseId == target.HouseId
                && this.Connectivity == target.Connectivity
                && this.AccumulatedUsageTime == target.AccumulatedUsageTime
                && this.Brightness == target.Brightness
                && this.Hue == target.Hue
                && this.Channel == target.Channel
                && this.WallSwitchId == target.WallSwitchId
                && this.DateCreated == target.DateCreated
                && this.DateUpdated == target.DateUpdated
                && this.DeathQrCode == target.DeathQrCode);
        }

        public void CopyFrom(Bulb value)
        {
            if (this.Id != value.Id)
                throw new ArgumentException("目标ID不一致。");

            this.TurnedOn = value.TurnedOn;
            this.OwnDevice = value.OwnDevice;
            this.Name = value.Name;
            this.DeviceIp = value.DeviceIp;
            this.RouterId = value.RouterId;
            this.HouseId = value.HouseId;
            this.Connectivity = value.Connectivity;
            this.AccumulatedUsageTime = value.AccumulatedUsageTime;
            this.Brightness = value.Brightness;
            this.Hue = value.Hue;
            this.Channel = value.Channel;
            this.WallSwitchId = value.WallSwitchId;
            this.DateCreated = value.DateCreated;
            this.DateUpdated = value.DateUpdated;
            this.DeathQrCode = value.DeathQrCode;
        }

        PhantomClient client = null;
        internal void SetClient(PhantomClient client)
        {
            this.client = client;
        }

        public void TurnOn()
        {
            if (this.client == null)
                return;

            this.client.SetBulb(this, true);
        }
        public void TurnOff()
        {
            if (this.client == null)
                return;

            this.client.SetBulb(this, false);
        }
    }
}
