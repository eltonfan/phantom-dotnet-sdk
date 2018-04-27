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
    public interface IWaterPurifiersApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取所有净水器
        /// </summary>
        /// <remarks>
        /// 获取所有净水器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>WaterPurifier</returns>
        WaterPurifier GetWaterPurifiers ();

        /// <summary>
        /// 获取所有净水器
        /// </summary>
        /// <remarks>
        /// 获取所有净水器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of WaterPurifier</returns>
        ApiResponse<WaterPurifier> GetWaterPurifiersWithHttpInfo ();
        /// <summary>
        /// 获取某个净水器
        /// </summary>
        /// <remarks>
        /// 获取某个净水器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">净水器id</param>
        /// <returns>WaterPurifier</returns>
        WaterPurifier GetWaterPurifiersId (int? id);

        /// <summary>
        /// 获取某个净水器
        /// </summary>
        /// <remarks>
        /// 获取某个净水器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">净水器id</param>
        /// <returns>ApiResponse of WaterPurifier</returns>
        ApiResponse<WaterPurifier> GetWaterPurifiersIdWithHttpInfo (int? id);
        /// <summary>
        /// 净水器滤芯状态
        /// </summary>
        /// <remarks>
        /// 净水器滤芯状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">净水器id</param>
        /// <returns>GmFilter</returns>
        GmFilter GetWaterPurifiersIdFilters (int? id);

        /// <summary>
        /// 净水器滤芯状态
        /// </summary>
        /// <remarks>
        /// 净水器滤芯状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">净水器id</param>
        /// <returns>ApiResponse of GmFilter</returns>
        ApiResponse<GmFilter> GetWaterPurifiersIdFiltersWithHttpInfo (int? id);
        /// <summary>
        /// 净水器累计流量
        /// </summary>
        /// <remarks>
        /// 净水器累计流量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">净水器id</param>
        /// <returns></returns>
        void GetWaterPurifiersIdFlows (int? id);

        /// <summary>
        /// 净水器累计流量
        /// </summary>
        /// <remarks>
        /// 净水器累计流量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">净水器id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetWaterPurifiersIdFlowsWithHttpInfo (int? id);
        /// <summary>
        /// 控制净水器
        /// </summary>
        /// <remarks>
        /// 控制净水器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">净水器id</param>
        /// <param name="power">开关，默认为开 (optional, default to true)</param>
        /// <param name="pump">水泵开关 (optional)</param>
        /// <param name="inlet">进水阀 (optional)</param>
        /// <param name="outlet">出水阀 (optional)</param>
        /// <param name="hot">加热开关 (optional)</param>
        /// <param name="highPressure">高压开关 (optional)</param>
        /// <param name="lowPressure">低压开关 (optional)</param>
        /// <param name="leak">漏水开关 (optional)</param>
        /// <param name="hummer">蜂鸣器开关 (optional)</param>
        /// <returns>WaterPurifier</returns>
        WaterPurifier PostWaterPurifiersIdAction (int? id, bool? power = null, bool? pump = null, bool? inlet = null, bool? outlet = null, bool? hot = null, bool? highPressure = null, bool? lowPressure = null, bool? leak = null, bool? hummer = null);

        /// <summary>
        /// 控制净水器
        /// </summary>
        /// <remarks>
        /// 控制净水器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">净水器id</param>
        /// <param name="power">开关，默认为开 (optional, default to true)</param>
        /// <param name="pump">水泵开关 (optional)</param>
        /// <param name="inlet">进水阀 (optional)</param>
        /// <param name="outlet">出水阀 (optional)</param>
        /// <param name="hot">加热开关 (optional)</param>
        /// <param name="highPressure">高压开关 (optional)</param>
        /// <param name="lowPressure">低压开关 (optional)</param>
        /// <param name="leak">漏水开关 (optional)</param>
        /// <param name="hummer">蜂鸣器开关 (optional)</param>
        /// <returns>ApiResponse of WaterPurifier</returns>
        ApiResponse<WaterPurifier> PostWaterPurifiersIdActionWithHttpInfo (int? id, bool? power = null, bool? pump = null, bool? inlet = null, bool? outlet = null, bool? hot = null, bool? highPressure = null, bool? lowPressure = null, bool? leak = null, bool? hummer = null);
        /// <summary>
        /// 更换滤芯
        /// </summary>
        /// <remarks>
        /// 更换滤芯
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">净水器id</param>
        /// <param name="index">滤芯索引</param>
        /// <returns>GmFilter</returns>
        GmFilter PostWaterPurifiersIdFiltersIndexReplacement (int? id, int? index);

        /// <summary>
        /// 更换滤芯
        /// </summary>
        /// <remarks>
        /// 更换滤芯
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">净水器id</param>
        /// <param name="index">滤芯索引</param>
        /// <returns>ApiResponse of GmFilter</returns>
        ApiResponse<GmFilter> PostWaterPurifiersIdFiltersIndexReplacementWithHttpInfo (int? id, int? index);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取所有净水器
        /// </summary>
        /// <remarks>
        /// 获取所有净水器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of WaterPurifier</returns>
        System.Threading.Tasks.Task<WaterPurifier> GetWaterPurifiersAsync ();

        /// <summary>
        /// 获取所有净水器
        /// </summary>
        /// <remarks>
        /// 获取所有净水器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (WaterPurifier)</returns>
        System.Threading.Tasks.Task<ApiResponse<WaterPurifier>> GetWaterPurifiersAsyncWithHttpInfo ();
        /// <summary>
        /// 获取某个净水器
        /// </summary>
        /// <remarks>
        /// 获取某个净水器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">净水器id</param>
        /// <returns>Task of WaterPurifier</returns>
        System.Threading.Tasks.Task<WaterPurifier> GetWaterPurifiersIdAsync (int? id);

        /// <summary>
        /// 获取某个净水器
        /// </summary>
        /// <remarks>
        /// 获取某个净水器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">净水器id</param>
        /// <returns>Task of ApiResponse (WaterPurifier)</returns>
        System.Threading.Tasks.Task<ApiResponse<WaterPurifier>> GetWaterPurifiersIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 净水器滤芯状态
        /// </summary>
        /// <remarks>
        /// 净水器滤芯状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">净水器id</param>
        /// <returns>Task of GmFilter</returns>
        System.Threading.Tasks.Task<GmFilter> GetWaterPurifiersIdFiltersAsync (int? id);

        /// <summary>
        /// 净水器滤芯状态
        /// </summary>
        /// <remarks>
        /// 净水器滤芯状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">净水器id</param>
        /// <returns>Task of ApiResponse (GmFilter)</returns>
        System.Threading.Tasks.Task<ApiResponse<GmFilter>> GetWaterPurifiersIdFiltersAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 净水器累计流量
        /// </summary>
        /// <remarks>
        /// 净水器累计流量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">净水器id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetWaterPurifiersIdFlowsAsync (int? id);

        /// <summary>
        /// 净水器累计流量
        /// </summary>
        /// <remarks>
        /// 净水器累计流量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">净水器id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetWaterPurifiersIdFlowsAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 控制净水器
        /// </summary>
        /// <remarks>
        /// 控制净水器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">净水器id</param>
        /// <param name="power">开关，默认为开 (optional, default to true)</param>
        /// <param name="pump">水泵开关 (optional)</param>
        /// <param name="inlet">进水阀 (optional)</param>
        /// <param name="outlet">出水阀 (optional)</param>
        /// <param name="hot">加热开关 (optional)</param>
        /// <param name="highPressure">高压开关 (optional)</param>
        /// <param name="lowPressure">低压开关 (optional)</param>
        /// <param name="leak">漏水开关 (optional)</param>
        /// <param name="hummer">蜂鸣器开关 (optional)</param>
        /// <returns>Task of WaterPurifier</returns>
        System.Threading.Tasks.Task<WaterPurifier> PostWaterPurifiersIdActionAsync (int? id, bool? power = null, bool? pump = null, bool? inlet = null, bool? outlet = null, bool? hot = null, bool? highPressure = null, bool? lowPressure = null, bool? leak = null, bool? hummer = null);

        /// <summary>
        /// 控制净水器
        /// </summary>
        /// <remarks>
        /// 控制净水器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">净水器id</param>
        /// <param name="power">开关，默认为开 (optional, default to true)</param>
        /// <param name="pump">水泵开关 (optional)</param>
        /// <param name="inlet">进水阀 (optional)</param>
        /// <param name="outlet">出水阀 (optional)</param>
        /// <param name="hot">加热开关 (optional)</param>
        /// <param name="highPressure">高压开关 (optional)</param>
        /// <param name="lowPressure">低压开关 (optional)</param>
        /// <param name="leak">漏水开关 (optional)</param>
        /// <param name="hummer">蜂鸣器开关 (optional)</param>
        /// <returns>Task of ApiResponse (WaterPurifier)</returns>
        System.Threading.Tasks.Task<ApiResponse<WaterPurifier>> PostWaterPurifiersIdActionAsyncWithHttpInfo (int? id, bool? power = null, bool? pump = null, bool? inlet = null, bool? outlet = null, bool? hot = null, bool? highPressure = null, bool? lowPressure = null, bool? leak = null, bool? hummer = null);
        /// <summary>
        /// 更换滤芯
        /// </summary>
        /// <remarks>
        /// 更换滤芯
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">净水器id</param>
        /// <param name="index">滤芯索引</param>
        /// <returns>Task of GmFilter</returns>
        System.Threading.Tasks.Task<GmFilter> PostWaterPurifiersIdFiltersIndexReplacementAsync (int? id, int? index);

        /// <summary>
        /// 更换滤芯
        /// </summary>
        /// <remarks>
        /// 更换滤芯
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">净水器id</param>
        /// <param name="index">滤芯索引</param>
        /// <returns>Task of ApiResponse (GmFilter)</returns>
        System.Threading.Tasks.Task<ApiResponse<GmFilter>> PostWaterPurifiersIdFiltersIndexReplacementAsyncWithHttpInfo (int? id, int? index);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}