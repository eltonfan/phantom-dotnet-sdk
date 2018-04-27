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

using Elton.Phantom.Models.Version1;
using System;
using System.Collections.Generic;

namespace Elton.Phantom.Api.Version1
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAreasApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 删除单个区域
        /// </summary>
        /// <remarks>
        /// 删除单个区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">房间ID</param>
        /// <returns>Area</returns>
        Area DeleteAreasAid (int? aid);

        /// <summary>
        /// 删除单个区域
        /// </summary>
        /// <remarks>
        /// 删除单个区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">房间ID</param>
        /// <returns>ApiResponse of Area</returns>
        ApiResponse<Area> DeleteAreasAidWithHttpInfo (int? aid);
        /// <summary>
        /// 房间里移除某些或某个设备
        /// </summary>
        /// <remarks>
        /// 房间里移除某些或某个设备
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceIdentifiers">设备标识符们</param>
        /// <param name="aid"></param>
        /// <returns></returns>
        void DeleteAreasAidDevices (List<string> deviceIdentifiers, int? aid);

        /// <summary>
        /// 房间里移除某些或某个设备
        /// </summary>
        /// <remarks>
        /// 房间里移除某些或某个设备
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceIdentifiers">设备标识符们</param>
        /// <param name="aid"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteAreasAidDevicesWithHttpInfo (List<string> deviceIdentifiers, int? aid);
        /// <summary>
        /// 删除区域中的情景
        /// </summary>
        /// <remarks>
        /// 删除区域中的情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">情景 ID</param>
        /// <param name="aid"></param>
        /// <returns>AreaComponent</returns>
        AreaComponent DeleteAreasAidScenariosSid (int? sid, int? aid);

        /// <summary>
        /// 删除区域中的情景
        /// </summary>
        /// <remarks>
        /// 删除区域中的情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">情景 ID</param>
        /// <param name="aid"></param>
        /// <returns>ApiResponse of AreaComponent</returns>
        ApiResponse<AreaComponent> DeleteAreasAidScenariosSidWithHttpInfo (int? sid, int? aid);
        /// <summary>
        /// 获取区域列表
        /// </summary>
        /// <remarks>
        /// 获取区域列表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Area</returns>
        Area GetAreas ();

        /// <summary>
        /// 获取区域列表
        /// </summary>
        /// <remarks>
        /// 获取区域列表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Area</returns>
        ApiResponse<Area> GetAreasWithHttpInfo ();
        /// <summary>
        /// 获取单个区域
        /// </summary>
        /// <remarks>
        /// 获取单个区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid"></param>
        /// <returns>Area</returns>
        Area GetAreasAid (int? aid);

        /// <summary>
        /// 获取单个区域
        /// </summary>
        /// <remarks>
        /// 获取单个区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid"></param>
        /// <returns>ApiResponse of Area</returns>
        ApiResponse<Area> GetAreasAidWithHttpInfo (int? aid);
        /// <summary>
        /// 获取区域中的情景列表
        /// </summary>
        /// <remarks>
        /// 获取区域中的情景列表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid"></param>
        /// <returns>AreaComponent</returns>
        AreaComponent GetAreasAidScenarios (int? aid);

        /// <summary>
        /// 获取区域中的情景列表
        /// </summary>
        /// <remarks>
        /// 获取区域中的情景列表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid"></param>
        /// <returns>ApiResponse of AreaComponent</returns>
        ApiResponse<AreaComponent> GetAreasAidScenariosWithHttpInfo (int? aid);
        /// <summary>
        /// 获取单个情景信息
        /// </summary>
        /// <remarks>
        /// 获取单个情景信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">情景 ID</param>
        /// <param name="aid"></param>
        /// <returns>AreaComponent</returns>
        AreaComponent GetAreasAidScenariosSid (int? sid, int? aid);

        /// <summary>
        /// 获取单个情景信息
        /// </summary>
        /// <remarks>
        /// 获取单个情景信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">情景 ID</param>
        /// <param name="aid"></param>
        /// <returns>ApiResponse of AreaComponent</returns>
        ApiResponse<AreaComponent> GetAreasAidScenariosSidWithHttpInfo (int? sid, int? aid);
        /// <summary>
        /// 新建区域
        /// </summary>
        /// <remarks>
        /// 新建区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">房间的名称</param>
        /// <param name="icon">房间的图标枚举值 (optional)</param>
        /// <param name="position">房间排序的值 (optional)</param>
        /// <param name="deviceIdentifiers">设备标识符 (optional)</param>
        /// <returns>Area</returns>
        Area PostAreas (string name, int? icon = null, int? position = null, List<string> deviceIdentifiers = null);

        /// <summary>
        /// 新建区域
        /// </summary>
        /// <remarks>
        /// 新建区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">房间的名称</param>
        /// <param name="icon">房间的图标枚举值 (optional)</param>
        /// <param name="position">房间排序的值 (optional)</param>
        /// <param name="deviceIdentifiers">设备标识符 (optional)</param>
        /// <returns>ApiResponse of Area</returns>
        ApiResponse<Area> PostAreasWithHttpInfo (string name, int? icon = null, int? position = null, List<string> deviceIdentifiers = null);
        /// <summary>
        /// 房间里加入某些或某个设备
        /// </summary>
        /// <remarks>
        /// 房间里加入某些或某个设备
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceIdentifiers">设备标识符</param>
        /// <param name="aid"></param>
        /// <returns>Device</returns>
        Device PostAreasAidDevices (List<string> deviceIdentifiers, int? aid);

        /// <summary>
        /// 房间里加入某些或某个设备
        /// </summary>
        /// <remarks>
        /// 房间里加入某些或某个设备
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceIdentifiers">设备标识符</param>
        /// <param name="aid"></param>
        /// <returns>ApiResponse of Device</returns>
        ApiResponse<Device> PostAreasAidDevicesWithHttpInfo (List<string> deviceIdentifiers, int? aid);
        /// <summary>
        /// 全量更新区域中的情景排序
        /// </summary>
        /// <remarks>
        /// 全量更新区域中的情景排序
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="positions">情景排序的值, 情景 ID 的排序</param>
        /// <param name="aid"></param>
        /// <returns>AreaComponent</returns>
        AreaComponent PostAreasAidScenarios (List<int?> positions, int? aid);

        /// <summary>
        /// 全量更新区域中的情景排序
        /// </summary>
        /// <remarks>
        /// 全量更新区域中的情景排序
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="positions">情景排序的值, 情景 ID 的排序</param>
        /// <param name="aid"></param>
        /// <returns>ApiResponse of AreaComponent</returns>
        ApiResponse<AreaComponent> PostAreasAidScenariosWithHttpInfo (List<int?> positions, int? aid);
        /// <summary>
        /// 迁移房间数据至区域
        /// </summary>
        /// <remarks>
        /// 迁移房间数据至区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Area</returns>
        Area PostAreasMigrateHouses ();

        /// <summary>
        /// 迁移房间数据至区域
        /// </summary>
        /// <remarks>
        /// 迁移房间数据至区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Area</returns>
        ApiResponse<Area> PostAreasMigrateHousesWithHttpInfo ();
        /// <summary>
        /// 修改单个区域信息
        /// </summary>
        /// <remarks>
        /// 修改单个区域信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">区域ID</param>
        /// <param name="name">区域的名称</param>
        /// <param name="icon">区域图标枚举值 (optional)</param>
        /// <param name="position">区域排序的值 (optional)</param>
        /// <param name="deviceIdentifiers">设备标识符 (optional)</param>
        /// <returns>Area</returns>
        Area PutAreasAid (int? aid, string name, string icon = null, int? position = null, List<string> deviceIdentifiers = null);

        /// <summary>
        /// 修改单个区域信息
        /// </summary>
        /// <remarks>
        /// 修改单个区域信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">区域ID</param>
        /// <param name="name">区域的名称</param>
        /// <param name="icon">区域图标枚举值 (optional)</param>
        /// <param name="position">区域排序的值 (optional)</param>
        /// <param name="deviceIdentifiers">设备标识符 (optional)</param>
        /// <returns>ApiResponse of Area</returns>
        ApiResponse<Area> PutAreasAidWithHttpInfo (int? aid, string name, string icon = null, int? position = null, List<string> deviceIdentifiers = null);
        /// <summary>
        /// 修改单个情景信息
        /// </summary>
        /// <remarks>
        /// 修改单个情景信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="icon">情景图标枚举值</param>
        /// <param name="position">情景排序的值</param>
        /// <param name="aid"></param>
        /// <param name="sid"></param>
        /// <returns>AreaComponent</returns>
        AreaComponent PutAreasAidScenariosSid (string icon, int? position, int? aid, int? sid);

        /// <summary>
        /// 修改单个情景信息
        /// </summary>
        /// <remarks>
        /// 修改单个情景信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="icon">情景图标枚举值</param>
        /// <param name="position">情景排序的值</param>
        /// <param name="aid"></param>
        /// <param name="sid"></param>
        /// <returns>ApiResponse of AreaComponent</returns>
        ApiResponse<AreaComponent> PutAreasAidScenariosSidWithHttpInfo (string icon, int? position, int? aid, int? sid);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 删除单个区域
        /// </summary>
        /// <remarks>
        /// 删除单个区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">房间ID</param>
        /// <returns>Task of Area</returns>
        System.Threading.Tasks.Task<Area> DeleteAreasAidAsync (int? aid);

        /// <summary>
        /// 删除单个区域
        /// </summary>
        /// <remarks>
        /// 删除单个区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">房间ID</param>
        /// <returns>Task of ApiResponse (Area)</returns>
        System.Threading.Tasks.Task<ApiResponse<Area>> DeleteAreasAidAsyncWithHttpInfo (int? aid);
        /// <summary>
        /// 房间里移除某些或某个设备
        /// </summary>
        /// <remarks>
        /// 房间里移除某些或某个设备
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceIdentifiers">设备标识符们</param>
        /// <param name="aid"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteAreasAidDevicesAsync (List<string> deviceIdentifiers, int? aid);

        /// <summary>
        /// 房间里移除某些或某个设备
        /// </summary>
        /// <remarks>
        /// 房间里移除某些或某个设备
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceIdentifiers">设备标识符们</param>
        /// <param name="aid"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAreasAidDevicesAsyncWithHttpInfo (List<string> deviceIdentifiers, int? aid);
        /// <summary>
        /// 删除区域中的情景
        /// </summary>
        /// <remarks>
        /// 删除区域中的情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">情景 ID</param>
        /// <param name="aid"></param>
        /// <returns>Task of AreaComponent</returns>
        System.Threading.Tasks.Task<AreaComponent> DeleteAreasAidScenariosSidAsync (int? sid, int? aid);

        /// <summary>
        /// 删除区域中的情景
        /// </summary>
        /// <remarks>
        /// 删除区域中的情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">情景 ID</param>
        /// <param name="aid"></param>
        /// <returns>Task of ApiResponse (AreaComponent)</returns>
        System.Threading.Tasks.Task<ApiResponse<AreaComponent>> DeleteAreasAidScenariosSidAsyncWithHttpInfo (int? sid, int? aid);
        /// <summary>
        /// 获取区域列表
        /// </summary>
        /// <remarks>
        /// 获取区域列表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Area</returns>
        System.Threading.Tasks.Task<Area> GetAreasAsync ();

        /// <summary>
        /// 获取区域列表
        /// </summary>
        /// <remarks>
        /// 获取区域列表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Area)</returns>
        System.Threading.Tasks.Task<ApiResponse<Area>> GetAreasAsyncWithHttpInfo ();
        /// <summary>
        /// 获取单个区域
        /// </summary>
        /// <remarks>
        /// 获取单个区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid"></param>
        /// <returns>Task of Area</returns>
        System.Threading.Tasks.Task<Area> GetAreasAidAsync (int? aid);

        /// <summary>
        /// 获取单个区域
        /// </summary>
        /// <remarks>
        /// 获取单个区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid"></param>
        /// <returns>Task of ApiResponse (Area)</returns>
        System.Threading.Tasks.Task<ApiResponse<Area>> GetAreasAidAsyncWithHttpInfo (int? aid);
        /// <summary>
        /// 获取区域中的情景列表
        /// </summary>
        /// <remarks>
        /// 获取区域中的情景列表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid"></param>
        /// <returns>Task of AreaComponent</returns>
        System.Threading.Tasks.Task<AreaComponent> GetAreasAidScenariosAsync (int? aid);

        /// <summary>
        /// 获取区域中的情景列表
        /// </summary>
        /// <remarks>
        /// 获取区域中的情景列表
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid"></param>
        /// <returns>Task of ApiResponse (AreaComponent)</returns>
        System.Threading.Tasks.Task<ApiResponse<AreaComponent>> GetAreasAidScenariosAsyncWithHttpInfo (int? aid);
        /// <summary>
        /// 获取单个情景信息
        /// </summary>
        /// <remarks>
        /// 获取单个情景信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">情景 ID</param>
        /// <param name="aid"></param>
        /// <returns>Task of AreaComponent</returns>
        System.Threading.Tasks.Task<AreaComponent> GetAreasAidScenariosSidAsync (int? sid, int? aid);

        /// <summary>
        /// 获取单个情景信息
        /// </summary>
        /// <remarks>
        /// 获取单个情景信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sid">情景 ID</param>
        /// <param name="aid"></param>
        /// <returns>Task of ApiResponse (AreaComponent)</returns>
        System.Threading.Tasks.Task<ApiResponse<AreaComponent>> GetAreasAidScenariosSidAsyncWithHttpInfo (int? sid, int? aid);
        /// <summary>
        /// 新建区域
        /// </summary>
        /// <remarks>
        /// 新建区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">房间的名称</param>
        /// <param name="icon">房间的图标枚举值 (optional)</param>
        /// <param name="position">房间排序的值 (optional)</param>
        /// <param name="deviceIdentifiers">设备标识符 (optional)</param>
        /// <returns>Task of Area</returns>
        System.Threading.Tasks.Task<Area> PostAreasAsync (string name, int? icon = null, int? position = null, List<string> deviceIdentifiers = null);

        /// <summary>
        /// 新建区域
        /// </summary>
        /// <remarks>
        /// 新建区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">房间的名称</param>
        /// <param name="icon">房间的图标枚举值 (optional)</param>
        /// <param name="position">房间排序的值 (optional)</param>
        /// <param name="deviceIdentifiers">设备标识符 (optional)</param>
        /// <returns>Task of ApiResponse (Area)</returns>
        System.Threading.Tasks.Task<ApiResponse<Area>> PostAreasAsyncWithHttpInfo (string name, int? icon = null, int? position = null, List<string> deviceIdentifiers = null);
        /// <summary>
        /// 房间里加入某些或某个设备
        /// </summary>
        /// <remarks>
        /// 房间里加入某些或某个设备
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceIdentifiers">设备标识符</param>
        /// <param name="aid"></param>
        /// <returns>Task of Device</returns>
        System.Threading.Tasks.Task<Device> PostAreasAidDevicesAsync (List<string> deviceIdentifiers, int? aid);

        /// <summary>
        /// 房间里加入某些或某个设备
        /// </summary>
        /// <remarks>
        /// 房间里加入某些或某个设备
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceIdentifiers">设备标识符</param>
        /// <param name="aid"></param>
        /// <returns>Task of ApiResponse (Device)</returns>
        System.Threading.Tasks.Task<ApiResponse<Device>> PostAreasAidDevicesAsyncWithHttpInfo (List<string> deviceIdentifiers, int? aid);
        /// <summary>
        /// 全量更新区域中的情景排序
        /// </summary>
        /// <remarks>
        /// 全量更新区域中的情景排序
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="positions">情景排序的值, 情景 ID 的排序</param>
        /// <param name="aid"></param>
        /// <returns>Task of AreaComponent</returns>
        System.Threading.Tasks.Task<AreaComponent> PostAreasAidScenariosAsync (List<int?> positions, int? aid);

        /// <summary>
        /// 全量更新区域中的情景排序
        /// </summary>
        /// <remarks>
        /// 全量更新区域中的情景排序
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="positions">情景排序的值, 情景 ID 的排序</param>
        /// <param name="aid"></param>
        /// <returns>Task of ApiResponse (AreaComponent)</returns>
        System.Threading.Tasks.Task<ApiResponse<AreaComponent>> PostAreasAidScenariosAsyncWithHttpInfo (List<int?> positions, int? aid);
        /// <summary>
        /// 迁移房间数据至区域
        /// </summary>
        /// <remarks>
        /// 迁移房间数据至区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Area</returns>
        System.Threading.Tasks.Task<Area> PostAreasMigrateHousesAsync ();

        /// <summary>
        /// 迁移房间数据至区域
        /// </summary>
        /// <remarks>
        /// 迁移房间数据至区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Area)</returns>
        System.Threading.Tasks.Task<ApiResponse<Area>> PostAreasMigrateHousesAsyncWithHttpInfo ();
        /// <summary>
        /// 修改单个区域信息
        /// </summary>
        /// <remarks>
        /// 修改单个区域信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">区域ID</param>
        /// <param name="name">区域的名称</param>
        /// <param name="icon">区域图标枚举值 (optional)</param>
        /// <param name="position">区域排序的值 (optional)</param>
        /// <param name="deviceIdentifiers">设备标识符 (optional)</param>
        /// <returns>Task of Area</returns>
        System.Threading.Tasks.Task<Area> PutAreasAidAsync (int? aid, string name, string icon = null, int? position = null, List<string> deviceIdentifiers = null);

        /// <summary>
        /// 修改单个区域信息
        /// </summary>
        /// <remarks>
        /// 修改单个区域信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aid">区域ID</param>
        /// <param name="name">区域的名称</param>
        /// <param name="icon">区域图标枚举值 (optional)</param>
        /// <param name="position">区域排序的值 (optional)</param>
        /// <param name="deviceIdentifiers">设备标识符 (optional)</param>
        /// <returns>Task of ApiResponse (Area)</returns>
        System.Threading.Tasks.Task<ApiResponse<Area>> PutAreasAidAsyncWithHttpInfo (int? aid, string name, string icon = null, int? position = null, List<string> deviceIdentifiers = null);
        /// <summary>
        /// 修改单个情景信息
        /// </summary>
        /// <remarks>
        /// 修改单个情景信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="icon">情景图标枚举值</param>
        /// <param name="position">情景排序的值</param>
        /// <param name="aid"></param>
        /// <param name="sid"></param>
        /// <returns>Task of AreaComponent</returns>
        System.Threading.Tasks.Task<AreaComponent> PutAreasAidScenariosSidAsync (string icon, int? position, int? aid, int? sid);

        /// <summary>
        /// 修改单个情景信息
        /// </summary>
        /// <remarks>
        /// 修改单个情景信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="icon">情景图标枚举值</param>
        /// <param name="position">情景排序的值</param>
        /// <param name="aid"></param>
        /// <param name="sid"></param>
        /// <returns>Task of ApiResponse (AreaComponent)</returns>
        System.Threading.Tasks.Task<ApiResponse<AreaComponent>> PutAreasAidScenariosSidAsyncWithHttpInfo (string icon, int? position, int? aid, int? sid);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}