using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Elton.Phantom
{
    public enum UserEventType
    {
        [EnumMember(Value = "back")]
        Back,
        [EnumMember(Value = "leave")]
        Leave,
    }
}
