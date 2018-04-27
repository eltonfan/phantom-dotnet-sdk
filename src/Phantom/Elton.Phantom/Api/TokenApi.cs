#region License

//   Copyright 2014 Elton FAN
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

using Elton.Phantom.Models;
using Elton.Phantom.Models.Version1;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom
{
    partial class PhantomApi
    {
        public Token CreateToken(string authorizationCode)
        {
            return this.Post<Token>(2, "../oauth2/token",
                new Argument("client_id", config.ApplicationId),
                new Argument("client_secret", config.ApplicationSecret),
                new Argument("redirect_uri", config.RedirectUri),
                new Argument("grant_type", "authorization_code"),
                new Argument("code", authorizationCode));
        }
        public Token RefreshToken(string refreshToken)
        {
            return this.Post<Token>(2, "../oauth2/token",
                new Argument("grant_type", "refresh_token"),
                new Argument("refresh_token", refreshToken));
        }
        public void RevokeToken(string access_token)
        {
            this.Post<Token>(2, "../oauth2/revoke",
                new Argument("token", access_token));
        }
    }
}
