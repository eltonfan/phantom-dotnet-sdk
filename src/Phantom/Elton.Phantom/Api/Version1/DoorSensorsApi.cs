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
    public interface IDoorSensorsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取当前用户的所有门磁
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DoorSensor</returns>
        DoorSensor GetDoorSensors ();

        /// <summary>
        /// 获取当前用户的所有门磁
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DoorSensor</returns>
        ApiResponse<DoorSensor> GetDoorSensorsWithHttpInfo ();
        /// <summary>
        /// 获取当前用户的某个门磁
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">DoorSensor的ID</param>
        /// <returns>DoorSensor</returns>
        DoorSensor GetDoorSensorsId (int? id);

        /// <summary>
        /// 获取当前用户的某个门磁
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">DoorSensor的ID</param>
        /// <returns>ApiResponse of DoorSensor</returns>
        ApiResponse<DoorSensor> GetDoorSensorsIdWithHttpInfo (int? id);
        /// <summary>
        /// 设置门磁打开3分钟后, 自动报警
        /// </summary>
        /// <remarks>
        /// 设置门磁打开3分钟后, 自动报警
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enable">开启长时间开启自动报警, true/false</param>
        /// <param name="id"></param>
        /// <returns></returns>
        void PostDoorSensorsIdAlarmAtMinutes (bool? enable, int? id);

        /// <summary>
        /// 设置门磁打开3分钟后, 自动报警
        /// </summary>
        /// <remarks>
        /// 设置门磁打开3分钟后, 自动报警
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enable">开启长时间开启自动报警, true/false</param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostDoorSensorsIdAlarmAtMinutesWithHttpInfo (bool? enable, int? id);
        /// <summary>
        /// 取消某个门磁的报警
        /// </summary>
        /// <remarks>
        /// 取消某个门磁的报警
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>DoorSensor</returns>
        DoorSensor PostDoorSensorsIdIgnoreInDanger (int? id);

        /// <summary>
        /// 取消某个门磁的报警
        /// </summary>
        /// <remarks>
        /// 取消某个门磁的报警
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of DoorSensor</returns>
        ApiResponse<DoorSensor> PostDoorSensorsIdIgnoreInDangerWithHttpInfo (int? id);
        /// <summary>
        /// 设置门磁状态消息接收模式
        /// </summary>
        /// <remarks>
        /// 设置门磁状态消息接收模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门磁的ID</param>
        /// <param name="notifyMode">通知模式</param>
        /// <returns>DoorSensor</returns>
        DoorSensor PostDoorSensorsIdNotifyMode (int? id, int? notifyMode);

        /// <summary>
        /// 设置门磁状态消息接收模式
        /// </summary>
        /// <remarks>
        /// 设置门磁状态消息接收模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门磁的ID</param>
        /// <param name="notifyMode">通知模式</param>
        /// <returns>ApiResponse of DoorSensor</returns>
        ApiResponse<DoorSensor> PostDoorSensorsIdNotifyModeWithHttpInfo (int? id, int? notifyMode);
        /// <summary>
        /// 取消所有门磁的报警
        /// </summary>
        /// <remarks>
        /// 取消所有门磁的报警
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DoorSensor</returns>
        DoorSensor PostDoorSensorsIgnoreInDanger ();

        /// <summary>
        /// 取消所有门磁的报警
        /// </summary>
        /// <remarks>
        /// 取消所有门磁的报警
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DoorSensor</returns>
        ApiResponse<DoorSensor> PostDoorSensorsIgnoreInDangerWithHttpInfo ();
        /// <summary>
        /// 设置用户所有已有门磁的消息接收模式（用户更新到新 App 时数据迁移用）
        /// </summary>
        /// <remarks>
        /// 设置用户所有已有门磁的消息接收模式（用户更新到新 App 时数据迁移用）
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notifyMode">通知模式</param>
        /// <returns>DoorSensor</returns>
        DoorSensor PostDoorSensorsNotifyMode (int? notifyMode);

        /// <summary>
        /// 设置用户所有已有门磁的消息接收模式（用户更新到新 App 时数据迁移用）
        /// </summary>
        /// <remarks>
        /// 设置用户所有已有门磁的消息接收模式（用户更新到新 App 时数据迁移用）
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notifyMode">通知模式</param>
        /// <returns>ApiResponse of DoorSensor</returns>
        ApiResponse<DoorSensor> PostDoorSensorsNotifyModeWithHttpInfo (int? notifyMode);
        /// <summary>
        /// 撤防所有门磁
        /// </summary>
        /// <remarks>
        /// 撤防所有门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DoorSensor</returns>
        DoorSensor PutDoorSensorsDisableAlert ();

        /// <summary>
        /// 撤防所有门磁
        /// </summary>
        /// <remarks>
        /// 撤防所有门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DoorSensor</returns>
        ApiResponse<DoorSensor> PutDoorSensorsDisableAlertWithHttpInfo ();
        /// <summary>
        /// 布防所有门磁
        /// </summary>
        /// <remarks>
        /// 布防所有门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DoorSensor</returns>
        DoorSensor PutDoorSensorsEnableAlert ();

        /// <summary>
        /// 布防所有门磁
        /// </summary>
        /// <remarks>
        /// 布防所有门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DoorSensor</returns>
        ApiResponse<DoorSensor> PutDoorSensorsEnableAlertWithHttpInfo ();
        /// <summary>
        /// 更改用户门磁的触发情景, 以及设置
        /// </summary>
        /// <remarks>
        /// 更改用户门磁的触发情景, 以及设置
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门磁的ID</param>
        /// <param name="scenarioId1">早上打开时触发的情景ID</param>
        /// <param name="scenarioId2">晚上打开时触发的情景ID</param>
        /// <param name="inDefenceSystem">是否参与全家布防 (optional)</param>
        /// <param name="longTimeOpenAlert">长时间不关门是否有提醒 (optional)</param>
        /// <param name="name">设备新名称 (optional)</param>
        /// <returns>DoorSensor</returns>
        DoorSensor PutDoorSensorsId (int? id, int? scenarioId1, int? scenarioId2, bool? inDefenceSystem = null, bool? longTimeOpenAlert = null, string name = null);

        /// <summary>
        /// 更改用户门磁的触发情景, 以及设置
        /// </summary>
        /// <remarks>
        /// 更改用户门磁的触发情景, 以及设置
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门磁的ID</param>
        /// <param name="scenarioId1">早上打开时触发的情景ID</param>
        /// <param name="scenarioId2">晚上打开时触发的情景ID</param>
        /// <param name="inDefenceSystem">是否参与全家布防 (optional)</param>
        /// <param name="longTimeOpenAlert">长时间不关门是否有提醒 (optional)</param>
        /// <param name="name">设备新名称 (optional)</param>
        /// <returns>ApiResponse of DoorSensor</returns>
        ApiResponse<DoorSensor> PutDoorSensorsIdWithHttpInfo (int? id, int? scenarioId1, int? scenarioId2, bool? inDefenceSystem = null, bool? longTimeOpenAlert = null, string name = null);
        /// <summary>
        /// 撤防某个门磁
        /// </summary>
        /// <remarks>
        /// 撤防某个门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门磁的ID</param>
        /// <returns>DoorSensor</returns>
        DoorSensor PutDoorSensorsIdDisableAlert (int? id);

        /// <summary>
        /// 撤防某个门磁
        /// </summary>
        /// <remarks>
        /// 撤防某个门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门磁的ID</param>
        /// <returns>ApiResponse of DoorSensor</returns>
        ApiResponse<DoorSensor> PutDoorSensorsIdDisableAlertWithHttpInfo (int? id);
        /// <summary>
        /// 布防某个门磁
        /// </summary>
        /// <remarks>
        /// 布防某个门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门磁的ID</param>
        /// <returns>DoorSensor</returns>
        DoorSensor PutDoorSensorsIdEnableAlert (int? id);

        /// <summary>
        /// 布防某个门磁
        /// </summary>
        /// <remarks>
        /// 布防某个门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门磁的ID</param>
        /// <returns>ApiResponse of DoorSensor</returns>
        ApiResponse<DoorSensor> PutDoorSensorsIdEnableAlertWithHttpInfo (int? id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取当前用户的所有门磁
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DoorSensor</returns>
        System.Threading.Tasks.Task<DoorSensor> GetDoorSensorsAsync ();

        /// <summary>
        /// 获取当前用户的所有门磁
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DoorSensor)</returns>
        System.Threading.Tasks.Task<ApiResponse<DoorSensor>> GetDoorSensorsAsyncWithHttpInfo ();
        /// <summary>
        /// 获取当前用户的某个门磁
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">DoorSensor的ID</param>
        /// <returns>Task of DoorSensor</returns>
        System.Threading.Tasks.Task<DoorSensor> GetDoorSensorsIdAsync (int? id);

        /// <summary>
        /// 获取当前用户的某个门磁
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">DoorSensor的ID</param>
        /// <returns>Task of ApiResponse (DoorSensor)</returns>
        System.Threading.Tasks.Task<ApiResponse<DoorSensor>> GetDoorSensorsIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 设置门磁打开3分钟后, 自动报警
        /// </summary>
        /// <remarks>
        /// 设置门磁打开3分钟后, 自动报警
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enable">开启长时间开启自动报警, true/false</param>
        /// <param name="id"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostDoorSensorsIdAlarmAtMinutesAsync (bool? enable, int? id);

        /// <summary>
        /// 设置门磁打开3分钟后, 自动报警
        /// </summary>
        /// <remarks>
        /// 设置门磁打开3分钟后, 自动报警
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enable">开启长时间开启自动报警, true/false</param>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostDoorSensorsIdAlarmAtMinutesAsyncWithHttpInfo (bool? enable, int? id);
        /// <summary>
        /// 取消某个门磁的报警
        /// </summary>
        /// <remarks>
        /// 取消某个门磁的报警
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of DoorSensor</returns>
        System.Threading.Tasks.Task<DoorSensor> PostDoorSensorsIdIgnoreInDangerAsync (int? id);

        /// <summary>
        /// 取消某个门磁的报警
        /// </summary>
        /// <remarks>
        /// 取消某个门磁的报警
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (DoorSensor)</returns>
        System.Threading.Tasks.Task<ApiResponse<DoorSensor>> PostDoorSensorsIdIgnoreInDangerAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 设置门磁状态消息接收模式
        /// </summary>
        /// <remarks>
        /// 设置门磁状态消息接收模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门磁的ID</param>
        /// <param name="notifyMode">通知模式</param>
        /// <returns>Task of DoorSensor</returns>
        System.Threading.Tasks.Task<DoorSensor> PostDoorSensorsIdNotifyModeAsync (int? id, int? notifyMode);

        /// <summary>
        /// 设置门磁状态消息接收模式
        /// </summary>
        /// <remarks>
        /// 设置门磁状态消息接收模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门磁的ID</param>
        /// <param name="notifyMode">通知模式</param>
        /// <returns>Task of ApiResponse (DoorSensor)</returns>
        System.Threading.Tasks.Task<ApiResponse<DoorSensor>> PostDoorSensorsIdNotifyModeAsyncWithHttpInfo (int? id, int? notifyMode);
        /// <summary>
        /// 取消所有门磁的报警
        /// </summary>
        /// <remarks>
        /// 取消所有门磁的报警
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DoorSensor</returns>
        System.Threading.Tasks.Task<DoorSensor> PostDoorSensorsIgnoreInDangerAsync ();

        /// <summary>
        /// 取消所有门磁的报警
        /// </summary>
        /// <remarks>
        /// 取消所有门磁的报警
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DoorSensor)</returns>
        System.Threading.Tasks.Task<ApiResponse<DoorSensor>> PostDoorSensorsIgnoreInDangerAsyncWithHttpInfo ();
        /// <summary>
        /// 设置用户所有已有门磁的消息接收模式（用户更新到新 App 时数据迁移用）
        /// </summary>
        /// <remarks>
        /// 设置用户所有已有门磁的消息接收模式（用户更新到新 App 时数据迁移用）
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notifyMode">通知模式</param>
        /// <returns>Task of DoorSensor</returns>
        System.Threading.Tasks.Task<DoorSensor> PostDoorSensorsNotifyModeAsync (int? notifyMode);

        /// <summary>
        /// 设置用户所有已有门磁的消息接收模式（用户更新到新 App 时数据迁移用）
        /// </summary>
        /// <remarks>
        /// 设置用户所有已有门磁的消息接收模式（用户更新到新 App 时数据迁移用）
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notifyMode">通知模式</param>
        /// <returns>Task of ApiResponse (DoorSensor)</returns>
        System.Threading.Tasks.Task<ApiResponse<DoorSensor>> PostDoorSensorsNotifyModeAsyncWithHttpInfo (int? notifyMode);
        /// <summary>
        /// 撤防所有门磁
        /// </summary>
        /// <remarks>
        /// 撤防所有门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DoorSensor</returns>
        System.Threading.Tasks.Task<DoorSensor> PutDoorSensorsDisableAlertAsync ();

        /// <summary>
        /// 撤防所有门磁
        /// </summary>
        /// <remarks>
        /// 撤防所有门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DoorSensor)</returns>
        System.Threading.Tasks.Task<ApiResponse<DoorSensor>> PutDoorSensorsDisableAlertAsyncWithHttpInfo ();
        /// <summary>
        /// 布防所有门磁
        /// </summary>
        /// <remarks>
        /// 布防所有门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DoorSensor</returns>
        System.Threading.Tasks.Task<DoorSensor> PutDoorSensorsEnableAlertAsync ();

        /// <summary>
        /// 布防所有门磁
        /// </summary>
        /// <remarks>
        /// 布防所有门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DoorSensor)</returns>
        System.Threading.Tasks.Task<ApiResponse<DoorSensor>> PutDoorSensorsEnableAlertAsyncWithHttpInfo ();
        /// <summary>
        /// 更改用户门磁的触发情景, 以及设置
        /// </summary>
        /// <remarks>
        /// 更改用户门磁的触发情景, 以及设置
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门磁的ID</param>
        /// <param name="scenarioId1">早上打开时触发的情景ID</param>
        /// <param name="scenarioId2">晚上打开时触发的情景ID</param>
        /// <param name="inDefenceSystem">是否参与全家布防 (optional)</param>
        /// <param name="longTimeOpenAlert">长时间不关门是否有提醒 (optional)</param>
        /// <param name="name">设备新名称 (optional)</param>
        /// <returns>Task of DoorSensor</returns>
        System.Threading.Tasks.Task<DoorSensor> PutDoorSensorsIdAsync (int? id, int? scenarioId1, int? scenarioId2, bool? inDefenceSystem = null, bool? longTimeOpenAlert = null, string name = null);

        /// <summary>
        /// 更改用户门磁的触发情景, 以及设置
        /// </summary>
        /// <remarks>
        /// 更改用户门磁的触发情景, 以及设置
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门磁的ID</param>
        /// <param name="scenarioId1">早上打开时触发的情景ID</param>
        /// <param name="scenarioId2">晚上打开时触发的情景ID</param>
        /// <param name="inDefenceSystem">是否参与全家布防 (optional)</param>
        /// <param name="longTimeOpenAlert">长时间不关门是否有提醒 (optional)</param>
        /// <param name="name">设备新名称 (optional)</param>
        /// <returns>Task of ApiResponse (DoorSensor)</returns>
        System.Threading.Tasks.Task<ApiResponse<DoorSensor>> PutDoorSensorsIdAsyncWithHttpInfo (int? id, int? scenarioId1, int? scenarioId2, bool? inDefenceSystem = null, bool? longTimeOpenAlert = null, string name = null);
        /// <summary>
        /// 撤防某个门磁
        /// </summary>
        /// <remarks>
        /// 撤防某个门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门磁的ID</param>
        /// <returns>Task of DoorSensor</returns>
        System.Threading.Tasks.Task<DoorSensor> PutDoorSensorsIdDisableAlertAsync (int? id);

        /// <summary>
        /// 撤防某个门磁
        /// </summary>
        /// <remarks>
        /// 撤防某个门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门磁的ID</param>
        /// <returns>Task of ApiResponse (DoorSensor)</returns>
        System.Threading.Tasks.Task<ApiResponse<DoorSensor>> PutDoorSensorsIdDisableAlertAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 布防某个门磁
        /// </summary>
        /// <remarks>
        /// 布防某个门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门磁的ID</param>
        /// <returns>Task of DoorSensor</returns>
        System.Threading.Tasks.Task<DoorSensor> PutDoorSensorsIdEnableAlertAsync (int? id);

        /// <summary>
        /// 布防某个门磁
        /// </summary>
        /// <remarks>
        /// 布防某个门磁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门磁的ID</param>
        /// <returns>Task of ApiResponse (DoorSensor)</returns>
        System.Threading.Tasks.Task<ApiResponse<DoorSensor>> PutDoorSensorsIdEnableAlertAsyncWithHttpInfo (int? id);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}