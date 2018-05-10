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
using System.Threading.Tasks;
using Newtonsoft.Json;
using Elton.Phantom.Rest;

namespace Elton.Phantom.Api.Version1
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IScenariosApi
    {
        /// <summary>
        /// 删除了情景模式
        /// </summary>
        /// <remarks>
        /// 删除了情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Scenario</returns>
        Scenario DeleteScenario(int? id);

        /// <summary>
        /// 删除了情景模式
        /// </summary>
        /// <remarks>
        /// 删除了情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Task of Scenario</returns>
        Task<Scenario> DeleteScenarioAsync(int? id);

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
        Scenario[] GetScenarios(bool? withoutSci = null, int? houseId = null, int? zoneId = null, string sciType = null, bool? sortByName = null, bool? sortByTime = null, bool? sortBySciSize = null);

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
        Task<Scenario[]> GetScenariosAsync(bool? withoutSci = null, int? houseId = null, int? zoneId = null, string sciType = null, bool? sortByName = null, bool? sortByTime = null, bool? sortBySciSize = null);


        /// <summary>
        /// 获取了情景模式
        /// </summary>
        /// <remarks>
        /// 获取了情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Scenario</returns>
        Scenario GetScenario(int? id);

        /// <summary>
        /// 获取了情景模式
        /// </summary>
        /// <remarks>
        /// 获取了情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Task of Scenario</returns>
        Task<Scenario> GetScenarioAsync(int? id);

        /// <summary>
        /// 查询分时情景
        /// </summary>
        /// <remarks>
        /// 查询分时情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Scenario</returns>
        Scenario GetScenariosTimeDivision();

        /// <summary>
        /// 查询分时情景
        /// </summary>
        /// <remarks>
        /// 查询分时情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Scenario</returns>
        Task<Scenario> GetScenariosTimeDivisionAsync();

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
        Scenario PostScenario(string name, List<int?> scenarioContentItemsAttributesGenericModuleId = null, List<int?> scenarioContentItemsAttributesMode = null, List<int?> scenarioContentItemsAttributesBulbId = null, List<float?> scenarioContentItemsAttributesBrightness = null, List<bool?> scenarioContentItemsAttributesTurnedOn = null, List<float?> scenarioContentItemsAttributesHue = null, List<string> scenarioContentItemsAttributesInfo = null, List<string> scenarioContentItemsAttributesStash = null, int? zoneId = null, int? areaId = null, int? icon = null);

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
        Task<Scenario> PostScenarioAsync(string name, List<int?> scenarioContentItemsAttributesGenericModuleId = null, List<int?> scenarioContentItemsAttributesMode = null, List<int?> scenarioContentItemsAttributesBulbId = null, List<float?> scenarioContentItemsAttributesBrightness = null, List<bool?> scenarioContentItemsAttributesTurnedOn = null, List<float?> scenarioContentItemsAttributesHue = null, List<string> scenarioContentItemsAttributesInfo = null, List<string> scenarioContentItemsAttributesStash = null, int? zoneId = null, int? areaId = null, int? icon = null);


        /// <summary>
        /// 应用了全关情景模式
        /// </summary>
        /// <remarks>
        /// 应用了全关情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origin"> (optional)</param>
        /// <returns>OperationResult</returns>
        OperationResult PostScenarioAllOff(int? origin = null);

        /// <summary>
        /// 应用了全关情景模式
        /// </summary>
        /// <remarks>
        /// 应用了全关情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origin"> (optional)</param>
        /// <returns>Task of OperationResult</returns>
        Task<OperationResult> PostScenarioAllOffAsync(int? origin = null);

        /// <summary>
        /// 应用了全开情景模式
        /// </summary>
        /// <remarks>
        /// 应用了全开情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origin"> (optional)</param>
        /// <returns>OperationResult</returns>
        OperationResult PostScenarioAllOn(int? origin = null);

        /// <summary>
        /// 应用了全开情景模式
        /// </summary>
        /// <remarks>
        /// 应用了全开情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origin"> (optional)</param>
        /// <returns>Task of OperationResult</returns>
        Task<OperationResult> PostScenarioAllOnAsync(int? origin = null);

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
        Scenario PostScenarioDelayTime(int? id, int? time);

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
        Task<Scenario> PostScenarioDelayTimeAsync(int? id, int? time);

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
        OperationResult PostScenarioApply(int? id, int? origin = null);

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
        Task<OperationResult> PostScenarioApplyAsync(int? id, int? origin = null);

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
        Scenario PostScenarioTimeDivision(string name, List<int?> timeDivisionItemsScenarioId, List<string> timeDivisionItemsStartTime, List<string> timeDivisionItemsEndTime, bool? cycleDay = null);

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
        Task<Scenario> PostScenarioTimeDivisionAsync(string name, List<int?> timeDivisionItemsScenarioId, List<string> timeDivisionItemsStartTime, List<string> timeDivisionItemsEndTime, bool? cycleDay = null);


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
        Scenario PutScenario(int? id, string name, List<Object> scenarioContentItemsAttributes, int? areaId = null, int? icon = null);

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
        Task<Scenario> PutScenarioAsync(int? id, string name, List<Object> scenarioContentItemsAttributes, int? areaId = null, int? icon = null);
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi : Api.Version1.IScenariosApi
    {
        /// <summary>
        /// 删除了情景模式
        /// </summary>
        /// <remarks>
        /// 删除了情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Scenario</returns>
        public Scenario DeleteScenario(int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ScenariosApi->DeleteScenariosId");

            return Delete<Scenario>(1, $"/scenarios/{id}");
        }

        /// <summary>
        /// 删除了情景模式
        /// </summary>
        /// <remarks>
        /// 删除了情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Task of Scenario</returns>
        public async Task<Scenario> DeleteScenarioAsync(int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ScenariosApi->DeleteScenariosId");

            return await DeleteAsync<Scenario>(1, $"/scenarios/{id}");
        }

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
        public Scenario[] GetScenarios(bool? withoutSci = null, int? houseId = null, int? zoneId = null, string sciType = null, bool? sortByName = null, bool? sortByTime = null, bool? sortBySciSize = null)
        {
            var queryParams = new Dictionary<string, string>();
            if (withoutSci != null)
                queryParams.Add("without_sci", withoutSci.ToString()); // query parameter
            if (houseId != null)
                queryParams.Add("house_id", houseId.ToString()); // query parameter
            if (zoneId != null)
                queryParams.Add("zone_id", zoneId.ToString()); // query parameter
            if (sciType != null)
                queryParams.Add("sci_type", sciType); // query parameter
            if (sortByName != null)
                queryParams.Add("sort_by_name", sortByName.ToString()); // query parameter
            if (sortByTime != null)
                queryParams.Add("sort_by_time", sortByTime.ToString()); // query parameter
            if (sortBySciSize != null)
                queryParams.Add("sort_by_sci_size", sortBySciSize.ToString()); // query parameter

            return Get<Scenario[]>(1, $"/scenarios", queryParams: queryParams);
        }

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
        public async Task<Scenario[]> GetScenariosAsync(bool? withoutSci = null, int? houseId = null, int? zoneId = null, string sciType = null, bool? sortByName = null, bool? sortByTime = null, bool? sortBySciSize = null)
        {
            var queryParams = new Dictionary<string, string>();
            if (withoutSci != null)
                queryParams.Add("without_sci", withoutSci.ToString()); // query parameter
            if (houseId != null)
                queryParams.Add("house_id", houseId.ToString()); // query parameter
            if (zoneId != null)
                queryParams.Add("zone_id", zoneId.ToString()); // query parameter
            if (sciType != null)
                queryParams.Add("sci_type", sciType); // query parameter
            if (sortByName != null)
                queryParams.Add("sort_by_name", sortByName.ToString()); // query parameter
            if (sortByTime != null)
                queryParams.Add("sort_by_time", sortByTime.ToString()); // query parameter
            if (sortBySciSize != null)
                queryParams.Add("sort_by_sci_size", sortBySciSize.ToString()); // query parameter

            return await GetAsync<Scenario[]>(1, $"/scenarios", queryParams: queryParams);
        }


        /// <summary>
        /// 获取了情景模式
        /// </summary>
        /// <remarks>
        /// 获取了情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Scenario</returns>
        public Scenario GetScenario(int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ScenariosApi->GetScenariosId");

            return Get<Scenario>(1, $"/scenarios/{id}");
        }

        /// <summary>
        /// 获取了情景模式
        /// </summary>
        /// <remarks>
        /// 获取了情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Task of Scenario</returns>
        public async Task<Scenario> GetScenarioAsync(int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ScenariosApi->GetScenariosId");

            return await GetAsync<Scenario>(1, $"/scenarios/{id}");
        }

        /// <summary>
        /// 查询分时情景
        /// </summary>
        /// <remarks>
        /// 查询分时情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Scenario</returns>
        public Scenario GetScenariosTimeDivision()
        {
            return Get<Scenario>(1, $"/scenarios/time_division");
        }

        /// <summary>
        /// 查询分时情景
        /// </summary>
        /// <remarks>
        /// 查询分时情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Scenario</returns>
        public async Task<Scenario> GetScenariosTimeDivisionAsync()
        {
            return await GetAsync<Scenario>(1, $"/scenarios/time_division");
        }

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
        public Scenario PostScenario(string name,
            List<int?> scenarioContentItemsAttributesGenericModuleId = null,
            List<int?> scenarioContentItemsAttributesMode = null,
            List<int?> scenarioContentItemsAttributesBulbId = null,
            List<float?> scenarioContentItemsAttributesBrightness = null,
            List<bool?> scenarioContentItemsAttributesTurnedOn = null,
            List<float?> scenarioContentItemsAttributesHue = null,
            List<string> scenarioContentItemsAttributesInfo = null,
            List<string> scenarioContentItemsAttributesStash = null,
            int? zoneId = null, int? areaId = null, int? icon = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling ScenariosApi->PostScenarios");

            var formParams = new Dictionary<string, object>();
            formParams.Add("name", name); // form parameter
            if (scenarioContentItemsAttributesGenericModuleId != null)
                formParams.Add("scenario_content_items_attributes[generic_module_id]", scenarioContentItemsAttributesGenericModuleId); // form parameter
            if (scenarioContentItemsAttributesMode != null)
                formParams.Add("scenario_content_items_attributes[mode]", scenarioContentItemsAttributesMode); // form parameter
            if (scenarioContentItemsAttributesBulbId != null)
                formParams.Add("scenario_content_items_attributes[bulb_id]", scenarioContentItemsAttributesBulbId); // form parameter
            if (scenarioContentItemsAttributesBrightness != null)
                formParams.Add("scenario_content_items_attributes[brightness]", scenarioContentItemsAttributesBrightness); // form parameter
            if (scenarioContentItemsAttributesTurnedOn != null)
                formParams.Add("scenario_content_items_attributes[turned_on]", scenarioContentItemsAttributesTurnedOn); // form parameter
            if (scenarioContentItemsAttributesHue != null)
                formParams.Add("scenario_content_items_attributes[hue]", scenarioContentItemsAttributesHue); // form parameter
            if (scenarioContentItemsAttributesInfo != null)
                formParams.Add("scenario_content_items_attributes[info]", scenarioContentItemsAttributesInfo); // form parameter
            if (scenarioContentItemsAttributesStash != null)
                formParams.Add("scenario_content_items_attributes[stash]", scenarioContentItemsAttributesStash); // form parameter
            if (zoneId != null)
                formParams.Add("zone_id", zoneId); // form parameter
            if (areaId != null)
                formParams.Add("area_id", areaId); // form parameter
            if (icon != null)
                formParams.Add("icon", icon); // form parameter

            return Post<Scenario>(1, "/scenarios",
                formParams: formParams);
        }

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
        public async Task<Scenario> PostScenarioAsync(string name,
            List<int?> scenarioContentItemsAttributesGenericModuleId = null,
            List<int?> scenarioContentItemsAttributesMode = null,
            List<int?> scenarioContentItemsAttributesBulbId = null,
            List<float?> scenarioContentItemsAttributesBrightness = null,
            List<bool?> scenarioContentItemsAttributesTurnedOn = null,
            List<float?> scenarioContentItemsAttributesHue = null,
            List<string> scenarioContentItemsAttributesInfo = null,
            List<string> scenarioContentItemsAttributesStash = null,
            int? zoneId = null, int? areaId = null, int? icon = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling ScenariosApi->PostScenarios");

            var formParams = new Dictionary<string, object>();
            formParams.Add("name", name); // form parameter
            if (scenarioContentItemsAttributesGenericModuleId != null)
                formParams.Add("scenario_content_items_attributes[generic_module_id]", scenarioContentItemsAttributesGenericModuleId); // form parameter
            if (scenarioContentItemsAttributesMode != null)
                formParams.Add("scenario_content_items_attributes[mode]", scenarioContentItemsAttributesMode); // form parameter
            if (scenarioContentItemsAttributesBulbId != null)
                formParams.Add("scenario_content_items_attributes[bulb_id]", scenarioContentItemsAttributesBulbId); // form parameter
            if (scenarioContentItemsAttributesBrightness != null)
                formParams.Add("scenario_content_items_attributes[brightness]", scenarioContentItemsAttributesBrightness); // form parameter
            if (scenarioContentItemsAttributesTurnedOn != null)
                formParams.Add("scenario_content_items_attributes[turned_on]", scenarioContentItemsAttributesTurnedOn); // form parameter
            if (scenarioContentItemsAttributesHue != null)
                formParams.Add("scenario_content_items_attributes[hue]", scenarioContentItemsAttributesHue); // form parameter
            if (scenarioContentItemsAttributesInfo != null)
                formParams.Add("scenario_content_items_attributes[info]", scenarioContentItemsAttributesInfo); // form parameter
            if (scenarioContentItemsAttributesStash != null)
                formParams.Add("scenario_content_items_attributes[stash]", scenarioContentItemsAttributesStash); // form parameter
            if (zoneId != null)
                formParams.Add("zone_id", zoneId); // form parameter
            if (areaId != null)
                formParams.Add("area_id", areaId); // form parameter
            if (icon != null)
                formParams.Add("icon", icon); // form parameter

            return await PostAsync<Scenario>(1, "/scenarios",
                formParams: formParams);
        }


        /// <summary>
        /// 应用了全关情景模式
        /// </summary>
        /// <remarks>
        /// 应用了全关情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origin"> (optional)</param>
        /// <returns>OperationResult</returns>
        public OperationResult PostScenarioAllOff(int? origin = null)
        {
            var formParams = new Dictionary<string, object>();
            if (origin != null)
                formParams.Add("origin", origin); // form parameter
            
            return Post<OperationResult>(1, "/scenarios/all_off",
                formParams: formParams);
        }

        /// <summary>
        /// 应用了全关情景模式
        /// </summary>
        /// <remarks>
        /// 应用了全关情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origin"> (optional)</param>
        /// <returns>Task of OperationResult</returns>
        public async Task<OperationResult> PostScenarioAllOffAsync(int? origin = null)
        {
            var formParams = new Dictionary<string, object>();
            if (origin != null)
                formParams.Add("origin", origin); // form parameter

            return await PostAsync<OperationResult>(1, "/scenarios/all_off",
                formParams: formParams);
        }

        /// <summary>
        /// 应用了全开情景模式
        /// </summary>
        /// <remarks>
        /// 应用了全开情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origin"> (optional)</param>
        /// <returns>OperationResult</returns>
        public OperationResult PostScenarioAllOn(int? origin = null)
        {
            var formParams = new Dictionary<string, object>();
            if (origin != null)
                formParams.Add("origin", origin); // form parameter

            return Post<OperationResult>(1, "/scenarios/all_on",
                formParams: formParams);
        }

        /// <summary>
        /// 应用了全开情景模式
        /// </summary>
        /// <remarks>
        /// 应用了全开情景模式
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origin"> (optional)</param>
        /// <returns>Task of OperationResult</returns>
        public async Task<OperationResult> PostScenarioAllOnAsync(int? origin = null)
        {
            var formParams = new Dictionary<string, object>();
            if (origin != null)
                formParams.Add("origin", origin); // form parameter

            return await PostAsync<OperationResult>(1, "/scenarios/all_on",
                formParams: formParams);
        }

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
        public Scenario PostScenarioDelayTime(int? id, int? time)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ScenariosApi->PostScenariosDelayTime");
            // verify the required parameter 'time' is set
            if (time == null)
                throw new ApiException(400, "Missing required parameter 'time' when calling ScenariosApi->PostScenariosDelayTime");

            var formParams = new Dictionary<string, object>();
            formParams.Add("id", id); // form parameter
            formParams.Add("time", time); // form parameter

            return Post<Scenario>(1, "/scenarios/delay_time",
                formParams: formParams);
        }

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
        public async Task<Scenario> PostScenarioDelayTimeAsync(int? id, int? time)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ScenariosApi->PostScenariosDelayTime");
            // verify the required parameter 'time' is set
            if (time == null)
                throw new ApiException(400, "Missing required parameter 'time' when calling ScenariosApi->PostScenariosDelayTime");

            var formParams = new Dictionary<string, object>();
            formParams.Add("id", id); // form parameter
            formParams.Add("time", time); // form parameter

            return await PostAsync<Scenario>(1, "/scenarios/delay_time",
                formParams: formParams);
        }

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
        public OperationResult PostScenarioApply(int? id, int? origin = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ScenariosApi->PostScenariosIdApply");

            var formParams = new Dictionary<string, object>();
            if (origin != null)
                formParams.Add("origin", origin); // form parameter

            return Post<OperationResult>(1, $"/scenarios/{id}/apply",
                formParams: formParams);
        }

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
        public async Task<OperationResult> PostScenarioApplyAsync(int? id, int? origin = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ScenariosApi->PostScenariosIdApply");

            var formParams = new Dictionary<string, object>();
            if (origin != null)
                formParams.Add("origin", origin); // form parameter

            return await PostAsync<OperationResult>(1, $"/scenarios/{id}/apply",
                formParams: formParams);
        }

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
        public Scenario PostScenarioTimeDivision(string name, List<int?> timeDivisionItemsScenarioId, List<string> timeDivisionItemsStartTime, List<string> timeDivisionItemsEndTime, bool? cycleDay = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling ScenariosApi->PostScenariosTimeDivision");
            // verify the required parameter 'timeDivisionItemsScenarioId' is set
            if (timeDivisionItemsScenarioId == null)
                throw new ApiException(400, "Missing required parameter 'timeDivisionItemsScenarioId' when calling ScenariosApi->PostScenariosTimeDivision");
            // verify the required parameter 'timeDivisionItemsStartTime' is set
            if (timeDivisionItemsStartTime == null)
                throw new ApiException(400, "Missing required parameter 'timeDivisionItemsStartTime' when calling ScenariosApi->PostScenariosTimeDivision");
            // verify the required parameter 'timeDivisionItemsEndTime' is set
            if (timeDivisionItemsEndTime == null)
                throw new ApiException(400, "Missing required parameter 'timeDivisionItemsEndTime' when calling ScenariosApi->PostScenariosTimeDivision");

            var formParams = new Dictionary<string, object>();
            formParams.Add("name", name); // form parameter
            if (cycleDay != null)
                formParams.Add("cycle_day", cycleDay); // form parameter
            formParams.Add("time_division_items[scenario_id]", timeDivisionItemsScenarioId); // form parameter
            formParams.Add("time_division_items[start_time]", timeDivisionItemsStartTime); // form parameter
            formParams.Add("time_division_items[end_time]", timeDivisionItemsEndTime); // form parameter

            return Post<Scenario>(1, "/scenarios/time_division",
                formParams: formParams);
        }

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
        public async Task<Scenario> PostScenarioTimeDivisionAsync(string name, List<int?> timeDivisionItemsScenarioId, List<string> timeDivisionItemsStartTime, List<string> timeDivisionItemsEndTime, bool? cycleDay = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling ScenariosApi->PostScenariosTimeDivision");
            // verify the required parameter 'timeDivisionItemsScenarioId' is set
            if (timeDivisionItemsScenarioId == null)
                throw new ApiException(400, "Missing required parameter 'timeDivisionItemsScenarioId' when calling ScenariosApi->PostScenariosTimeDivision");
            // verify the required parameter 'timeDivisionItemsStartTime' is set
            if (timeDivisionItemsStartTime == null)
                throw new ApiException(400, "Missing required parameter 'timeDivisionItemsStartTime' when calling ScenariosApi->PostScenariosTimeDivision");
            // verify the required parameter 'timeDivisionItemsEndTime' is set
            if (timeDivisionItemsEndTime == null)
                throw new ApiException(400, "Missing required parameter 'timeDivisionItemsEndTime' when calling ScenariosApi->PostScenariosTimeDivision");

            var formParams = new Dictionary<string, object>();
            formParams.Add("name", name); // form parameter
            if (cycleDay != null)
                formParams.Add("cycle_day", cycleDay); // form parameter
            formParams.Add("time_division_items[scenario_id]", timeDivisionItemsScenarioId); // form parameter
            formParams.Add("time_division_items[start_time]", timeDivisionItemsStartTime); // form parameter
            formParams.Add("time_division_items[end_time]", timeDivisionItemsEndTime); // form parameter

            return await PostAsync<Scenario>(1, "/scenarios/time_division",
                formParams: formParams);
        }

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
        public Scenario PutScenario(int? id, string name, List<Object> scenarioContentItemsAttributes, int? areaId = null, int? icon = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ScenariosApi->PutScenariosId");
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling ScenariosApi->PutScenariosId");
            // verify the required parameter 'scenarioContentItemsAttributes' is set
            if (scenarioContentItemsAttributes == null)
                throw new ApiException(400, "Missing required parameter 'scenarioContentItemsAttributes' when calling ScenariosApi->PutScenariosId");

            var formParams = new Dictionary<string, object>();
            formParams.Add("name", name); // form parameter
            if (areaId != null)
                formParams.Add("area_id", areaId); // form parameter
            if (icon != null)
                formParams.Add("icon", icon); // form parameter
            formParams.Add("scenario_content_items_attributes", scenarioContentItemsAttributes); // form parameter

            return Post<Scenario>(1, $"/scenarios/{id}",
                formParams: formParams);
        }

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
        public async Task<Scenario> PutScenarioAsync(int? id, string name, List<Object> scenarioContentItemsAttributes, int? areaId = null, int? icon = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ScenariosApi->PutScenariosId");
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling ScenariosApi->PutScenariosId");
            // verify the required parameter 'scenarioContentItemsAttributes' is set
            if (scenarioContentItemsAttributes == null)
                throw new ApiException(400, "Missing required parameter 'scenarioContentItemsAttributes' when calling ScenariosApi->PutScenariosId");

            var formParams = new Dictionary<string, object>();
            formParams.Add("name", name); // form parameter
            if (areaId != null)
                formParams.Add("area_id", areaId); // form parameter
            if (icon != null)
                formParams.Add("icon", icon); // form parameter
            formParams.Add("scenario_content_items_attributes", scenarioContentItemsAttributes); // form parameter

            return await PostAsync<Scenario>(1, $"/scenarios/{id}",
                formParams: formParams);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="hasDetails">如果为true，则同时获取详细信息。</param>
        /// <returns></returns>
        public Scenario[] GetScenarios(int zoneId, bool hasDetails = false)
        {
            Scenario[] arrayScenarios = this.Get<Scenario[]>(0, $"scenarios?zone_id={zoneId}");
            if (!hasDetails || arrayScenarios == null || arrayScenarios.Length < 1)
                return arrayScenarios;

            List<Operation> list = new List<Operation>();
            foreach (Scenario item in arrayScenarios)
                list.Add(new Operation("GET", $"/api/scenarios/{item.Id}"));

            var result = this.Batch(1, list.ToArray());
            List<Scenario> listDetails = new List<Scenario>();
            foreach (var item in result.Results)
            {
                if (item.Status == 200)
                {
                    Scenario Scenario = JsonConvert.DeserializeObject<Scenario>(item.Body);
                    listDetails.Add(Scenario);
                }
            }
            return listDetails.ToArray();
        }
    }
}