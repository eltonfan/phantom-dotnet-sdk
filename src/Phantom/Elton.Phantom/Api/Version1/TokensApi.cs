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

namespace Elton.Phantom.Api.Version1
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITokensApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取当前用户的所有令牌，亦即所有已登录客户端
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有令牌，亦即所有已登录客户端
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Token</returns>
        Token GetTokens ();

        /// <summary>
        /// 获取当前用户的所有令牌，亦即所有已登录客户端
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有令牌，亦即所有已登录客户端
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Token</returns>
        ApiResponse<Token> GetTokensWithHttpInfo ();
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
        Token PostTokens (string appId, string appSecret, string deviceToken = null, string deviceName = null);

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
        /// <returns>ApiResponse of Token</returns>
        ApiResponse<Token> PostTokensWithHttpInfo (string appId, string appSecret, string deviceToken = null, string deviceName = null);
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
        Token PutTokensRefresh (string appId, string appSecret, string refreshToken);

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
        /// <returns>ApiResponse of Token</returns>
        ApiResponse<Token> PutTokensRefreshWithHttpInfo (string appId, string appSecret, string refreshToken);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取当前用户的所有令牌，亦即所有已登录客户端
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有令牌，亦即所有已登录客户端
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Token</returns>
        System.Threading.Tasks.Task<Token> GetTokensAsync ();

        /// <summary>
        /// 获取当前用户的所有令牌，亦即所有已登录客户端
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有令牌，亦即所有已登录客户端
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Token)</returns>
        System.Threading.Tasks.Task<ApiResponse<Token>> GetTokensAsyncWithHttpInfo ();
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
        System.Threading.Tasks.Task<Token> PostTokensAsync (string appId, string appSecret, string deviceToken = null, string deviceName = null);

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
        /// <returns>Task of ApiResponse (Token)</returns>
        System.Threading.Tasks.Task<ApiResponse<Token>> PostTokensAsyncWithHttpInfo (string appId, string appSecret, string deviceToken = null, string deviceName = null);
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
        System.Threading.Tasks.Task<Token> PutTokensRefreshAsync (string appId, string appSecret, string refreshToken);

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
        /// <returns>Task of ApiResponse (Token)</returns>
        System.Threading.Tasks.Task<ApiResponse<Token>> PutTokensRefreshAsyncWithHttpInfo (string appId, string appSecret, string refreshToken);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}