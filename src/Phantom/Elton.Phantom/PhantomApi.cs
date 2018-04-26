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

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using System.Diagnostics.Contracts;
using System.Net;

namespace Elton.Phantom
{
    /// <summary>
    /// 实现对幻腾API的各功能封装。
    /// </summary>
    /// <remarks>
    /// https://huantengsmart.com/doc/api_v1
    /// https://huantengsmart.com/doc/api_v2
    /// </remarks>
    public partial class PhantomApi
    {
        static readonly Common.Logging.ILog log = Common.Logging.LogManager.GetLogger(typeof(PhantomApi));

        protected readonly RestClient client = null;
        protected readonly PhantomConfiguration config = null;
        string token = null;
        public PhantomApi(PhantomConfiguration config)
        {
            Contract.Requires(config != null, "config can not be empty.");
            this.config = config;

            client = new RestClient(Consts.ApiUrl);
            client.DefaultParameters.Clear();
            client.UserAgent = config.UserAgent;
        }

        public void SetCredentials(string token)
        {
            this.token = token;
        }

        RestRequest CreateRequest(int apiVersion, Method method, string resource, object body = null, params Argument[] parameters)
        {
            if (apiVersion < 1 || apiVersion > 2)
                throw new NotSupportedException("Only v1 & v2 api is supported.");

            var request = new RestRequest(resource, method);
            request.AddOrUpdateHeader("Accept", $"application/vnd.huantengsmart-v{apiVersion}+json");//"application/json"
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
        internal BatchResults Batch(int apiVersion, params Operation[] ops)
        {
            var content = new JObject();
            content.Add("ops", JToken.FromObject(ops));
            content.Add("sequential", true);

            //https://huantengsmart.com/massapi
            return this.Post<BatchResults>(apiVersion, "../massapi", content);
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
            var jsonString = GetString(apiVersion, url);
            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        protected dynamic Get(int apiVersion, string url, params KeyValuePair<string, string>[] urlSegments)
        {
            return JsonConvert.DeserializeObject(GetString(apiVersion, url));
        }

        internal T Post<T>(int apiVersion, string url, object body = null, params Argument[] parameters)
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
