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
using Elton.Phantom.Models.Version2;

namespace Elton.Phantom.Api.Version2
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPingApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 乒乓测试，用于测试能否服务器成功处理最简单的请求 v2
        /// </summary>
        /// <remarks>
        /// 乒乓测试，用于测试能否服务器成功处理最简单的请求 v2
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticateUser">是否要求用户身份认证 (optional)</param>
        /// <returns></returns>
        void GetPing (bool? authenticateUser = null);

        /// <summary>
        /// 乒乓测试，用于测试能否服务器成功处理最简单的请求 v2
        /// </summary>
        /// <remarks>
        /// 乒乓测试，用于测试能否服务器成功处理最简单的请求 v2
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticateUser">是否要求用户身份认证 (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetPingWithHttpInfo (bool? authenticateUser = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 乒乓测试，用于测试能否服务器成功处理最简单的请求 v2
        /// </summary>
        /// <remarks>
        /// 乒乓测试，用于测试能否服务器成功处理最简单的请求 v2
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticateUser">是否要求用户身份认证 (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetPingAsync (bool? authenticateUser = null);

        /// <summary>
        /// 乒乓测试，用于测试能否服务器成功处理最简单的请求 v2
        /// </summary>
        /// <remarks>
        /// 乒乓测试，用于测试能否服务器成功处理最简单的请求 v2
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticateUser">是否要求用户身份认证 (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetPingAsyncWithHttpInfo (bool? authenticateUser = null);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}