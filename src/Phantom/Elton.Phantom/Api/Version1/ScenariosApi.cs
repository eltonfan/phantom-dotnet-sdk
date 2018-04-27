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
    public interface IScenariosApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 删除了情景模式
        /// </summary>
        /// <remarks>
        /// 删除了情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Scenario</returns>
        Scenario DeleteScenariosId (int? id);

        /// <summary>
        /// 删除了情景模式
        /// </summary>
        /// <remarks>
        /// 删除了情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>ApiResponse of Scenario</returns>
        ApiResponse<Scenario> DeleteScenariosIdWithHttpInfo (int? id);
        /// <summary>
        /// 获取了所有情景模式
        /// </summary>
        /// <remarks>
        /// 获取了所有情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withoutSci">不需要SCI详细信息 (optional)</param>
        /// <param name="houseId">房间ID (optional)</param>
        /// <param name="zoneId">区域ID (optional)</param>
        /// <param name="sciType">包含的SCI类型 (optional)</param>
        /// <param name="sortByName">按名称排序 (optional)</param>
        /// <param name="sortByTime">按创建时间排序 (optional)</param>
        /// <param name="sortBySciSize">按sci数量排序 (optional)</param>
        /// <returns>Scenario</returns>
        Scenario GetScenarios (bool? withoutSci = null, int? houseId = null, int? zoneId = null, string sciType = null, bool? sortByName = null, bool? sortByTime = null, bool? sortBySciSize = null);

        /// <summary>
        /// 获取了所有情景模式
        /// </summary>
        /// <remarks>
        /// 获取了所有情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withoutSci">不需要SCI详细信息 (optional)</param>
        /// <param name="houseId">房间ID (optional)</param>
        /// <param name="zoneId">区域ID (optional)</param>
        /// <param name="sciType">包含的SCI类型 (optional)</param>
        /// <param name="sortByName">按名称排序 (optional)</param>
        /// <param name="sortByTime">按创建时间排序 (optional)</param>
        /// <param name="sortBySciSize">按sci数量排序 (optional)</param>
        /// <returns>ApiResponse of Scenario</returns>
        ApiResponse<Scenario> GetScenariosWithHttpInfo (bool? withoutSci = null, int? houseId = null, int? zoneId = null, string sciType = null, bool? sortByName = null, bool? sortByTime = null, bool? sortBySciSize = null);
        /// <summary>
        /// 获取了情景模式
        /// </summary>
        /// <remarks>
        /// 获取了情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Scenario</returns>
        Scenario GetScenariosId (int? id);

        /// <summary>
        /// 获取了情景模式
        /// </summary>
        /// <remarks>
        /// 获取了情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>ApiResponse of Scenario</returns>
        ApiResponse<Scenario> GetScenariosIdWithHttpInfo (int? id);
        /// <summary>
        /// 查询分时情景
        /// </summary>
        /// <remarks>
        /// 查询分时情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Scenario</returns>
        Scenario GetScenariosTimeDivision ();

        /// <summary>
        /// 查询分时情景
        /// </summary>
        /// <remarks>
        /// 查询分时情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Scenario</returns>
        ApiResponse<Scenario> GetScenariosTimeDivisionWithHttpInfo ();
        /// <summary>
        /// 创建了一个新的情景模式
        /// </summary>
        /// <remarks>
        /// 创建了一个新的情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">情景模式名称</param>
        /// <param name="scenarioContentItemsAttributesGenericModuleId"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesMode"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesBulbId"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesBrightness"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesTurnedOn"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesHue"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesInfo"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesStash"> (optional)</param>
        /// <param name="zoneId">Zone ID (optional)</param>
        /// <param name="areaId">Area ID (optional)</param>
        /// <param name="icon">Icon (optional)</param>
        /// <returns>Scenario</returns>
        Scenario PostScenarios (string name, List<int?> scenarioContentItemsAttributesGenericModuleId = null, List<int?> scenarioContentItemsAttributesMode = null, List<int?> scenarioContentItemsAttributesBulbId = null, List<float?> scenarioContentItemsAttributesBrightness = null, List<bool?> scenarioContentItemsAttributesTurnedOn = null, List<float?> scenarioContentItemsAttributesHue = null, List<string> scenarioContentItemsAttributesInfo = null, List<string> scenarioContentItemsAttributesStash = null, int? zoneId = null, int? areaId = null, int? icon = null);

        /// <summary>
        /// 创建了一个新的情景模式
        /// </summary>
        /// <remarks>
        /// 创建了一个新的情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">情景模式名称</param>
        /// <param name="scenarioContentItemsAttributesGenericModuleId"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesMode"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesBulbId"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesBrightness"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesTurnedOn"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesHue"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesInfo"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesStash"> (optional)</param>
        /// <param name="zoneId">Zone ID (optional)</param>
        /// <param name="areaId">Area ID (optional)</param>
        /// <param name="icon">Icon (optional)</param>
        /// <returns>ApiResponse of Scenario</returns>
        ApiResponse<Scenario> PostScenariosWithHttpInfo (string name, List<int?> scenarioContentItemsAttributesGenericModuleId = null, List<int?> scenarioContentItemsAttributesMode = null, List<int?> scenarioContentItemsAttributesBulbId = null, List<float?> scenarioContentItemsAttributesBrightness = null, List<bool?> scenarioContentItemsAttributesTurnedOn = null, List<float?> scenarioContentItemsAttributesHue = null, List<string> scenarioContentItemsAttributesInfo = null, List<string> scenarioContentItemsAttributesStash = null, int? zoneId = null, int? areaId = null, int? icon = null);
        /// <summary>
        /// 应用了全关情景模式
        /// </summary>
        /// <remarks>
        /// 应用了全关情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origin"> (optional)</param>
        /// <returns>OperationResult</returns>
        OperationResult PostScenariosAllOff (int? origin = null);

        /// <summary>
        /// 应用了全关情景模式
        /// </summary>
        /// <remarks>
        /// 应用了全关情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origin"> (optional)</param>
        /// <returns>ApiResponse of OperationResult</returns>
        ApiResponse<OperationResult> PostScenariosAllOffWithHttpInfo (int? origin = null);
        /// <summary>
        /// 应用了全开情景模式
        /// </summary>
        /// <remarks>
        /// 应用了全开情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origin"> (optional)</param>
        /// <returns>OperationResult</returns>
        OperationResult PostScenariosAllOn (int? origin = null);

        /// <summary>
        /// 应用了全开情景模式
        /// </summary>
        /// <remarks>
        /// 应用了全开情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origin"> (optional)</param>
        /// <returns>ApiResponse of OperationResult</returns>
        ApiResponse<OperationResult> PostScenariosAllOnWithHttpInfo (int? origin = null);
        /// <summary>
        /// 更新延迟关灯情景时间
        /// </summary>
        /// <remarks>
        /// 更新延迟关灯情景时间
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <param name="time">延迟关灯的时间</param>
        /// <returns>Scenario</returns>
        Scenario PostScenariosDelayTime (int? id, int? time);

        /// <summary>
        /// 更新延迟关灯情景时间
        /// </summary>
        /// <remarks>
        /// 更新延迟关灯情景时间
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <param name="time">延迟关灯的时间</param>
        /// <returns>ApiResponse of Scenario</returns>
        ApiResponse<Scenario> PostScenariosDelayTimeWithHttpInfo (int? id, int? time);
        /// <summary>
        /// 应用了一个情景模式
        /// </summary>
        /// <remarks>
        /// 应用了一个情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <param name="origin"> (optional)</param>
        /// <returns>OperationResult</returns>
        OperationResult PostScenariosIdApply (int? id, int? origin = null);

        /// <summary>
        /// 应用了一个情景模式
        /// </summary>
        /// <remarks>
        /// 应用了一个情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <param name="origin"> (optional)</param>
        /// <returns>ApiResponse of OperationResult</returns>
        ApiResponse<OperationResult> PostScenariosIdApplyWithHttpInfo (int? id, int? origin = null);
        /// <summary>
        /// 创建分时情景
        /// </summary>
        /// <remarks>
        /// 创建分时情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">情景模式名称,系统会自动加上分时前缀</param>
        /// <param name="timeDivisionItemsScenarioId">子情景id</param>
        /// <param name="timeDivisionItemsStartTime">开始时间,通过算法\&quot;%01X\&quot;%wday+\&quot;%05X\&quot;%(hour*3600+minute*60+second)\&quot;得出,0-6代表周日到周六,按天循环始终传0</param>
        /// <param name="timeDivisionItemsEndTime">结束时间,格式如上</param>
        /// <param name="cycleDay">循环周期,默认按周循环 (optional)</param>
        /// <returns>Scenario</returns>
        Scenario PostScenariosTimeDivision (string name, List<int?> timeDivisionItemsScenarioId, List<string> timeDivisionItemsStartTime, List<string> timeDivisionItemsEndTime, bool? cycleDay = null);

        /// <summary>
        /// 创建分时情景
        /// </summary>
        /// <remarks>
        /// 创建分时情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">情景模式名称,系统会自动加上分时前缀</param>
        /// <param name="timeDivisionItemsScenarioId">子情景id</param>
        /// <param name="timeDivisionItemsStartTime">开始时间,通过算法\&quot;%01X\&quot;%wday+\&quot;%05X\&quot;%(hour*3600+minute*60+second)\&quot;得出,0-6代表周日到周六,按天循环始终传0</param>
        /// <param name="timeDivisionItemsEndTime">结束时间,格式如上</param>
        /// <param name="cycleDay">循环周期,默认按周循环 (optional)</param>
        /// <returns>ApiResponse of Scenario</returns>
        ApiResponse<Scenario> PostScenariosTimeDivisionWithHttpInfo (string name, List<int?> timeDivisionItemsScenarioId, List<string> timeDivisionItemsStartTime, List<string> timeDivisionItemsEndTime, bool? cycleDay = null);
        /// <summary>
        /// 更新了情景模式
        /// </summary>
        /// <remarks>
        /// 更新了情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <param name="name">情景模式名称</param>
        /// <param name="scenarioContentItemsAttributes">情景模式内容, 一个scenario_content_items_attributes数组</param>
        /// <param name="areaId">Area ID (optional)</param>
        /// <param name="icon">Icon (optional)</param>
        /// <returns>Scenario</returns>
        Scenario PutScenariosId (int? id, string name, List<Object> scenarioContentItemsAttributes, int? areaId = null, int? icon = null);

        /// <summary>
        /// 更新了情景模式
        /// </summary>
        /// <remarks>
        /// 更新了情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <param name="name">情景模式名称</param>
        /// <param name="scenarioContentItemsAttributes">情景模式内容, 一个scenario_content_items_attributes数组</param>
        /// <param name="areaId">Area ID (optional)</param>
        /// <param name="icon">Icon (optional)</param>
        /// <returns>ApiResponse of Scenario</returns>
        ApiResponse<Scenario> PutScenariosIdWithHttpInfo (int? id, string name, List<Object> scenarioContentItemsAttributes, int? areaId = null, int? icon = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 删除了情景模式
        /// </summary>
        /// <remarks>
        /// 删除了情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Task of Scenario</returns>
        System.Threading.Tasks.Task<Scenario> DeleteScenariosIdAsync (int? id);

        /// <summary>
        /// 删除了情景模式
        /// </summary>
        /// <remarks>
        /// 删除了情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (Scenario)</returns>
        System.Threading.Tasks.Task<ApiResponse<Scenario>> DeleteScenariosIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 获取了所有情景模式
        /// </summary>
        /// <remarks>
        /// 获取了所有情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withoutSci">不需要SCI详细信息 (optional)</param>
        /// <param name="houseId">房间ID (optional)</param>
        /// <param name="zoneId">区域ID (optional)</param>
        /// <param name="sciType">包含的SCI类型 (optional)</param>
        /// <param name="sortByName">按名称排序 (optional)</param>
        /// <param name="sortByTime">按创建时间排序 (optional)</param>
        /// <param name="sortBySciSize">按sci数量排序 (optional)</param>
        /// <returns>Task of Scenario</returns>
        System.Threading.Tasks.Task<Scenario> GetScenariosAsync (bool? withoutSci = null, int? houseId = null, int? zoneId = null, string sciType = null, bool? sortByName = null, bool? sortByTime = null, bool? sortBySciSize = null);

        /// <summary>
        /// 获取了所有情景模式
        /// </summary>
        /// <remarks>
        /// 获取了所有情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withoutSci">不需要SCI详细信息 (optional)</param>
        /// <param name="houseId">房间ID (optional)</param>
        /// <param name="zoneId">区域ID (optional)</param>
        /// <param name="sciType">包含的SCI类型 (optional)</param>
        /// <param name="sortByName">按名称排序 (optional)</param>
        /// <param name="sortByTime">按创建时间排序 (optional)</param>
        /// <param name="sortBySciSize">按sci数量排序 (optional)</param>
        /// <returns>Task of ApiResponse (Scenario)</returns>
        System.Threading.Tasks.Task<ApiResponse<Scenario>> GetScenariosAsyncWithHttpInfo (bool? withoutSci = null, int? houseId = null, int? zoneId = null, string sciType = null, bool? sortByName = null, bool? sortByTime = null, bool? sortBySciSize = null);
        /// <summary>
        /// 获取了情景模式
        /// </summary>
        /// <remarks>
        /// 获取了情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Task of Scenario</returns>
        System.Threading.Tasks.Task<Scenario> GetScenariosIdAsync (int? id);

        /// <summary>
        /// 获取了情景模式
        /// </summary>
        /// <remarks>
        /// 获取了情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (Scenario)</returns>
        System.Threading.Tasks.Task<ApiResponse<Scenario>> GetScenariosIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 查询分时情景
        /// </summary>
        /// <remarks>
        /// 查询分时情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Scenario</returns>
        System.Threading.Tasks.Task<Scenario> GetScenariosTimeDivisionAsync ();

        /// <summary>
        /// 查询分时情景
        /// </summary>
        /// <remarks>
        /// 查询分时情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Scenario)</returns>
        System.Threading.Tasks.Task<ApiResponse<Scenario>> GetScenariosTimeDivisionAsyncWithHttpInfo ();
        /// <summary>
        /// 创建了一个新的情景模式
        /// </summary>
        /// <remarks>
        /// 创建了一个新的情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">情景模式名称</param>
        /// <param name="scenarioContentItemsAttributesGenericModuleId"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesMode"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesBulbId"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesBrightness"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesTurnedOn"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesHue"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesInfo"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesStash"> (optional)</param>
        /// <param name="zoneId">Zone ID (optional)</param>
        /// <param name="areaId">Area ID (optional)</param>
        /// <param name="icon">Icon (optional)</param>
        /// <returns>Task of Scenario</returns>
        System.Threading.Tasks.Task<Scenario> PostScenariosAsync (string name, List<int?> scenarioContentItemsAttributesGenericModuleId = null, List<int?> scenarioContentItemsAttributesMode = null, List<int?> scenarioContentItemsAttributesBulbId = null, List<float?> scenarioContentItemsAttributesBrightness = null, List<bool?> scenarioContentItemsAttributesTurnedOn = null, List<float?> scenarioContentItemsAttributesHue = null, List<string> scenarioContentItemsAttributesInfo = null, List<string> scenarioContentItemsAttributesStash = null, int? zoneId = null, int? areaId = null, int? icon = null);

        /// <summary>
        /// 创建了一个新的情景模式
        /// </summary>
        /// <remarks>
        /// 创建了一个新的情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">情景模式名称</param>
        /// <param name="scenarioContentItemsAttributesGenericModuleId"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesMode"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesBulbId"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesBrightness"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesTurnedOn"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesHue"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesInfo"> (optional)</param>
        /// <param name="scenarioContentItemsAttributesStash"> (optional)</param>
        /// <param name="zoneId">Zone ID (optional)</param>
        /// <param name="areaId">Area ID (optional)</param>
        /// <param name="icon">Icon (optional)</param>
        /// <returns>Task of ApiResponse (Scenario)</returns>
        System.Threading.Tasks.Task<ApiResponse<Scenario>> PostScenariosAsyncWithHttpInfo (string name, List<int?> scenarioContentItemsAttributesGenericModuleId = null, List<int?> scenarioContentItemsAttributesMode = null, List<int?> scenarioContentItemsAttributesBulbId = null, List<float?> scenarioContentItemsAttributesBrightness = null, List<bool?> scenarioContentItemsAttributesTurnedOn = null, List<float?> scenarioContentItemsAttributesHue = null, List<string> scenarioContentItemsAttributesInfo = null, List<string> scenarioContentItemsAttributesStash = null, int? zoneId = null, int? areaId = null, int? icon = null);
        /// <summary>
        /// 应用了全关情景模式
        /// </summary>
        /// <remarks>
        /// 应用了全关情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origin"> (optional)</param>
        /// <returns>Task of OperationResult</returns>
        System.Threading.Tasks.Task<OperationResult> PostScenariosAllOffAsync (int? origin = null);

        /// <summary>
        /// 应用了全关情景模式
        /// </summary>
        /// <remarks>
        /// 应用了全关情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origin"> (optional)</param>
        /// <returns>Task of ApiResponse (OperationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationResult>> PostScenariosAllOffAsyncWithHttpInfo (int? origin = null);
        /// <summary>
        /// 应用了全开情景模式
        /// </summary>
        /// <remarks>
        /// 应用了全开情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origin"> (optional)</param>
        /// <returns>Task of OperationResult</returns>
        System.Threading.Tasks.Task<OperationResult> PostScenariosAllOnAsync (int? origin = null);

        /// <summary>
        /// 应用了全开情景模式
        /// </summary>
        /// <remarks>
        /// 应用了全开情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origin"> (optional)</param>
        /// <returns>Task of ApiResponse (OperationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationResult>> PostScenariosAllOnAsyncWithHttpInfo (int? origin = null);
        /// <summary>
        /// 更新延迟关灯情景时间
        /// </summary>
        /// <remarks>
        /// 更新延迟关灯情景时间
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <param name="time">延迟关灯的时间</param>
        /// <returns>Task of Scenario</returns>
        System.Threading.Tasks.Task<Scenario> PostScenariosDelayTimeAsync (int? id, int? time);

        /// <summary>
        /// 更新延迟关灯情景时间
        /// </summary>
        /// <remarks>
        /// 更新延迟关灯情景时间
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <param name="time">延迟关灯的时间</param>
        /// <returns>Task of ApiResponse (Scenario)</returns>
        System.Threading.Tasks.Task<ApiResponse<Scenario>> PostScenariosDelayTimeAsyncWithHttpInfo (int? id, int? time);
        /// <summary>
        /// 应用了一个情景模式
        /// </summary>
        /// <remarks>
        /// 应用了一个情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <param name="origin"> (optional)</param>
        /// <returns>Task of OperationResult</returns>
        System.Threading.Tasks.Task<OperationResult> PostScenariosIdApplyAsync (int? id, int? origin = null);

        /// <summary>
        /// 应用了一个情景模式
        /// </summary>
        /// <remarks>
        /// 应用了一个情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <param name="origin"> (optional)</param>
        /// <returns>Task of ApiResponse (OperationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationResult>> PostScenariosIdApplyAsyncWithHttpInfo (int? id, int? origin = null);
        /// <summary>
        /// 创建分时情景
        /// </summary>
        /// <remarks>
        /// 创建分时情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">情景模式名称,系统会自动加上分时前缀</param>
        /// <param name="timeDivisionItemsScenarioId">子情景id</param>
        /// <param name="timeDivisionItemsStartTime">开始时间,通过算法\&quot;%01X\&quot;%wday+\&quot;%05X\&quot;%(hour*3600+minute*60+second)\&quot;得出,0-6代表周日到周六,按天循环始终传0</param>
        /// <param name="timeDivisionItemsEndTime">结束时间,格式如上</param>
        /// <param name="cycleDay">循环周期,默认按周循环 (optional)</param>
        /// <returns>Task of Scenario</returns>
        System.Threading.Tasks.Task<Scenario> PostScenariosTimeDivisionAsync (string name, List<int?> timeDivisionItemsScenarioId, List<string> timeDivisionItemsStartTime, List<string> timeDivisionItemsEndTime, bool? cycleDay = null);

        /// <summary>
        /// 创建分时情景
        /// </summary>
        /// <remarks>
        /// 创建分时情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">情景模式名称,系统会自动加上分时前缀</param>
        /// <param name="timeDivisionItemsScenarioId">子情景id</param>
        /// <param name="timeDivisionItemsStartTime">开始时间,通过算法\&quot;%01X\&quot;%wday+\&quot;%05X\&quot;%(hour*3600+minute*60+second)\&quot;得出,0-6代表周日到周六,按天循环始终传0</param>
        /// <param name="timeDivisionItemsEndTime">结束时间,格式如上</param>
        /// <param name="cycleDay">循环周期,默认按周循环 (optional)</param>
        /// <returns>Task of ApiResponse (Scenario)</returns>
        System.Threading.Tasks.Task<ApiResponse<Scenario>> PostScenariosTimeDivisionAsyncWithHttpInfo (string name, List<int?> timeDivisionItemsScenarioId, List<string> timeDivisionItemsStartTime, List<string> timeDivisionItemsEndTime, bool? cycleDay = null);
        /// <summary>
        /// 更新了情景模式
        /// </summary>
        /// <remarks>
        /// 更新了情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <param name="name">情景模式名称</param>
        /// <param name="scenarioContentItemsAttributes">情景模式内容, 一个scenario_content_items_attributes数组</param>
        /// <param name="areaId">Area ID (optional)</param>
        /// <param name="icon">Icon (optional)</param>
        /// <returns>Task of Scenario</returns>
        System.Threading.Tasks.Task<Scenario> PutScenariosIdAsync (int? id, string name, List<Object> scenarioContentItemsAttributes, int? areaId = null, int? icon = null);

        /// <summary>
        /// 更新了情景模式
        /// </summary>
        /// <remarks>
        /// 更新了情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <param name="name">情景模式名称</param>
        /// <param name="scenarioContentItemsAttributes">情景模式内容, 一个scenario_content_items_attributes数组</param>
        /// <param name="areaId">Area ID (optional)</param>
        /// <param name="icon">Icon (optional)</param>
        /// <returns>Task of ApiResponse (Scenario)</returns>
        System.Threading.Tasks.Task<ApiResponse<Scenario>> PutScenariosIdAsyncWithHttpInfo (int? id, string name, List<Object> scenarioContentItemsAttributes, int? areaId = null, int? icon = null);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}