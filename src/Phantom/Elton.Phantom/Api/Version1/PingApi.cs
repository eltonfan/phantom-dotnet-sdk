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
using System.Threading.Tasks;
using RestSharp;
using Elton.Phantom.Models.Version1;
using Elton.Phantom.Api.Version1;
using Elton.Phantom.Rest;

namespace Elton.Phantom.Api.Version1
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPingApi
    {
        void GetPing(bool? authenticateUser = null, int? id = null);
        Task GetPingAsync(bool? authenticateUser = null, int? id = null);
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi : IPingApi
    {
        /// <summary>
        /// 乒乓测试，用于测试能否服务器成功处理最简单的请求
        /// </summary>
        /// <remarks>
        /// 乒乓测试，用于测试能否服务器成功处理最简单的请求
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticateUser">是否要求用户身份认证 (optional)</param>
        /// <param name="id">区域ID (optional)</param>
        /// <returns></returns>
        public void GetPing(bool? authenticateUser = null, int? id = null)
        {
            var queryParams = new Dictionary<string, string>();
            if (authenticateUser != null)
                queryParams.Add("authenticate_user", authenticateUser?.ToString()); // query parameter
            if (id != null)
                queryParams.Add("id", id?.ToString()); // query parameter

            var result = Get<string>(1, "/ping",
                queryParams: queryParams);

            CheckPingResult(1, result);
        }

        /// <summary>
        /// 乒乓测试，用于测试能否服务器成功处理最简单的请求
        /// </summary>
        /// <remarks>
        /// 乒乓测试，用于测试能否服务器成功处理最简单的请求
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticateUser">是否要求用户身份认证 (optional)</param>
        /// <param name="id">区域ID (optional)</param>
        /// <returns>Task of void</returns>
        public async Task GetPingAsync(bool? authenticateUser = null, int? id = null)
        {
            var queryParams = new Dictionary<string, string>();
            if (authenticateUser != null)
                queryParams.Add("authenticate_user", authenticateUser?.ToString()); // query parameter
            if (id != null)
                queryParams.Add("id", id?.ToString()); // query parameter

            var result = await GetAsync<string>(1, "/ping",
                queryParams: queryParams);

            CheckPingResult(1, result);
        }

        protected void CheckPingResult(int apiVersion, string result)
        {
            result = result?.Trim('"');
            if (apiVersion == 1 && result == "pong")
                return;
            if (result == $"pong v{apiVersion}")
                return;

            throw new ApiException(500, $"Ping-v{apiVersion} ERROR, response: {result}.");
        }
    }
}