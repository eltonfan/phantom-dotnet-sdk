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
using Elton.Phantom.Rest;

namespace Elton.Phantom.Api.Version1
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IZonesApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 删除一个区域
        /// </summary>
        /// <remarks>
        /// 删除一个区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">要删除的区域id</param>
        /// <returns>Zone</returns>
        Zone DeleteZonesId (int? id);

        /// <summary>
        /// 删除一个区域
        /// </summary>
        /// <remarks>
        /// 删除一个区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">要删除的区域id</param>
        /// <returns>ApiResponse of Zone</returns>
        ApiResponse<Zone> DeleteZonesIdWithHttpInfo (int? id);
        /// <summary>
        /// 获取所有区域
        /// </summary>
        /// <remarks>
        /// 获取所有区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeZero">包含一个id为0的分组 (optional)</param>
        /// <returns>Zone</returns>
        Zone GetZones (bool? includeZero = null);

        /// <summary>
        /// 获取所有区域
        /// </summary>
        /// <remarks>
        /// 获取所有区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeZero">包含一个id为0的分组 (optional)</param>
        /// <returns>ApiResponse of Zone</returns>
        ApiResponse<Zone> GetZonesWithHttpInfo (bool? includeZero = null);
        /// <summary>
        /// 获取未分配到zone里的设备
        /// </summary>
        /// <remarks>
        /// 获取未分配到zone里的设备
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void GetZonesGetDevicesNotInZone ();

        /// <summary>
        /// 获取未分配到zone里的设备
        /// </summary>
        /// <remarks>
        /// 获取未分配到zone里的设备
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetZonesGetDevicesNotInZoneWithHttpInfo ();
        /// <summary>
        /// 查看区域信息
        /// </summary>
        /// <remarks>
        /// 查看区域信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Zone</returns>
        Zone GetZonesId (int? id);

        /// <summary>
        /// 查看区域信息
        /// </summary>
        /// <remarks>
        /// 查看区域信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Zone</returns>
        ApiResponse<Zone> GetZonesIdWithHttpInfo (int? id);
        /// <summary>
        /// 创建一个新区域
        /// </summary>
        /// <remarks>
        /// 创建一个新区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulbIds">新建区域包含的灯id</param>
        /// <param name="name">新建区域的名字 (optional)</param>
        /// <param name="signature">特征，用作图标 (optional)</param>
        /// <returns>Zone</returns>
        Zone PostZones (string bulbIds, string name = null, int? signature = null);

        /// <summary>
        /// 创建一个新区域
        /// </summary>
        /// <remarks>
        /// 创建一个新区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulbIds">新建区域包含的灯id</param>
        /// <param name="name">新建区域的名字 (optional)</param>
        /// <param name="signature">特征，用作图标 (optional)</param>
        /// <returns>ApiResponse of Zone</returns>
        ApiResponse<Zone> PostZonesWithHttpInfo (string bulbIds, string name = null, int? signature = null);
        /// <summary>
        /// 编辑区域信息
        /// </summary>
        /// <remarks>
        /// 编辑区域信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="bulbIds">新建区域包含的灯id (optional)</param>
        /// <param name="name">新建区域的名字 (optional)</param>
        /// <param name="signature">特征，用作图标 (optional)</param>
        /// <returns>Zone</returns>
        Zone PutZonesId (int? id, string bulbIds = null, string name = null, int? signature = null);

        /// <summary>
        /// 编辑区域信息
        /// </summary>
        /// <remarks>
        /// 编辑区域信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="bulbIds">新建区域包含的灯id (optional)</param>
        /// <param name="name">新建区域的名字 (optional)</param>
        /// <param name="signature">特征，用作图标 (optional)</param>
        /// <returns>ApiResponse of Zone</returns>
        ApiResponse<Zone> PutZonesIdWithHttpInfo (int? id, string bulbIds = null, string name = null, int? signature = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 删除一个区域
        /// </summary>
        /// <remarks>
        /// 删除一个区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">要删除的区域id</param>
        /// <returns>Task of Zone</returns>
        System.Threading.Tasks.Task<Zone> DeleteZonesIdAsync (int? id);

        /// <summary>
        /// 删除一个区域
        /// </summary>
        /// <remarks>
        /// 删除一个区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">要删除的区域id</param>
        /// <returns>Task of ApiResponse (Zone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Zone>> DeleteZonesIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 获取所有区域
        /// </summary>
        /// <remarks>
        /// 获取所有区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeZero">包含一个id为0的分组 (optional)</param>
        /// <returns>Task of Zone</returns>
        System.Threading.Tasks.Task<Zone> GetZonesAsync (bool? includeZero = null);

        /// <summary>
        /// 获取所有区域
        /// </summary>
        /// <remarks>
        /// 获取所有区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeZero">包含一个id为0的分组 (optional)</param>
        /// <returns>Task of ApiResponse (Zone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Zone>> GetZonesAsyncWithHttpInfo (bool? includeZero = null);
        /// <summary>
        /// 获取未分配到zone里的设备
        /// </summary>
        /// <remarks>
        /// 获取未分配到zone里的设备
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetZonesGetDevicesNotInZoneAsync ();

        /// <summary>
        /// 获取未分配到zone里的设备
        /// </summary>
        /// <remarks>
        /// 获取未分配到zone里的设备
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetZonesGetDevicesNotInZoneAsyncWithHttpInfo ();
        /// <summary>
        /// 查看区域信息
        /// </summary>
        /// <remarks>
        /// 查看区域信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of Zone</returns>
        System.Threading.Tasks.Task<Zone> GetZonesIdAsync (int? id);

        /// <summary>
        /// 查看区域信息
        /// </summary>
        /// <remarks>
        /// 查看区域信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (Zone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Zone>> GetZonesIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 创建一个新区域
        /// </summary>
        /// <remarks>
        /// 创建一个新区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulbIds">新建区域包含的灯id</param>
        /// <param name="name">新建区域的名字 (optional)</param>
        /// <param name="signature">特征，用作图标 (optional)</param>
        /// <returns>Task of Zone</returns>
        System.Threading.Tasks.Task<Zone> PostZonesAsync (string bulbIds, string name = null, int? signature = null);

        /// <summary>
        /// 创建一个新区域
        /// </summary>
        /// <remarks>
        /// 创建一个新区域
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulbIds">新建区域包含的灯id</param>
        /// <param name="name">新建区域的名字 (optional)</param>
        /// <param name="signature">特征，用作图标 (optional)</param>
        /// <returns>Task of ApiResponse (Zone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Zone>> PostZonesAsyncWithHttpInfo (string bulbIds, string name = null, int? signature = null);
        /// <summary>
        /// 编辑区域信息
        /// </summary>
        /// <remarks>
        /// 编辑区域信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="bulbIds">新建区域包含的灯id (optional)</param>
        /// <param name="name">新建区域的名字 (optional)</param>
        /// <param name="signature">特征，用作图标 (optional)</param>
        /// <returns>Task of Zone</returns>
        System.Threading.Tasks.Task<Zone> PutZonesIdAsync (int? id, string bulbIds = null, string name = null, int? signature = null);

        /// <summary>
        /// 编辑区域信息
        /// </summary>
        /// <remarks>
        /// 编辑区域信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="bulbIds">新建区域包含的灯id (optional)</param>
        /// <param name="name">新建区域的名字 (optional)</param>
        /// <param name="signature">特征，用作图标 (optional)</param>
        /// <returns>Task of ApiResponse (Zone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Zone>> PutZonesIdAsyncWithHttpInfo (int? id, string bulbIds = null, string name = null, int? signature = null);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}