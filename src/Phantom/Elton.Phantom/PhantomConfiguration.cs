// Coded by chuangen http://chuangen.name.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom
{
    /// <summary>
    /// 幻腾接口配置。（配置客户端信息）
    /// 从 https://huantengsmart.com/oauth2/applications 获取 Application 信息。
    /// </summary>
    public class PhantomConfiguration
    {
        [JsonProperty("appId")]
        public string ApplicationId { get; set; }
        [JsonProperty("appSecret")]
        public string ApplicationSecret { get; set; }
        [JsonProperty("redirectUri")]
        public string RedirectUri { get; set; }
        /// <summary>
        /// 客户端的 User-Agent。
        /// </summary>
        [JsonProperty("userAgent")]
        public string UserAgent { get; set; } = "eltonfan@live.cn/1.0.0 (Windows 10)";
        /// <summary>
        /// 请求的时间间隔。（毫秒）
        /// </summary>
        public int RequestInterval { get; set; } = 20 * 1000;

        public PhantomConfiguration()
        { }

        public PhantomConfiguration(string appId, string appSecret, string redirectUri)
        {
            this.ApplicationId = appId;
            this.ApplicationSecret = appSecret;
            this.RedirectUri = redirectUri;
        }
    }

    public class TokenConfig
    {
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
        [JsonProperty("refreshToken")]
        public string RefreshToken { get; set; }
        [JsonProperty("scope")]
        public string Scopes { get; set; }
        [JsonProperty("expiresIn")]
        public int ExpiresIn { get; set; }
        [JsonProperty("createdAt")]
        public int CreatedAt { get; set; }

        [JsonIgnore]
        public DateTime DateExpired
        {
            get => DateCreated.AddSeconds(ExpiresIn);
            set => ExpiresIn = (int)value.Subtract(DateCreated).TotalSeconds;
        }

        [JsonIgnore]
        public DateTime DateCreated
        {
            get => new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(CreatedAt);
            set => CreatedAt = (int)value.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }

        public void CopyFrom(Models.TokenV2 token)
        {
            this.AccessToken = token.AccessToken;
            this.RefreshToken = token.RefreshToken;
            this.Scopes = token.Scopes;
            this.ExpiresIn = token.ExpiresIn;
            this.CreatedAt = token.CreatedAt;
        }
    }
}