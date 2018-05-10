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
using Elton.Phantom.Rest;

namespace Elton.Phantom.Api.Version2
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IScenariosApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 更新一个情景
        /// </summary>
        /// <remarks>
        /// 更新一个情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">情景的id</param>
        /// <param name="name">情景的新名称</param>
        /// <returns>Scenario</returns>
        Scenario PutScenariosId (int? id, string name);

        /// <summary>
        /// 更新一个情景
        /// </summary>
        /// <remarks>
        /// 更新一个情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">情景的id</param>
        /// <param name="name">情景的新名称</param>
        /// <returns>ApiResponse of Scenario</returns>
        ApiResponse<Scenario> PutScenariosIdWithHttpInfo (int? id, string name);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 更新一个情景
        /// </summary>
        /// <remarks>
        /// 更新一个情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">情景的id</param>
        /// <param name="name">情景的新名称</param>
        /// <returns>Task of Scenario</returns>
        System.Threading.Tasks.Task<Scenario> PutScenariosIdAsync (int? id, string name);

        /// <summary>
        /// 更新一个情景
        /// </summary>
        /// <remarks>
        /// 更新一个情景
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">情景的id</param>
        /// <param name="name">情景的新名称</param>
        /// <returns>Task of ApiResponse (Scenario)</returns>
        System.Threading.Tasks.Task<ApiResponse<Scenario>> PutScenariosIdAsyncWithHttpInfo (int? id, string name);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}