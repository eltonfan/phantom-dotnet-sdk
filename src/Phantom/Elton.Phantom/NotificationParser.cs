using Elton.Phantom.Notifications;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elton.Phantom
{
    internal class NotificationTypeEntry
    {
        readonly NotificationType type;
        readonly string version;
        readonly string fullName;
        readonly Type objectType;
        public NotificationTypeEntry(NotificationType type, string version, Type objectType)
        {
            this.type = type;
            this.version = version;
            this.fullName = GetFullName(type, version);
            this.objectType = objectType;
        }

        public static string GetFullName(NotificationType type, string version)
        {
            return string.IsNullOrEmpty(version) ? type.ToString() : string.Format("{0}.v{1}", type, version);
        }

        public NotificationType Type { get { return type; } }
        public string Version { get { return version; } }
        public string FullName { get { return fullName; } }
        public Type ObjectType { get { return objectType; } }
    }

    internal class NotificationParser
    {
        static NotificationParser instance = null;
        public static NotificationParser Default
        {
            get
            {
                if (instance == null)
                    instance = new NotificationParser();
                return instance;
            }
        }

        readonly Dictionary<string, NotificationTypeEntry> dicTypes = new Dictionary<string, NotificationTypeEntry>(StringComparer.OrdinalIgnoreCase);
        private NotificationParser()
        {
            AddPayloadType(NotificationType.DoorSensorsChanged, "2", typeof(DoorSensorsChanged));
            AddPayloadType(NotificationType.IoDetectorChanged, "1", typeof(IoDetectorChanged));
            AddPayloadType(NotificationType.DeviceConnectivity, "1", typeof(DeviceConnectivity));
            AddPayloadType(NotificationType.BulbsChanged, "2", typeof(BulbsChanged));
            AddPayloadType(NotificationType.InfraredSensorsChanged, "1", typeof(InfraredSensorsChanged));
            AddPayloadType(NotificationType.SwitchesChanged, "1", typeof(SwitchesChanged));
            AddPayloadType(NotificationType.WallSwitchPressed, "1", typeof(WallSwitchPressed));
            AddPayloadType(NotificationType.SwitchPressed, "1", typeof(SwitchPressed));
            AddPayloadType(NotificationType.WallSwitchesChanged, "1", typeof(WallSwitchesChanged));
            AddPayloadType(NotificationType.GroupCreated, "1", typeof(GroupCreated));
            AddPayloadType(NotificationType.SecurityPatternsChanged, "1", typeof(SecurityPatternsChanged));
            //AddPayloadType(NotificationType., "", typeof()); 通用模块发生变化
            AddPayloadType(NotificationType.UserEvent, "1", typeof(UserEvent));
        }

        public void AddPayloadType(NotificationType type, string version, Type objectType)
        {
            NotificationTypeEntry item = new NotificationTypeEntry(type, version, objectType);
            string fullName = item.FullName;
            if (dicTypes.ContainsKey(fullName))
                dicTypes[fullName] = item;
            else
                dicTypes.Add(fullName, item);
        }

        public Notification Parse(string jsonString)
        {
            if (string.IsNullOrEmpty(jsonString))
                return null;
            JObject obj = JObject.Parse(jsonString);

            return Parse(obj);
        }

        public Notification Parse(JObject obj)
        {
            string typeString = obj["type"].ToObject<string>();
            if (!Notification.ParseTypeString(typeString, out NotificationType type, out string version, out string user))
                return null;
            string key = NotificationTypeEntry.GetFullName(type, version);
            if (!dicTypes.TryGetValue(key, out NotificationTypeEntry contentType))
                return null;
            Notification result = new Notification
            {
                Type = type,
                Version = version,
                UserId = user,
                Content = obj["content"].ToObject(contentType.ObjectType) as NotificationContent,
            };

            return result;
        }

        public ICollection<NotificationTypeEntry> SupportedMessages
        {
            get { return dicTypes.Values; }
        }
    }
}
