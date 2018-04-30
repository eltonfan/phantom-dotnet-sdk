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
    public interface INespressoApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 雀巢咖啡机接口
        /// </summary>
        /// <remarks>
        /// 雀巢咖啡机接口
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timestamp">时间戳</param>
        /// <param name="tradeNo">交易ID</param>
        /// <param name="appId">APP ID</param>
        /// <param name="sign">签名</param>
        /// <param name="id"></param>
        /// <returns></returns>
        void GetNespressoIdPop (int? timestamp, string tradeNo, string appId, string sign, int? id);

        /// <summary>
        /// 雀巢咖啡机接口
        /// </summary>
        /// <remarks>
        /// 雀巢咖啡机接口
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timestamp">时间戳</param>
        /// <param name="tradeNo">交易ID</param>
        /// <param name="appId">APP ID</param>
        /// <param name="sign">签名</param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetNespressoIdPopWithHttpInfo (int? timestamp, string tradeNo, string appId, string sign, int? id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 雀巢咖啡机接口
        /// </summary>
        /// <remarks>
        /// 雀巢咖啡机接口
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timestamp">时间戳</param>
        /// <param name="tradeNo">交易ID</param>
        /// <param name="appId">APP ID</param>
        /// <param name="sign">签名</param>
        /// <param name="id"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetNespressoIdPopAsync (int? timestamp, string tradeNo, string appId, string sign, int? id);

        /// <summary>
        /// 雀巢咖啡机接口
        /// </summary>
        /// <remarks>
        /// 雀巢咖啡机接口
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timestamp">时间戳</param>
        /// <param name="tradeNo">交易ID</param>
        /// <param name="appId">APP ID</param>
        /// <param name="sign">签名</param>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetNespressoIdPopAsyncWithHttpInfo (int? timestamp, string tradeNo, string appId, string sign, int? id);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}