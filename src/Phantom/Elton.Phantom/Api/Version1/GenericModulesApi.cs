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
    public interface IGenericModulesApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取当前用户的所有通用模块
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有通用模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GenericModule</returns>
        GenericModule GetGenericModules ();

        /// <summary>
        /// 获取当前用户的所有通用模块
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有通用模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GenericModule</returns>
        ApiResponse<GenericModule> GetGenericModulesWithHttpInfo ();
        /// <summary>
        /// 获取当前用户的某个通用模块
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个通用模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <returns>GenericModule</returns>
        GenericModule GetGenericModulesId (int? id);

        /// <summary>
        /// 获取当前用户的某个通用模块
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个通用模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <returns>ApiResponse of GenericModule</returns>
        ApiResponse<GenericModule> GetGenericModulesIdWithHttpInfo (int? id);
        /// <summary>
        /// 获取当前用户的某个通用模块的某个布尔量
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个通用模块的某个布尔量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <returns>BoolContent</returns>
        BoolContent GetGenericModulesIdBoolsN (int? id, int? n);

        /// <summary>
        /// 获取当前用户的某个通用模块的某个布尔量
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个通用模块的某个布尔量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <returns>ApiResponse of BoolContent</returns>
        ApiResponse<BoolContent> GetGenericModulesIdBoolsNWithHttpInfo (int? id, int? n);
        /// <summary>
        /// 获取当前用户的某个通用模块的某个数据量
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个通用模块的某个数据量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <returns>IntegerContent</returns>
        IntegerContent GetGenericModulesIdDataN (int? id, int? n);

        /// <summary>
        /// 获取当前用户的某个通用模块的某个数据量
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个通用模块的某个数据量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <returns>ApiResponse of IntegerContent</returns>
        ApiResponse<IntegerContent> GetGenericModulesIdDataNWithHttpInfo (int? id, int? n);
        /// <summary>
        /// 获取当前用户的某个通用模块的某个模式量
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个通用模块的某个模式量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <returns>IntegerContent</returns>
        IntegerContent GetGenericModulesIdModesN (int? id, int? n);

        /// <summary>
        /// 获取当前用户的某个通用模块的某个模式量
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个通用模块的某个模式量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <returns>ApiResponse of IntegerContent</returns>
        ApiResponse<IntegerContent> GetGenericModulesIdModesNWithHttpInfo (int? id, int? n);
        /// <summary>
        /// 刷新当前用户的某个通用模块的全部布尔量
        /// </summary>
        /// <remarks>
        /// 刷新当前用户的某个通用模块的全部布尔量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <returns>OperationResult</returns>
        OperationResult PostGenericModulesIdRefreshBools (int? id);

        /// <summary>
        /// 刷新当前用户的某个通用模块的全部布尔量
        /// </summary>
        /// <remarks>
        /// 刷新当前用户的某个通用模块的全部布尔量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <returns>ApiResponse of OperationResult</returns>
        ApiResponse<OperationResult> PostGenericModulesIdRefreshBoolsWithHttpInfo (int? id);
        /// <summary>
        /// 刷新当前用户的某个通用模块的全部数据量
        /// </summary>
        /// <remarks>
        /// 刷新当前用户的某个通用模块的全部数据量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <returns>OperationResult</returns>
        OperationResult PostGenericModulesIdRefreshData (int? id);

        /// <summary>
        /// 刷新当前用户的某个通用模块的全部数据量
        /// </summary>
        /// <remarks>
        /// 刷新当前用户的某个通用模块的全部数据量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <returns>ApiResponse of OperationResult</returns>
        ApiResponse<OperationResult> PostGenericModulesIdRefreshDataWithHttpInfo (int? id);
        /// <summary>
        /// 刷新当前用户的某个通用模块的全部模式量
        /// </summary>
        /// <remarks>
        /// 刷新当前用户的某个通用模块的全部模式量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <returns>OperationResult</returns>
        OperationResult PostGenericModulesIdRefreshModes (int? id);

        /// <summary>
        /// 刷新当前用户的某个通用模块的全部模式量
        /// </summary>
        /// <remarks>
        /// 刷新当前用户的某个通用模块的全部模式量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <returns>ApiResponse of OperationResult</returns>
        ApiResponse<OperationResult> PostGenericModulesIdRefreshModesWithHttpInfo (int? id);
        /// <summary>
        /// 更新当前用户的某个通用模块的某个布尔量
        /// </summary>
        /// <remarks>
        /// 更新当前用户的某个通用模块的某个布尔量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <param name="_bool">布尔量</param>
        /// <returns>OperationResult</returns>
        OperationResult PutGenericModulesIdBoolsN (int? id, int? n, bool? _bool);

        /// <summary>
        /// 更新当前用户的某个通用模块的某个布尔量
        /// </summary>
        /// <remarks>
        /// 更新当前用户的某个通用模块的某个布尔量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <param name="_bool">布尔量</param>
        /// <returns>ApiResponse of OperationResult</returns>
        ApiResponse<OperationResult> PutGenericModulesIdBoolsNWithHttpInfo (int? id, int? n, bool? _bool);
        /// <summary>
        /// 更新当前用户的某个通用模块的某个数据量
        /// </summary>
        /// <remarks>
        /// 更新当前用户的某个通用模块的某个数据量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <param name="datum">数据量</param>
        /// <returns>OperationResult</returns>
        OperationResult PutGenericModulesIdDataN (int? id, int? n, int? datum);

        /// <summary>
        /// 更新当前用户的某个通用模块的某个数据量
        /// </summary>
        /// <remarks>
        /// 更新当前用户的某个通用模块的某个数据量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <param name="datum">数据量</param>
        /// <returns>ApiResponse of OperationResult</returns>
        ApiResponse<OperationResult> PutGenericModulesIdDataNWithHttpInfo (int? id, int? n, int? datum);
        /// <summary>
        /// 控制新风机
        /// </summary>
        /// <remarks>
        /// 控制新风机
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="power">开关 (optional)</param>
        /// <param name="mode">模式 (optional)</param>
        /// <param name="wind">风速 (optional)</param>
        /// <returns>OperationResult</returns>
        OperationResult PutGenericModulesIdFan (int? id, bool? power = null, string mode = null, string wind = null);

        /// <summary>
        /// 控制新风机
        /// </summary>
        /// <remarks>
        /// 控制新风机
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="power">开关 (optional)</param>
        /// <param name="mode">模式 (optional)</param>
        /// <param name="wind">风速 (optional)</param>
        /// <returns>ApiResponse of OperationResult</returns>
        ApiResponse<OperationResult> PutGenericModulesIdFanWithHttpInfo (int? id, bool? power = null, string mode = null, string wind = null);
        /// <summary>
        /// 更新当前用户的某个通用模块的某个模式量
        /// </summary>
        /// <remarks>
        /// 更新当前用户的某个通用模块的某个模式量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <param name="mode">模式量</param>
        /// <returns>OperationResult</returns>
        OperationResult PutGenericModulesIdModesN (int? id, int? n, int? mode);

        /// <summary>
        /// 更新当前用户的某个通用模块的某个模式量
        /// </summary>
        /// <remarks>
        /// 更新当前用户的某个通用模块的某个模式量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <param name="mode">模式量</param>
        /// <returns>ApiResponse of OperationResult</returns>
        ApiResponse<OperationResult> PutGenericModulesIdModesNWithHttpInfo (int? id, int? n, int? mode);
        /// <summary>
        /// 控制智能窗户
        /// </summary>
        /// <remarks>
        /// 控制智能窗户
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="percent">开窗百分比，100全开，0关</param>
        /// <param name="mode">模式：平开1，上悬2 (optional)</param>
        /// <param name="speed">速度，0停止，1-3速度越来越大 (optional)</param>
        /// <returns>OperationResult</returns>
        OperationResult PutGenericModulesIdWindow (int? id, int? percent, string mode = null, int? speed = null);

        /// <summary>
        /// 控制智能窗户
        /// </summary>
        /// <remarks>
        /// 控制智能窗户
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="percent">开窗百分比，100全开，0关</param>
        /// <param name="mode">模式：平开1，上悬2 (optional)</param>
        /// <param name="speed">速度，0停止，1-3速度越来越大 (optional)</param>
        /// <returns>ApiResponse of OperationResult</returns>
        ApiResponse<OperationResult> PutGenericModulesIdWindowWithHttpInfo (int? id, int? percent, string mode = null, int? speed = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取当前用户的所有通用模块
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有通用模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GenericModule</returns>
        System.Threading.Tasks.Task<GenericModule> GetGenericModulesAsync ();

        /// <summary>
        /// 获取当前用户的所有通用模块
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有通用模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GenericModule)</returns>
        System.Threading.Tasks.Task<ApiResponse<GenericModule>> GetGenericModulesAsyncWithHttpInfo ();
        /// <summary>
        /// 获取当前用户的某个通用模块
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个通用模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <returns>Task of GenericModule</returns>
        System.Threading.Tasks.Task<GenericModule> GetGenericModulesIdAsync (int? id);

        /// <summary>
        /// 获取当前用户的某个通用模块
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个通用模块
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <returns>Task of ApiResponse (GenericModule)</returns>
        System.Threading.Tasks.Task<ApiResponse<GenericModule>> GetGenericModulesIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 获取当前用户的某个通用模块的某个布尔量
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个通用模块的某个布尔量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <returns>Task of BoolContent</returns>
        System.Threading.Tasks.Task<BoolContent> GetGenericModulesIdBoolsNAsync (int? id, int? n);

        /// <summary>
        /// 获取当前用户的某个通用模块的某个布尔量
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个通用模块的某个布尔量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <returns>Task of ApiResponse (BoolContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoolContent>> GetGenericModulesIdBoolsNAsyncWithHttpInfo (int? id, int? n);
        /// <summary>
        /// 获取当前用户的某个通用模块的某个数据量
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个通用模块的某个数据量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <returns>Task of IntegerContent</returns>
        System.Threading.Tasks.Task<IntegerContent> GetGenericModulesIdDataNAsync (int? id, int? n);

        /// <summary>
        /// 获取当前用户的某个通用模块的某个数据量
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个通用模块的某个数据量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <returns>Task of ApiResponse (IntegerContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegerContent>> GetGenericModulesIdDataNAsyncWithHttpInfo (int? id, int? n);
        /// <summary>
        /// 获取当前用户的某个通用模块的某个模式量
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个通用模块的某个模式量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <returns>Task of IntegerContent</returns>
        System.Threading.Tasks.Task<IntegerContent> GetGenericModulesIdModesNAsync (int? id, int? n);

        /// <summary>
        /// 获取当前用户的某个通用模块的某个模式量
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个通用模块的某个模式量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <returns>Task of ApiResponse (IntegerContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegerContent>> GetGenericModulesIdModesNAsyncWithHttpInfo (int? id, int? n);
        /// <summary>
        /// 刷新当前用户的某个通用模块的全部布尔量
        /// </summary>
        /// <remarks>
        /// 刷新当前用户的某个通用模块的全部布尔量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <returns>Task of OperationResult</returns>
        System.Threading.Tasks.Task<OperationResult> PostGenericModulesIdRefreshBoolsAsync (int? id);

        /// <summary>
        /// 刷新当前用户的某个通用模块的全部布尔量
        /// </summary>
        /// <remarks>
        /// 刷新当前用户的某个通用模块的全部布尔量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <returns>Task of ApiResponse (OperationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationResult>> PostGenericModulesIdRefreshBoolsAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 刷新当前用户的某个通用模块的全部数据量
        /// </summary>
        /// <remarks>
        /// 刷新当前用户的某个通用模块的全部数据量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <returns>Task of OperationResult</returns>
        System.Threading.Tasks.Task<OperationResult> PostGenericModulesIdRefreshDataAsync (int? id);

        /// <summary>
        /// 刷新当前用户的某个通用模块的全部数据量
        /// </summary>
        /// <remarks>
        /// 刷新当前用户的某个通用模块的全部数据量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <returns>Task of ApiResponse (OperationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationResult>> PostGenericModulesIdRefreshDataAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 刷新当前用户的某个通用模块的全部模式量
        /// </summary>
        /// <remarks>
        /// 刷新当前用户的某个通用模块的全部模式量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <returns>Task of OperationResult</returns>
        System.Threading.Tasks.Task<OperationResult> PostGenericModulesIdRefreshModesAsync (int? id);

        /// <summary>
        /// 刷新当前用户的某个通用模块的全部模式量
        /// </summary>
        /// <remarks>
        /// 刷新当前用户的某个通用模块的全部模式量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <returns>Task of ApiResponse (OperationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationResult>> PostGenericModulesIdRefreshModesAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 更新当前用户的某个通用模块的某个布尔量
        /// </summary>
        /// <remarks>
        /// 更新当前用户的某个通用模块的某个布尔量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <param name="_bool">布尔量</param>
        /// <returns>Task of OperationResult</returns>
        System.Threading.Tasks.Task<OperationResult> PutGenericModulesIdBoolsNAsync (int? id, int? n, bool? _bool);

        /// <summary>
        /// 更新当前用户的某个通用模块的某个布尔量
        /// </summary>
        /// <remarks>
        /// 更新当前用户的某个通用模块的某个布尔量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <param name="_bool">布尔量</param>
        /// <returns>Task of ApiResponse (OperationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationResult>> PutGenericModulesIdBoolsNAsyncWithHttpInfo (int? id, int? n, bool? _bool);
        /// <summary>
        /// 更新当前用户的某个通用模块的某个数据量
        /// </summary>
        /// <remarks>
        /// 更新当前用户的某个通用模块的某个数据量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <param name="datum">数据量</param>
        /// <returns>Task of OperationResult</returns>
        System.Threading.Tasks.Task<OperationResult> PutGenericModulesIdDataNAsync (int? id, int? n, int? datum);

        /// <summary>
        /// 更新当前用户的某个通用模块的某个数据量
        /// </summary>
        /// <remarks>
        /// 更新当前用户的某个通用模块的某个数据量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <param name="datum">数据量</param>
        /// <returns>Task of ApiResponse (OperationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationResult>> PutGenericModulesIdDataNAsyncWithHttpInfo (int? id, int? n, int? datum);
        /// <summary>
        /// 控制新风机
        /// </summary>
        /// <remarks>
        /// 控制新风机
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="power">开关 (optional)</param>
        /// <param name="mode">模式 (optional)</param>
        /// <param name="wind">风速 (optional)</param>
        /// <returns>Task of OperationResult</returns>
        System.Threading.Tasks.Task<OperationResult> PutGenericModulesIdFanAsync (int? id, bool? power = null, string mode = null, string wind = null);

        /// <summary>
        /// 控制新风机
        /// </summary>
        /// <remarks>
        /// 控制新风机
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="power">开关 (optional)</param>
        /// <param name="mode">模式 (optional)</param>
        /// <param name="wind">风速 (optional)</param>
        /// <returns>Task of ApiResponse (OperationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationResult>> PutGenericModulesIdFanAsyncWithHttpInfo (int? id, bool? power = null, string mode = null, string wind = null);
        /// <summary>
        /// 更新当前用户的某个通用模块的某个模式量
        /// </summary>
        /// <remarks>
        /// 更新当前用户的某个通用模块的某个模式量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <param name="mode">模式量</param>
        /// <returns>Task of OperationResult</returns>
        System.Threading.Tasks.Task<OperationResult> PutGenericModulesIdModesNAsync (int? id, int? n, int? mode);

        /// <summary>
        /// 更新当前用户的某个通用模块的某个模式量
        /// </summary>
        /// <remarks>
        /// 更新当前用户的某个通用模块的某个模式量
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="n">数据序号</param>
        /// <param name="mode">模式量</param>
        /// <returns>Task of ApiResponse (OperationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationResult>> PutGenericModulesIdModesNAsyncWithHttpInfo (int? id, int? n, int? mode);
        /// <summary>
        /// 控制智能窗户
        /// </summary>
        /// <remarks>
        /// 控制智能窗户
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="percent">开窗百分比，100全开，0关</param>
        /// <param name="mode">模式：平开1，上悬2 (optional)</param>
        /// <param name="speed">速度，0停止，1-3速度越来越大 (optional)</param>
        /// <returns>Task of OperationResult</returns>
        System.Threading.Tasks.Task<OperationResult> PutGenericModulesIdWindowAsync (int? id, int? percent, string mode = null, int? speed = null);

        /// <summary>
        /// 控制智能窗户
        /// </summary>
        /// <remarks>
        /// 控制智能窗户
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="percent">开窗百分比，100全开，0关</param>
        /// <param name="mode">模式：平开1，上悬2 (optional)</param>
        /// <param name="speed">速度，0停止，1-3速度越来越大 (optional)</param>
        /// <returns>Task of ApiResponse (OperationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationResult>> PutGenericModulesIdWindowAsyncWithHttpInfo (int? id, int? percent, string mode = null, int? speed = null);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}