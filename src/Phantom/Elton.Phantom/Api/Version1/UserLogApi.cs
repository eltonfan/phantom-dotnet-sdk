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

namespace Elton.Phantom.Api.Version1
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserLogApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取当前用户的操作记录
        /// </summary>
        /// <remarks>
        /// 获取当前用户的操作记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromTimestamp">UTC时间戳 (单位: 毫秒 ms), regexp: /\\d{13}/ (optional)</param>
        /// <param name="count">返回记录数量(最大20条) (optional, default to 20)</param>
        /// <returns>UserLog</returns>
        UserLog GetUserLog (int? fromTimestamp = null, int? count = null);

        /// <summary>
        /// 获取当前用户的操作记录
        /// </summary>
        /// <remarks>
        /// 获取当前用户的操作记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromTimestamp">UTC时间戳 (单位: 毫秒 ms), regexp: /\\d{13}/ (optional)</param>
        /// <param name="count">返回记录数量(最大20条) (optional, default to 20)</param>
        /// <returns>ApiResponse of UserLog</returns>
        ApiResponse<UserLog> GetUserLogWithHttpInfo (int? fromTimestamp = null, int? count = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取当前用户的操作记录
        /// </summary>
        /// <remarks>
        /// 获取当前用户的操作记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromTimestamp">UTC时间戳 (单位: 毫秒 ms), regexp: /\\d{13}/ (optional)</param>
        /// <param name="count">返回记录数量(最大20条) (optional, default to 20)</param>
        /// <returns>Task of UserLog</returns>
        System.Threading.Tasks.Task<UserLog> GetUserLogAsync (int? fromTimestamp = null, int? count = null);

        /// <summary>
        /// 获取当前用户的操作记录
        /// </summary>
        /// <remarks>
        /// 获取当前用户的操作记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromTimestamp">UTC时间戳 (单位: 毫秒 ms), regexp: /\\d{13}/ (optional)</param>
        /// <param name="count">返回记录数量(最大20条) (optional, default to 20)</param>
        /// <returns>Task of ApiResponse (UserLog)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserLog>> GetUserLogAsyncWithHttpInfo (int? fromTimestamp = null, int? count = null);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}