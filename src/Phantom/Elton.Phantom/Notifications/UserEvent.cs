using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elton.Phantom.Notifications
{
    /// <summary>
    /// 用户离家回家
    /// </summary>
    public class UserEvent : NotificationContent
    {
        [JsonProperty("user_uniq_id")]
        public string user_uniq_id { get; set; }
        [JsonProperty("event"), JsonConverter(typeof(StringEnumConverter))]
        public UserEventType EventType { get; set; }
        [JsonProperty("distance")]
        public int Distance { get; set; }
    }
}
