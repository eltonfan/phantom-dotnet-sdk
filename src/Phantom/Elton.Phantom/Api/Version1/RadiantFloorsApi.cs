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
using Elton.Phantom.Rest;

namespace Elton.Phantom.Api.Version1
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRadiantFloorsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取所有地暖
        /// </summary>
        /// <remarks>
        /// 获取所有地暖
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>RadiantFloor</returns>
        RadiantFloor GetRadiantFloors ();

        /// <summary>
        /// 获取所有地暖
        /// </summary>
        /// <remarks>
        /// 获取所有地暖
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of RadiantFloor</returns>
        ApiResponse<RadiantFloor> GetRadiantFloorsWithHttpInfo ();
        /// <summary>
        /// 获取某个地暖
        /// </summary>
        /// <remarks>
        /// 获取某个地暖
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">地暖id</param>
        /// <returns>RadiantFloor</returns>
        RadiantFloor GetRadiantFloorsId (int? id);

        /// <summary>
        /// 获取某个地暖
        /// </summary>
        /// <remarks>
        /// 获取某个地暖
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">地暖id</param>
        /// <returns>ApiResponse of RadiantFloor</returns>
        ApiResponse<RadiantFloor> GetRadiantFloorsIdWithHttpInfo (int? id);
        /// <summary>
        /// 控制地暖
        /// </summary>
        /// <remarks>
        /// 控制地暖
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">地暖id</param>
        /// <param name="power">开关，默认为开 (optional, default to true)</param>
        /// <param name="temperature">温度 (optional)</param>
        /// <param name="hour">小时 (optional)</param>
        /// <param name="min">分钟 (optional)</param>
        /// <param name="week">星期 (optional)</param>
        /// <returns>RadiantFloor</returns>
        RadiantFloor PostRadiantFloorsIdAction (int? id, bool? power = null, int? temperature = null, int? hour = null, int? min = null, int? week = null);

        /// <summary>
        /// 控制地暖
        /// </summary>
        /// <remarks>
        /// 控制地暖
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">地暖id</param>
        /// <param name="power">开关，默认为开 (optional, default to true)</param>
        /// <param name="temperature">温度 (optional)</param>
        /// <param name="hour">小时 (optional)</param>
        /// <param name="min">分钟 (optional)</param>
        /// <param name="week">星期 (optional)</param>
        /// <returns>ApiResponse of RadiantFloor</returns>
        ApiResponse<RadiantFloor> PostRadiantFloorsIdActionWithHttpInfo (int? id, bool? power = null, int? temperature = null, int? hour = null, int? min = null, int? week = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取所有地暖
        /// </summary>
        /// <remarks>
        /// 获取所有地暖
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of RadiantFloor</returns>
        System.Threading.Tasks.Task<RadiantFloor> GetRadiantFloorsAsync ();

        /// <summary>
        /// 获取所有地暖
        /// </summary>
        /// <remarks>
        /// 获取所有地暖
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (RadiantFloor)</returns>
        System.Threading.Tasks.Task<ApiResponse<RadiantFloor>> GetRadiantFloorsAsyncWithHttpInfo ();
        /// <summary>
        /// 获取某个地暖
        /// </summary>
        /// <remarks>
        /// 获取某个地暖
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">地暖id</param>
        /// <returns>Task of RadiantFloor</returns>
        System.Threading.Tasks.Task<RadiantFloor> GetRadiantFloorsIdAsync (int? id);

        /// <summary>
        /// 获取某个地暖
        /// </summary>
        /// <remarks>
        /// 获取某个地暖
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">地暖id</param>
        /// <returns>Task of ApiResponse (RadiantFloor)</returns>
        System.Threading.Tasks.Task<ApiResponse<RadiantFloor>> GetRadiantFloorsIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 控制地暖
        /// </summary>
        /// <remarks>
        /// 控制地暖
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">地暖id</param>
        /// <param name="power">开关，默认为开 (optional, default to true)</param>
        /// <param name="temperature">温度 (optional)</param>
        /// <param name="hour">小时 (optional)</param>
        /// <param name="min">分钟 (optional)</param>
        /// <param name="week">星期 (optional)</param>
        /// <returns>Task of RadiantFloor</returns>
        System.Threading.Tasks.Task<RadiantFloor> PostRadiantFloorsIdActionAsync (int? id, bool? power = null, int? temperature = null, int? hour = null, int? min = null, int? week = null);

        /// <summary>
        /// 控制地暖
        /// </summary>
        /// <remarks>
        /// 控制地暖
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">地暖id</param>
        /// <param name="power">开关，默认为开 (optional, default to true)</param>
        /// <param name="temperature">温度 (optional)</param>
        /// <param name="hour">小时 (optional)</param>
        /// <param name="min">分钟 (optional)</param>
        /// <param name="week">星期 (optional)</param>
        /// <returns>Task of ApiResponse (RadiantFloor)</returns>
        System.Threading.Tasks.Task<ApiResponse<RadiantFloor>> PostRadiantFloorsIdActionAsyncWithHttpInfo (int? id, bool? power = null, int? temperature = null, int? hour = null, int? min = null, int? week = null);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}