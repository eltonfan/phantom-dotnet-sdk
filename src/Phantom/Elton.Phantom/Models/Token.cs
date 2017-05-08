// Coded by chuangen http://chuangen.name.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom.Models
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

    //https://github.com/HuanTeng/huanteng.github.io/blob/master/oauth.md

    public class TokenV2
    {
        public string access_token { get; set; }
        /// <summary>
        /// bearer
        /// </summary>
        public string token_type { get; set; }
        public long expires_in { get; set; }
        public string refresh_token { get; set; }
        public string scope { get; set; }
        public long created_at { get; set; }
    }
}
