// Coded by chuangen http://chuangen.name.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mavplus.Phantom.API
{
    internal class OperationResult
    {
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("body")]
        public string Body { get; set; }

        public OperationResult()
        { }
        public OperationResult(int status, string body)
        {
            this.Status = status;
            this.Body = body;
        }
    }
}
