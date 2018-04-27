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
    public interface IWallSwitchesApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取当前用户的所有墙面开关
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有墙面开关
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>WallSwitch</returns>
        WallSwitch GetWallSwitches ();

        /// <summary>
        /// 获取当前用户的所有墙面开关
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有墙面开关
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of WallSwitch</returns>
        ApiResponse<WallSwitch> GetWallSwitchesWithHttpInfo ();
        /// <summary>
        /// 获取当前用户的某个墙面开关
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个墙面开关
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">WallSwitch的ID</param>
        /// <returns>WallSwitch</returns>
        WallSwitch GetWallSwitchesId (int? id);

        /// <summary>
        /// 获取当前用户的某个墙面开关
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个墙面开关
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">WallSwitch的ID</param>
        /// <returns>ApiResponse of WallSwitch</returns>
        ApiResponse<WallSwitch> GetWallSwitchesIdWithHttpInfo (int? id);
        /// <summary>
        /// 墙面开关直接控灯API
        /// </summary>
        /// <remarks>
        /// 墙面开关直接控灯API
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">WallSwitch的ID</param>
        /// <param name="channel">WallSwitch的channel，第一路是1</param>
        /// <param name="switchOn">开启true,关闭false</param>
        /// <returns>WallSwitch</returns>
        WallSwitch PostWallSwitchesIdChannelControlBulb (int? id, int? channel, bool? switchOn);

        /// <summary>
        /// 墙面开关直接控灯API
        /// </summary>
        /// <remarks>
        /// 墙面开关直接控灯API
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">WallSwitch的ID</param>
        /// <param name="channel">WallSwitch的channel，第一路是1</param>
        /// <param name="switchOn">开启true,关闭false</param>
        /// <returns>ApiResponse of WallSwitch</returns>
        ApiResponse<WallSwitch> PostWallSwitchesIdChannelControlBulbWithHttpInfo (int? id, int? channel, bool? switchOn);
        /// <summary>
        /// 设置某个墙面开关某一路的triggable_bulb_ids
        /// </summary>
        /// <remarks>
        /// 设置某个墙面开关某一路的triggable_bulb_ids
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">WallSwitch的ID</param>
        /// <param name="channel">WallSwitch的channel，第一路是0</param>
        /// <param name="bulbIds">以逗号分隔的灯泡ID，如1,2,3</param>
        /// <returns>WallSwitch</returns>
        WallSwitch PostWallSwitchesIdChannelTriggableBulbIds (int? id, int? channel, string bulbIds);

        /// <summary>
        /// 设置某个墙面开关某一路的triggable_bulb_ids
        /// </summary>
        /// <remarks>
        /// 设置某个墙面开关某一路的triggable_bulb_ids
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">WallSwitch的ID</param>
        /// <param name="channel">WallSwitch的channel，第一路是0</param>
        /// <param name="bulbIds">以逗号分隔的灯泡ID，如1,2,3</param>
        /// <returns>ApiResponse of WallSwitch</returns>
        ApiResponse<WallSwitch> PostWallSwitchesIdChannelTriggableBulbIdsWithHttpInfo (int? id, int? channel, string bulbIds);
        /// <summary>
        /// 设置某个墙面开关的情景
        /// </summary>
        /// <remarks>
        /// 设置某个墙面开关的情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">WallSwitch的ID</param>
        /// <returns>WallSwitch</returns>
        WallSwitch PutWallSwitchesId (int? id);

        /// <summary>
        /// 设置某个墙面开关的情景
        /// </summary>
        /// <remarks>
        /// 设置某个墙面开关的情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">WallSwitch的ID</param>
        /// <returns>ApiResponse of WallSwitch</returns>
        ApiResponse<WallSwitch> PutWallSwitchesIdWithHttpInfo (int? id);
        /// <summary>
        /// 设置某个墙面开关的某一路长按情景
        /// </summary>
        /// <remarks>
        /// 设置某个墙面开关的某一路长按情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">WallSwitch的ID</param>
        /// <param name="channel">WallSwitch的channel，第一路是1</param>
        /// <param name="scenarioId">长按绑定的情景id</param>
        /// <returns>WallSwitch</returns>
        WallSwitch PutWallSwitchesIdChannel (int? id, int? channel, int? scenarioId);

        /// <summary>
        /// 设置某个墙面开关的某一路长按情景
        /// </summary>
        /// <remarks>
        /// 设置某个墙面开关的某一路长按情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">WallSwitch的ID</param>
        /// <param name="channel">WallSwitch的channel，第一路是1</param>
        /// <param name="scenarioId">长按绑定的情景id</param>
        /// <returns>ApiResponse of WallSwitch</returns>
        ApiResponse<WallSwitch> PutWallSwitchesIdChannelWithHttpInfo (int? id, int? channel, int? scenarioId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取当前用户的所有墙面开关
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有墙面开关
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of WallSwitch</returns>
        System.Threading.Tasks.Task<WallSwitch> GetWallSwitchesAsync ();

        /// <summary>
        /// 获取当前用户的所有墙面开关
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有墙面开关
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (WallSwitch)</returns>
        System.Threading.Tasks.Task<ApiResponse<WallSwitch>> GetWallSwitchesAsyncWithHttpInfo ();
        /// <summary>
        /// 获取当前用户的某个墙面开关
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个墙面开关
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">WallSwitch的ID</param>
        /// <returns>Task of WallSwitch</returns>
        System.Threading.Tasks.Task<WallSwitch> GetWallSwitchesIdAsync (int? id);

        /// <summary>
        /// 获取当前用户的某个墙面开关
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个墙面开关
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">WallSwitch的ID</param>
        /// <returns>Task of ApiResponse (WallSwitch)</returns>
        System.Threading.Tasks.Task<ApiResponse<WallSwitch>> GetWallSwitchesIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 墙面开关直接控灯API
        /// </summary>
        /// <remarks>
        /// 墙面开关直接控灯API
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">WallSwitch的ID</param>
        /// <param name="channel">WallSwitch的channel，第一路是1</param>
        /// <param name="switchOn">开启true,关闭false</param>
        /// <returns>Task of WallSwitch</returns>
        System.Threading.Tasks.Task<WallSwitch> PostWallSwitchesIdChannelControlBulbAsync (int? id, int? channel, bool? switchOn);

        /// <summary>
        /// 墙面开关直接控灯API
        /// </summary>
        /// <remarks>
        /// 墙面开关直接控灯API
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">WallSwitch的ID</param>
        /// <param name="channel">WallSwitch的channel，第一路是1</param>
        /// <param name="switchOn">开启true,关闭false</param>
        /// <returns>Task of ApiResponse (WallSwitch)</returns>
        System.Threading.Tasks.Task<ApiResponse<WallSwitch>> PostWallSwitchesIdChannelControlBulbAsyncWithHttpInfo (int? id, int? channel, bool? switchOn);
        /// <summary>
        /// 设置某个墙面开关某一路的triggable_bulb_ids
        /// </summary>
        /// <remarks>
        /// 设置某个墙面开关某一路的triggable_bulb_ids
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">WallSwitch的ID</param>
        /// <param name="channel">WallSwitch的channel，第一路是0</param>
        /// <param name="bulbIds">以逗号分隔的灯泡ID，如1,2,3</param>
        /// <returns>Task of WallSwitch</returns>
        System.Threading.Tasks.Task<WallSwitch> PostWallSwitchesIdChannelTriggableBulbIdsAsync (int? id, int? channel, string bulbIds);

        /// <summary>
        /// 设置某个墙面开关某一路的triggable_bulb_ids
        /// </summary>
        /// <remarks>
        /// 设置某个墙面开关某一路的triggable_bulb_ids
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">WallSwitch的ID</param>
        /// <param name="channel">WallSwitch的channel，第一路是0</param>
        /// <param name="bulbIds">以逗号分隔的灯泡ID，如1,2,3</param>
        /// <returns>Task of ApiResponse (WallSwitch)</returns>
        System.Threading.Tasks.Task<ApiResponse<WallSwitch>> PostWallSwitchesIdChannelTriggableBulbIdsAsyncWithHttpInfo (int? id, int? channel, string bulbIds);
        /// <summary>
        /// 设置某个墙面开关的情景
        /// </summary>
        /// <remarks>
        /// 设置某个墙面开关的情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">WallSwitch的ID</param>
        /// <returns>Task of WallSwitch</returns>
        System.Threading.Tasks.Task<WallSwitch> PutWallSwitchesIdAsync (int? id);

        /// <summary>
        /// 设置某个墙面开关的情景
        /// </summary>
        /// <remarks>
        /// 设置某个墙面开关的情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">WallSwitch的ID</param>
        /// <returns>Task of ApiResponse (WallSwitch)</returns>
        System.Threading.Tasks.Task<ApiResponse<WallSwitch>> PutWallSwitchesIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 设置某个墙面开关的某一路长按情景
        /// </summary>
        /// <remarks>
        /// 设置某个墙面开关的某一路长按情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">WallSwitch的ID</param>
        /// <param name="channel">WallSwitch的channel，第一路是1</param>
        /// <param name="scenarioId">长按绑定的情景id</param>
        /// <returns>Task of WallSwitch</returns>
        System.Threading.Tasks.Task<WallSwitch> PutWallSwitchesIdChannelAsync (int? id, int? channel, int? scenarioId);

        /// <summary>
        /// 设置某个墙面开关的某一路长按情景
        /// </summary>
        /// <remarks>
        /// 设置某个墙面开关的某一路长按情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">WallSwitch的ID</param>
        /// <param name="channel">WallSwitch的channel，第一路是1</param>
        /// <param name="scenarioId">长按绑定的情景id</param>
        /// <returns>Task of ApiResponse (WallSwitch)</returns>
        System.Threading.Tasks.Task<ApiResponse<WallSwitch>> PutWallSwitchesIdChannelAsyncWithHttpInfo (int? id, int? channel, int? scenarioId);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}