#region License

//   Copyright 2014 Elton FAN (eltonfan@live.cn, http://elton.io)
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 

#endregion

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Elton.Phantom.Models.Version1
{
    /// <summary>
    /// 获取了灯泡
    /// </summary>
    [DataContract]
    public partial class Bulb :  IEquatable<Bulb>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bulb" /> class.
        /// </summary>
        [JsonConstructor]
        protected Bulb() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Bulb" /> class.
        /// </summary>
        /// <param name="DeviceIdentifier">设备标识字符串 cf. 总则§2.3 (required).</param>
        /// <param name="Id">ID (required).</param>
        /// <param name="TurnedOn">是否已开机 (required).</param>
        /// <param name="OwnDevice">是不是自己的设备 (required).</param>
        /// <param name="Name">设备的名字 (required).</param>
        /// <param name="HouseId">房子ID.</param>
        /// <param name="Connectivity">在线状态说明 cf. 总则§?.</param>
        /// <param name="AccumulatedUsageTime">累计使用时长.</param>
        /// <param name="Brightness">亮度.</param>
        /// <param name="Hue">色温.</param>
        /// <param name="Channel">位于墙面开关的第几路.</param>
        /// <param name="WallSwitchId">墙面开关ID.</param>
        /// <param name="AliasBulbGroupId">代表的组ID.</param>
        /// <param name="Position">排序用的序号.</param>
        /// <param name="AutoHue">是否启用自动色温.</param>
        /// <param name="ScriptEndTime">脚本停止时间.</param>
        public Bulb(string DeviceIdentifier = default, int? Id = default, bool? TurnedOn = default, bool? OwnDevice = default, string Name = default, int? HouseId = default, string Connectivity = default, int? AccumulatedUsageTime = default, float? Brightness = default, float? Hue = default, int? Channel = default, int? WallSwitchId = default, int? AliasBulbGroupId = default, int? Position = default, bool? AutoHue = default, DateTime? ScriptEndTime = default)
        {
            // to ensure "DeviceIdentifier" is required (not null)
            this.DeviceIdentifier = DeviceIdentifier ?? throw new InvalidDataException("DeviceIdentifier is a required property for Bulb and cannot be null");
            // to ensure "Id" is required (not null)
            this.Id = Id ?? throw new InvalidDataException("Id is a required property for Bulb and cannot be null");
            // to ensure "TurnedOn" is required (not null)
            this.TurnedOn = TurnedOn ?? throw new InvalidDataException("TurnedOn is a required property for Bulb and cannot be null");
            // to ensure "OwnDevice" is required (not null)
            this.OwnDevice = OwnDevice ?? throw new InvalidDataException("OwnDevice is a required property for Bulb and cannot be null"); ;
            // to ensure "Name" is required (not null)
            this.Name = Name ?? throw new InvalidDataException("Name is a required property for Bulb and cannot be null");

            this.HouseId = HouseId;
            this.Connectivity = Connectivity;
            this.AccumulatedUsageTime = AccumulatedUsageTime;
            this.Brightness = Brightness;
            this.Hue = Hue;
            this.Channel = Channel;
            this.WallSwitchId = WallSwitchId;
            this.AliasBulbGroupId = AliasBulbGroupId;
            this.Position = Position;
            this.AutoHue = AutoHue;
            this.ScriptEndTime = ScriptEndTime;
        }
        
        /// <summary>
        /// 设备标识字符串 cf. 总则§2.3
        /// </summary>
        /// <value>设备标识字符串 cf. 总则§2.3</value>
        [DataMember(Name="device_identifier", EmitDefaultValue=false)]
        public string DeviceIdentifier { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        /// <value>ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// 是否已开机
        /// </summary>
        /// <value>是否已开机</value>
        [DataMember(Name="turned_on", EmitDefaultValue=false)]
        public bool TurnedOn { get; set; }

        /// <summary>
        /// 是不是自己的设备
        /// </summary>
        /// <value>是不是自己的设备</value>
        [DataMember(Name="own_device?", EmitDefaultValue=false)]
        public bool OwnDevice { get; set; }

        /// <summary>
        /// 设备的名字
        /// </summary>
        /// <value>设备的名字</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 房子ID
        /// </summary>
        /// <value>房子ID</value>
        [DataMember(Name="house_id", EmitDefaultValue=false)]
        public int? HouseId { get; set; }

        /// <summary>
        /// 在线状态说明 cf. 总则§?
        /// </summary>
        /// <value>在线状态说明 cf. 总则§?</value>
        [DataMember(Name="connectivity", EmitDefaultValue=false)]
        public string Connectivity { get; set; }

        /// <summary>
        /// 累计使用时长
        /// </summary>
        /// <value>累计使用时长</value>
        [DataMember(Name="accumulated_usage_time", EmitDefaultValue=false)]
        public int? AccumulatedUsageTime { get; set; }

        /// <summary>
        /// 亮度
        /// </summary>
        /// <value>亮度</value>
        [DataMember(Name="brightness", EmitDefaultValue=false)]
        public float? Brightness { get; set; }

        /// <summary>
        /// 色温
        /// </summary>
        /// <value>色温</value>
        [DataMember(Name="hue", EmitDefaultValue=false)]
        public float? Hue { get; set; }

        /// <summary>
        /// 位于墙面开关的第几路
        /// </summary>
        /// <value>位于墙面开关的第几路</value>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public int? Channel { get; set; }

        /// <summary>
        /// 墙面开关ID
        /// </summary>
        /// <value>墙面开关ID</value>
        [DataMember(Name="wall_switch_id", EmitDefaultValue=false)]
        public int? WallSwitchId { get; set; }

        /// <summary>
        /// 代表的组ID
        /// </summary>
        /// <value>代表的组ID</value>
        [DataMember(Name="alias_bulb_group_id", EmitDefaultValue=false)]
        public int? AliasBulbGroupId { get; set; }

        /// <summary>
        /// 排序用的序号
        /// </summary>
        /// <value>排序用的序号</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public int? Position { get; set; }

        /// <summary>
        /// 是否启用自动色温
        /// </summary>
        /// <value>是否启用自动色温</value>
        [DataMember(Name="auto_hue", EmitDefaultValue=false)]
        public bool? AutoHue { get; set; }

        /// <summary>
        /// 脚本停止时间
        /// </summary>
        /// <value>脚本停止时间</value>
        [DataMember(Name="script_end_time", EmitDefaultValue=false)]
        public DateTime? ScriptEndTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Bulb {\n");
            sb.Append("  DeviceIdentifier: ").Append(DeviceIdentifier).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TurnedOn: ").Append(TurnedOn).Append("\n");
            sb.Append("  OwnDevice: ").Append(OwnDevice).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HouseId: ").Append(HouseId).Append("\n");
            sb.Append("  Connectivity: ").Append(Connectivity).Append("\n");
            sb.Append("  AccumulatedUsageTime: ").Append(AccumulatedUsageTime).Append("\n");
            sb.Append("  Brightness: ").Append(Brightness).Append("\n");
            sb.Append("  Hue: ").Append(Hue).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  WallSwitchId: ").Append(WallSwitchId).Append("\n");
            sb.Append("  AliasBulbGroupId: ").Append(AliasBulbGroupId).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  AutoHue: ").Append(AutoHue).Append("\n");
            sb.Append("  ScriptEndTime: ").Append(ScriptEndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Bulb);
        }

        /// <summary>
        /// Returns true if Bulb instances are equal
        /// </summary>
        /// <param name="input">Instance of Bulb to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Bulb input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceIdentifier == input.DeviceIdentifier ||
                    (this.DeviceIdentifier != null &&
                    this.DeviceIdentifier.Equals(input.DeviceIdentifier))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.TurnedOn == input.TurnedOn ||
                    (this.TurnedOn != null &&
                    this.TurnedOn.Equals(input.TurnedOn))
                ) && 
                (
                    this.OwnDevice == input.OwnDevice ||
                    (this.OwnDevice != null &&
                    this.OwnDevice.Equals(input.OwnDevice))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.HouseId == input.HouseId ||
                    (this.HouseId != null &&
                    this.HouseId.Equals(input.HouseId))
                ) && 
                (
                    this.Connectivity == input.Connectivity ||
                    (this.Connectivity != null &&
                    this.Connectivity.Equals(input.Connectivity))
                ) && 
                (
                    this.AccumulatedUsageTime == input.AccumulatedUsageTime ||
                    (this.AccumulatedUsageTime != null &&
                    this.AccumulatedUsageTime.Equals(input.AccumulatedUsageTime))
                ) && 
                (
                    this.Brightness == input.Brightness ||
                    (this.Brightness != null &&
                    this.Brightness.Equals(input.Brightness))
                ) && 
                (
                    this.Hue == input.Hue ||
                    (this.Hue != null &&
                    this.Hue.Equals(input.Hue))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.WallSwitchId == input.WallSwitchId ||
                    (this.WallSwitchId != null &&
                    this.WallSwitchId.Equals(input.WallSwitchId))
                ) && 
                (
                    this.AliasBulbGroupId == input.AliasBulbGroupId ||
                    (this.AliasBulbGroupId != null &&
                    this.AliasBulbGroupId.Equals(input.AliasBulbGroupId))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.AutoHue == input.AutoHue ||
                    (this.AutoHue != null &&
                    this.AutoHue.Equals(input.AutoHue))
                ) && 
                (
                    this.ScriptEndTime == input.ScriptEndTime ||
                    (this.ScriptEndTime != null &&
                    this.ScriptEndTime.Equals(input.ScriptEndTime))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DeviceIdentifier != null)
                    hashCode = hashCode * 59 + this.DeviceIdentifier.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TurnedOn != null)
                    hashCode = hashCode * 59 + this.TurnedOn.GetHashCode();
                if (this.OwnDevice != null)
                    hashCode = hashCode * 59 + this.OwnDevice.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.HouseId != null)
                    hashCode = hashCode * 59 + this.HouseId.GetHashCode();
                if (this.Connectivity != null)
                    hashCode = hashCode * 59 + this.Connectivity.GetHashCode();
                if (this.AccumulatedUsageTime != null)
                    hashCode = hashCode * 59 + this.AccumulatedUsageTime.GetHashCode();
                if (this.Brightness != null)
                    hashCode = hashCode * 59 + this.Brightness.GetHashCode();
                if (this.Hue != null)
                    hashCode = hashCode * 59 + this.Hue.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.WallSwitchId != null)
                    hashCode = hashCode * 59 + this.WallSwitchId.GetHashCode();
                if (this.AliasBulbGroupId != null)
                    hashCode = hashCode * 59 + this.AliasBulbGroupId.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.AutoHue != null)
                    hashCode = hashCode * 59 + this.AutoHue.GetHashCode();
                if (this.ScriptEndTime != null)
                    hashCode = hashCode * 59 + this.ScriptEndTime.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }

        // 文档错误的地方：
        // turned_on int --> bool
        //

        //public override string ToString()
        //{
        //    return string.Format("{0} {1} (亮度{2}, 色温{3}) {4}",
        //        this.Id, this.Name, this.Brightness, this.Hue, this.Connectivity);
        //}

        [JsonIgnore]
        public float ActualBrightness => TurnedOn ? Brightness ?? 0.0F : 0.0F;

        public void CopyFrom(Bulb target)
        {
            this.DeviceIdentifier = target.DeviceIdentifier;
            this.Id = target.Id;
            this.TurnedOn = target.TurnedOn;
            this.OwnDevice = target.OwnDevice;
            this.Name = target.Name;
            this.HouseId = target.HouseId;
            this.Connectivity = target.Connectivity;
            this.AccumulatedUsageTime = target.AccumulatedUsageTime;
            this.Brightness = target.Brightness;
            this.Hue = target.Hue;
            this.Channel = target.Channel;
            this.WallSwitchId = target.WallSwitchId;
            this.AliasBulbGroupId = target.AliasBulbGroupId;
            this.Position = target.Position;
            this.AutoHue = target.AutoHue;
            this.ScriptEndTime = target.ScriptEndTime;
        }
    }

}
