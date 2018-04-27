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
using System.Linq;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Elton.Phantom.Models.Version1
{
    /// <summary>
    /// 设定开启/关闭触发情景
    /// </summary>
    [DataContract]
    public partial class Scenario :  IEquatable<Scenario>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Scenario" /> class.
        /// </summary>
        [JsonConstructor]
        protected Scenario() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Scenario" /> class.
        /// </summary>
        /// <param name="Id">ID (required).</param>
        /// <param name="Name">名字 (required).</param>
        /// <param name="HouseId">房间ID (required).</param>
        /// <param name="HouseName">房间名字 (required).</param>
        /// <param name="ZoneId">区域ID (required).</param>
        /// <param name="AreaId">区域ID (required).</param>
        /// <param name="Icon">Icon (required).</param>
        /// <param name="Hidden">是否隐藏 (required).</param>
        /// <param name="ZoneName">区域名字.</param>
        /// <param name="SciSize">SCI个数.</param>
        /// <param name="CreatedAt">记录的创建日期.</param>
        /// <param name="UpdatedAt">记录的更新日期.</param>
        /// <param name="ScenarioContentItems">情景内容 (required).</param>
        /// <param name="AlarmIds">定时情景id.</param>
        public Scenario(int? Id = default, string Name = default, int? HouseId = default, string HouseName = default, int? ZoneId = default, int? AreaId = default, int? Icon = default, bool? Hidden = default, string ZoneName = default, int? SciSize = default, DateTime? CreatedAt = default, DateTime? UpdatedAt = default, List<ScenarioContentItem> ScenarioContentItems = default, List<int> AlarmIds = default)
        {
            // to ensure "Id" is required (not null)
            this.Id = Id ?? throw new InvalidDataException("Id is a required property for Scenario and cannot be null");
            // to ensure "Name" is required (not null)
            this.Name = Name ?? throw new InvalidDataException("Name is a required property for Scenario and cannot be null");
            // to ensure "HouseId" is required (not null)
            this.HouseId = HouseId ?? throw new InvalidDataException("HouseId is a required property for Scenario and cannot be null");
            // to ensure "HouseName" is required (not null)
            this.HouseName = HouseName ?? throw new InvalidDataException("HouseName is a required property for Scenario and cannot be null");
            // to ensure "ZoneId" is required (not null)
            this.ZoneId = ZoneId ?? throw new InvalidDataException("ZoneId is a required property for Scenario and cannot be null");
            // to ensure "AreaId" is required (not null)
            this.AreaId = AreaId ?? throw new InvalidDataException("AreaId is a required property for Scenario and cannot be null");
            // to ensure "Icon" is required (not null)
            this.Icon = Icon ?? throw new InvalidDataException("Icon is a required property for Scenario and cannot be null");
            // to ensure "Hidden" is required (not null)
            this.Hidden = Hidden ?? throw new InvalidDataException("Hidden is a required property for Scenario and cannot be null");
            // to ensure "ScenarioContentItems" is required (not null)
            this.ScenarioContentItems = ScenarioContentItems ?? throw new InvalidDataException("ScenarioContentItems is a required property for Scenario and cannot be null");

            this.ZoneName = ZoneName;
            this.SciSize = SciSize;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            this.AlarmIds = AlarmIds;
        }
        
        /// <summary>
        /// ID
        /// </summary>
        /// <value>ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        /// <value>名字</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 房间ID
        /// </summary>
        /// <value>房间ID</value>
        [DataMember(Name="house_id", EmitDefaultValue=false)]
        public int? HouseId { get; set; }

        /// <summary>
        /// 房间名字
        /// </summary>
        /// <value>房间名字</value>
        [DataMember(Name="house_name", EmitDefaultValue=false)]
        public string HouseName { get; set; }

        /// <summary>
        /// 区域ID
        /// </summary>
        /// <value>区域ID</value>
        [DataMember(Name="zone_id", EmitDefaultValue=false)]
        public int? ZoneId { get; set; }

        /// <summary>
        /// 区域ID
        /// </summary>
        /// <value>区域ID</value>
        [DataMember(Name="area_id", EmitDefaultValue=false)]
        public int? AreaId { get; set; }

        /// <summary>
        /// Icon
        /// </summary>
        /// <value>Icon</value>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public int? Icon { get; set; }

        /// <summary>
        /// 是否隐藏
        /// </summary>
        /// <value>是否隐藏</value>
        [DataMember(Name="hidden", EmitDefaultValue=false)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// 区域名字
        /// </summary>
        /// <value>区域名字</value>
        [DataMember(Name="zone_name", EmitDefaultValue=false)]
        public string ZoneName { get; set; }

        /// <summary>
        /// SCI个数
        /// </summary>
        /// <value>SCI个数</value>
        [DataMember(Name="sci_size", EmitDefaultValue=false)]
        public int? SciSize { get; set; }

        /// <summary>
        /// 记录的创建日期
        /// </summary>
        /// <value>记录的创建日期</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 记录的更新日期
        /// </summary>
        /// <value>记录的更新日期</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 情景内容
        /// </summary>
        /// <value>情景内容</value>
        [DataMember(Name="scenario_content_items", EmitDefaultValue=false)]
        public List<ScenarioContentItem> ScenarioContentItems { get; set; }

        /// <summary>
        /// 定时情景id
        /// </summary>
        /// <value>定时情景id</value>
        [DataMember(Name="alarm_ids", EmitDefaultValue=false)]
        public List<int> AlarmIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Scenario {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HouseId: ").Append(HouseId).Append("\n");
            sb.Append("  HouseName: ").Append(HouseName).Append("\n");
            sb.Append("  ZoneId: ").Append(ZoneId).Append("\n");
            sb.Append("  AreaId: ").Append(AreaId).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  ZoneName: ").Append(ZoneName).Append("\n");
            sb.Append("  SciSize: ").Append(SciSize).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ScenarioContentItems: ").Append(ScenarioContentItems).Append("\n");
            sb.Append("  AlarmIds: ").Append(AlarmIds).Append("\n");
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
            return this.Equals(input as Scenario);
        }

        /// <summary>
        /// Returns true if Scenario instances are equal
        /// </summary>
        /// <param name="input">Instance of Scenario to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Scenario input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.HouseName == input.HouseName ||
                    (this.HouseName != null &&
                    this.HouseName.Equals(input.HouseName))
                ) && 
                (
                    this.ZoneId == input.ZoneId ||
                    (this.ZoneId != null &&
                    this.ZoneId.Equals(input.ZoneId))
                ) && 
                (
                    this.AreaId == input.AreaId ||
                    (this.AreaId != null &&
                    this.AreaId.Equals(input.AreaId))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.Hidden == input.Hidden ||
                    (this.Hidden != null &&
                    this.Hidden.Equals(input.Hidden))
                ) && 
                (
                    this.ZoneName == input.ZoneName ||
                    (this.ZoneName != null &&
                    this.ZoneName.Equals(input.ZoneName))
                ) && 
                (
                    this.SciSize == input.SciSize ||
                    (this.SciSize != null &&
                    this.SciSize.Equals(input.SciSize))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.ScenarioContentItems == input.ScenarioContentItems ||
                    this.ScenarioContentItems != null &&
                    this.ScenarioContentItems.SequenceEqual(input.ScenarioContentItems)
                ) && 
                (
                    this.AlarmIds == input.AlarmIds ||
                    this.AlarmIds != null &&
                    this.AlarmIds.SequenceEqual(input.AlarmIds)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.HouseId != null)
                    hashCode = hashCode * 59 + this.HouseId.GetHashCode();
                if (this.HouseName != null)
                    hashCode = hashCode * 59 + this.HouseName.GetHashCode();
                if (this.ZoneId != null)
                    hashCode = hashCode * 59 + this.ZoneId.GetHashCode();
                if (this.AreaId != null)
                    hashCode = hashCode * 59 + this.AreaId.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.Hidden != null)
                    hashCode = hashCode * 59 + this.Hidden.GetHashCode();
                if (this.ZoneName != null)
                    hashCode = hashCode * 59 + this.ZoneName.GetHashCode();
                if (this.SciSize != null)
                    hashCode = hashCode * 59 + this.SciSize.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.ScenarioContentItems != null)
                    hashCode = hashCode * 59 + this.ScenarioContentItems.GetHashCode();
                if (this.AlarmIds != null)
                    hashCode = hashCode * 59 + this.AlarmIds.GetHashCode();
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

        public void CopyFrom(Scenario target)
        {
            this.Id = target.Id;
            this.Name = target.Name;
            this.HouseId = target.HouseId;
            this.HouseName = target.HouseName;
            this.ZoneId = target.ZoneId;
            this.AreaId = target.AreaId;
            this.Icon = target.Icon;
            this.Hidden = target.Hidden;
            this.ScenarioContentItems = target.ScenarioContentItems;
            this.ZoneName = ZoneName;
            this.SciSize = SciSize;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            this.AlarmIds = AlarmIds;
        }

        // 文档错误：
        // house_name int? --> string
        // zone_name int? --> string

        public class ScenarioAverage
        {
            [DataMember(Name = "hue", EmitDefaultValue = false)]
            public float Hue { get; set; }
            [DataMember(Name = "brightness", EmitDefaultValue = false)]
            public float Brightness { get; set; }
        }
        [DataMember(Name = "average", EmitDefaultValue = false)]
        public ScenarioAverage Average { get; set; }
    }
}
