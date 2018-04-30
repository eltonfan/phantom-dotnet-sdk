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
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Elton.Phantom.Models.Version1;
using System.Threading.Tasks;
using Elton.Phantom.Api.Version1;
using Elton.OAuth2;
using Token = Elton.Phantom.Token;

namespace Elton.Phantom.Api.Version1
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITokensApi
    {
        Token GetTokens();
        Task<Token> GetTokensAsync();
        Token PostTokens(string appId, string appSecret, string deviceToken = null, string deviceName = null);
        Task<Token> PostTokensAsync(string appId, string appSecret, string deviceToken = null, string deviceName = null);
        Token PutTokensRefresh(string appId, string appSecret, string refreshToken);
        Task<Token> PutTokensRefreshAsync(string appId, string appSecret, string refreshToken);
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi : ITokensApi
    {
        /// <summary>
        /// 获取当前用户的所有令牌，亦即所有已登录客户端
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有令牌，亦即所有已登录客户端
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Token</returns>
        [Obsolete]
        Token ITokensApi.GetTokens()
        {
            return Get<Token>(1, "/tokens");
        }

        /// <summary>
        /// 获取当前用户的所有令牌，亦即所有已登录客户端
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有令牌，亦即所有已登录客户端
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Token</returns>
        [Obsolete]
        async Task<Token> ITokensApi.GetTokensAsync()
        {
            return await GetAsync<Token>(1, "/tokens");
        }

        /// <summary>
        /// 获取当前用户的一个令牌，并可选地注册APN推送
        /// </summary>
        /// <remarks>
        /// 获取当前用户的一个令牌，并可选地注册APN推送
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">键</param>
        /// <param name="appSecret">密</param>
        /// <param name="deviceToken">APN设备令牌，可注册APN推送 (optional)</param>
        /// <param name="deviceName">设备的名称 (optional)</param>
        /// <returns>Token</returns>
        [Obsolete]
        Token ITokensApi.PostTokens(string appId, string appSecret, string deviceToken = null, string deviceName = null)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling TokensApi->PostTokens");
            // verify the required parameter 'appSecret' is set
            if (appSecret == null)
                throw new ApiException(400, "Missing required parameter 'appSecret' when calling TokensApi->PostTokens");

            var formParams = new Dictionary<string, object>();
            formParams.Add("app_id", appId); // form parameter
            formParams.Add("app_secret", appSecret); // form parameter
            if (deviceToken != null)
                formParams.Add("device_token", deviceToken); // form parameter
            if (deviceName != null)
                formParams.Add("device_name", deviceName); // form parameter

            return Post<Token>(1, "/tokens",
                formParams: formParams);
        }

        /// <summary>
        /// 获取当前用户的一个令牌，并可选地注册APN推送
        /// </summary>
        /// <remarks>
        /// 获取当前用户的一个令牌，并可选地注册APN推送
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">键</param>
        /// <param name="appSecret">密</param>
        /// <param name="deviceToken">APN设备令牌，可注册APN推送 (optional)</param>
        /// <param name="deviceName">设备的名称 (optional)</param>
        /// <returns>Task of Token</returns>
        [Obsolete]
        async Task<Token> ITokensApi.PostTokensAsync(string appId, string appSecret, string deviceToken = null, string deviceName = null)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling TokensApi->PostTokens");
            // verify the required parameter 'appSecret' is set
            if (appSecret == null)
                throw new ApiException(400, "Missing required parameter 'appSecret' when calling TokensApi->PostTokens");

            var formParams = new Dictionary<string, object>();
            formParams.Add("app_id", appId); // form parameter
            formParams.Add("app_secret", appSecret); // form parameter
            if (deviceToken != null)
                formParams.Add("device_token", deviceToken); // form parameter
            if (deviceName != null)
                formParams.Add("device_name", deviceName); // form parameter

            return await PostAsync<Token>(1, "/tokens",
                formParams: formParams);
        }

        /// <summary>
        /// 刷新一个令牌
        /// </summary>
        /// <remarks>
        /// 刷新一个令牌
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">键</param>
        /// <param name="appSecret">密</param>
        /// <param name="refreshToken">刷新令牌</param>
        /// <returns>Token</returns>
        [Obsolete]
        Token ITokensApi.PutTokensRefresh(string appId, string appSecret, string refreshToken)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling TokensApi->PutTokensRefresh");
            // verify the required parameter 'appSecret' is set
            if (appSecret == null)
                throw new ApiException(400, "Missing required parameter 'appSecret' when calling TokensApi->PutTokensRefresh");
            // verify the required parameter 'refreshToken' is set
            if (refreshToken == null)
                throw new ApiException(400, "Missing required parameter 'refreshToken' when calling TokensApi->PutTokensRefresh");

            var formParams = new Dictionary<string, object>();
            formParams.Add("app_id", appId); // form parameter
            formParams.Add("app_secret", appSecret); // form parameter
            formParams.Add("refresh_token", refreshToken); // form parameter

            return Put<Token>(1, "/tokens/refresh",
                formParams: formParams);
        }

        /// <summary>
        /// 刷新一个令牌
        /// </summary>
        /// <remarks>
        /// 刷新一个令牌
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">键</param>
        /// <param name="appSecret">密</param>
        /// <param name="refreshToken">刷新令牌</param>
        /// <returns>Task of Token</returns>
        [Obsolete]
        async Task<Token> ITokensApi.PutTokensRefreshAsync(string appId, string appSecret, string refreshToken)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling TokensApi->PutTokensRefresh");
            // verify the required parameter 'appSecret' is set
            if (appSecret == null)
                throw new ApiException(400, "Missing required parameter 'appSecret' when calling TokensApi->PutTokensRefresh");
            // verify the required parameter 'refreshToken' is set
            if (refreshToken == null)
                throw new ApiException(400, "Missing required parameter 'refreshToken' when calling TokensApi->PutTokensRefresh");

            var formParams = new Dictionary<string, object>();
            formParams.Add("app_id", appId); // form parameter
            formParams.Add("app_secret", appSecret); // form parameter
            formParams.Add("refresh_token", refreshToken); // form parameter

            return await PutAsync<Token>(1, "/tokens/refresh",
                formParams: formParams);
        }
    }
}