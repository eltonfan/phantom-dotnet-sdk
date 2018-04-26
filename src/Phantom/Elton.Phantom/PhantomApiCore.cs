// Coded by Elton FAN. http://elton.io/

using System;
using System.Collections.Generic;
using System.Text;
using Elton.Phantom.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using System.Collections.Specialized;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Elton.Phantom.Version1;

namespace Elton.Phantom
{
    /// <summary>
    /// 实现对幻腾API的各功能封装。
    /// </summary>
    internal class PhantomApiCore
    {
        static readonly Common.Logging.ILog log = Common.Logging.LogManager.GetLogger(typeof(PhantomApiCore));

        protected readonly RestClient client = null;
        protected readonly PhantomConfiguration config = null;
        string token = null;
        readonly string accept;
        public PhantomApiCore(PhantomConfiguration config, string accept = "application/json")
        {
            Contract.Requires(config != null, "config can not be empty.");
            this.config = config;

            client = new RestClient(Consts.ApiUrl);
            client.DefaultParameters.Clear();
            client.UserAgent = config.UserAgent;
            this.accept = accept;

            //client.DefaultParameters.Add(new Parameter
            //{
            //    Name = "Accept",
            //    Type = ParameterType.HttpHeader,
            //    Value = accept,
            //});
        }

        public bool Ping()
        {
            string result = this.Get<string>(2, "ping.json");
            if (string.IsNullOrEmpty(result))
                return false;

            return result.Contains("pong");
        }

        public void SetCredentials(string token)
        {
            this.token = token;
        }

        RestRequest CreateRequest(int apiVersion, Method method, string resource, object body = null, params Argument[] parameters)
        {
            var request = new RestRequest(resource, method);
            request.AddOrUpdateHeader("Accept", $"application/vnd.huantengsmart-v{apiVersion}+json");
            if (token != null)
                request.AddHeader("Authorization", Authorization);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            if (body != null)
                request.AddBody(body);

            if (parameters != null)
            {
                foreach (Argument item in parameters)
                    request.AddParameter(item.Key, item.Value);
            }

            return request;
        }

        protected string GetString(int apiVersion, string resource, params KeyValuePair<string, string>[] urlSegments)
        {
            var request = CreateRequest(apiVersion, Method.GET, resource);

            if (urlSegments != null)
            {
                foreach (var item in urlSegments)
                    request.AddUrlSegment(item.Key, item.Value);
            }

            var response = client.Execute(request).GetAwaiter().GetResult();
            CheckError(response);
            return response.Content;
        }

        /// <summary>
        /// 批命令请求。
        /// </summary>
        /// <param name="authorization"></param>
        /// <param name="ops"></param>
        /// <returns></returns>
        protected OperationResult[] Batch(int apiVersion, params Operation[] ops)
        {
            var content = new JObject();
            content.Add("ops", JToken.FromObject(ops));
            content.Add("sequential", true);

            List<OperationResult> results = new List<OperationResult>();

            //string URI = "https://huantengsmart.com/massapi";
            //Accept = "application/vnd.huantengsmart-v1+json";
            //Authorization = authorization
            //ContentType = "application/json; charset=utf-8";
            JObject result = this.Post<JObject>(apiVersion, "../massapi", content);
            foreach (JToken item in result["results"] as JArray)
            {
                results.Add(new OperationResult(item.Value<int>("status"), item["body"].ToString()));
            }
            return results.ToArray();
        }

        static void CheckError(IRestResponse response)
        {
            if (response.IsSuccess)
                return;

            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                case HttpStatusCode.Created:
                    break;
                case HttpStatusCode.Unauthorized:
                    throw new PhantomUnauthorizedException(response.StatusDescription);
                default://其他错误
                    string message = "";
                    var status = PhantomExceptionStatus.Unknown;
                    if (!TryParseErrorMessage(response.Content, out status, out message))
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
            if (obj == null)
                return false;

            string error = obj.Value<string>("error");
            if (string.IsNullOrEmpty(error))
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

        protected string Authorization => "bearer " + token;
        public PhantomConfiguration Configuration => config;
        public string Token => token;


        protected T Get<T>(int apiVersion, string url, params KeyValuePair<string, string>[] urlSegments)
        {
            return JsonConvert.DeserializeObject<T>(GetString(apiVersion, url));
        }

        protected dynamic Get(int apiVersion, string url, params KeyValuePair<string, string>[] urlSegments)
        {
            return JsonConvert.DeserializeObject(GetString(apiVersion, url));
        }

        protected T Post<T>(int apiVersion, string url, object body = null, params Argument[] parameters)
        {
            var request = CreateRequest(apiVersion, Method.POST, url, body, parameters);

            IRestResponse response = client.Execute(request).GetAwaiter().GetResult();
            CheckError(response);
            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        protected T Put<T>(int apiVersion, string url, object data)
        {
            var request = CreateRequest(apiVersion, Method.PUT, url);

            request.AddBody(data);

            IRestResponse response = client.Execute(request).GetAwaiter().GetResult();
            CheckError(response);
            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        protected bool Delete(int apiVersion, string url)
        {
            var request = CreateRequest(apiVersion, Method.DELETE, url);

            IRestResponse response = client.Execute(request).GetAwaiter().GetResult();
            CheckError(response);

            dynamic result = JsonConvert.DeserializeObject(response.Content);
            return result.success;
        }
    }
}
