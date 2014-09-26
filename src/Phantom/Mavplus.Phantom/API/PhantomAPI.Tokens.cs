using Mavplus.Phantom.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Mavplus.Phantom.API
{
    partial class PhantomAPI
    {
        /// <summary>
        /// 获取当前用户的一个令牌。
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Token CreateToken()
        {
            return this.POST<Token>(
                "tokens.json", null,
                new Argument("app_id", config.AppId),
                new Argument("app_secret", config.AppSecret));
        }
        /// <summary>
        /// 使用基本认证方式，获取当前用户的一个令牌。
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Token CreateToken(string userName, string password)
        {
            return this.POST<Token>(
                "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(userName + ":" + password)),
                "tokens.json", null,
                new Argument("app_id", config.AppId),
                new Argument("app_secret", config.AppSecret));
        }
        public Token RefreshToken()
        {
            Token[] list = GET<Token[]>("tokens.json");

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
    }
}
