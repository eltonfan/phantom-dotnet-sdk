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
using Elton.OAuth2;

namespace Elton.Phantom.Api.Version2
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
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}