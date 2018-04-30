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
    public interface IElectricMetersApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取所有电表
        /// </summary>
        /// <remarks>
        /// 获取所有电表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>FreshAirMachine</returns>
        FreshAirMachine GetElectricMeters ();

        /// <summary>
        /// 获取所有电表
        /// </summary>
        /// <remarks>
        /// 获取所有电表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of FreshAirMachine</returns>
        ApiResponse<FreshAirMachine> GetElectricMetersWithHttpInfo ();
        /// <summary>
        /// 获取某个电表
        /// </summary>
        /// <remarks>
        /// 获取某个电表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">电表ID</param>
        /// <returns>ElectricMeter</returns>
        ElectricMeter GetElectricMetersId (int? id);

        /// <summary>
        /// 获取某个电表
        /// </summary>
        /// <remarks>
        /// 获取某个电表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">电表ID</param>
        /// <returns>ApiResponse of ElectricMeter</returns>
        ApiResponse<ElectricMeter> GetElectricMetersIdWithHttpInfo (int? id);
        /// <summary>
        /// 获取电表历史电量
        /// </summary>
        /// <remarks>
        /// 获取电表历史电量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">电表id</param>
        /// <param name="startDate">开始日期</param>
        /// <param name="endDate">结束日期</param>
        /// <returns></returns>
        void GetElectricMetersIdQuantities (int? id, string startDate, string endDate);

        /// <summary>
        /// 获取电表历史电量
        /// </summary>
        /// <remarks>
        /// 获取电表历史电量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">电表id</param>
        /// <param name="startDate">开始日期</param>
        /// <param name="endDate">结束日期</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetElectricMetersIdQuantitiesWithHttpInfo (int? id, string startDate, string endDate);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取所有电表
        /// </summary>
        /// <remarks>
        /// 获取所有电表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of FreshAirMachine</returns>
        System.Threading.Tasks.Task<FreshAirMachine> GetElectricMetersAsync ();

        /// <summary>
        /// 获取所有电表
        /// </summary>
        /// <remarks>
        /// 获取所有电表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (FreshAirMachine)</returns>
        System.Threading.Tasks.Task<ApiResponse<FreshAirMachine>> GetElectricMetersAsyncWithHttpInfo ();
        /// <summary>
        /// 获取某个电表
        /// </summary>
        /// <remarks>
        /// 获取某个电表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">电表ID</param>
        /// <returns>Task of ElectricMeter</returns>
        System.Threading.Tasks.Task<ElectricMeter> GetElectricMetersIdAsync (int? id);

        /// <summary>
        /// 获取某个电表
        /// </summary>
        /// <remarks>
        /// 获取某个电表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">电表ID</param>
        /// <returns>Task of ApiResponse (ElectricMeter)</returns>
        System.Threading.Tasks.Task<ApiResponse<ElectricMeter>> GetElectricMetersIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 获取电表历史电量
        /// </summary>
        /// <remarks>
        /// 获取电表历史电量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">电表id</param>
        /// <param name="startDate">开始日期</param>
        /// <param name="endDate">结束日期</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetElectricMetersIdQuantitiesAsync (int? id, string startDate, string endDate);

        /// <summary>
        /// 获取电表历史电量
        /// </summary>
        /// <remarks>
        /// 获取电表历史电量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">电表id</param>
        /// <param name="startDate">开始日期</param>
        /// <param name="endDate">结束日期</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetElectricMetersIdQuantitiesAsyncWithHttpInfo (int? id, string startDate, string endDate);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}