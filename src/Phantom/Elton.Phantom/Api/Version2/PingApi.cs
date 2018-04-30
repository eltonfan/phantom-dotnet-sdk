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
using System.Threading.Tasks;
using Elton.Phantom.Api.Version2;
using Elton.OAuth2;

namespace Elton.Phantom.Api.Version2
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPingApi
    {
        void GetPing(bool? authenticateUser = null);
        Task GetPingAsync(bool? authenticateUser = null);
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi : Api.Version2.IPingApi
    {
        /// <summary>
        /// 乒乓测试，用于测试能否服务器成功处理最简单的请求 v2
        /// </summary>
        /// <remarks>
        /// 乒乓测试，用于测试能否服务器成功处理最简单的请求 v2
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticateUser">是否要求用户身份认证 (optional)</param>
        /// <returns></returns>
        void IPingApi.GetPing(bool? authenticateUser = null)
        {
            var queryParams = new Dictionary<string, string>();
            if (authenticateUser != null)
                queryParams.Add("authenticate_user", authenticateUser?.ToString()); // query parameter

            var result = Get<string>(2, "/ping",
                queryParams: queryParams);

            CheckPingResult(2, result);
        }
        /// <summary>
        /// 乒乓测试，用于测试能否服务器成功处理最简单的请求 v2
        /// </summary>
        /// <remarks>
        /// 乒乓测试，用于测试能否服务器成功处理最简单的请求 v2
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticateUser">是否要求用户身份认证 (optional)</param>
        /// <returns>Task of void</returns>
        async Task IPingApi.GetPingAsync(bool? authenticateUser = null)
        {
            var queryParams = new Dictionary<string, string>();
            if (authenticateUser != null)
                queryParams.Add("authenticate_user", authenticateUser?.ToString()); // query parameter

            var result = await GetAsync<string>(2, "/ping",
                queryParams: queryParams);

            CheckPingResult(2, result);
        }
    }
}