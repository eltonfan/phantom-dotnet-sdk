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
    public interface IClientAppsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 删除当前用户（开发者）的某客户端应用
        /// </summary>
        /// <remarks>
        /// 删除当前用户（开发者）的某客户端应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">客户端应用ID</param>
        /// <returns>ClientApp</returns>
        ClientApp DeleteClientAppsId(int? id);

        /// <summary>
        /// 删除当前用户（开发者）的某客户端应用
        /// </summary>
        /// <remarks>
        /// 删除当前用户（开发者）的某客户端应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">客户端应用ID</param>
        /// <returns>ApiResponse of ClientApp</returns>
        ApiResponse<ClientApp> DeleteClientAppsIdWithHttpInfo(int? id);
        /// <summary>
        /// 获取当前用户（开发者）的所有客户端应用
        /// </summary>
        /// <remarks>
        /// 获取当前用户（开发者）的所有客户端应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ClientApp</returns>
        ClientApp GetClientApps();

        /// <summary>
        /// 获取当前用户（开发者）的所有客户端应用
        /// </summary>
        /// <remarks>
        /// 获取当前用户（开发者）的所有客户端应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ClientApp</returns>
        ApiResponse<ClientApp> GetClientAppsWithHttpInfo();
        /// <summary>
        /// 获取当前用户（开发者）的某客户端应用
        /// </summary>
        /// <remarks>
        /// 获取当前用户（开发者）的某客户端应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">客户端应用ID</param>
        /// <returns>ClientApp</returns>
        ClientApp GetClientAppsId(int? id);

        /// <summary>
        /// 获取当前用户（开发者）的某客户端应用
        /// </summary>
        /// <remarks>
        /// 获取当前用户（开发者）的某客户端应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">客户端应用ID</param>
        /// <returns>ApiResponse of ClientApp</returns>
        ApiResponse<ClientApp> GetClientAppsIdWithHttpInfo(int? id);
        /// <summary>
        /// 为当前用户（开发者）注册一个新的客户端应用
        /// </summary>
        /// <remarks>
        /// 为当前用户（开发者）注册一个新的客户端应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">客户端应用名称</param>
        /// <param name="description">客户端应用简短介绍</param>
        /// <returns>ClientApp</returns>
        ClientApp PostClientApps(string name, string description);

        /// <summary>
        /// 为当前用户（开发者）注册一个新的客户端应用
        /// </summary>
        /// <remarks>
        /// 为当前用户（开发者）注册一个新的客户端应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">客户端应用名称</param>
        /// <param name="description">客户端应用简短介绍</param>
        /// <returns>ApiResponse of ClientApp</returns>
        ApiResponse<ClientApp> PostClientAppsWithHttpInfo(string name, string description);
        /// <summary>
        /// 更新当前用户（开发者）的某客户端应用
        /// </summary>
        /// <remarks>
        /// 更新当前用户（开发者）的某客户端应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">客户端应用ID</param>
        /// <param name="name">客户端应用名称</param>
        /// <param name="description">客户端应用简短介绍</param>
        /// <returns>ClientApp</returns>
        ClientApp PutClientAppsId(int? id, string name, string description);

        /// <summary>
        /// 更新当前用户（开发者）的某客户端应用
        /// </summary>
        /// <remarks>
        /// 更新当前用户（开发者）的某客户端应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">客户端应用ID</param>
        /// <param name="name">客户端应用名称</param>
        /// <param name="description">客户端应用简短介绍</param>
        /// <returns>ApiResponse of ClientApp</returns>
        ApiResponse<ClientApp> PutClientAppsIdWithHttpInfo(int? id, string name, string description);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 删除当前用户（开发者）的某客户端应用
        /// </summary>
        /// <remarks>
        /// 删除当前用户（开发者）的某客户端应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">客户端应用ID</param>
        /// <returns>Task of ClientApp</returns>
        System.Threading.Tasks.Task<ClientApp> DeleteClientAppsIdAsync(int? id);

        /// <summary>
        /// 删除当前用户（开发者）的某客户端应用
        /// </summary>
        /// <remarks>
        /// 删除当前用户（开发者）的某客户端应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">客户端应用ID</param>
        /// <returns>Task of ApiResponse (ClientApp)</returns>
        System.Threading.Tasks.Task<ApiResponse<ClientApp>> DeleteClientAppsIdAsyncWithHttpInfo(int? id);
        /// <summary>
        /// 获取当前用户（开发者）的所有客户端应用
        /// </summary>
        /// <remarks>
        /// 获取当前用户（开发者）的所有客户端应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ClientApp</returns>
        System.Threading.Tasks.Task<ClientApp> GetClientAppsAsync();

        /// <summary>
        /// 获取当前用户（开发者）的所有客户端应用
        /// </summary>
        /// <remarks>
        /// 获取当前用户（开发者）的所有客户端应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ClientApp)</returns>
        System.Threading.Tasks.Task<ApiResponse<ClientApp>> GetClientAppsAsyncWithHttpInfo();
        /// <summary>
        /// 获取当前用户（开发者）的某客户端应用
        /// </summary>
        /// <remarks>
        /// 获取当前用户（开发者）的某客户端应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">客户端应用ID</param>
        /// <returns>Task of ClientApp</returns>
        System.Threading.Tasks.Task<ClientApp> GetClientAppsIdAsync(int? id);

        /// <summary>
        /// 获取当前用户（开发者）的某客户端应用
        /// </summary>
        /// <remarks>
        /// 获取当前用户（开发者）的某客户端应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">客户端应用ID</param>
        /// <returns>Task of ApiResponse (ClientApp)</returns>
        System.Threading.Tasks.Task<ApiResponse<ClientApp>> GetClientAppsIdAsyncWithHttpInfo(int? id);
        /// <summary>
        /// 为当前用户（开发者）注册一个新的客户端应用
        /// </summary>
        /// <remarks>
        /// 为当前用户（开发者）注册一个新的客户端应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">客户端应用名称</param>
        /// <param name="description">客户端应用简短介绍</param>
        /// <returns>Task of ClientApp</returns>
        System.Threading.Tasks.Task<ClientApp> PostClientAppsAsync(string name, string description);

        /// <summary>
        /// 为当前用户（开发者）注册一个新的客户端应用
        /// </summary>
        /// <remarks>
        /// 为当前用户（开发者）注册一个新的客户端应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">客户端应用名称</param>
        /// <param name="description">客户端应用简短介绍</param>
        /// <returns>Task of ApiResponse (ClientApp)</returns>
        System.Threading.Tasks.Task<ApiResponse<ClientApp>> PostClientAppsAsyncWithHttpInfo(string name, string description);
        /// <summary>
        /// 更新当前用户（开发者）的某客户端应用
        /// </summary>
        /// <remarks>
        /// 更新当前用户（开发者）的某客户端应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">客户端应用ID</param>
        /// <param name="name">客户端应用名称</param>
        /// <param name="description">客户端应用简短介绍</param>
        /// <returns>Task of ClientApp</returns>
        System.Threading.Tasks.Task<ClientApp> PutClientAppsIdAsync(int? id, string name, string description);

        /// <summary>
        /// 更新当前用户（开发者）的某客户端应用
        /// </summary>
        /// <remarks>
        /// 更新当前用户（开发者）的某客户端应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">客户端应用ID</param>
        /// <param name="name">客户端应用名称</param>
        /// <param name="description">客户端应用简短介绍</param>
        /// <returns>Task of ApiResponse (ClientApp)</returns>
        System.Threading.Tasks.Task<ApiResponse<ClientApp>> PutClientAppsIdAsyncWithHttpInfo(int? id, string name, string description);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}