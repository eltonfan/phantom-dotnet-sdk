#region License

//   Copyright 2014 Elton FAN (eltonfan@live.cn, http://elton.io)
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 

#endregion

using Elton.Phantom.Models.Version1;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom
{
    /// <summary>
    /// 幻腾接口配置。（配置客户端信息）
    /// 从 https://huantengsmart.com/oauth2/applications 获取 Application 信息。
    /// </summary>
    [DataContract]
    public class PhantomConfiguration : Elton.OAuth2.ApiConfiguration
    {
        [JsonConstructor]
        protected PhantomConfiguration() { }

        public PhantomConfiguration(string appId = default, string appSecret = default, string redirectUrl = default)
        {
            BaseUrl = $"https://huantengsmart.com/api/";
            AuthorizationUrl = $"https://huantengsmart.com/oauth2/authorize";
            RefreshTokenUrl = $"https://huantengsmart.com/oauth2/token";
            AccessTokenUrl = $"https://huantengsmart.com/oauth2/token";
            RevokeTokenUrl = $"https://huantengsmart.com/oauth2/token";

            this.ApplicationId = appId;
            this.ApplicationSecret = appSecret;
            this.RedirectUri = redirectUrl;
        }

        public string GetAuthorizationUrl(string appId = default, string redirectUri = default, string scope = default)
        {
            if (redirectUri != null)
                redirectUri = System.Web.HttpUtility.UrlEncode(redirectUri, Encoding.UTF8);
            return $"{AuthorizationUrl}?client_id={appId}&scope={scope}&redirect_uri={redirectUri}&response_type=code";
        }
    }
}