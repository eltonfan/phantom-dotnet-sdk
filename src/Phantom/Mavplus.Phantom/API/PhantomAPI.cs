// Coded by chuangen http://chuangen.name.

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
    internal partial class PhantomAPI
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
            request.RequestFormat = DataFormat.Json;
            if (urlSegments != null)
            {
                foreach (UrlSegment item in urlSegments)
                    request.AddUrlSegment(item.Key, item.Value);
            }
            if(this.token != null)
                request.AddHeader("Authorization", "token " + this.token);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            IRestResponse response = client.Execute(request);
            CheckError(response);
            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        protected T POST<T>(string authorization, string url, UrlSegment[] urlSegments, params Argument[] arguments)
        {
            var request = new RestRequest(url, Method.POST);
            if (urlSegments != null)
            {
                foreach (UrlSegment item in urlSegments)
                    request.AddUrlSegment(item.Key, item.Value);
            }
            request.AddHeader("Authorization", authorization);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            if (arguments != null)
            {
                foreach (Argument item in arguments)
                    request.AddParameter(item.Key, item.Value);
            }

            IRestResponse response = client.Execute(request);
            CheckError(response);
            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        protected T POST<T>(string url, UrlSegment[] urlSegments, object data)
        {
            var request = new RestRequest(url, Method.POST);
            request.RequestFormat = DataFormat.Json;
            if (urlSegments != null)
            {
                foreach (UrlSegment item in urlSegments)
                    request.AddUrlSegment(item.Key, item.Value);
            }
            request.AddHeader("Authorization", "token " + this.token);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            request.AddBody(data);

            IRestResponse response = client.Execute(request);
            CheckError(response);
            return JsonConvert.DeserializeObject<T>(response.Content);
        }
        protected T PUT<T>(string url, UrlSegment[] urlSegments, object data)
        {
            var request = new RestRequest(url, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            if (urlSegments != null)
            {
                foreach (UrlSegment item in urlSegments)
                    request.AddUrlSegment(item.Key, item.Value);
            }
            request.AddHeader("Authorization", "token " + this.token);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            request.AddBody(data);

            IRestResponse response = client.Execute(request);
            CheckError(response);
            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        /// <summary>
        /// 批命令请求。
        /// </summary>
        /// <param name="authorization"></param>
        /// <param name="ops"></param>
        /// <returns></returns>
        protected OperationResult[] Batch(string authorization, params Operation[] ops)
        {
            JsonObject content = new JsonObject();
            content.Add("ops", ops);
            content.Add("sequential", true);

            List<OperationResult> results = new List<OperationResult>();

            string URI = "https://huantengsmart.com/massapi";
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.Accept] = "application/vnd.huantengsmart-v1+json"; //"application/json"
                wc.Headers[HttpRequestHeader.Authorization] = authorization;
                wc.Headers[HttpRequestHeader.ContentType] = "application/json; charset=utf-8";
                wc.Headers[HttpRequestHeader.UserAgent] = config.UserAgent;

                string responseText = wc.UploadString(URI, "POST", JsonConvert.SerializeObject(content));

                JObject result = JsonConvert.DeserializeObject(responseText) as JObject;

                foreach (JToken item in result["results"] as JArray)
                {
                    results.Add(new OperationResult(item.Value<int>("status"), item["body"].ToString()));
                }
            }

            return results.ToArray();
        }
        protected OperationResult[] Batch(params Operation[] ops)
        {
            return Batch("token " + this.token, ops);
        }
        static void CheckError(IRestResponse response)
        {
            if (response.ErrorException != null)
                throw response.ErrorException;

            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                case HttpStatusCode.Created:
                    break;
                case HttpStatusCode.Unauthorized:
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


        protected T POST<T>(string url, UrlSegment[] urlSegments, params Argument[] arguments)
        {
            if (string.IsNullOrEmpty(this.token))
                throw new PhantomException("尚未换取令牌。");

            return this.POST<T>("token " + this.token, url, urlSegments, arguments);
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
