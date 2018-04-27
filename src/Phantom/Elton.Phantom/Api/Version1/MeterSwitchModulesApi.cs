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
    public interface IMeterSwitchModulesApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取所有通断计量模块
        /// </summary>
        /// <remarks>
        /// 获取所有通断计量模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>MeterSwitchModule</returns>
        MeterSwitchModule GetMeterSwitchModules ();

        /// <summary>
        /// 获取所有通断计量模块
        /// </summary>
        /// <remarks>
        /// 获取所有通断计量模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of MeterSwitchModule</returns>
        ApiResponse<MeterSwitchModule> GetMeterSwitchModulesWithHttpInfo ();
        /// <summary>
        /// 获取某个通断计量模块
        /// </summary>
        /// <remarks>
        /// 获取某个通断计量模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通断计量器 ID</param>
        /// <returns>MeterSwitchModule</returns>
        MeterSwitchModule GetMeterSwitchModulesId (int? id);

        /// <summary>
        /// 获取某个通断计量模块
        /// </summary>
        /// <remarks>
        /// 获取某个通断计量模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通断计量器 ID</param>
        /// <returns>ApiResponse of MeterSwitchModule</returns>
        ApiResponse<MeterSwitchModule> GetMeterSwitchModulesIdWithHttpInfo (int? id);
        /// <summary>
        /// 关闭某个通断计量模块
        /// </summary>
        /// <remarks>
        /// 关闭某个通断计量模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通断计量器 ID</param>
        /// <returns>MeterSwitchModule</returns>
        MeterSwitchModule PostMeterSwitchModulesIdSwitchOff (int? id);

        /// <summary>
        /// 关闭某个通断计量模块
        /// </summary>
        /// <remarks>
        /// 关闭某个通断计量模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通断计量器 ID</param>
        /// <returns>ApiResponse of MeterSwitchModule</returns>
        ApiResponse<MeterSwitchModule> PostMeterSwitchModulesIdSwitchOffWithHttpInfo (int? id);
        /// <summary>
        /// 打开某个通断计量模块
        /// </summary>
        /// <remarks>
        /// 打开某个通断计量模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通断计量器 ID</param>
        /// <returns>MeterSwitchModule</returns>
        MeterSwitchModule PostMeterSwitchModulesIdSwitchOn (int? id);

        /// <summary>
        /// 打开某个通断计量模块
        /// </summary>
        /// <remarks>
        /// 打开某个通断计量模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通断计量器 ID</param>
        /// <returns>ApiResponse of MeterSwitchModule</returns>
        ApiResponse<MeterSwitchModule> PostMeterSwitchModulesIdSwitchOnWithHttpInfo (int? id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取所有通断计量模块
        /// </summary>
        /// <remarks>
        /// 获取所有通断计量模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of MeterSwitchModule</returns>
        System.Threading.Tasks.Task<MeterSwitchModule> GetMeterSwitchModulesAsync ();

        /// <summary>
        /// 获取所有通断计量模块
        /// </summary>
        /// <remarks>
        /// 获取所有通断计量模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (MeterSwitchModule)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeterSwitchModule>> GetMeterSwitchModulesAsyncWithHttpInfo ();
        /// <summary>
        /// 获取某个通断计量模块
        /// </summary>
        /// <remarks>
        /// 获取某个通断计量模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通断计量器 ID</param>
        /// <returns>Task of MeterSwitchModule</returns>
        System.Threading.Tasks.Task<MeterSwitchModule> GetMeterSwitchModulesIdAsync (int? id);

        /// <summary>
        /// 获取某个通断计量模块
        /// </summary>
        /// <remarks>
        /// 获取某个通断计量模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通断计量器 ID</param>
        /// <returns>Task of ApiResponse (MeterSwitchModule)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeterSwitchModule>> GetMeterSwitchModulesIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 关闭某个通断计量模块
        /// </summary>
        /// <remarks>
        /// 关闭某个通断计量模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通断计量器 ID</param>
        /// <returns>Task of MeterSwitchModule</returns>
        System.Threading.Tasks.Task<MeterSwitchModule> PostMeterSwitchModulesIdSwitchOffAsync (int? id);

        /// <summary>
        /// 关闭某个通断计量模块
        /// </summary>
        /// <remarks>
        /// 关闭某个通断计量模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通断计量器 ID</param>
        /// <returns>Task of ApiResponse (MeterSwitchModule)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeterSwitchModule>> PostMeterSwitchModulesIdSwitchOffAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 打开某个通断计量模块
        /// </summary>
        /// <remarks>
        /// 打开某个通断计量模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通断计量器 ID</param>
        /// <returns>Task of MeterSwitchModule</returns>
        System.Threading.Tasks.Task<MeterSwitchModule> PostMeterSwitchModulesIdSwitchOnAsync (int? id);

        /// <summary>
        /// 打开某个通断计量模块
        /// </summary>
        /// <remarks>
        /// 打开某个通断计量模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通断计量器 ID</param>
        /// <returns>Task of ApiResponse (MeterSwitchModule)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeterSwitchModule>> PostMeterSwitchModulesIdSwitchOnAsyncWithHttpInfo (int? id);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}