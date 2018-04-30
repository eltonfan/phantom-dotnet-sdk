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
    public interface IIoDetectorsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取所有的开关量采集器
        /// </summary>
        /// <remarks>
        /// 获取所有的开关量采集器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>IoDetector</returns>
        IoDetector GetIoDetectors ();

        /// <summary>
        /// 获取所有的开关量采集器
        /// </summary>
        /// <remarks>
        /// 获取所有的开关量采集器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of IoDetector</returns>
        ApiResponse<IoDetector> GetIoDetectorsWithHttpInfo ();
        /// <summary>
        /// 获取开关量采集器
        /// </summary>
        /// <remarks>
        /// 获取开关量采集器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>IoDetector</returns>
        IoDetector GetIoDetectorsId (int? id);

        /// <summary>
        /// 获取开关量采集器
        /// </summary>
        /// <remarks>
        /// 获取开关量采集器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of IoDetector</returns>
        ApiResponse<IoDetector> GetIoDetectorsIdWithHttpInfo (int? id);
        /// <summary>
        /// 设定开启关闭时间阈值
        /// </summary>
        /// <remarks>
        /// 设定开启关闭时间阈值
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="onDelay">开启时间阈值</param>
        /// <param name="offDelay">关闭时间阈值</param>
        /// <param name="id"></param>
        /// <returns></returns>
        void PutIoDetectorsIdDelay (int? onDelay, int? offDelay, int? id);

        /// <summary>
        /// 设定开启关闭时间阈值
        /// </summary>
        /// <remarks>
        /// 设定开启关闭时间阈值
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="onDelay">开启时间阈值</param>
        /// <param name="offDelay">关闭时间阈值</param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PutIoDetectorsIdDelayWithHttpInfo (int? onDelay, int? offDelay, int? id);
        /// <summary>
        /// 设定开启/关闭触发情景
        /// </summary>
        /// <remarks>
        /// 设定开启/关闭触发情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="onScenarioId">开启触发情景</param>
        /// <param name="offScenarioId">关闭触发情景</param>
        /// <param name="id"></param>
        /// <returns>Scenario</returns>
        Scenario PutIoDetectorsIdScenarios (int? onScenarioId, int? offScenarioId, int? id);

        /// <summary>
        /// 设定开启/关闭触发情景
        /// </summary>
        /// <remarks>
        /// 设定开启/关闭触发情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="onScenarioId">开启触发情景</param>
        /// <param name="offScenarioId">关闭触发情景</param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Scenario</returns>
        ApiResponse<Scenario> PutIoDetectorsIdScenariosWithHttpInfo (int? onScenarioId, int? offScenarioId, int? id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取所有的开关量采集器
        /// </summary>
        /// <remarks>
        /// 获取所有的开关量采集器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IoDetector</returns>
        System.Threading.Tasks.Task<IoDetector> GetIoDetectorsAsync ();

        /// <summary>
        /// 获取所有的开关量采集器
        /// </summary>
        /// <remarks>
        /// 获取所有的开关量采集器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (IoDetector)</returns>
        System.Threading.Tasks.Task<ApiResponse<IoDetector>> GetIoDetectorsAsyncWithHttpInfo ();
        /// <summary>
        /// 获取开关量采集器
        /// </summary>
        /// <remarks>
        /// 获取开关量采集器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of IoDetector</returns>
        System.Threading.Tasks.Task<IoDetector> GetIoDetectorsIdAsync (int? id);

        /// <summary>
        /// 获取开关量采集器
        /// </summary>
        /// <remarks>
        /// 获取开关量采集器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (IoDetector)</returns>
        System.Threading.Tasks.Task<ApiResponse<IoDetector>> GetIoDetectorsIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 设定开启关闭时间阈值
        /// </summary>
        /// <remarks>
        /// 设定开启关闭时间阈值
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="onDelay">开启时间阈值</param>
        /// <param name="offDelay">关闭时间阈值</param>
        /// <param name="id"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PutIoDetectorsIdDelayAsync (int? onDelay, int? offDelay, int? id);

        /// <summary>
        /// 设定开启关闭时间阈值
        /// </summary>
        /// <remarks>
        /// 设定开启关闭时间阈值
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="onDelay">开启时间阈值</param>
        /// <param name="offDelay">关闭时间阈值</param>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PutIoDetectorsIdDelayAsyncWithHttpInfo (int? onDelay, int? offDelay, int? id);
        /// <summary>
        /// 设定开启/关闭触发情景
        /// </summary>
        /// <remarks>
        /// 设定开启/关闭触发情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="onScenarioId">开启触发情景</param>
        /// <param name="offScenarioId">关闭触发情景</param>
        /// <param name="id"></param>
        /// <returns>Task of Scenario</returns>
        System.Threading.Tasks.Task<Scenario> PutIoDetectorsIdScenariosAsync (int? onScenarioId, int? offScenarioId, int? id);

        /// <summary>
        /// 设定开启/关闭触发情景
        /// </summary>
        /// <remarks>
        /// 设定开启/关闭触发情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="onScenarioId">开启触发情景</param>
        /// <param name="offScenarioId">关闭触发情景</param>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (Scenario)</returns>
        System.Threading.Tasks.Task<ApiResponse<Scenario>> PutIoDetectorsIdScenariosAsyncWithHttpInfo (int? onScenarioId, int? offScenarioId, int? id);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}