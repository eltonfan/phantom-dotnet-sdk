using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mavplus.Phantom.Models
{
    /// <summary>
    /// 令牌。
    /// </summary>
    public class Token
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
        [JsonProperty("expires_in")]
        public long ExpiresIn { get; set; }
        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
