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
using Elton.Phantom.Models.Version1;
using RestSharp;

namespace Elton.Phantom.Api.Version1
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBulbsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取了所有灯泡
        /// </summary>
        /// <remarks>
        /// 获取了所有灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Bulb</returns>
        Bulb GetBulbs();

        /// <summary>
        /// 获取了所有灯泡
        /// </summary>
        /// <remarks>
        /// 获取了所有灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Bulb</returns>
        ApiResponse<Bulb> GetBulbsWithHttpInfo();
        /// <summary>
        /// 获取灯泡当前状态
        /// </summary>
        /// <remarks>
        /// 获取灯泡当前状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns></returns>
        void GetBulbsAdvanceId(int? id);

        /// <summary>
        /// 获取灯泡当前状态
        /// </summary>
        /// <remarks>
        /// 获取灯泡当前状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetBulbsAdvanceIdWithHttpInfo(int? id);
        /// <summary>
        /// 获取一天的使用情况的图表
        /// </summary>
        /// <remarks>
        /// 获取一天的使用情况的图表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="date">日期,请按照yyyy-MM-dd传值,年必须是4位,月和日可以是1位。比如2016-7-1.如果不传就是获取当日的意思 (optional)</param>
        /// <returns></returns>
        void GetBulbsAdvanceIdChart(int? id, string date = null);

        /// <summary>
        /// 获取一天的使用情况的图表
        /// </summary>
        /// <remarks>
        /// 获取一天的使用情况的图表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="date">日期,请按照yyyy-MM-dd传值,年必须是4位,月和日可以是1位。比如2016-7-1.如果不传就是获取当日的意思 (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetBulbsAdvanceIdChartWithHttpInfo(int? id, string date = null);
        /// <summary>
        /// 获取灯泡的操作记录
        /// </summary>
        /// <remarks>
        /// 获取灯泡的操作记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="startDate">日期,请按照yyyy-MM-dd传值,年必须是4位,月和日可以是1位。比如2016-7-1.</param>
        /// <param name="endDate">格式同上，但是必须比start_date小；例如start_date是2016-7-4，那么end_date最大可以是2016-7-3。如果不传，则只返回start_date那一天的数据. (optional)</param>
        /// <returns></returns>
        void GetBulbsAdvanceIdLogs(int? id, string startDate, string endDate = null);

        /// <summary>
        /// 获取灯泡的操作记录
        /// </summary>
        /// <remarks>
        /// 获取灯泡的操作记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="startDate">日期,请按照yyyy-MM-dd传值,年必须是4位,月和日可以是1位。比如2016-7-1.</param>
        /// <param name="endDate">格式同上，但是必须比start_date小；例如start_date是2016-7-4，那么end_date最大可以是2016-7-3。如果不传，则只返回start_date那一天的数据. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetBulbsAdvanceIdLogsWithHttpInfo(int? id, string startDate, string endDate = null);
        /// <summary>
        /// 获取了灯泡
        /// </summary>
        /// <remarks>
        /// 获取了灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>Bulb</returns>
        Bulb GetBulbsId(int? id);

        /// <summary>
        /// 获取了灯泡
        /// </summary>
        /// <remarks>
        /// 获取了灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>ApiResponse of Bulb</returns>
        ApiResponse<Bulb> GetBulbsIdWithHttpInfo(int? id);
        /// <summary>
        /// 设定自动色温
        /// </summary>
        /// <remarks>
        /// 设定自动色温
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="autoHue">自动色温</param>
        /// <returns>OperationResult</returns>
        OperationResult PostBulbsIdAutoHue(int? id, bool? autoHue);

        /// <summary>
        /// 设定自动色温
        /// </summary>
        /// <remarks>
        /// 设定自动色温
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="autoHue">自动色温</param>
        /// <returns>ApiResponse of OperationResult</returns>
        ApiResponse<OperationResult> PostBulbsIdAutoHueWithHttpInfo(int? id, bool? autoHue);
        /// <summary>
        /// 关闭了灯泡
        /// </summary>
        /// <remarks>
        /// 关闭了灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>OperationResult</returns>
        OperationResult PostBulbsIdSwitchOff(int? id);

        /// <summary>
        /// 关闭了灯泡
        /// </summary>
        /// <remarks>
        /// 关闭了灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>ApiResponse of OperationResult</returns>
        ApiResponse<OperationResult> PostBulbsIdSwitchOffWithHttpInfo(int? id);
        /// <summary>
        /// 开启了灯泡
        /// </summary>
        /// <remarks>
        /// 开启了灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>OperationResult</returns>
        OperationResult PostBulbsIdSwitchOn(int? id);

        /// <summary>
        /// 开启了灯泡
        /// </summary>
        /// <remarks>
        /// 开启了灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>ApiResponse of OperationResult</returns>
        ApiResponse<OperationResult> PostBulbsIdSwitchOnWithHttpInfo(int? id);
        /// <summary>
        /// 调节了灯泡的状态
        /// </summary>
        /// <remarks>
        /// 调节了灯泡的状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="brightness">亮度 (optional)</param>
        /// <param name="hue">色温 (optional)</param>
        /// <returns>OperationResult</returns>
        OperationResult PostBulbsIdTune(int? id, float? brightness = null, float? hue = null);

        /// <summary>
        /// 调节了灯泡的状态
        /// </summary>
        /// <remarks>
        /// 调节了灯泡的状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="brightness">亮度 (optional)</param>
        /// <param name="hue">色温 (optional)</param>
        /// <returns>ApiResponse of OperationResult</returns>
        ApiResponse<OperationResult> PostBulbsIdTuneWithHttpInfo(int? id, float? brightness = null, float? hue = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取了所有灯泡
        /// </summary>
        /// <remarks>
        /// 获取了所有灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Bulb</returns>
        System.Threading.Tasks.Task<Bulb> GetBulbsAsync();

        /// <summary>
        /// 获取了所有灯泡
        /// </summary>
        /// <remarks>
        /// 获取了所有灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Bulb)</returns>
        System.Threading.Tasks.Task<ApiResponse<Bulb>> GetBulbsAsyncWithHttpInfo();
        /// <summary>
        /// 获取灯泡当前状态
        /// </summary>
        /// <remarks>
        /// 获取灯泡当前状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetBulbsAdvanceIdAsync(int? id);

        /// <summary>
        /// 获取灯泡当前状态
        /// </summary>
        /// <remarks>
        /// 获取灯泡当前状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetBulbsAdvanceIdAsyncWithHttpInfo(int? id);
        /// <summary>
        /// 获取一天的使用情况的图表
        /// </summary>
        /// <remarks>
        /// 获取一天的使用情况的图表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="date">日期,请按照yyyy-MM-dd传值,年必须是4位,月和日可以是1位。比如2016-7-1.如果不传就是获取当日的意思 (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetBulbsAdvanceIdChartAsync(int? id, string date = null);

        /// <summary>
        /// 获取一天的使用情况的图表
        /// </summary>
        /// <remarks>
        /// 获取一天的使用情况的图表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="date">日期,请按照yyyy-MM-dd传值,年必须是4位,月和日可以是1位。比如2016-7-1.如果不传就是获取当日的意思 (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetBulbsAdvanceIdChartAsyncWithHttpInfo(int? id, string date = null);
        /// <summary>
        /// 获取灯泡的操作记录
        /// </summary>
        /// <remarks>
        /// 获取灯泡的操作记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="startDate">日期,请按照yyyy-MM-dd传值,年必须是4位,月和日可以是1位。比如2016-7-1.</param>
        /// <param name="endDate">格式同上，但是必须比start_date小；例如start_date是2016-7-4，那么end_date最大可以是2016-7-3。如果不传，则只返回start_date那一天的数据. (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetBulbsAdvanceIdLogsAsync(int? id, string startDate, string endDate = null);

        /// <summary>
        /// 获取灯泡的操作记录
        /// </summary>
        /// <remarks>
        /// 获取灯泡的操作记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="startDate">日期,请按照yyyy-MM-dd传值,年必须是4位,月和日可以是1位。比如2016-7-1.</param>
        /// <param name="endDate">格式同上，但是必须比start_date小；例如start_date是2016-7-4，那么end_date最大可以是2016-7-3。如果不传，则只返回start_date那一天的数据. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetBulbsAdvanceIdLogsAsyncWithHttpInfo(int? id, string startDate, string endDate = null);
        /// <summary>
        /// 获取了灯泡
        /// </summary>
        /// <remarks>
        /// 获取了灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>Task of Bulb</returns>
        System.Threading.Tasks.Task<Bulb> GetBulbsIdAsync(int? id);

        /// <summary>
        /// 获取了灯泡
        /// </summary>
        /// <remarks>
        /// 获取了灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>Task of ApiResponse (Bulb)</returns>
        System.Threading.Tasks.Task<ApiResponse<Bulb>> GetBulbsIdAsyncWithHttpInfo(int? id);
        /// <summary>
        /// 设定自动色温
        /// </summary>
        /// <remarks>
        /// 设定自动色温
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="autoHue">自动色温</param>
        /// <returns>Task of OperationResult</returns>
        System.Threading.Tasks.Task<OperationResult> PostBulbsIdAutoHueAsync(int? id, bool? autoHue);

        /// <summary>
        /// 设定自动色温
        /// </summary>
        /// <remarks>
        /// 设定自动色温
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="autoHue">自动色温</param>
        /// <returns>Task of ApiResponse (OperationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationResult>> PostBulbsIdAutoHueAsyncWithHttpInfo(int? id, bool? autoHue);
        /// <summary>
        /// 关闭了灯泡
        /// </summary>
        /// <remarks>
        /// 关闭了灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>Task of OperationResult</returns>
        System.Threading.Tasks.Task<OperationResult> PostBulbsIdSwitchOffAsync(int? id);

        /// <summary>
        /// 关闭了灯泡
        /// </summary>
        /// <remarks>
        /// 关闭了灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>Task of ApiResponse (OperationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationResult>> PostBulbsIdSwitchOffAsyncWithHttpInfo(int? id);
        /// <summary>
        /// 开启了灯泡
        /// </summary>
        /// <remarks>
        /// 开启了灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>Task of OperationResult</returns>
        System.Threading.Tasks.Task<OperationResult> PostBulbsIdSwitchOnAsync(int? id);

        /// <summary>
        /// 开启了灯泡
        /// </summary>
        /// <remarks>
        /// 开启了灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <returns>Task of ApiResponse (OperationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationResult>> PostBulbsIdSwitchOnAsyncWithHttpInfo(int? id);
        /// <summary>
        /// 调节了灯泡的状态
        /// </summary>
        /// <remarks>
        /// 调节了灯泡的状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="brightness">亮度 (optional)</param>
        /// <param name="hue">色温 (optional)</param>
        /// <returns>Task of OperationResult</returns>
        System.Threading.Tasks.Task<OperationResult> PostBulbsIdTuneAsync(int? id, float? brightness = null, float? hue = null);

        /// <summary>
        /// 调节了灯泡的状态
        /// </summary>
        /// <remarks>
        /// 调节了灯泡的状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">灯泡ID</param>
        /// <param name="brightness">亮度 (optional)</param>
        /// <param name="hue">色温 (optional)</param>
        /// <returns>Task of ApiResponse (OperationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationResult>> PostBulbsIdTuneAsyncWithHttpInfo(int? id, float? brightness = null, float? hue = null);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}