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
    public interface IInfraredSensorsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取当前用户的所有红外传感器
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有红外传感器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InfraredSensorOverview</returns>
        InfraredSensorOverview GetInfraredSensors ();

        /// <summary>
        /// 获取当前用户的所有红外传感器
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有红外传感器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InfraredSensorOverview</returns>
        ApiResponse<InfraredSensorOverview> GetInfraredSensorsWithHttpInfo ();
        /// <summary>
        /// 获取当前用户的某个红外传感器
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个红外传感器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">DoorSensor的ID</param>
        /// <returns>InfraredSensor</returns>
        InfraredSensor GetInfraredSensorsId (int? id);

        /// <summary>
        /// 获取当前用户的某个红外传感器
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个红外传感器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">DoorSensor的ID</param>
        /// <returns>ApiResponse of InfraredSensor</returns>
        ApiResponse<InfraredSensor> GetInfraredSensorsIdWithHttpInfo (int? id);
        /// <summary>
        /// 获取某个红外传感器所有日志
        /// </summary>
        /// <remarks>
        /// 获取某个红外传感器所有日志
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">InfraredSensor的ID</param>
        /// <param name="fromTimestamp">起始unix timestamp, 单位是秒 (optional)</param>
        /// <param name="count">每次读取的日志数量，默认100 (optional)</param>
        /// <returns>InfraredSensorLog</returns>
        InfraredSensorLog GetInfraredSensorsIdLogs (int? id, int? fromTimestamp = null, int? count = null);

        /// <summary>
        /// 获取某个红外传感器所有日志
        /// </summary>
        /// <remarks>
        /// 获取某个红外传感器所有日志
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">InfraredSensor的ID</param>
        /// <param name="fromTimestamp">起始unix timestamp, 单位是秒 (optional)</param>
        /// <param name="count">每次读取的日志数量，默认100 (optional)</param>
        /// <returns>ApiResponse of InfraredSensorLog</returns>
        ApiResponse<InfraredSensorLog> GetInfraredSensorsIdLogsWithHttpInfo (int? id, int? fromTimestamp = null, int? count = null);
        /// <summary>
        /// 设置红外的情景id
        /// </summary>
        /// <remarks>
        /// 设置红外的情景id
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scenarioId1">有人时的情景id</param>
        /// <param name="scenarioId2">没人时的情景id</param>
        /// <param name="id"></param>
        /// <returns>InfraredSensor</returns>
        InfraredSensor PutInfraredSensorsId (int? scenarioId1, int? scenarioId2, int? id);

        /// <summary>
        /// 设置红外的情景id
        /// </summary>
        /// <remarks>
        /// 设置红外的情景id
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scenarioId1">有人时的情景id</param>
        /// <param name="scenarioId2">没人时的情景id</param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of InfraredSensor</returns>
        ApiResponse<InfraredSensor> PutInfraredSensorsIdWithHttpInfo (int? scenarioId1, int? scenarioId2, int? id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取当前用户的所有红外传感器
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有红外传感器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InfraredSensorOverview</returns>
        System.Threading.Tasks.Task<InfraredSensorOverview> GetInfraredSensorsAsync ();

        /// <summary>
        /// 获取当前用户的所有红外传感器
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有红外传感器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InfraredSensorOverview)</returns>
        System.Threading.Tasks.Task<ApiResponse<InfraredSensorOverview>> GetInfraredSensorsAsyncWithHttpInfo ();
        /// <summary>
        /// 获取当前用户的某个红外传感器
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个红外传感器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">DoorSensor的ID</param>
        /// <returns>Task of InfraredSensor</returns>
        System.Threading.Tasks.Task<InfraredSensor> GetInfraredSensorsIdAsync (int? id);

        /// <summary>
        /// 获取当前用户的某个红外传感器
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个红外传感器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">DoorSensor的ID</param>
        /// <returns>Task of ApiResponse (InfraredSensor)</returns>
        System.Threading.Tasks.Task<ApiResponse<InfraredSensor>> GetInfraredSensorsIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 获取某个红外传感器所有日志
        /// </summary>
        /// <remarks>
        /// 获取某个红外传感器所有日志
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">InfraredSensor的ID</param>
        /// <param name="fromTimestamp">起始unix timestamp, 单位是秒 (optional)</param>
        /// <param name="count">每次读取的日志数量，默认100 (optional)</param>
        /// <returns>Task of InfraredSensorLog</returns>
        System.Threading.Tasks.Task<InfraredSensorLog> GetInfraredSensorsIdLogsAsync (int? id, int? fromTimestamp = null, int? count = null);

        /// <summary>
        /// 获取某个红外传感器所有日志
        /// </summary>
        /// <remarks>
        /// 获取某个红外传感器所有日志
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">InfraredSensor的ID</param>
        /// <param name="fromTimestamp">起始unix timestamp, 单位是秒 (optional)</param>
        /// <param name="count">每次读取的日志数量，默认100 (optional)</param>
        /// <returns>Task of ApiResponse (InfraredSensorLog)</returns>
        System.Threading.Tasks.Task<ApiResponse<InfraredSensorLog>> GetInfraredSensorsIdLogsAsyncWithHttpInfo (int? id, int? fromTimestamp = null, int? count = null);
        /// <summary>
        /// 设置红外的情景id
        /// </summary>
        /// <remarks>
        /// 设置红外的情景id
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scenarioId1">有人时的情景id</param>
        /// <param name="scenarioId2">没人时的情景id</param>
        /// <param name="id"></param>
        /// <returns>Task of InfraredSensor</returns>
        System.Threading.Tasks.Task<InfraredSensor> PutInfraredSensorsIdAsync (int? scenarioId1, int? scenarioId2, int? id);

        /// <summary>
        /// 设置红外的情景id
        /// </summary>
        /// <remarks>
        /// 设置红外的情景id
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scenarioId1">有人时的情景id</param>
        /// <param name="scenarioId2">没人时的情景id</param>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (InfraredSensor)</returns>
        System.Threading.Tasks.Task<ApiResponse<InfraredSensor>> PutInfraredSensorsIdAsyncWithHttpInfo (int? scenarioId1, int? scenarioId2, int? id);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}