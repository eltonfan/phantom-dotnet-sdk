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
    public interface ICurtainsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取所有窗帘
        /// </summary>
        /// <remarks>
        /// 获取所有窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Curtain</returns>
        Curtain GetCurtains();

        /// <summary>
        /// 获取所有窗帘
        /// </summary>
        /// <remarks>
        /// 获取所有窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Curtain</returns>
        ApiResponse<Curtain> GetCurtainsWithHttpInfo();
        /// <summary>
        /// 获取某个窗帘
        /// </summary>
        /// <remarks>
        /// 获取某个窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">窗帘ID</param>
        /// <returns>Curtain</returns>
        Curtain GetCurtainsId(int? id);

        /// <summary>
        /// 获取某个窗帘
        /// </summary>
        /// <remarks>
        /// 获取某个窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">窗帘ID</param>
        /// <returns>ApiResponse of Curtain</returns>
        ApiResponse<Curtain> GetCurtainsIdWithHttpInfo(int? id);
        /// <summary>
        /// 控制窗帘
        /// </summary>
        /// <remarks>
        /// 控制窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">窗帘id</param>
        /// <param name="action">动作: open 开；close 关；stop 停 (optional)</param>
        /// <param name="percent">按照百分比控制开启面积 (optional)</param>
        /// <returns>Curtain</returns>
        Curtain PostCurtainsIdAction(int? id, string action = null, int? percent = null);

        /// <summary>
        /// 控制窗帘
        /// </summary>
        /// <remarks>
        /// 控制窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">窗帘id</param>
        /// <param name="action">动作: open 开；close 关；stop 停 (optional)</param>
        /// <param name="percent">按照百分比控制开启面积 (optional)</param>
        /// <returns>ApiResponse of Curtain</returns>
        ApiResponse<Curtain> PostCurtainsIdActionWithHttpInfo(int? id, string action = null, int? percent = null);
        /// <summary>
        /// 窗帘功能开关
        /// </summary>
        /// <remarks>
        /// 窗帘功能开关
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">窗帘id</param>
        /// <param name="reverse">是否反置行程 (optional)</param>
        /// <param name="pullAndLaunch">是否开启手拉启动 (optional)</param>
        /// <returns>Curtain</returns>
        Curtain PostCurtainsIdConfig(int? id, bool? reverse = null, bool? pullAndLaunch = null);

        /// <summary>
        /// 窗帘功能开关
        /// </summary>
        /// <remarks>
        /// 窗帘功能开关
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">窗帘id</param>
        /// <param name="reverse">是否反置行程 (optional)</param>
        /// <param name="pullAndLaunch">是否开启手拉启动 (optional)</param>
        /// <returns>ApiResponse of Curtain</returns>
        ApiResponse<Curtain> PostCurtainsIdConfigWithHttpInfo(int? id, bool? reverse = null, bool? pullAndLaunch = null);
        /// <summary>
        /// 配置窗帘行程: 步骤／调节／微调 三选一
        /// </summary>
        /// <remarks>
        /// 配置窗帘行程: 步骤／调节／微调 三选一
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">窗帘id</param>
        /// <param name="step">设置行程的步骤: su: 开始设置行程；up: 完成上行程设置；sd: 开始设置下行程；down: 完成下形成设置 (optional)</param>
        /// <param name="tuning">调节窗帘位置：up: 上／开；down: 下／关 (optional)</param>
        /// <param name="fineTuning">微调窗帘位置：up: 上／开；down: 下／关 (optional)</param>
        /// <returns>Curtain</returns>
        Curtain PostCurtainsIdLimitSet(int? id, string step = null, string tuning = null, string fineTuning = null);

        /// <summary>
        /// 配置窗帘行程: 步骤／调节／微调 三选一
        /// </summary>
        /// <remarks>
        /// 配置窗帘行程: 步骤／调节／微调 三选一
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">窗帘id</param>
        /// <param name="step">设置行程的步骤: su: 开始设置行程；up: 完成上行程设置；sd: 开始设置下行程；down: 完成下形成设置 (optional)</param>
        /// <param name="tuning">调节窗帘位置：up: 上／开；down: 下／关 (optional)</param>
        /// <param name="fineTuning">微调窗帘位置：up: 上／开；down: 下／关 (optional)</param>
        /// <returns>ApiResponse of Curtain</returns>
        ApiResponse<Curtain> PostCurtainsIdLimitSetWithHttpInfo(int? id, string step = null, string tuning = null, string fineTuning = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取所有窗帘
        /// </summary>
        /// <remarks>
        /// 获取所有窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Curtain</returns>
        System.Threading.Tasks.Task<Curtain> GetCurtainsAsync();

        /// <summary>
        /// 获取所有窗帘
        /// </summary>
        /// <remarks>
        /// 获取所有窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Curtain)</returns>
        System.Threading.Tasks.Task<ApiResponse<Curtain>> GetCurtainsAsyncWithHttpInfo();
        /// <summary>
        /// 获取某个窗帘
        /// </summary>
        /// <remarks>
        /// 获取某个窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">窗帘ID</param>
        /// <returns>Task of Curtain</returns>
        System.Threading.Tasks.Task<Curtain> GetCurtainsIdAsync(int? id);

        /// <summary>
        /// 获取某个窗帘
        /// </summary>
        /// <remarks>
        /// 获取某个窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">窗帘ID</param>
        /// <returns>Task of ApiResponse (Curtain)</returns>
        System.Threading.Tasks.Task<ApiResponse<Curtain>> GetCurtainsIdAsyncWithHttpInfo(int? id);
        /// <summary>
        /// 控制窗帘
        /// </summary>
        /// <remarks>
        /// 控制窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">窗帘id</param>
        /// <param name="action">动作: open 开；close 关；stop 停 (optional)</param>
        /// <param name="percent">按照百分比控制开启面积 (optional)</param>
        /// <returns>Task of Curtain</returns>
        System.Threading.Tasks.Task<Curtain> PostCurtainsIdActionAsync(int? id, string action = null, int? percent = null);

        /// <summary>
        /// 控制窗帘
        /// </summary>
        /// <remarks>
        /// 控制窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">窗帘id</param>
        /// <param name="action">动作: open 开；close 关；stop 停 (optional)</param>
        /// <param name="percent">按照百分比控制开启面积 (optional)</param>
        /// <returns>Task of ApiResponse (Curtain)</returns>
        System.Threading.Tasks.Task<ApiResponse<Curtain>> PostCurtainsIdActionAsyncWithHttpInfo(int? id, string action = null, int? percent = null);
        /// <summary>
        /// 窗帘功能开关
        /// </summary>
        /// <remarks>
        /// 窗帘功能开关
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">窗帘id</param>
        /// <param name="reverse">是否反置行程 (optional)</param>
        /// <param name="pullAndLaunch">是否开启手拉启动 (optional)</param>
        /// <returns>Task of Curtain</returns>
        System.Threading.Tasks.Task<Curtain> PostCurtainsIdConfigAsync(int? id, bool? reverse = null, bool? pullAndLaunch = null);

        /// <summary>
        /// 窗帘功能开关
        /// </summary>
        /// <remarks>
        /// 窗帘功能开关
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">窗帘id</param>
        /// <param name="reverse">是否反置行程 (optional)</param>
        /// <param name="pullAndLaunch">是否开启手拉启动 (optional)</param>
        /// <returns>Task of ApiResponse (Curtain)</returns>
        System.Threading.Tasks.Task<ApiResponse<Curtain>> PostCurtainsIdConfigAsyncWithHttpInfo(int? id, bool? reverse = null, bool? pullAndLaunch = null);
        /// <summary>
        /// 配置窗帘行程: 步骤／调节／微调 三选一
        /// </summary>
        /// <remarks>
        /// 配置窗帘行程: 步骤／调节／微调 三选一
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">窗帘id</param>
        /// <param name="step">设置行程的步骤: su: 开始设置行程；up: 完成上行程设置；sd: 开始设置下行程；down: 完成下形成设置 (optional)</param>
        /// <param name="tuning">调节窗帘位置：up: 上／开；down: 下／关 (optional)</param>
        /// <param name="fineTuning">微调窗帘位置：up: 上／开；down: 下／关 (optional)</param>
        /// <returns>Task of Curtain</returns>
        System.Threading.Tasks.Task<Curtain> PostCurtainsIdLimitSetAsync(int? id, string step = null, string tuning = null, string fineTuning = null);

        /// <summary>
        /// 配置窗帘行程: 步骤／调节／微调 三选一
        /// </summary>
        /// <remarks>
        /// 配置窗帘行程: 步骤／调节／微调 三选一
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">窗帘id</param>
        /// <param name="step">设置行程的步骤: su: 开始设置行程；up: 完成上行程设置；sd: 开始设置下行程；down: 完成下形成设置 (optional)</param>
        /// <param name="tuning">调节窗帘位置：up: 上／开；down: 下／关 (optional)</param>
        /// <param name="fineTuning">微调窗帘位置：up: 上／开；down: 下／关 (optional)</param>
        /// <returns>Task of ApiResponse (Curtain)</returns>
        System.Threading.Tasks.Task<ApiResponse<Curtain>> PostCurtainsIdLimitSetAsyncWithHttpInfo(int? id, string step = null, string tuning = null, string fineTuning = null);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}