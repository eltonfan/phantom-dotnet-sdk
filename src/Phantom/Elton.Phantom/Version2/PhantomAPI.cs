// Coded by chuangen http://chuangen.name.

using Elton.Phantom.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom.Version2
{
    /// <summary>
    /// 实现对幻腾API的各功能封装。
    /// </summary>
    /// <remarks> https://huantengsmart.com/doc/api_v2 </remarks>
    public partial class PhantomAPI
    {
        static readonly Common.Logging.ILog log = Common.Logging.LogManager.GetLogger(typeof(PhantomAPI));

        readonly RestClient client = null;
        readonly PhantomConfiguration config = null;

        string token = null;
        public PhantomAPI(PhantomConfiguration config)
        {
            Contract.Requires(config != null, "config can not be empty.");
            this.config = config;

            client = new RestClient("https://huantengsmart.com/api/");
            client.UserAgent = config.UserAgent;
            client.DefaultParameters.Clear();
            client.DefaultParameters.Add(new Parameter
            {
                Name = "Accept",
                Type = ParameterType.HttpHeader,
                Value = "application/vnd.huantengsmart-v2+json",
            });//"application/json"
        }

        string Authorization
        {
            get => "bearer " + this.token;
        }

        public void SetCredentials(string token)
        {
            this.token = token;
        }

        void AddHeaders(RestRequest request)
        {
            if (this.token != null)
                request.AddHeader("Authorization", Authorization);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
        }

        public bool Ping()
        {
            string result = this.GetJson<string>("ping.json");
            if (string.IsNullOrEmpty(result))
                return false;

            return result.Contains("pong");
        }

        string GetString(string url, params UrlSegment[] urlSegments)
        {
            var request = new RestRequest(url, Method.GET);
            //request.RequestFormat = DataFormat.Json;
            if (urlSegments != null)
            {
                foreach (UrlSegment item in urlSegments)
                    request.AddUrlSegment(item.Key, item.Value);
            }
            AddHeaders(request);

            IRestResponse response = client.Execute(request).GetAwaiter().GetResult();
            CheckError(response);

            return response.Content;
        }



        T GetJson<T>(string url, params UrlSegment[] urlSegments)
        {
            string content = GetString(url, urlSegments);
            return JsonConvert.DeserializeObject<T>(GetString(url, urlSegments));
        }

        dynamic GetJson(string url, params UrlSegment[] urlSegments)
        {
            return JsonConvert.DeserializeObject(GetString(url, urlSegments));
        }

        bool Delete(string url, params UrlSegment[] urlSegments)
        {
            var request = new RestRequest(url, Method.DELETE);
            if (urlSegments != null)
            {
                foreach (UrlSegment item in urlSegments)
                    request.AddUrlSegment(item.Key, item.Value);
            }
            AddHeaders(request);

            IRestResponse response = client.Execute(request).GetAwaiter().GetResult();
            CheckError(response);

            dynamic result = JsonConvert.DeserializeObject(response.Content);
            return result.success;
        }
        

        T PostJson<T>(string authorization, string url, UrlSegment[] urlSegments, params Argument[] arguments)
        {
            var request = new RestRequest(url, Method.POST);
            if (urlSegments != null)
            {
                foreach (UrlSegment item in urlSegments)
                    request.AddUrlSegment(item.Key, item.Value);
            }
            if(!string.IsNullOrWhiteSpace(authorization))
                request.AddHeader("Authorization", authorization);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            if (arguments != null)
            {
                foreach (Argument item in arguments)
                    request.AddParameter(item.Key, item.Value);
            }

            IRestResponse<T> response = client.Execute<T>(request).GetAwaiter().GetResult();
            CheckError(response);
            return response.Data;
        }

        T PostForm<T>(string authorization, string url, UrlSegment[] urlSegments, params Argument[] arguments)
        {
            var request = new RestRequest(url, Method.POST);
            if (urlSegments != null)
            {
                foreach (UrlSegment item in urlSegments)
                    request.AddUrlSegment(item.Key, item.Value);
            }
            if (!string.IsNullOrWhiteSpace(authorization))
                request.AddHeader("Authorization", authorization);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            if (arguments != null)
            {
                foreach (Argument item in arguments)
                    request.AddParameter(item.Key, item.Value);
            }

            IRestResponse<T> response = client.Execute<T>(request).GetAwaiter().GetResult();
            CheckError(response);
            return response.Data;
        }

        static void CheckError(IRestResponse response)
        {
            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
                return;
            if(response.StatusCode == HttpStatusCode.Unauthorized)
                throw new PhantomUnauthorizedException();

            //其他错误
            var status = PhantomExceptionStatus.Unknown;
            string message = null;
            try
            {
                JObject obj = JsonConvert.DeserializeObject(response.Content) as JObject;
                if (obj == null)
                {
                    message = response.Content;
                    return;
                }
                string error = obj.Value<string>("error");
                if (string.IsNullOrEmpty(error))
                {
                    message = response.Content;
                    return;
                }

                //进一步解析错误信息
                string[] parts = (error ?? "").Split(new char[] { ':' });
                if (parts == null || parts.Length < 2 || !Enum.TryParse<PhantomExceptionStatus>(parts[0], out status))
                {
                    message = error;
                    status = PhantomExceptionStatus.Unknown;
                }
                else
                {
                    message = parts[1];
                }
            }
            finally
            {
                throw new PhantomException(message, status);
            }
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
