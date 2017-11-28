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
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom.Version1
{
    /// <summary>
    /// 实现对幻腾API的各功能封装。
    /// </summary>
    /// <remarks> https://huantengsmart.com/doc/api_v1 </remarks>
    public partial class PhantomAPI
    {
        static readonly Common.Logging.ILog log = Common.Logging.LogManager.GetLogger(typeof(PhantomAPI));

        readonly RestClient client = null;
        readonly PhantomConfiguration config = null;
        readonly Dictionary<int, Bulb> dicBulbs = new Dictionary<int, Bulb>();

        string token = null;
        public PhantomAPI(PhantomConfiguration config)
        {
            Contract.Requires(config != null, "config can not be empty.");
            this.config = config;

            client = new RestClient("https://huantengsmart.com/api/");
            client.DefaultParameters.Clear();
            client.UserAgent = config.UserAgent;
            client.DefaultParameters.Add(new Parameter
            {
                Name = "Accept",
                Type = ParameterType.HttpHeader,
                Value = "application/vnd.huantengsmart-v1+json",
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
            string result = this.GET<string>("ping.json");
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
        T GET<T>(string url, params UrlSegment[] urlSegments)
        {
            return JsonConvert.DeserializeObject<T>(GetString(url, urlSegments));
        }
        dynamic GET(string url, params UrlSegment[] urlSegments)
        {
            return JsonConvert.DeserializeObject(GetString(url, urlSegments));
        }

        bool DELETE(string url, params UrlSegment[] urlSegments)
        {
            var request = new RestRequest(url, Method.DELETE);
            //request.RequestFormat = DataFormat.Json;
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
        

        T POST<T>(string authorization, string url, UrlSegment[] urlSegments, params Argument[] arguments)
        {
            var request = new RestRequest(url, Method.POST);
            if (urlSegments != null)
            {
                foreach (UrlSegment item in urlSegments)
                    request.AddUrlSegment(item.Key, item.Value);
            }
            if(!string.IsNullOrWhiteSpace(authorization))
                request.AddHeader("Authorization", authorization);
            //request.AddHeader("Content-Type", "application/json; charset=utf-8");
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

        T POST<T>(string url, UrlSegment[] urlSegments, object data)
        {
            var request = new RestRequest(url, Method.POST);
            //request.RequestFormat = DataFormat.Json;
            if (urlSegments != null)
            {
                foreach (UrlSegment item in urlSegments)
                    request.AddUrlSegment(item.Key, item.Value);
            }
            AddHeaders(request);

            request.AddBody(data);

            IRestResponse response = client.Execute(request).GetAwaiter().GetResult();
            CheckError(response);
            return JsonConvert.DeserializeObject<T>(response.Content);
        }
        T PUT<T>(string url, UrlSegment[] urlSegments, object data)
        {
            var request = new RestRequest(url, Method.PUT);
            //request.RequestFormat = DataFormat.Json;
            if (urlSegments != null)
            {
                foreach (UrlSegment item in urlSegments)
                    request.AddUrlSegment(item.Key, item.Value);
            }
            request.AddHeader("Authorization", Authorization);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            request.AddBody(data);

            IRestResponse response = client.Execute(request).GetAwaiter().GetResult();
            CheckError(response);
            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        /// <summary>
        /// 批命令请求。
        /// </summary>
        /// <param name="authorization"></param>
        /// <param name="ops"></param>
        /// <returns></returns>
        OperationResult[] Batch(string authorization, params Operation[] ops)
        {
            var content = new JObject();
            content.Add("ops", JToken.FromObject(ops));
            content.Add("sequential", true);

            List<OperationResult> results = new List<OperationResult>();

            //string URI = "https://huantengsmart.com/massapi";
            //Accept = "application/vnd.huantengsmart-v1+json";
            //Authorization = authorization
            //ContentType = "application/json; charset=utf-8";
            JObject result = this.POST<JObject>("../massapi", null, content);
            foreach (JToken item in result["results"] as JArray)
            {
                results.Add(new OperationResult(item.Value<int>("status"), item["body"].ToString()));
            }
            return results.ToArray();
        }
        OperationResult[] Batch(params Operation[] ops)
        {
            return Batch(Authorization, ops);
        }
        static void CheckError(IRestResponse response)
        {
            //if (response.ErrorException != null)
            //    throw response.ErrorException;

            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                case HttpStatusCode.Created:
                    break;
                case HttpStatusCode.Unauthorized:
                    throw new PhantomUnauthorizedException();
                default://其他错误
                    string message = "";
                    PhantomExceptionStatus status = PhantomExceptionStatus.Unknown;
                    if(!TryParseErrorMessage(response.Content, out status, out message))
                    {
                        message = response.Content;
                        status = PhantomExceptionStatus.Unknown;
                    }
                    throw new PhantomException(message, status);
            }
        }

        static bool TryParseErrorMessage(string content, out PhantomExceptionStatus status, out string message)
        {
            status = PhantomExceptionStatus.Unknown;
            message = "";

            JObject obj = JsonConvert.DeserializeObject(content) as JObject;
            if(obj == null)
                return false;

            string error = obj.Value<string>("error");
            if(string.IsNullOrEmpty(error))
                return false;
            //进一步解析错误信息
            string[] parts = (error ?? "").Split(new char[] { ':' });
            if (parts == null || parts.Length < 2 || !Enum.TryParse<PhantomExceptionStatus>(parts[0], out status))
            {
                message = error;
                status = PhantomExceptionStatus.Unknown;

                return true;
            }
            else
            {
                message = parts[1];
                return true;
            }
        }


        T POST<T>(string url, UrlSegment[] urlSegments, params Argument[] arguments)
        {
            if (string.IsNullOrEmpty(this.token))
                throw new PhantomException("尚未换取令牌。");

            return this.POST<T>(Authorization, url, urlSegments, arguments);
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
