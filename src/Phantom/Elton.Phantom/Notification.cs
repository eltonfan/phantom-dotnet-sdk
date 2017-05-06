using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Elton.Phantom
{
    public abstract class NotificationContent
    {
    }

    public class Notification
    {
        [JsonIgnore]//[JsonProperty(""), JsonConverter(typeof(StringEnumConverter)]
        public NotificationType Type { get; set; }
        [JsonIgnore]
        public string Version { get; set; }
        [JsonIgnore]
        public string UserId { get; set; }

        [JsonProperty("type")]
        public string TypeString
        {
            get { return string.Format("{0}-v{1}-{2}", this.Type, this.Version, this.UserId); }
            set
            {
                if (!ParseTypeString(value, out NotificationType type, out string version, out string user))
                    return;
                this.Type = type;
                this.Version = version;
                this.UserId = user;
            }
        }

        [JsonProperty("content")]
        public NotificationContent Content { get; set; }

        const string regexPattern = @"^(?<type>\w+)-v(?<version>[\w\.]+)-(?<user>\w+)$";
        static Regex regex = null;
        internal static bool ParseTypeString(string input, out NotificationType type, out string version, out string user)
        {
            if (regex == null)
                regex = new Regex(regexPattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);

            var match = regex.Match(input);
            if (!match.Success)
            {
                type = NotificationType.Unknown;
                version = null;
                user = null;

                return false;
            }

            bool result = true;
            if (!Enum.TryParse<NotificationType>(match.Groups["type"].Value, out type))
                result = false;
            version = match.Groups["version"].Value;
            user = match.Groups["user"].Value;

            return result;
        }

        public static string Format(Notification value)
        {
            return JsonConvert.SerializeObject(value);
        }

        public static Notification Parse(string jsonString)
        {
            return NotificationParser.Default.Parse(jsonString);
        }

        public static Notification Parse(JObject obj)
        {
            return NotificationParser.Default.Parse(obj);
        }
    }
}
