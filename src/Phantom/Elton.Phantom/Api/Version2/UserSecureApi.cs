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
    public interface IUserSecureApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取当前用户的安全设置
        /// </summary>
        /// <remarks>
        /// 获取当前用户的安全设置
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserSecureV2</returns>
        UserSecureV2 GetUserSecure ();

        /// <summary>
        /// 获取当前用户的安全设置
        /// </summary>
        /// <remarks>
        /// 获取当前用户的安全设置
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserSecureV2</returns>
        ApiResponse<UserSecureV2> GetUserSecureWithHttpInfo ();
        /// <summary>
        /// 更新安全级别
        /// </summary>
        /// <remarks>
        /// 更新安全级别
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secureLevelMask">MASK: 1:报警APP推送，2:报警短信推送, 4:正常开关APP推送</param>
        /// <returns></returns>
        void PostUserSecureUpdateLevel (int? secureLevelMask);

        /// <summary>
        /// 更新安全级别
        /// </summary>
        /// <remarks>
        /// 更新安全级别
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secureLevelMask">MASK: 1:报警APP推送，2:报警短信推送, 4:正常开关APP推送</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostUserSecureUpdateLevelWithHttpInfo (int? secureLevelMask);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取当前用户的安全设置
        /// </summary>
        /// <remarks>
        /// 获取当前用户的安全设置
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserSecureV2</returns>
        System.Threading.Tasks.Task<UserSecureV2> GetUserSecureAsync ();

        /// <summary>
        /// 获取当前用户的安全设置
        /// </summary>
        /// <remarks>
        /// 获取当前用户的安全设置
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserSecureV2)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserSecureV2>> GetUserSecureAsyncWithHttpInfo ();
        /// <summary>
        /// 更新安全级别
        /// </summary>
        /// <remarks>
        /// 更新安全级别
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secureLevelMask">MASK: 1:报警APP推送，2:报警短信推送, 4:正常开关APP推送</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostUserSecureUpdateLevelAsync (int? secureLevelMask);

        /// <summary>
        /// 更新安全级别
        /// </summary>
        /// <remarks>
        /// 更新安全级别
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="secureLevelMask">MASK: 1:报警APP推送，2:报警短信推送, 4:正常开关APP推送</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostUserSecureUpdateLevelAsyncWithHttpInfo (int? secureLevelMask);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}