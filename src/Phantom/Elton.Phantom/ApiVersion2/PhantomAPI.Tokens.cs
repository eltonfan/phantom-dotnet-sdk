// Coded by chuangen http://chuangen.name.

using Elton.Phantom.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom.ApiVersion2
{
    partial class PhantomAPI
    {
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

        public TokenV2 CreateToken(string authorizationCode)
        {
            return this.POST<TokenV2>(null, "../oauth2/token", null,
                new Argument("client_id", config.AppId),
                new Argument("client_secret", config.AppSecret),
                new Argument("redirect_uri", config.RedirectUri),
                new Argument("grant_type", "authorization_code"),
                new Argument("code", authorizationCode));
        }
        public TokenV2 RefreshToken(string refreshToken)
        {
            return this.POST<TokenV2>(null, "../oauth2/token", null,
                new Argument("grant_type", "refresh_token"),
                new Argument("refresh_token", refreshToken));
        }
        public void RevokeToken(string access_token)
        {
            this.POST<TokenV2>(null, "../oauth2/revoke", null,
                new Argument("token", access_token));
        }
    }
}
