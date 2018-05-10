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
    public interface IMeterSwitchesApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取所有通断计量器
        /// </summary>
        /// <remarks>
        /// 获取所有通断计量器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>MeterSwitch</returns>
        MeterSwitch GetMeterSwitches ();

        /// <summary>
        /// 获取所有通断计量器
        /// </summary>
        /// <remarks>
        /// 获取所有通断计量器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of MeterSwitch</returns>
        ApiResponse<MeterSwitch> GetMeterSwitchesWithHttpInfo ();
        /// <summary>
        /// 获取某个通断计量器
        /// </summary>
        /// <remarks>
        /// 获取某个通断计量器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <returns>MeterSwitch</returns>
        MeterSwitch GetMeterSwitchesId (int? id);

        /// <summary>
        /// 获取某个通断计量器
        /// </summary>
        /// <remarks>
        /// 获取某个通断计量器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <returns>ApiResponse of MeterSwitch</returns>
        ApiResponse<MeterSwitch> GetMeterSwitchesIdWithHttpInfo (int? id);
        /// <summary>
        /// 关闭某个通断计量器
        /// </summary>
        /// <remarks>
        /// 关闭某个通断计量器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <returns>MeterSwitch</returns>
        MeterSwitch PostMeterSwitchesIdSwitchOff (int? id);

        /// <summary>
        /// 关闭某个通断计量器
        /// </summary>
        /// <remarks>
        /// 关闭某个通断计量器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <returns>ApiResponse of MeterSwitch</returns>
        ApiResponse<MeterSwitch> PostMeterSwitchesIdSwitchOffWithHttpInfo (int? id);
        /// <summary>
        /// 打开某个通断计量器
        /// </summary>
        /// <remarks>
        /// 打开某个通断计量器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <returns>MeterSwitch</returns>
        MeterSwitch PostMeterSwitchesIdSwitchOn (int? id);

        /// <summary>
        /// 打开某个通断计量器
        /// </summary>
        /// <remarks>
        /// 打开某个通断计量器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <returns>ApiResponse of MeterSwitch</returns>
        ApiResponse<MeterSwitch> PostMeterSwitchesIdSwitchOnWithHttpInfo (int? id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取所有通断计量器
        /// </summary>
        /// <remarks>
        /// 获取所有通断计量器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of MeterSwitch</returns>
        System.Threading.Tasks.Task<MeterSwitch> GetMeterSwitchesAsync ();

        /// <summary>
        /// 获取所有通断计量器
        /// </summary>
        /// <remarks>
        /// 获取所有通断计量器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (MeterSwitch)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeterSwitch>> GetMeterSwitchesAsyncWithHttpInfo ();
        /// <summary>
        /// 获取某个通断计量器
        /// </summary>
        /// <remarks>
        /// 获取某个通断计量器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <returns>Task of MeterSwitch</returns>
        System.Threading.Tasks.Task<MeterSwitch> GetMeterSwitchesIdAsync (int? id);

        /// <summary>
        /// 获取某个通断计量器
        /// </summary>
        /// <remarks>
        /// 获取某个通断计量器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <returns>Task of ApiResponse (MeterSwitch)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeterSwitch>> GetMeterSwitchesIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 关闭某个通断计量器
        /// </summary>
        /// <remarks>
        /// 关闭某个通断计量器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <returns>Task of MeterSwitch</returns>
        System.Threading.Tasks.Task<MeterSwitch> PostMeterSwitchesIdSwitchOffAsync (int? id);

        /// <summary>
        /// 关闭某个通断计量器
        /// </summary>
        /// <remarks>
        /// 关闭某个通断计量器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <returns>Task of ApiResponse (MeterSwitch)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeterSwitch>> PostMeterSwitchesIdSwitchOffAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 打开某个通断计量器
        /// </summary>
        /// <remarks>
        /// 打开某个通断计量器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <returns>Task of MeterSwitch</returns>
        System.Threading.Tasks.Task<MeterSwitch> PostMeterSwitchesIdSwitchOnAsync (int? id);

        /// <summary>
        /// 打开某个通断计量器
        /// </summary>
        /// <remarks>
        /// 打开某个通断计量器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <returns>Task of ApiResponse (MeterSwitch)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeterSwitch>> PostMeterSwitchesIdSwitchOnAsyncWithHttpInfo (int? id);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}