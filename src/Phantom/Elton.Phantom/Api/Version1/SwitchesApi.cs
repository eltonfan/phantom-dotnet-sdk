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
    public interface ISwitchesApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取当前用户的所有随心开关
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有随心开关
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ModelSwitch</returns>
        ModelSwitch GetSwitches ();

        /// <summary>
        /// 获取当前用户的所有随心开关
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有随心开关
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ModelSwitch</returns>
        ApiResponse<ModelSwitch> GetSwitchesWithHttpInfo ();
        /// <summary>
        /// 获取当前用户的某个随心开关
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个随心开关
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Switch的ID</param>
        /// <returns>ModelSwitch</returns>
        ModelSwitch GetSwitchesId (int? id);

        /// <summary>
        /// 获取当前用户的某个随心开关
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个随心开关
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Switch的ID</param>
        /// <returns>ApiResponse of ModelSwitch</returns>
        ApiResponse<ModelSwitch> GetSwitchesIdWithHttpInfo (int? id);
        /// <summary>
        /// 固化IFTTT情景
        /// </summary>
        /// <remarks>
        /// 固化IFTTT情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">随心开关ID</param>
        /// <returns>ModelSwitch</returns>
        ModelSwitch PostSwitchesIdApplyScene (int? id);

        /// <summary>
        /// 固化IFTTT情景
        /// </summary>
        /// <remarks>
        /// 固化IFTTT情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">随心开关ID</param>
        /// <returns>ApiResponse of ModelSwitch</returns>
        ApiResponse<ModelSwitch> PostSwitchesIdApplySceneWithHttpInfo (int? id);
        /// <summary>
        /// 随心开关清除固化信息
        /// </summary>
        /// <remarks>
        /// 随心开关清除固化信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">随心开关ID</param>
        /// <returns>ModelSwitch</returns>
        ModelSwitch PostSwitchesIdClearInfo (int? id);

        /// <summary>
        /// 随心开关清除固化信息
        /// </summary>
        /// <remarks>
        /// 随心开关清除固化信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">随心开关ID</param>
        /// <returns>ApiResponse of ModelSwitch</returns>
        ApiResponse<ModelSwitch> PostSwitchesIdClearInfoWithHttpInfo (int? id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取当前用户的所有随心开关
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有随心开关
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ModelSwitch</returns>
        System.Threading.Tasks.Task<ModelSwitch> GetSwitchesAsync ();

        /// <summary>
        /// 获取当前用户的所有随心开关
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有随心开关
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ModelSwitch)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModelSwitch>> GetSwitchesAsyncWithHttpInfo ();
        /// <summary>
        /// 获取当前用户的某个随心开关
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个随心开关
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Switch的ID</param>
        /// <returns>Task of ModelSwitch</returns>
        System.Threading.Tasks.Task<ModelSwitch> GetSwitchesIdAsync (int? id);

        /// <summary>
        /// 获取当前用户的某个随心开关
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个随心开关
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Switch的ID</param>
        /// <returns>Task of ApiResponse (ModelSwitch)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModelSwitch>> GetSwitchesIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 固化IFTTT情景
        /// </summary>
        /// <remarks>
        /// 固化IFTTT情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">随心开关ID</param>
        /// <returns>Task of ModelSwitch</returns>
        System.Threading.Tasks.Task<ModelSwitch> PostSwitchesIdApplySceneAsync (int? id);

        /// <summary>
        /// 固化IFTTT情景
        /// </summary>
        /// <remarks>
        /// 固化IFTTT情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">随心开关ID</param>
        /// <returns>Task of ApiResponse (ModelSwitch)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModelSwitch>> PostSwitchesIdApplySceneAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 随心开关清除固化信息
        /// </summary>
        /// <remarks>
        /// 随心开关清除固化信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">随心开关ID</param>
        /// <returns>Task of ModelSwitch</returns>
        System.Threading.Tasks.Task<ModelSwitch> PostSwitchesIdClearInfoAsync (int? id);

        /// <summary>
        /// 随心开关清除固化信息
        /// </summary>
        /// <remarks>
        /// 随心开关清除固化信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">随心开关ID</param>
        /// <returns>Task of ApiResponse (ModelSwitch)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModelSwitch>> PostSwitchesIdClearInfoAsyncWithHttpInfo (int? id);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}