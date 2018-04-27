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
using Elton.Phantom.Models.Version2;

namespace Elton.Phantom.Api.Version2
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeviceLogApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取当前用户的指定设备的记录
        /// </summary>
        /// <remarks>
        /// 获取当前用户的指定设备的记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceType">设备类型</param>
        /// <param name="deviceId">设备id, 如果为空, 表示取device_type类型的所有数据 (optional)</param>
        /// <param name="nextCursor">下一段数据的游标 (optional)</param>
        /// <param name="count">返回记录数量(最大20条) (optional, default to 20)</param>
        /// <returns></returns>
        void GetDeviceLog (string deviceType, int? deviceId = null, string nextCursor = null, int? count = null);

        /// <summary>
        /// 获取当前用户的指定设备的记录
        /// </summary>
        /// <remarks>
        /// 获取当前用户的指定设备的记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceType">设备类型</param>
        /// <param name="deviceId">设备id, 如果为空, 表示取device_type类型的所有数据 (optional)</param>
        /// <param name="nextCursor">下一段数据的游标 (optional)</param>
        /// <param name="count">返回记录数量(最大20条) (optional, default to 20)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetDeviceLogWithHttpInfo (string deviceType, int? deviceId = null, string nextCursor = null, int? count = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取当前用户的指定设备的记录
        /// </summary>
        /// <remarks>
        /// 获取当前用户的指定设备的记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceType">设备类型</param>
        /// <param name="deviceId">设备id, 如果为空, 表示取device_type类型的所有数据 (optional)</param>
        /// <param name="nextCursor">下一段数据的游标 (optional)</param>
        /// <param name="count">返回记录数量(最大20条) (optional, default to 20)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetDeviceLogAsync (string deviceType, int? deviceId = null, string nextCursor = null, int? count = null);

        /// <summary>
        /// 获取当前用户的指定设备的记录
        /// </summary>
        /// <remarks>
        /// 获取当前用户的指定设备的记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceType">设备类型</param>
        /// <param name="deviceId">设备id, 如果为空, 表示取device_type类型的所有数据 (optional)</param>
        /// <param name="nextCursor">下一段数据的游标 (optional)</param>
        /// <param name="count">返回记录数量(最大20条) (optional, default to 20)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetDeviceLogAsyncWithHttpInfo (string deviceType, int? deviceId = null, string nextCursor = null, int? count = null);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}