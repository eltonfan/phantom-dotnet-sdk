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
    public interface IGenericModuleConfApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取当前用户的某个通用模块配置值
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个通用模块配置值
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <returns></returns>
        void GetGenericModuleConfId (int? id);

        /// <summary>
        /// 获取当前用户的某个通用模块配置值
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个通用模块配置值
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetGenericModuleConfIdWithHttpInfo (int? id);
        /// <summary>
        /// 设置此通用模块设置值
        /// </summary>
        /// <remarks>
        /// 设置此通用模块设置值
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="configure">通用模块配置值 (optional)</param>
        /// <returns></returns>
        void PostGenericModuleConfIdUpdate (int? id, int? configure = null);

        /// <summary>
        /// 设置此通用模块设置值
        /// </summary>
        /// <remarks>
        /// 设置此通用模块设置值
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="configure">通用模块配置值 (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostGenericModuleConfIdUpdateWithHttpInfo (int? id, int? configure = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取当前用户的某个通用模块配置值
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个通用模块配置值
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetGenericModuleConfIdAsync (int? id);

        /// <summary>
        /// 获取当前用户的某个通用模块配置值
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个通用模块配置值
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetGenericModuleConfIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 设置此通用模块设置值
        /// </summary>
        /// <remarks>
        /// 设置此通用模块设置值
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="configure">通用模块配置值 (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostGenericModuleConfIdUpdateAsync (int? id, int? configure = null);

        /// <summary>
        /// 设置此通用模块设置值
        /// </summary>
        /// <remarks>
        /// 设置此通用模块设置值
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">通用模块ID</param>
        /// <param name="configure">通用模块配置值 (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostGenericModuleConfIdUpdateAsyncWithHttpInfo (int? id, int? configure = null);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}