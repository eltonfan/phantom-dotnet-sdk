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
        public Token RefreshToken()
        {
            Token[] list = GET<Token[]>("tokens.json");

            Token token = null;
            if (list != null)
            {
                foreach (Token item in list)
                {
                    if (item.expires_in <= 0)
                        continue;
                    if (item.user_agent != config.UserAgent)
                        continue;

                    if (token == null || token.expires_in < item.expires_in)
                        token = item;
                }
            }
            return token;
        }
    }
}
