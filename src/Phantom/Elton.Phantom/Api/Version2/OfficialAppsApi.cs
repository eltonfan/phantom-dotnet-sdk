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
using Elton.Phantom.Rest;

namespace Elton.Phantom.Api.Version2
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOfficialAppsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 下载最新官方应用
        /// </summary>
        /// <remarks>
        /// 下载最新官方应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">第三方APP ID</param>
        /// <param name="rnVersion">React Native 版本</param>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <returns>ThirdAppV2</returns>
        ThirdAppV2 PostOfficialAppsOfficialApp (int? id, string rnVersion, string platform = null);

        /// <summary>
        /// 下载最新官方应用
        /// </summary>
        /// <remarks>
        /// 下载最新官方应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">第三方APP ID</param>
        /// <param name="rnVersion">React Native 版本</param>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <returns>ApiResponse of ThirdAppV2</returns>
        ApiResponse<ThirdAppV2> PostOfficialAppsOfficialAppWithHttpInfo (int? id, string rnVersion, string platform = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 下载最新官方应用
        /// </summary>
        /// <remarks>
        /// 下载最新官方应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">第三方APP ID</param>
        /// <param name="rnVersion">React Native 版本</param>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <returns>Task of ThirdAppV2</returns>
        System.Threading.Tasks.Task<ThirdAppV2> PostOfficialAppsOfficialAppAsync (int? id, string rnVersion, string platform = null);

        /// <summary>
        /// 下载最新官方应用
        /// </summary>
        /// <remarks>
        /// 下载最新官方应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">第三方APP ID</param>
        /// <param name="rnVersion">React Native 版本</param>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <returns>Task of ApiResponse (ThirdAppV2)</returns>
        System.Threading.Tasks.Task<ApiResponse<ThirdAppV2>> PostOfficialAppsOfficialAppAsyncWithHttpInfo (int? id, string rnVersion, string platform = null);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}