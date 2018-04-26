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

namespace Elton.Phantom.Version2
{
    partial class PhantomAPI
    {
        public TokenV2 CreateToken(string authorizationCode)
        {
            return this.Post<TokenV2>(2, "../oauth2/token",
                new Argument("client_id", config.ApplicationId),
                new Argument("client_secret", config.ApplicationSecret),
                new Argument("redirect_uri", config.RedirectUri),
                new Argument("grant_type", "authorization_code"),
                new Argument("code", authorizationCode));
        }
        public TokenV2 RefreshToken(string refreshToken)
        {
            return this.Post<TokenV2>(2, "../oauth2/token",
                new Argument("grant_type", "refresh_token"),
                new Argument("refresh_token", refreshToken));
        }
        public void RevokeToken(string access_token)
        {
            this.Post<TokenV2>(2, "../oauth2/revoke",
                new Argument("token", access_token));
        }
    }
}
