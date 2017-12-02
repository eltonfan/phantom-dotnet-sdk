// Coded by chuangen http://chuangen.name.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom.Version1
{
    internal class Operation
    {
        [JsonProperty("method")]
        public string Method { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("params")]
        public object Parameters { get; set; }

        public Operation()
        { }
        public Operation(string method, string url)
        {
            this.Method = method;
            this.Url = url;
        }
    }
}
