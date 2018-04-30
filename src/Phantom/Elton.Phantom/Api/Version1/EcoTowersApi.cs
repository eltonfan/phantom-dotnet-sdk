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
using Elton.OAuth2;

namespace Elton.Phantom.Api.Version1
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEcoTowersApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取当前用户的所有EcoTower
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有EcoTower
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EcoTower</returns>
        EcoTower GetEcoTowers ();

        /// <summary>
        /// 获取当前用户的所有EcoTower
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有EcoTower
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EcoTower</returns>
        ApiResponse<EcoTower> GetEcoTowersWithHttpInfo ();
        /// <summary>
        /// 获取当前用户的某个EcoTower
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个EcoTower
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">EcoTower的ID</param>
        /// <returns>EcoTower</returns>
        EcoTower GetEcoTowersId (int? id);

        /// <summary>
        /// 获取当前用户的某个EcoTower
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个EcoTower
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">EcoTower的ID</param>
        /// <returns>ApiResponse of EcoTower</returns>
        ApiResponse<EcoTower> GetEcoTowersIdWithHttpInfo (int? id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取当前用户的所有EcoTower
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有EcoTower
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EcoTower</returns>
        System.Threading.Tasks.Task<EcoTower> GetEcoTowersAsync ();

        /// <summary>
        /// 获取当前用户的所有EcoTower
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有EcoTower
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EcoTower)</returns>
        System.Threading.Tasks.Task<ApiResponse<EcoTower>> GetEcoTowersAsyncWithHttpInfo ();
        /// <summary>
        /// 获取当前用户的某个EcoTower
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个EcoTower
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">EcoTower的ID</param>
        /// <returns>Task of EcoTower</returns>
        System.Threading.Tasks.Task<EcoTower> GetEcoTowersIdAsync (int? id);

        /// <summary>
        /// 获取当前用户的某个EcoTower
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个EcoTower
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">EcoTower的ID</param>
        /// <returns>Task of ApiResponse (EcoTower)</returns>
        System.Threading.Tasks.Task<ApiResponse<EcoTower>> GetEcoTowersIdAsyncWithHttpInfo (int? id);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}