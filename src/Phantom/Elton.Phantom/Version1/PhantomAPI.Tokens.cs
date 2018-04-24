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

namespace Elton.Phantom.Version1
{
    partial class PhantomAPI
    {
        /// <summary>
        /// 获取当前用户的一个令牌。获取新令牌后，旧令牌失效。
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [Obsolete]
        public Token CreateToken()
        {
            return this.POST<Token>(
                "tokens.json", null,
                new Argument("app_id", config.ApplicationId),
                new Argument("app_secret", config.ApplicationSecret));
        }
        /// <summary>
        /// 换取令牌。请使用基本身份认证与POST /tokens接口获取令牌，获取时需要传递第一步中获取的键/密对，亦即app_id和app_secret。
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        [Obsolete]
        public Token CreateToken(string authorization, out User userInfo)
        {
            Token token = null;
            userInfo = null;

            Operation ops1 = new Operation("GET", "/api/user.json");
            Operation ops2 = new Operation("POST", "/api/tokens.json");
            JObject para = new JObject();
            para.Add("app_id", config.ApplicationId);
            para.Add("app_secret", config.ApplicationSecret);
            ops2.Parameters = para;

            OperationResult[] results = this.Batch(
                authorization,
                ops1, ops2);
            if (results[0].Status == 200)
                userInfo = JsonConvert.DeserializeObject<User>(results[0].Body);
            if (results[1].Status == 201)
                token = JsonConvert.DeserializeObject<Token>(results[1].Body);

            return token;
        }
        [Obsolete]
        public Token[] GetTokens()
        {
            return GetJson<Token[]>("tokens.json");
        }
        [Obsolete]
        public Token GetCurrentToken()
        {
            Token[] list = GetTokens();

            Token token = null;
            if (list != null)
            {
                foreach (Token item in list)
                {
                    if (item.ExpiresIn <= 0)
                        continue;
                    if (item.UserAgent != config.UserAgent)
                        continue;

                    if (token == null || token.ExpiresIn < item.ExpiresIn)
                        token = item;
                }
            }
            return token;
        }

        [Obsolete]
        public Token RefreshToken(string refreshToken)
        {
            return this.PUT<Token>("tokens/refresh", null,
                new
                {
                    app_id = config.ApplicationId,
                    app_secret = config.ApplicationSecret,
                    refresh_token = refreshToken,
                });
        }
    }
}
