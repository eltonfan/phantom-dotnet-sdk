// Coded by chuangen http://chuangen.name.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom
{
    internal class BatchResultItem
    {
        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("headers")]
        public Dictionary<string, string> Headers { get; set; }
        [JsonProperty("status")]
        public int Status { get; set; }
    }

    internal class BatchResults
    {
        [JsonProperty("results")]
        public BatchResultItem[] Results { get; set; }
    }
}
