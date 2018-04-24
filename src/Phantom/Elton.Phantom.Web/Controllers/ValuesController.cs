using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text;

namespace Elton.Phantom.Web.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var client = MyClient.Default.Client;
            if (client.Connected)
                return new string[] { "Connected" };


            //成功：GET redirect_uri/?code=authorize_code
            //失败：GET redirect_uri/?error=access_denied&error_description=The+resource+owner+or+authorization+server+denied+the+request.

            var code = HttpContext.Request.Query["code"].FirstOrDefault();
            var error = HttpContext.Request.Query["error"].FirstOrDefault();
            var error_description = HttpContext.Request.Query["error_description"].FirstOrDefault();
            if (!string.IsNullOrEmpty(error))
            {
                return new string[] { error, error_description, };
            }
            else if(string.IsNullOrEmpty(code))
            {
                error = "Failed";
                error_description = "The code query is empty.";

                var scope = PhantomScopes.GetString();
                string url = string.Format("https://huantengsmart.com/oauth2/authorize?client_id={0}&scope={1}&redirect_uri={2}&response_type=code",
                    SecretKeys.Phantom606.AppId,
                    scope,
                    WebUtility.UrlEncode(SecretKeys.Phantom606.RedirectUri));//WebUtility.UrlEncode("http://localhost:58288/api/values"));
                return new string[] { "Failed", url, };
            }
            else
            {
                string authorizeCode = code;
                var api = new PhantomApi(MyClient.Default.Configuration);
                var token = api.CreateToken(authorizeCode);

                //settings.AccessToken = token.AccessToken;
                //settings.RefreshToken = token.RefreshToken;
                //settings.Save();
                client.Connect(token.AccessToken);
                return new string[] { "Finished", token.AccessToken, };
            }

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
