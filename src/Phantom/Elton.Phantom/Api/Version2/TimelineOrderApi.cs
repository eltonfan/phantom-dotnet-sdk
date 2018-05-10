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
    public interface ITimelineOrderApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取小幻说页面的展示顺序
        /// </summary>
        /// <remarks>
        /// 获取小幻说页面的展示顺序
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void GetTimelineOrder ();

        /// <summary>
        /// 获取小幻说页面的展示顺序
        /// </summary>
        /// <remarks>
        /// 获取小幻说页面的展示顺序
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetTimelineOrderWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取小幻说页面的展示顺序
        /// </summary>
        /// <remarks>
        /// 获取小幻说页面的展示顺序
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetTimelineOrderAsync ();

        /// <summary>
        /// 获取小幻说页面的展示顺序
        /// </summary>
        /// <remarks>
        /// 获取小幻说页面的展示顺序
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetTimelineOrderAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}