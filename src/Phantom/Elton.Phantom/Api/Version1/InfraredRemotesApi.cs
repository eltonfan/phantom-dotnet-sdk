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
    public interface IInfraredRemotesApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取当前用户的所有红外遥控
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有红外遥控
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InfraredRemote</returns>
        InfraredRemote GetInfraredRemotes ();

        /// <summary>
        /// 获取当前用户的所有红外遥控
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有红外遥控
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InfraredRemote</returns>
        ApiResponse<InfraredRemote> GetInfraredRemotesWithHttpInfo ();
        /// <summary>
        /// 获取当前用户的某个红外遥控
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个红外遥控
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">红外遥控设备的 ID</param>
        /// <returns>InfraredRemote</returns>
        InfraredRemote GetInfraredRemotesId (int? id);

        /// <summary>
        /// 获取当前用户的某个红外遥控
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个红外遥控
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">红外遥控设备的 ID</param>
        /// <returns>ApiResponse of InfraredRemote</returns>
        ApiResponse<InfraredRemote> GetInfraredRemotesIdWithHttpInfo (int? id);
        /// <summary>
        /// 发送红外指令控制
        /// </summary>
        /// <remarks>
        /// 发送红外指令控制
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">红外遥控 ID</param>
        /// <param name="onOff">开关：true 开；false 关.</param>
        /// <param name="mode">auto 自动；cold 制冷；hot 制热；humidity 抽湿；supply 送风 (optional, default to auto)</param>
        /// <param name="temp">温度：摄氏温度值(16-32) (optional, default to 16)</param>
        /// <param name="fan">风量：auto 自动；low 低风；middle 中风；high 高风 (optional, default to auto)</param>
        /// <param name="direction">风向：0 自动；1-5 分别表示5个位置 (optional, default to 0)</param>
        /// <returns>InfraredRemote</returns>
        InfraredRemote PostInfraredRemotesIdInfra (int? id, bool? onOff, string mode = null, int? temp = null, string fan = null, int? direction = null);

        /// <summary>
        /// 发送红外指令控制
        /// </summary>
        /// <remarks>
        /// 发送红外指令控制
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">红外遥控 ID</param>
        /// <param name="onOff">开关：true 开；false 关.</param>
        /// <param name="mode">auto 自动；cold 制冷；hot 制热；humidity 抽湿；supply 送风 (optional, default to auto)</param>
        /// <param name="temp">温度：摄氏温度值(16-32) (optional, default to 16)</param>
        /// <param name="fan">风量：auto 自动；low 低风；middle 中风；high 高风 (optional, default to auto)</param>
        /// <param name="direction">风向：0 自动；1-5 分别表示5个位置 (optional, default to 0)</param>
        /// <returns>ApiResponse of InfraredRemote</returns>
        ApiResponse<InfraredRemote> PostInfraredRemotesIdInfraWithHttpInfo (int? id, bool? onOff, string mode = null, int? temp = null, string fan = null, int? direction = null);
        /// <summary>
        /// 配置红外遥控
        /// </summary>
        /// <remarks>
        /// 配置红外遥控
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">红外遥控 ID</param>
        /// <param name="typeId">所控制的设备类型 ID，利用插控儿设备识别获取</param>
        /// <returns></returns>
        void PostInfraredRemotesIdTiming (int? id, string typeId);

        /// <summary>
        /// 配置红外遥控
        /// </summary>
        /// <remarks>
        /// 配置红外遥控
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">红外遥控 ID</param>
        /// <param name="typeId">所控制的设备类型 ID，利用插控儿设备识别获取</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostInfraredRemotesIdTimingWithHttpInfo (int? id, string typeId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取当前用户的所有红外遥控
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有红外遥控
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InfraredRemote</returns>
        System.Threading.Tasks.Task<InfraredRemote> GetInfraredRemotesAsync ();

        /// <summary>
        /// 获取当前用户的所有红外遥控
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有红外遥控
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InfraredRemote)</returns>
        System.Threading.Tasks.Task<ApiResponse<InfraredRemote>> GetInfraredRemotesAsyncWithHttpInfo ();
        /// <summary>
        /// 获取当前用户的某个红外遥控
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个红外遥控
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">红外遥控设备的 ID</param>
        /// <returns>Task of InfraredRemote</returns>
        System.Threading.Tasks.Task<InfraredRemote> GetInfraredRemotesIdAsync (int? id);

        /// <summary>
        /// 获取当前用户的某个红外遥控
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个红外遥控
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">红外遥控设备的 ID</param>
        /// <returns>Task of ApiResponse (InfraredRemote)</returns>
        System.Threading.Tasks.Task<ApiResponse<InfraredRemote>> GetInfraredRemotesIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 发送红外指令控制
        /// </summary>
        /// <remarks>
        /// 发送红外指令控制
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">红外遥控 ID</param>
        /// <param name="onOff">开关：true 开；false 关.</param>
        /// <param name="mode">auto 自动；cold 制冷；hot 制热；humidity 抽湿；supply 送风 (optional, default to auto)</param>
        /// <param name="temp">温度：摄氏温度值(16-32) (optional, default to 16)</param>
        /// <param name="fan">风量：auto 自动；low 低风；middle 中风；high 高风 (optional, default to auto)</param>
        /// <param name="direction">风向：0 自动；1-5 分别表示5个位置 (optional, default to 0)</param>
        /// <returns>Task of InfraredRemote</returns>
        System.Threading.Tasks.Task<InfraredRemote> PostInfraredRemotesIdInfraAsync (int? id, bool? onOff, string mode = null, int? temp = null, string fan = null, int? direction = null);

        /// <summary>
        /// 发送红外指令控制
        /// </summary>
        /// <remarks>
        /// 发送红外指令控制
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">红外遥控 ID</param>
        /// <param name="onOff">开关：true 开；false 关.</param>
        /// <param name="mode">auto 自动；cold 制冷；hot 制热；humidity 抽湿；supply 送风 (optional, default to auto)</param>
        /// <param name="temp">温度：摄氏温度值(16-32) (optional, default to 16)</param>
        /// <param name="fan">风量：auto 自动；low 低风；middle 中风；high 高风 (optional, default to auto)</param>
        /// <param name="direction">风向：0 自动；1-5 分别表示5个位置 (optional, default to 0)</param>
        /// <returns>Task of ApiResponse (InfraredRemote)</returns>
        System.Threading.Tasks.Task<ApiResponse<InfraredRemote>> PostInfraredRemotesIdInfraAsyncWithHttpInfo (int? id, bool? onOff, string mode = null, int? temp = null, string fan = null, int? direction = null);
        /// <summary>
        /// 配置红外遥控
        /// </summary>
        /// <remarks>
        /// 配置红外遥控
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">红外遥控 ID</param>
        /// <param name="typeId">所控制的设备类型 ID，利用插控儿设备识别获取</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostInfraredRemotesIdTimingAsync (int? id, string typeId);

        /// <summary>
        /// 配置红外遥控
        /// </summary>
        /// <remarks>
        /// 配置红外遥控
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">红外遥控 ID</param>
        /// <param name="typeId">所控制的设备类型 ID，利用插控儿设备识别获取</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostInfraredRemotesIdTimingAsyncWithHttpInfo (int? id, string typeId);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}