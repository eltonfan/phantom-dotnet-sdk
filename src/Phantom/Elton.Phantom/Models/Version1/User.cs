#region License

//   Copyright 2014 Elton FAN (eltonfan@live.cn, http://elton.io) (eltonfan@live.cn, http://elton.io)
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
    /// 获取当前用户的资料
    /// </summary>
    [DataContract]
    public partial class User :  IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        [JsonConstructor]
        protected User() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="Id">幻腾用户ID (required).</param>
        /// <param name="UserUniqId">用户的独立ID (required).</param>
        /// <param name="Phone">手机号.</param>
        /// <param name="Name">用户的名字 (required).</param>
        /// <param name="Email">用户的邮箱 (required).</param>
        /// <param name="HomeLong">用户的家的经度.</param>
        /// <param name="HomeLat">用户的家的纬度.</param>
        /// <param name="HomeInfo">info.</param>
        /// <param name="HomeGaodeLong">高德地图经度.</param>
        /// <param name="HomeGaodeLat">高德地图纬度.</param>
        /// <param name="HomeComingScenarioId">用户的回家情景ID.</param>
        /// <param name="HomeLeavingScenarioId">用户的离家情景ID.</param>
        /// <param name="DeviceCount">用户的设备数量 (required).</param>
        /// <param name="SleepTime">用户的入睡时间，数值以当日分钟数.</param>
        /// <param name="WakeTime">用户的起床时间，数值以当日分钟数.</param>
        /// <param name="CreatedAt">记录的创建日期.</param>
        /// <param name="UpdatedAt">记录的更新日期.</param>
        /// <param name="Type">用户type (required).</param>
        /// <param name="DeprecatedToken">供旧客户端使用的认证令牌，在不久的将来本字段会被废弃 (required).</param>
        /// <param name="Nickname">用户昵称.</param>
        /// <param name="Avatar">用户头像地址.</param>
        /// <param name="VoiceMessageUrl">语音留言链接.</param>
        /// <param name="HasIermuUser">账户下是否存在iermu用户.</param>
        public User(int? Id = default, string UserUniqId = default, string Phone = default, string Name = default, string Email = default, string HomeLong = default, string HomeLat = default, string HomeInfo = default, string HomeGaodeLong = default, string HomeGaodeLat = default, int? HomeComingScenarioId = default, int? HomeLeavingScenarioId = default, string DeviceCount = default, int? SleepTime = default, int? WakeTime = default, DateTime? CreatedAt = default, DateTime? UpdatedAt = default, string Type = default, string DeprecatedToken = default, string Nickname = default, string Avatar = default, string VoiceMessageUrl = default, string HasIermuUser = default)
        {
            // to ensure "Id" is required (not null)
            this.Id = Id ?? throw new InvalidDataException("Id is a required property for User and cannot be null");
            // to ensure "UserUniqId" is required (not null)
            this.UserUniqId = UserUniqId ?? throw new InvalidDataException("UserUniqId is a required property for User and cannot be null");
            // to ensure "Name" is required (not null)
            this.Name = Name ?? throw new InvalidDataException("Name is a required property for User and cannot be null");
            // to ensure "Email" is required (not null)
            this.Email = Email ?? throw new InvalidDataException("Email is a required property for User and cannot be null");
            // to ensure "DeviceCount" is required (not null)
            this.DeviceCount = DeviceCount ?? throw new InvalidDataException("DeviceCount is a required property for User and cannot be null");
            // to ensure "Type" is required (not null)
            this.Type = Type ?? throw new InvalidDataException("Type is a required property for User and cannot be null");
            // to ensure "DeprecatedToken" is required (not null)
            this.DeprecatedToken = DeprecatedToken ?? throw new InvalidDataException("DeprecatedToken is a required property for User and cannot be null");

            this.Phone = Phone;
            this.HomeLong = HomeLong;
            this.HomeLat = HomeLat;
            this.HomeInfo = HomeInfo;
            this.HomeGaodeLong = HomeGaodeLong;
            this.HomeGaodeLat = HomeGaodeLat;
            this.HomeComingScenarioId = HomeComingScenarioId;
            this.HomeLeavingScenarioId = HomeLeavingScenarioId;
            this.SleepTime = SleepTime;
            this.WakeTime = WakeTime;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            this.Nickname = Nickname;
            this.Avatar = Avatar;
            this.VoiceMessageUrl = VoiceMessageUrl;
            this.HasIermuUser = HasIermuUser;
        }
        
        /// <summary>
        /// 幻腾用户ID
        /// </summary>
        /// <value>幻腾用户ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// 用户的独立ID
        /// </summary>
        /// <value>用户的独立ID</value>
        [DataMember(Name="user_uniq_id", EmitDefaultValue=false)]
        public string UserUniqId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        /// <value>手机号</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// 用户的名字
        /// </summary>
        /// <value>用户的名字</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 用户的邮箱
        /// </summary>
        /// <value>用户的邮箱</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// 用户的家的经度
        /// </summary>
        /// <value>用户的家的经度</value>
        [DataMember(Name="home_long", EmitDefaultValue=false)]
        public string HomeLong { get; set; }

        /// <summary>
        /// 用户的家的纬度
        /// </summary>
        /// <value>用户的家的纬度</value>
        [DataMember(Name="home_lat", EmitDefaultValue=false)]
        public string HomeLat { get; set; }

        /// <summary>
        /// info
        /// </summary>
        /// <value>info</value>
        [DataMember(Name="home_info", EmitDefaultValue=false)]
        public string HomeInfo { get; set; }

        /// <summary>
        /// 高德地图经度
        /// </summary>
        /// <value>高德地图经度</value>
        [DataMember(Name="home_gaode_long", EmitDefaultValue=false)]
        public string HomeGaodeLong { get; set; }

        /// <summary>
        /// 高德地图纬度
        /// </summary>
        /// <value>高德地图纬度</value>
        [DataMember(Name="home_gaode_lat", EmitDefaultValue=false)]
        public string HomeGaodeLat { get; set; }

        /// <summary>
        /// 用户的回家情景ID
        /// </summary>
        /// <value>用户的回家情景ID</value>
        [DataMember(Name="home_coming_scenario_id", EmitDefaultValue=false)]
        public int? HomeComingScenarioId { get; set; }

        /// <summary>
        /// 用户的离家情景ID
        /// </summary>
        /// <value>用户的离家情景ID</value>
        [DataMember(Name="home_leaving_scenario_id", EmitDefaultValue=false)]
        public int? HomeLeavingScenarioId { get; set; }

        /// <summary>
        /// 用户的设备数量
        /// </summary>
        /// <value>用户的设备数量</value>
        [DataMember(Name="device_count", EmitDefaultValue=false)]
        public string DeviceCount { get; set; }

        /// <summary>
        /// 用户的入睡时间，数值以当日分钟数
        /// </summary>
        /// <value>用户的入睡时间，数值以当日分钟数</value>
        [DataMember(Name="sleep_time", EmitDefaultValue=false)]
        public int? SleepTime { get; set; }

        /// <summary>
        /// 用户的起床时间，数值以当日分钟数
        /// </summary>
        /// <value>用户的起床时间，数值以当日分钟数</value>
        [DataMember(Name="wake_time", EmitDefaultValue=false)]
        public int? WakeTime { get; set; }

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
        /// 用户type
        /// </summary>
        /// <value>用户type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// 供旧客户端使用的认证令牌，在不久的将来本字段会被废弃
        /// </summary>
        /// <value>供旧客户端使用的认证令牌，在不久的将来本字段会被废弃</value>
        [DataMember(Name="deprecated_token", EmitDefaultValue=false)]
        public string DeprecatedToken { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        /// <value>用户昵称</value>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// 用户头像地址
        /// </summary>
        /// <value>用户头像地址</value>
        [DataMember(Name="avatar", EmitDefaultValue=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// 语音留言链接
        /// </summary>
        /// <value>语音留言链接</value>
        [DataMember(Name="voice_message_url", EmitDefaultValue=false)]
        public string VoiceMessageUrl { get; set; }

        /// <summary>
        /// 账户下是否存在iermu用户
        /// </summary>
        /// <value>账户下是否存在iermu用户</value>
        [DataMember(Name="has_iermu_user", EmitDefaultValue=false)]
        public string HasIermuUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserUniqId: ").Append(UserUniqId).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  HomeLong: ").Append(HomeLong).Append("\n");
            sb.Append("  HomeLat: ").Append(HomeLat).Append("\n");
            sb.Append("  HomeInfo: ").Append(HomeInfo).Append("\n");
            sb.Append("  HomeGaodeLong: ").Append(HomeGaodeLong).Append("\n");
            sb.Append("  HomeGaodeLat: ").Append(HomeGaodeLat).Append("\n");
            sb.Append("  HomeComingScenarioId: ").Append(HomeComingScenarioId).Append("\n");
            sb.Append("  HomeLeavingScenarioId: ").Append(HomeLeavingScenarioId).Append("\n");
            sb.Append("  DeviceCount: ").Append(DeviceCount).Append("\n");
            sb.Append("  SleepTime: ").Append(SleepTime).Append("\n");
            sb.Append("  WakeTime: ").Append(WakeTime).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DeprecatedToken: ").Append(DeprecatedToken).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  VoiceMessageUrl: ").Append(VoiceMessageUrl).Append("\n");
            sb.Append("  HasIermuUser: ").Append(HasIermuUser).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
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
                    this.UserUniqId == input.UserUniqId ||
                    (this.UserUniqId != null &&
                    this.UserUniqId.Equals(input.UserUniqId))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.HomeLong == input.HomeLong ||
                    (this.HomeLong != null &&
                    this.HomeLong.Equals(input.HomeLong))
                ) && 
                (
                    this.HomeLat == input.HomeLat ||
                    (this.HomeLat != null &&
                    this.HomeLat.Equals(input.HomeLat))
                ) && 
                (
                    this.HomeInfo == input.HomeInfo ||
                    (this.HomeInfo != null &&
                    this.HomeInfo.Equals(input.HomeInfo))
                ) && 
                (
                    this.HomeGaodeLong == input.HomeGaodeLong ||
                    (this.HomeGaodeLong != null &&
                    this.HomeGaodeLong.Equals(input.HomeGaodeLong))
                ) && 
                (
                    this.HomeGaodeLat == input.HomeGaodeLat ||
                    (this.HomeGaodeLat != null &&
                    this.HomeGaodeLat.Equals(input.HomeGaodeLat))
                ) && 
                (
                    this.HomeComingScenarioId == input.HomeComingScenarioId ||
                    (this.HomeComingScenarioId != null &&
                    this.HomeComingScenarioId.Equals(input.HomeComingScenarioId))
                ) && 
                (
                    this.HomeLeavingScenarioId == input.HomeLeavingScenarioId ||
                    (this.HomeLeavingScenarioId != null &&
                    this.HomeLeavingScenarioId.Equals(input.HomeLeavingScenarioId))
                ) && 
                (
                    this.DeviceCount == input.DeviceCount ||
                    (this.DeviceCount != null &&
                    this.DeviceCount.Equals(input.DeviceCount))
                ) && 
                (
                    this.SleepTime == input.SleepTime ||
                    (this.SleepTime != null &&
                    this.SleepTime.Equals(input.SleepTime))
                ) && 
                (
                    this.WakeTime == input.WakeTime ||
                    (this.WakeTime != null &&
                    this.WakeTime.Equals(input.WakeTime))
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.DeprecatedToken == input.DeprecatedToken ||
                    (this.DeprecatedToken != null &&
                    this.DeprecatedToken.Equals(input.DeprecatedToken))
                ) && 
                (
                    this.Nickname == input.Nickname ||
                    (this.Nickname != null &&
                    this.Nickname.Equals(input.Nickname))
                ) && 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
                ) && 
                (
                    this.VoiceMessageUrl == input.VoiceMessageUrl ||
                    (this.VoiceMessageUrl != null &&
                    this.VoiceMessageUrl.Equals(input.VoiceMessageUrl))
                ) && 
                (
                    this.HasIermuUser == input.HasIermuUser ||
                    (this.HasIermuUser != null &&
                    this.HasIermuUser.Equals(input.HasIermuUser))
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
                if (this.UserUniqId != null)
                    hashCode = hashCode * 59 + this.UserUniqId.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.HomeLong != null)
                    hashCode = hashCode * 59 + this.HomeLong.GetHashCode();
                if (this.HomeLat != null)
                    hashCode = hashCode * 59 + this.HomeLat.GetHashCode();
                if (this.HomeInfo != null)
                    hashCode = hashCode * 59 + this.HomeInfo.GetHashCode();
                if (this.HomeGaodeLong != null)
                    hashCode = hashCode * 59 + this.HomeGaodeLong.GetHashCode();
                if (this.HomeGaodeLat != null)
                    hashCode = hashCode * 59 + this.HomeGaodeLat.GetHashCode();
                if (this.HomeComingScenarioId != null)
                    hashCode = hashCode * 59 + this.HomeComingScenarioId.GetHashCode();
                if (this.HomeLeavingScenarioId != null)
                    hashCode = hashCode * 59 + this.HomeLeavingScenarioId.GetHashCode();
                if (this.DeviceCount != null)
                    hashCode = hashCode * 59 + this.DeviceCount.GetHashCode();
                if (this.SleepTime != null)
                    hashCode = hashCode * 59 + this.SleepTime.GetHashCode();
                if (this.WakeTime != null)
                    hashCode = hashCode * 59 + this.WakeTime.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DeprecatedToken != null)
                    hashCode = hashCode * 59 + this.DeprecatedToken.GetHashCode();
                if (this.Nickname != null)
                    hashCode = hashCode * 59 + this.Nickname.GetHashCode();
                if (this.Avatar != null)
                    hashCode = hashCode * 59 + this.Avatar.GetHashCode();
                if (this.VoiceMessageUrl != null)
                    hashCode = hashCode * 59 + this.VoiceMessageUrl.GetHashCode();
                if (this.HasIermuUser != null)
                    hashCode = hashCode * 59 + this.HasIermuUser.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
