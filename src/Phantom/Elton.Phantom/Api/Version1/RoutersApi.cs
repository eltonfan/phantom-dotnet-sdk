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
    public interface IRoutersApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取当前用户的所有路由
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有路由
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Router</returns>
        Router GetRouters ();

        /// <summary>
        /// 获取当前用户的所有路由
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有路由
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Router</returns>
        ApiResponse<Router> GetRoutersWithHttpInfo ();
        /// <summary>
        /// 获取当前用户的某个路由
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个路由
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Router的ID</param>
        /// <returns>Router</returns>
        Router GetRoutersId (int? id);

        /// <summary>
        /// 获取当前用户的某个路由
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个路由
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Router的ID</param>
        /// <returns>ApiResponse of Router</returns>
        ApiResponse<Router> GetRoutersIdWithHttpInfo (int? id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取当前用户的所有路由
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有路由
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Router</returns>
        System.Threading.Tasks.Task<Router> GetRoutersAsync ();

        /// <summary>
        /// 获取当前用户的所有路由
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有路由
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Router)</returns>
        System.Threading.Tasks.Task<ApiResponse<Router>> GetRoutersAsyncWithHttpInfo ();
        /// <summary>
        /// 获取当前用户的某个路由
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个路由
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Router的ID</param>
        /// <returns>Task of Router</returns>
        System.Threading.Tasks.Task<Router> GetRoutersIdAsync (int? id);

        /// <summary>
        /// 获取当前用户的某个路由
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个路由
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Router的ID</param>
        /// <returns>Task of ApiResponse (Router)</returns>
        System.Threading.Tasks.Task<ApiResponse<Router>> GetRoutersIdAsyncWithHttpInfo (int? id);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}