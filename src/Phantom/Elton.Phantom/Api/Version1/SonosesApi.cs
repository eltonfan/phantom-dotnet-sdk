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
    public interface ISonosesApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取所有sonos
        /// </summary>
        /// <remarks>
        /// 获取所有sonos
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Sonos</returns>
        Sonos GetSonoses ();

        /// <summary>
        /// 获取所有sonos
        /// </summary>
        /// <remarks>
        /// 获取所有sonos
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Sonos</returns>
        ApiResponse<Sonos> GetSonosesWithHttpInfo ();
        /// <summary>
        /// 获取某个Sonos
        /// </summary>
        /// <remarks>
        /// 获取某个Sonos
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Sonos ID</param>
        /// <returns>Sonos</returns>
        Sonos GetSonosesId (int? id);

        /// <summary>
        /// 获取某个Sonos
        /// </summary>
        /// <remarks>
        /// 获取某个Sonos
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Sonos ID</param>
        /// <returns>ApiResponse of Sonos</returns>
        ApiResponse<Sonos> GetSonosesIdWithHttpInfo (int? id);
        /// <summary>
        /// 控制Sonos
        /// </summary>
        /// <remarks>
        /// 控制Sonos
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Sonos ID</param>
        /// <param name="type">0 - 顺序播放，不重复; 1 - 循环播放; 2 - 单曲循环; 4 - 随机播放</param>
        /// <param name="index">歌单索引</param>
        /// <param name="value">0-100</param>
        /// <param name="action">动作: play 播放; pause 暂停；mute 静音；cut 歌单切换; volume 调节音量; mode 调节模式 (optional)</param>
        /// <returns>Sonos</returns>
        Sonos PostSonosesIdAction (int? id, int? type, int? index, int? value, string action = null);

        /// <summary>
        /// 控制Sonos
        /// </summary>
        /// <remarks>
        /// 控制Sonos
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Sonos ID</param>
        /// <param name="type">0 - 顺序播放，不重复; 1 - 循环播放; 2 - 单曲循环; 4 - 随机播放</param>
        /// <param name="index">歌单索引</param>
        /// <param name="value">0-100</param>
        /// <param name="action">动作: play 播放; pause 暂停；mute 静音；cut 歌单切换; volume 调节音量; mode 调节模式 (optional)</param>
        /// <returns>ApiResponse of Sonos</returns>
        ApiResponse<Sonos> PostSonosesIdActionWithHttpInfo (int? id, int? type, int? index, int? value, string action = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取所有sonos
        /// </summary>
        /// <remarks>
        /// 获取所有sonos
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Sonos</returns>
        System.Threading.Tasks.Task<Sonos> GetSonosesAsync ();

        /// <summary>
        /// 获取所有sonos
        /// </summary>
        /// <remarks>
        /// 获取所有sonos
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Sonos)</returns>
        System.Threading.Tasks.Task<ApiResponse<Sonos>> GetSonosesAsyncWithHttpInfo ();
        /// <summary>
        /// 获取某个Sonos
        /// </summary>
        /// <remarks>
        /// 获取某个Sonos
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Sonos ID</param>
        /// <returns>Task of Sonos</returns>
        System.Threading.Tasks.Task<Sonos> GetSonosesIdAsync (int? id);

        /// <summary>
        /// 获取某个Sonos
        /// </summary>
        /// <remarks>
        /// 获取某个Sonos
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Sonos ID</param>
        /// <returns>Task of ApiResponse (Sonos)</returns>
        System.Threading.Tasks.Task<ApiResponse<Sonos>> GetSonosesIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 控制Sonos
        /// </summary>
        /// <remarks>
        /// 控制Sonos
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Sonos ID</param>
        /// <param name="type">0 - 顺序播放，不重复; 1 - 循环播放; 2 - 单曲循环; 4 - 随机播放</param>
        /// <param name="index">歌单索引</param>
        /// <param name="value">0-100</param>
        /// <param name="action">动作: play 播放; pause 暂停；mute 静音；cut 歌单切换; volume 调节音量; mode 调节模式 (optional)</param>
        /// <returns>Task of Sonos</returns>
        System.Threading.Tasks.Task<Sonos> PostSonosesIdActionAsync (int? id, int? type, int? index, int? value, string action = null);

        /// <summary>
        /// 控制Sonos
        /// </summary>
        /// <remarks>
        /// 控制Sonos
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Sonos ID</param>
        /// <param name="type">0 - 顺序播放，不重复; 1 - 循环播放; 2 - 单曲循环; 4 - 随机播放</param>
        /// <param name="index">歌单索引</param>
        /// <param name="value">0-100</param>
        /// <param name="action">动作: play 播放; pause 暂停；mute 静音；cut 歌单切换; volume 调节音量; mode 调节模式 (optional)</param>
        /// <returns>Task of ApiResponse (Sonos)</returns>
        System.Threading.Tasks.Task<ApiResponse<Sonos>> PostSonosesIdActionAsyncWithHttpInfo (int? id, int? type, int? index, int? value, string action = null);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}