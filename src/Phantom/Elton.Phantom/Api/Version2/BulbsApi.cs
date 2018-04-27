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
using Elton.Phantom.Models.Version2;
using RestSharp;
using Elton.Phantom.Models.Version2;

namespace Elton.Phantom.Api.Version2
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBulbsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取了所有灯泡
        /// </summary>
        /// <remarks>
        /// 获取了所有灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeShared">返回被分享的设备 (optional)</param>
        /// <returns>Bulb</returns>
        Bulb GetBulbs (bool? includeShared = null);

        /// <summary>
        /// 获取了所有灯泡
        /// </summary>
        /// <remarks>
        /// 获取了所有灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeShared">返回被分享的设备 (optional)</param>
        /// <returns>ApiResponse of Bulb</returns>
        ApiResponse<Bulb> GetBulbsWithHttpInfo (bool? includeShared = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取了所有灯泡
        /// </summary>
        /// <remarks>
        /// 获取了所有灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeShared">返回被分享的设备 (optional)</param>
        /// <returns>Task of Bulb</returns>
        System.Threading.Tasks.Task<Bulb> GetBulbsAsync (bool? includeShared = null);

        /// <summary>
        /// 获取了所有灯泡
        /// </summary>
        /// <remarks>
        /// 获取了所有灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeShared">返回被分享的设备 (optional)</param>
        /// <returns>Task of ApiResponse (Bulb)</returns>
        System.Threading.Tasks.Task<ApiResponse<Bulb>> GetBulbsAsyncWithHttpInfo (bool? includeShared = null);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}