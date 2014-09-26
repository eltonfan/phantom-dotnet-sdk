using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mavplus.Phantom.Models
{
    /// <summary>
    /// 用户信息。
    /// </summary>
    public class User
    {
        /// <summary>
        /// 用户的独立ID
        /// </summary>
        [JsonProperty("user_uniq_id")]
        public int UserUniqId { get; set; }
        /// <summary>
        /// 用户的名字
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// 用户的邮箱
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
        /// <summary>
        /// 用户的家的经度。
        /// </summary>
        [JsonProperty("home_long")]
        public float HomeLongitude { get; set; }
        /// <summary>
        /// 用户的家的维度。
        /// </summary>
        [JsonProperty("home_lat")]
        public float HomeLatitude { get; set; }
        /// <summary>
        /// 用户的回家情景ID
        /// </summary>
        [JsonProperty("home_coming_scenario_id")]
        public int HomeComingScenarioId { get; set; }
        /// <summary>
        /// 用户的离家情景ID
        /// </summary>
        [JsonProperty("home_leaving_scenario_id")]
        public int HomeLeavingScenarioId { get; set; }
        /// <summary>
        /// 用户的设备数量
        /// </summary>
        [JsonProperty("device_count")]
        public int DeviceCount { get; set; }
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
        /// 供旧客户端使用的认证令牌，在不久的将来本字段会被废弃
        /// </summary>
        [JsonProperty("deprecated_token")]
        public string DeprecatedToken { get; set;}
    }
}
