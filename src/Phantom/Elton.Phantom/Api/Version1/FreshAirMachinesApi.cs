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
    public interface IFreshAirMachinesApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取所有新风机
        /// </summary>
        /// <remarks>
        /// 获取所有新风机
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>FreshAirMachine</returns>
        FreshAirMachine GetFreshAirMachines ();

        /// <summary>
        /// 获取所有新风机
        /// </summary>
        /// <remarks>
        /// 获取所有新风机
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of FreshAirMachine</returns>
        ApiResponse<FreshAirMachine> GetFreshAirMachinesWithHttpInfo ();
        /// <summary>
        /// 获取某个新风机
        /// </summary>
        /// <remarks>
        /// 获取某个新风机
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">新风机ID</param>
        /// <returns>FreshAirMachine</returns>
        FreshAirMachine GetFreshAirMachinesId (int? id);

        /// <summary>
        /// 获取某个新风机
        /// </summary>
        /// <remarks>
        /// 获取某个新风机
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">新风机ID</param>
        /// <returns>ApiResponse of FreshAirMachine</returns>
        ApiResponse<FreshAirMachine> GetFreshAirMachinesIdWithHttpInfo (int? id);
        /// <summary>
        /// 新风机滤网状态
        /// </summary>
        /// <remarks>
        /// 新风机滤网状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">新风机id</param>
        /// <returns>GmFilter</returns>
        GmFilter GetFreshAirMachinesIdFilters (int? id);

        /// <summary>
        /// 新风机滤网状态
        /// </summary>
        /// <remarks>
        /// 新风机滤网状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">新风机id</param>
        /// <returns>ApiResponse of GmFilter</returns>
        ApiResponse<GmFilter> GetFreshAirMachinesIdFiltersWithHttpInfo (int? id);
        /// <summary>
        /// 获取新风机净化量
        /// </summary>
        /// <remarks>
        /// 获取新风机净化量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">新风机ID</param>
        /// <returns></returns>
        void GetFreshAirMachinesIdFlows (int? id);

        /// <summary>
        /// 获取新风机净化量
        /// </summary>
        /// <remarks>
        /// 获取新风机净化量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">新风机ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetFreshAirMachinesIdFlowsWithHttpInfo (int? id);
        /// <summary>
        /// 控制新风机
        /// </summary>
        /// <remarks>
        /// 控制新风机
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">新风机id</param>
        /// <param name="power">开关，默认为开 (optional, default to true)</param>
        /// <param name="mode">模式 (optional)</param>
        /// <param name="wind">风速 (optional)</param>
        /// <returns>FreshAirMachine</returns>
        FreshAirMachine PostFreshAirMachinesIdAction (int? id, bool? power = null, string mode = null, string wind = null);

        /// <summary>
        /// 控制新风机
        /// </summary>
        /// <remarks>
        /// 控制新风机
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">新风机id</param>
        /// <param name="power">开关，默认为开 (optional, default to true)</param>
        /// <param name="mode">模式 (optional)</param>
        /// <param name="wind">风速 (optional)</param>
        /// <returns>ApiResponse of FreshAirMachine</returns>
        ApiResponse<FreshAirMachine> PostFreshAirMachinesIdActionWithHttpInfo (int? id, bool? power = null, string mode = null, string wind = null);
        /// <summary>
        /// 更换滤网
        /// </summary>
        /// <remarks>
        /// 更换滤网
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">新风机id</param>
        /// <param name="index">滤网索引</param>
        /// <returns>GmFilter</returns>
        GmFilter PostFreshAirMachinesIdFiltersIndexReplacement (int? id, int? index);

        /// <summary>
        /// 更换滤网
        /// </summary>
        /// <remarks>
        /// 更换滤网
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">新风机id</param>
        /// <param name="index">滤网索引</param>
        /// <returns>ApiResponse of GmFilter</returns>
        ApiResponse<GmFilter> PostFreshAirMachinesIdFiltersIndexReplacementWithHttpInfo (int? id, int? index);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取所有新风机
        /// </summary>
        /// <remarks>
        /// 获取所有新风机
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of FreshAirMachine</returns>
        System.Threading.Tasks.Task<FreshAirMachine> GetFreshAirMachinesAsync ();

        /// <summary>
        /// 获取所有新风机
        /// </summary>
        /// <remarks>
        /// 获取所有新风机
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (FreshAirMachine)</returns>
        System.Threading.Tasks.Task<ApiResponse<FreshAirMachine>> GetFreshAirMachinesAsyncWithHttpInfo ();
        /// <summary>
        /// 获取某个新风机
        /// </summary>
        /// <remarks>
        /// 获取某个新风机
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">新风机ID</param>
        /// <returns>Task of FreshAirMachine</returns>
        System.Threading.Tasks.Task<FreshAirMachine> GetFreshAirMachinesIdAsync (int? id);

        /// <summary>
        /// 获取某个新风机
        /// </summary>
        /// <remarks>
        /// 获取某个新风机
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">新风机ID</param>
        /// <returns>Task of ApiResponse (FreshAirMachine)</returns>
        System.Threading.Tasks.Task<ApiResponse<FreshAirMachine>> GetFreshAirMachinesIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 新风机滤网状态
        /// </summary>
        /// <remarks>
        /// 新风机滤网状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">新风机id</param>
        /// <returns>Task of GmFilter</returns>
        System.Threading.Tasks.Task<GmFilter> GetFreshAirMachinesIdFiltersAsync (int? id);

        /// <summary>
        /// 新风机滤网状态
        /// </summary>
        /// <remarks>
        /// 新风机滤网状态
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">新风机id</param>
        /// <returns>Task of ApiResponse (GmFilter)</returns>
        System.Threading.Tasks.Task<ApiResponse<GmFilter>> GetFreshAirMachinesIdFiltersAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 获取新风机净化量
        /// </summary>
        /// <remarks>
        /// 获取新风机净化量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">新风机ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetFreshAirMachinesIdFlowsAsync (int? id);

        /// <summary>
        /// 获取新风机净化量
        /// </summary>
        /// <remarks>
        /// 获取新风机净化量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">新风机ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetFreshAirMachinesIdFlowsAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 控制新风机
        /// </summary>
        /// <remarks>
        /// 控制新风机
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">新风机id</param>
        /// <param name="power">开关，默认为开 (optional, default to true)</param>
        /// <param name="mode">模式 (optional)</param>
        /// <param name="wind">风速 (optional)</param>
        /// <returns>Task of FreshAirMachine</returns>
        System.Threading.Tasks.Task<FreshAirMachine> PostFreshAirMachinesIdActionAsync (int? id, bool? power = null, string mode = null, string wind = null);

        /// <summary>
        /// 控制新风机
        /// </summary>
        /// <remarks>
        /// 控制新风机
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">新风机id</param>
        /// <param name="power">开关，默认为开 (optional, default to true)</param>
        /// <param name="mode">模式 (optional)</param>
        /// <param name="wind">风速 (optional)</param>
        /// <returns>Task of ApiResponse (FreshAirMachine)</returns>
        System.Threading.Tasks.Task<ApiResponse<FreshAirMachine>> PostFreshAirMachinesIdActionAsyncWithHttpInfo (int? id, bool? power = null, string mode = null, string wind = null);
        /// <summary>
        /// 更换滤网
        /// </summary>
        /// <remarks>
        /// 更换滤网
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">新风机id</param>
        /// <param name="index">滤网索引</param>
        /// <returns>Task of GmFilter</returns>
        System.Threading.Tasks.Task<GmFilter> PostFreshAirMachinesIdFiltersIndexReplacementAsync (int? id, int? index);

        /// <summary>
        /// 更换滤网
        /// </summary>
        /// <remarks>
        /// 更换滤网
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">新风机id</param>
        /// <param name="index">滤网索引</param>
        /// <returns>Task of ApiResponse (GmFilter)</returns>
        System.Threading.Tasks.Task<ApiResponse<GmFilter>> PostFreshAirMachinesIdFiltersIndexReplacementAsyncWithHttpInfo (int? id, int? index);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}