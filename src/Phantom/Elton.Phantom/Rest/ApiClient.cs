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
using System.Diagnostics.Contracts;
using System.Linq;
using RestSharp;
using System.Threading.Tasks;

namespace Elton.Phantom.Rest
{
    public partial class ApiClient
    {
        static readonly Common.Logging.ILog log = Common.Logging.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected readonly RestClient client;
        protected readonly ApiConfiguration config;
        protected readonly DataConverter converter;
        protected string token = null;
        public ApiClient(ApiConfiguration config)
        {
            Contract.Requires(config != null, "config can not be empty.");
            this.config = config;

            client = new RestClient(config.BaseUrl);
            client.DefaultParameters.Clear();
            client.Timeout = config.Timeout;
            client.UserAgent = config.UserAgent;

            converter = new DataConverter(this.config);
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
        /// <param name="path"></param>
        /// <param name="postBody"></param>
        /// <param name="formParams"></param>
        /// <returns></returns>
        protected RestRequest PrepareRequest(string path, Method method,
            IEnumerable<KeyValuePair<string, string>> queryParams = null,
            object postBody = null,
            string contentType = "application/json; charset=utf-8",
            IEnumerable<KeyValuePair<string, string>> headerParams = null,
            IEnumerable<KeyValuePair<string, object>> formParams = null,
            IEnumerable<KeyValuePair<string, FileParameter>> fileParams = null,
            IEnumerable<KeyValuePair<string, object>> pathParams = default,
            string accept = "application/json")
        {
            var request = new RestRequest(path, method);
            request.AddOrUpdateParameter("Accept", accept, ParameterType.HttpHeader);
            if (token != null)
                request.AddHeader("Authorization", Authorization);
            request.AddHeader("Content-Type", contentType);

            if (pathParams != null)
            {// add path parameter, if any
                foreach (var pair in pathParams)
                    request.AddParameter(pair.Key, pair.Value, ParameterType.UrlSegment);//AddUrlSegment
            }
            
            if (headerParams != null)
            {// add header parameter, if any
                foreach (var pair in headerParams)
                    request.AddHeader(pair.Key, pair.Value);
            }

            if (queryParams != null)
            {// add query parameter, if any
                foreach (var pair in queryParams)
                    request.AddQueryParameter(pair.Key, pair.Value);
            }

            if (formParams != null)
            {// add form parameter, if any
                foreach (var pair in formParams)
                    request.AddParameter(pair.Key, pair.Value);
            }

            if (fileParams != null)
            {// add file parameter, if any
                foreach (var pair in fileParams)
                {
                    var param = pair.Value;
                    request.AddFile(param.Name, param.Writer, param.FileName, param.ContentLength, param.ContentType);
                }
            }

            if (postBody != null)
            { // http body (model or byte[]) parameter
                request.AddParameter(contentType, postBody, ParameterType.RequestBody);//AddBody
            }

            return request;
        }

        /// <summary>
        /// Allows for extending request processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        partial void InterceptRequest(IRestRequest request);

        /// <summary>
        /// Allows for extending response processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        /// <param name="response">The RestSharp response object</param>
        partial void InterceptResponse(IRestRequest request, IRestResponse response);
        
        /// <summary>
        /// Makes the HTTP request (Sync).
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="pathParams">Path parameters.</param>
        /// <param name="contentType">Content Type of the request</param>
        /// <returns>Object</returns>
        public ApiResponse<T> CallApi<T>(string path, Method method,
            IEnumerable<KeyValuePair<string, string>> queryParams = null,
            object postBody = null,
            string contentType = "application/json; charset=utf-8",
            IEnumerable<KeyValuePair<string, string>> headerParams = null,
            IEnumerable<KeyValuePair<string, object>> formParams = null,
            IEnumerable<KeyValuePair<string, FileParameter>> fileParams = null,
            IEnumerable<KeyValuePair<string, object>> pathParams = null,
            ExceptionFactory check = null)
        {
            var request = PrepareRequest(path, method,
                queryParams: queryParams,
                postBody: postBody, contentType: contentType,
                headerParams: headerParams,
                formParams: formParams,
                fileParams: fileParams,
                pathParams: pathParams);

            InterceptRequest(request);
            var response = client.Execute(request);
            InterceptResponse(request, response);

            var error = CheckError(response);
            if (error == null && check != null)
                error = check(path, response);
            if (error != null)
                throw error;

            return new ApiResponse<T>((int)response.StatusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (T)converter.Deserialize(response, typeof(T)));
        }

        /// <summary>
        /// Makes the asynchronous HTTP request.
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="pathParams">Path parameters.</param>
        /// <param name="contentType">Content type.</param>
        /// <returns>The Task instance.</returns>
        public async Task<ApiResponse<T>> CallApiAsync<T>(string path, Method method,
            IEnumerable<KeyValuePair<string, string>> queryParams = null,
            object postBody = null,
            string contentType = "application/json; charset=utf-8",
            IEnumerable<KeyValuePair<string, string>> headerParams = null,
            IEnumerable<KeyValuePair<string, object>> formParams = null,
            IEnumerable<KeyValuePair<string, FileParameter>> fileParams = null,
            IEnumerable<KeyValuePair<string, object>> pathParams = null,
            ExceptionFactory check = null)
        {
            var request = PrepareRequest(path, method,
                queryParams: queryParams,
                postBody: postBody, contentType: contentType,
                headerParams: headerParams,
                formParams: formParams,
                fileParams: fileParams,
                pathParams: pathParams);

            InterceptRequest(request);
            var response = await client.ExecuteTaskAsync(request);
            InterceptResponse(request, response);

            var error = CheckError(response);
            if (error == null && check != null)
                error = check(path, response);
            if (error != null)
                throw error;

            return new ApiResponse<T>((int)response.StatusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (T)converter.Deserialize(response, typeof(T)));
        }

        protected virtual Exception CheckError(IRestResponse response)
        {
            if (response.IsSuccessful)
                return null;

            return new ApiException((int)response.StatusCode, response.StatusDescription);
        }

        protected string Authorization => "bearer " + token;
        public ApiConfiguration Configuration => config;
        public string Token => token;

        protected T Get<T>(string url, IEnumerable<KeyValuePair<string, string>> queryParams = null, IEnumerable<KeyValuePair<string, object>> pathParams = null, ExceptionFactory check = null)
        {
            return CallApi<T>(url, Method.GET,
                queryParams: queryParams,
                pathParams: pathParams,
                check: check).Data;
        }

        protected async Task<T> GetAsync<T>(string url, IEnumerable<KeyValuePair<string, string>> queryParams = null, IEnumerable<KeyValuePair<string, object>> pathParams = null, ExceptionFactory check = null)
        {
            var response = await CallApiAsync<T>(url, Method.GET,
                queryParams: queryParams,
                pathParams: pathParams,
                check: check);

            return response.Data;
        }

        protected T Post<T>(string url, object postBody = null,
            string contentType = "application/json; charset=utf-8",
            IEnumerable<KeyValuePair<string, string>> headerParams = null,
            IEnumerable<KeyValuePair<String, object>> formParams = null)
        {
            return CallApi<T>(url, Method.POST, 
                postBody: postBody,
                contentType: contentType,
                headerParams: headerParams,
                formParams: formParams).Data;
        }

        protected async Task<T> PostAsync<T>(string url, object postBody = null,
            string contentType = "application/json; charset=utf-8",
            IEnumerable<KeyValuePair<String, object>> formParams = null)
        {
            var response = await CallApiAsync<T>(url, Method.POST,
                postBody: postBody,
                contentType: contentType,
                formParams: formParams);

            return response.Data;
        }

        protected T Put<T>(string url, object postBody = null, IEnumerable<KeyValuePair<String, object>> formParams = null, ExceptionFactory check = null)
        {
            return CallApi<T>(url, Method.PUT,
                postBody: postBody,
                formParams: formParams,
                check: check).Data;
        }

        protected async Task<T> PutAsync<T>(string url, object postBody = null, IEnumerable<KeyValuePair<String, object>> formParams = null, ExceptionFactory check = null)
        {
            var response = await CallApiAsync<T>(url, Method.PUT,
                postBody: postBody,
                formParams: formParams,
                check: check);

            return response.Data;
        }

        protected T Delete<T>(string url, ExceptionFactory check = null)
        {
            var result = CallApi<T>(url, Method.DELETE,
                check: check).Data;
            return result;
        }

        protected async Task<T> DeleteAsync<T>(string url, ExceptionFactory check = null)
        {
            var response = await CallApiAsync<dynamic>(url, Method.DELETE,
                check: check);
            return response.Data;
        }

        public virtual IToken CreateToken(string authorizationCode)
        {
            return this.Post<Token>(config.AccessTokenUrl,
                contentType: "application/x-www-form-urlencoded",
                formParams: new[] {
                    new KeyValuePair<string, object>("client_id", config.ApplicationId),
                    new KeyValuePair<string, object>("client_secret", config.ApplicationSecret),
                    new KeyValuePair<string, object>("redirect_uri", config.RedirectUri),
                    new KeyValuePair<string, object>("grant_type", "authorization_code"),
                    new KeyValuePair<string, object>("code", authorizationCode)
                });
        }

        public virtual IToken RefreshToken(string refreshToken)
        {
            return this.Post<Token>(config.RefreshTokenUrl,
                contentType: "application/x-www-form-urlencoded",
                formParams: new[] {
                    new KeyValuePair<string, object>("client_id", config.ApplicationId),
                    new KeyValuePair<string, object>("client_secret", config.ApplicationSecret),
                    new KeyValuePair<string, object>("grant_type", "refresh_token"),
                    new KeyValuePair<string, object>("refresh_token", refreshToken)
                });
        }
    }
}
