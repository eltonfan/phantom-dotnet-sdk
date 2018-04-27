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
    public interface IEnvironmentSensorsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取所有环境传感器
        /// </summary>
        /// <remarks>
        /// 获取所有环境传感器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EnvironmentSensor</returns>
        EnvironmentSensor GetEnvironmentSensors ();

        /// <summary>
        /// 获取所有环境传感器
        /// </summary>
        /// <remarks>
        /// 获取所有环境传感器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EnvironmentSensor</returns>
        ApiResponse<EnvironmentSensor> GetEnvironmentSensorsWithHttpInfo ();
        /// <summary>
        /// 获取某个环境传感器
        /// </summary>
        /// <remarks>
        /// 获取某个环境传感器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <returns>EnvironmentSensor</returns>
        EnvironmentSensor GetEnvironmentSensorsId (int? id);

        /// <summary>
        /// 获取某个环境传感器
        /// </summary>
        /// <remarks>
        /// 获取某个环境传感器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <returns>ApiResponse of EnvironmentSensor</returns>
        ApiResponse<EnvironmentSensor> GetEnvironmentSensorsIdWithHttpInfo (int? id);
        /// <summary>
        /// 获取某个环境传感器某段时间少吸的砖头数
        /// </summary>
        /// <remarks>
        /// 获取某个环境传感器某段时间少吸的砖头数
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <param name="startTime">开始时间(时间格式必须为:2017-08-08 08:08:08)</param>
        /// <param name="endTime">结束时间(时间格式必须为:2017-08-08 08:08:08)</param>
        /// <returns>EnvironmentSensor</returns>
        EnvironmentSensor GetEnvironmentSensorsIdBrick (int? id, string startTime, string endTime);

        /// <summary>
        /// 获取某个环境传感器某段时间少吸的砖头数
        /// </summary>
        /// <remarks>
        /// 获取某个环境传感器某段时间少吸的砖头数
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <param name="startTime">开始时间(时间格式必须为:2017-08-08 08:08:08)</param>
        /// <param name="endTime">结束时间(时间格式必须为:2017-08-08 08:08:08)</param>
        /// <returns>ApiResponse of EnvironmentSensor</returns>
        ApiResponse<EnvironmentSensor> GetEnvironmentSensorsIdBrickWithHttpInfo (int? id, string startTime, string endTime);
        /// <summary>
        /// 获取传感器使用状态
        /// </summary>
        /// <remarks>
        /// 获取传感器使用状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <returns>GmFilter</returns>
        GmFilter GetEnvironmentSensorsIdFilters (int? id);

        /// <summary>
        /// 获取传感器使用状态
        /// </summary>
        /// <remarks>
        /// 获取传感器使用状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <returns>ApiResponse of GmFilter</returns>
        ApiResponse<GmFilter> GetEnvironmentSensorsIdFiltersWithHttpInfo (int? id);
        /// <summary>
        /// 获取某个环境传感器走势图
        /// </summary>
        /// <remarks>
        /// 获取某个环境传感器走势图
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <param name="startTime">开始时间(时间格式必须为:2017-08-08 08:08:08)</param>
        /// <param name="endTime">结束时间(时间格式必须为:2017-08-08 08:08:08)</param>
        /// <returns>EnvironmentSensor</returns>
        EnvironmentSensor GetEnvironmentSensorsIdTrend (int? id, string startTime, string endTime);

        /// <summary>
        /// 获取某个环境传感器走势图
        /// </summary>
        /// <remarks>
        /// 获取某个环境传感器走势图
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <param name="startTime">开始时间(时间格式必须为:2017-08-08 08:08:08)</param>
        /// <param name="endTime">结束时间(时间格式必须为:2017-08-08 08:08:08)</param>
        /// <returns>ApiResponse of EnvironmentSensor</returns>
        ApiResponse<EnvironmentSensor> GetEnvironmentSensorsIdTrendWithHttpInfo (int? id, string startTime, string endTime);
        /// <summary>
        /// 获取标准线
        /// </summary>
        /// <remarks>
        /// 获取标准线
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void GetEnvironmentSensorsStandardLine ();

        /// <summary>
        /// 获取标准线
        /// </summary>
        /// <remarks>
        /// 获取标准线
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetEnvironmentSensorsStandardLineWithHttpInfo ();
        /// <summary>
        /// 更换内部传感器
        /// </summary>
        /// <remarks>
        /// 更换内部传感器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器id</param>
        /// <param name="index">内部传感器索引</param>
        /// <returns>GmFilter</returns>
        GmFilter PostEnvironmentSensorsIdFiltersIndexReplacement (int? id, int? index);

        /// <summary>
        /// 更换内部传感器
        /// </summary>
        /// <remarks>
        /// 更换内部传感器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器id</param>
        /// <param name="index">内部传感器索引</param>
        /// <returns>ApiResponse of GmFilter</returns>
        ApiResponse<GmFilter> PostEnvironmentSensorsIdFiltersIndexReplacementWithHttpInfo (int? id, int? index);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取所有环境传感器
        /// </summary>
        /// <remarks>
        /// 获取所有环境传感器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EnvironmentSensor</returns>
        System.Threading.Tasks.Task<EnvironmentSensor> GetEnvironmentSensorsAsync ();

        /// <summary>
        /// 获取所有环境传感器
        /// </summary>
        /// <remarks>
        /// 获取所有环境传感器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EnvironmentSensor)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnvironmentSensor>> GetEnvironmentSensorsAsyncWithHttpInfo ();
        /// <summary>
        /// 获取某个环境传感器
        /// </summary>
        /// <remarks>
        /// 获取某个环境传感器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <returns>Task of EnvironmentSensor</returns>
        System.Threading.Tasks.Task<EnvironmentSensor> GetEnvironmentSensorsIdAsync (int? id);

        /// <summary>
        /// 获取某个环境传感器
        /// </summary>
        /// <remarks>
        /// 获取某个环境传感器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <returns>Task of ApiResponse (EnvironmentSensor)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnvironmentSensor>> GetEnvironmentSensorsIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 获取某个环境传感器某段时间少吸的砖头数
        /// </summary>
        /// <remarks>
        /// 获取某个环境传感器某段时间少吸的砖头数
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <param name="startTime">开始时间(时间格式必须为:2017-08-08 08:08:08)</param>
        /// <param name="endTime">结束时间(时间格式必须为:2017-08-08 08:08:08)</param>
        /// <returns>Task of EnvironmentSensor</returns>
        System.Threading.Tasks.Task<EnvironmentSensor> GetEnvironmentSensorsIdBrickAsync (int? id, string startTime, string endTime);

        /// <summary>
        /// 获取某个环境传感器某段时间少吸的砖头数
        /// </summary>
        /// <remarks>
        /// 获取某个环境传感器某段时间少吸的砖头数
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <param name="startTime">开始时间(时间格式必须为:2017-08-08 08:08:08)</param>
        /// <param name="endTime">结束时间(时间格式必须为:2017-08-08 08:08:08)</param>
        /// <returns>Task of ApiResponse (EnvironmentSensor)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnvironmentSensor>> GetEnvironmentSensorsIdBrickAsyncWithHttpInfo (int? id, string startTime, string endTime);
        /// <summary>
        /// 获取传感器使用状态
        /// </summary>
        /// <remarks>
        /// 获取传感器使用状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <returns>Task of GmFilter</returns>
        System.Threading.Tasks.Task<GmFilter> GetEnvironmentSensorsIdFiltersAsync (int? id);

        /// <summary>
        /// 获取传感器使用状态
        /// </summary>
        /// <remarks>
        /// 获取传感器使用状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <returns>Task of ApiResponse (GmFilter)</returns>
        System.Threading.Tasks.Task<ApiResponse<GmFilter>> GetEnvironmentSensorsIdFiltersAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 获取某个环境传感器走势图
        /// </summary>
        /// <remarks>
        /// 获取某个环境传感器走势图
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <param name="startTime">开始时间(时间格式必须为:2017-08-08 08:08:08)</param>
        /// <param name="endTime">结束时间(时间格式必须为:2017-08-08 08:08:08)</param>
        /// <returns>Task of EnvironmentSensor</returns>
        System.Threading.Tasks.Task<EnvironmentSensor> GetEnvironmentSensorsIdTrendAsync (int? id, string startTime, string endTime);

        /// <summary>
        /// 获取某个环境传感器走势图
        /// </summary>
        /// <remarks>
        /// 获取某个环境传感器走势图
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器ID</param>
        /// <param name="startTime">开始时间(时间格式必须为:2017-08-08 08:08:08)</param>
        /// <param name="endTime">结束时间(时间格式必须为:2017-08-08 08:08:08)</param>
        /// <returns>Task of ApiResponse (EnvironmentSensor)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnvironmentSensor>> GetEnvironmentSensorsIdTrendAsyncWithHttpInfo (int? id, string startTime, string endTime);
        /// <summary>
        /// 获取标准线
        /// </summary>
        /// <remarks>
        /// 获取标准线
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetEnvironmentSensorsStandardLineAsync ();

        /// <summary>
        /// 获取标准线
        /// </summary>
        /// <remarks>
        /// 获取标准线
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetEnvironmentSensorsStandardLineAsyncWithHttpInfo ();
        /// <summary>
        /// 更换内部传感器
        /// </summary>
        /// <remarks>
        /// 更换内部传感器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器id</param>
        /// <param name="index">内部传感器索引</param>
        /// <returns>Task of GmFilter</returns>
        System.Threading.Tasks.Task<GmFilter> PostEnvironmentSensorsIdFiltersIndexReplacementAsync (int? id, int? index);

        /// <summary>
        /// 更换内部传感器
        /// </summary>
        /// <remarks>
        /// 更换内部传感器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">传感器id</param>
        /// <param name="index">内部传感器索引</param>
        /// <returns>Task of ApiResponse (GmFilter)</returns>
        System.Threading.Tasks.Task<ApiResponse<GmFilter>> PostEnvironmentSensorsIdFiltersIndexReplacementAsyncWithHttpInfo (int? id, int? index);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}