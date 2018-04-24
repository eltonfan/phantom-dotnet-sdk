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

    /// <summary>
    /// 刷新一个令牌。文档有误
    /// </summary>
    public class TokenV2
    {
        /// <summary>
        /// 访问令牌 cf.RFC6749
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        /// <summary>
        /// 设备的名字 cf.RFC6749
        /// bearer
        /// </summary>
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
        /// <summary>
        /// 刷新令牌 cf.RFC6749
        /// </summary>
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
        /// <summary>
        /// 几秒后过期 cf.RFC6749
        /// </summary>
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }
        /// <summary>
        /// 客户端
        /// </summary>
        //[JsonProperty("user_agent")]
        //public string UserAgent { get; set; }
        /// <summary>
        /// utc的时间戳(单位: 秒)
        /// </summary>
        //[JsonProperty("timestamp")]
        //public int Timestamp { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("scope")]
        public string Scopes { get; set; }
    }
}