using Mavplus.Phantom.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Mavplus.Phantom.API
{
    /// <summary>
    /// 实现对幻腾API的各功能封装。
    /// </summary>
    /// <remarks> https://huantengsmart.com/doc/api_v1 </remarks>
    public partial class PhantomAPI
    {
        readonly RestClient client = null;
        readonly PhantomConfiguration config = null;
        readonly Dictionary<int, Bulb> dicBulbs = new Dictionary<int, Bulb>();

        string token = null;
        public PhantomAPI(PhantomConfiguration config)
        {
            if (config == null)
                throw new ArgumentNullException("config", "config 不能为空。");
            this.config = config;

            client = new RestClient("https://huantengsmart.com/api/");
            client.UserAgent = config.UserAgent;

            client.DefaultParameters.Add(new Parameter
            {
                Name = "Accept",
                Type = ParameterType.HttpHeader,
                Value = "application/vnd.huantengsmart-v1+json",
            });//"application/json"
        }

        public void SetCredentials(string token)
        {
            this.token = token;
        }

        public bool Ping()
        {
            string result = this.GET<string>("ping.json");
            if (string.IsNullOrEmpty(result))
                return false;

            return result.Contains("pong");
        }

        protected T GET<T>(string url, params UrlSegment[] urlSegments)
        {
            var request = new RestRequest(url, Method.GET);
            if (urlSegments != null)
            {
                foreach (UrlSegment item in urlSegments)
                    request.AddUrlSegment(item.Key, item.Value);
            }
            if(this.token != null)
                request.AddHeader("Authorization", "token " + this.token);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            IRestResponse response = client.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                //{"status":"500","error":"Internal Server Error"}
                JObject obj = JsonConvert.DeserializeObject(response.Content) as JObject;
                int status = obj.Value<int>("status");
                string error = obj.Value<string>("error");

                throw new PhantomException(error);
            }

            var content = response.Content; // raw content as string
            return JsonConvert.DeserializeObject<T>(content);
        }

        protected void SET<T>(string url, UrlSegment[] urlSegments, params Argument[] arguments)
        {
            var request = new RestRequest(url, Method.POST);
            if (urlSegments != null)
            {
                foreach (UrlSegment item in urlSegments)
                    request.AddUrlSegment(item.Key, item.Value);
            }
            if (this.token != null)
                request.AddHeader("Authorization", "token " + this.token);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            if (arguments != null)
            {
                foreach (Argument item in arguments)
                    request.AddParameter(item.Key, item.Value);
            }

            IRestResponse response = client.Execute(request);
            JObject obj = Newtonsoft.Json.JsonConvert.DeserializeObject(response.Content) as JObject;
            string error = obj.Value<string>("error");
            bool success = obj.Value<bool>("success");

            if (error != null)
                throw new Exception(error);
        }

        public PhantomConfiguration Configuration
        {
            get { return this.config; }
        }

        public string Token
        {
            get { return this.token; }
        }
    }
}
