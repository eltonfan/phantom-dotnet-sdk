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
    public interface IDoorAccessesApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取了所有门禁
        /// </summary>
        /// <remarks>
        /// 获取了所有门禁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DoorAccess</returns>
        DoorAccess GetDoorAccesses();

        /// <summary>
        /// 获取了所有门禁
        /// </summary>
        /// <remarks>
        /// 获取了所有门禁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DoorAccess</returns>
        ApiResponse<DoorAccess> GetDoorAccessesWithHttpInfo();
        /// <summary>
        /// 获取了门禁
        /// </summary>
        /// <remarks>
        /// 获取了门禁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门禁ID</param>
        /// <returns>DoorAccess</returns>
        DoorAccess GetDoorAccessesId(int? id);

        /// <summary>
        /// 获取了门禁
        /// </summary>
        /// <remarks>
        /// 获取了门禁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门禁ID</param>
        /// <returns>ApiResponse of DoorAccess</returns>
        ApiResponse<DoorAccess> GetDoorAccessesIdWithHttpInfo(int? id);
        /// <summary>
        /// 生成分享开门权限的url
        /// </summary>
        /// <remarks>
        /// 生成分享开门权限的url
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门禁ID</param>
        /// <returns></returns>
        void GetDoorAccessesIdCreateShareUrl(int? id);

        /// <summary>
        /// 生成分享开门权限的url
        /// </summary>
        /// <remarks>
        /// 生成分享开门权限的url
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门禁ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetDoorAccessesIdCreateShareUrlWithHttpInfo(int? id);
        /// <summary>
        /// 开启了门禁
        /// </summary>
        /// <remarks>
        /// 开启了门禁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门禁ID</param>
        /// <returns>OperationResult</returns>
        OperationResult PostDoorAccessesIdOpen(int? id);

        /// <summary>
        /// 开启了门禁
        /// </summary>
        /// <remarks>
        /// 开启了门禁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门禁ID</param>
        /// <returns>ApiResponse of OperationResult</returns>
        ApiResponse<OperationResult> PostDoorAccessesIdOpenWithHttpInfo(int? id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取了所有门禁
        /// </summary>
        /// <remarks>
        /// 获取了所有门禁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DoorAccess</returns>
        System.Threading.Tasks.Task<DoorAccess> GetDoorAccessesAsync();

        /// <summary>
        /// 获取了所有门禁
        /// </summary>
        /// <remarks>
        /// 获取了所有门禁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DoorAccess)</returns>
        System.Threading.Tasks.Task<ApiResponse<DoorAccess>> GetDoorAccessesAsyncWithHttpInfo();
        /// <summary>
        /// 获取了门禁
        /// </summary>
        /// <remarks>
        /// 获取了门禁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门禁ID</param>
        /// <returns>Task of DoorAccess</returns>
        System.Threading.Tasks.Task<DoorAccess> GetDoorAccessesIdAsync(int? id);

        /// <summary>
        /// 获取了门禁
        /// </summary>
        /// <remarks>
        /// 获取了门禁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门禁ID</param>
        /// <returns>Task of ApiResponse (DoorAccess)</returns>
        System.Threading.Tasks.Task<ApiResponse<DoorAccess>> GetDoorAccessesIdAsyncWithHttpInfo(int? id);
        /// <summary>
        /// 生成分享开门权限的url
        /// </summary>
        /// <remarks>
        /// 生成分享开门权限的url
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门禁ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetDoorAccessesIdCreateShareUrlAsync(int? id);

        /// <summary>
        /// 生成分享开门权限的url
        /// </summary>
        /// <remarks>
        /// 生成分享开门权限的url
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门禁ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetDoorAccessesIdCreateShareUrlAsyncWithHttpInfo(int? id);
        /// <summary>
        /// 开启了门禁
        /// </summary>
        /// <remarks>
        /// 开启了门禁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门禁ID</param>
        /// <returns>Task of OperationResult</returns>
        System.Threading.Tasks.Task<OperationResult> PostDoorAccessesIdOpenAsync(int? id);

        /// <summary>
        /// 开启了门禁
        /// </summary>
        /// <remarks>
        /// 开启了门禁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门禁ID</param>
        /// <returns>Task of ApiResponse (OperationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationResult>> PostDoorAccessesIdOpenAsyncWithHttpInfo(int? id);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}