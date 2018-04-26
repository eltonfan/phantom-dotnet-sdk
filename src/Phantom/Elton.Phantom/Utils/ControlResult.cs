// Coded by chuangen http://chuangen.name.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom
{
    internal class ControlResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        public ControlResult()
        { }
    }
}
