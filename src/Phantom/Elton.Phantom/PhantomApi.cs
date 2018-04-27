#region License

//   Copyright 2014 Elton FAN (eltonfan@live.cn, http://elton.io)
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
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using RestSharp;

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

        protected readonly RestClient client;
        protected readonly PhantomConfiguration config;
        protected readonly SerializationTool converter;
        string token = null;
        public PhantomApi(PhantomConfiguration config)
        {
            Contract.Requires(config != null, "config can not be empty.");
            this.config = config;

            client = new RestClient(Consts.ApiUrl);
            client.DefaultParameters.Clear();
            client.UserAgent = config.UserAgent;

            converter = new SerializationTool(this.config);
        }

        public void SetCredentials(string token)
        {
            this.token = token;
        }

        /// <summary>
        /// Creates and sets up a RestRequest prior to a call.
        /// </summary>
        /// <param name="apiVersion"></param>
        /// <param name="method"></param>
        /// <param name="resource"></param>
        /// <param name="body"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        RestRequest PrepareRequest(int apiVersion, Method method, string resource, object body = null,
            Argument[] parameters = null, KeyValuePair<string, string>[] urlSegments = null)
        {
            if (apiVersion < 1 || apiVersion > 2)
                throw new NotSupportedException("Only v1 & v2 api is supported.");

            var request = new RestRequest(resource, method);
            request.AddOrUpdateParameter("Accept", $"application/vnd.huantengsmart-v{apiVersion}+json", ParameterType.HttpHeader);//"application/json"
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
            if (urlSegments != null)
            {
                foreach (var item in urlSegments)
                    request.AddUrlSegment(item.Key, item.Value);
            }

            return request;
        }
        ApiResponse<T> Execute<T>(int apiVersion, Method method, string resource, object body = null,
            Argument[] parameters = null, KeyValuePair<string, string>[] urlSegments = null,
            ExceptionFactory check = null)
        {
            var request = PrepareRequest(apiVersion, method, resource, body, parameters, urlSegments);
            var response = client.Execute(request);
            CheckError(response);

            int statusCode = (int)response.StatusCode;

            if (check != null)
            {
                var exception = check(resource, response);
                if (exception != null)
                    throw exception;
            }

            return new ApiResponse<T>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (T)converter.Deserialize(response, typeof(T)));
        }

        void CheckControlResult(string resource, OperationResult result)
        {
            if (result == null)
                throw new ApiException();
            if (!result.Success)
                throw new PhantomException(result.Reason);
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
            if (response.IsSuccessful)
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


        protected T Get<T>(int apiVersion, string url, KeyValuePair<string, string>[] urlSegments = null, ExceptionFactory check = null)
        {
            return Execute<T>(apiVersion, Method.GET, url,
                urlSegments: urlSegments,
                check: check).Data;
        }

        internal T Post<T>(int apiVersion, string url, object body = null, params Argument[] parameters)
        {
            return Execute<T>(apiVersion, Method.POST, url,
                body: body,
                parameters: parameters).Data;
        }

        internal void Post(int apiVersion, string url, object body = null, params Argument[] parameters)
        {
            var result = Execute<OperationResult>(apiVersion, Method.POST, url,
                body: body,
                parameters: parameters).Data;

            CheckControlResult(url, result);
        }

        protected T Put<T>(int apiVersion, string url, object data, ExceptionFactory check = null)
        {
            return Execute<T>(apiVersion, Method.PUT, url,
                body: data,
                check: check).Data;
        }

        protected bool Delete(int apiVersion, string url, ExceptionFactory check = null)
        {
            var result = Execute<dynamic>(apiVersion, Method.DELETE, url,
                check: check).Data;
            return result.success;
        }
    }
}
