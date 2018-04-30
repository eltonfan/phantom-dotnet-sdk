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
    public interface ICurtainApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 关闭窗帘
        /// </summary>
        /// <remarks>
        /// 关闭窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns></returns>
        void PostCurtainIdClose (int? id);

        /// <summary>
        /// 关闭窗帘
        /// </summary>
        /// <remarks>
        /// 关闭窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostCurtainIdCloseWithHttpInfo (int? id);
        /// <summary>
        /// 打开窗帘
        /// </summary>
        /// <remarks>
        /// 打开窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns></returns>
        void PostCurtainIdOpen (int? id);

        /// <summary>
        /// 打开窗帘
        /// </summary>
        /// <remarks>
        /// 打开窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostCurtainIdOpenWithHttpInfo (int? id);
        /// <summary>
        /// 标记窗帘反转
        /// </summary>
        /// <remarks>
        /// 标记窗帘反转
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns></returns>
        void PostCurtainIdReverse (int? id);

        /// <summary>
        /// 标记窗帘反转
        /// </summary>
        /// <remarks>
        /// 标记窗帘反转
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostCurtainIdReverseWithHttpInfo (int? id);
        /// <summary>
        /// 设置窗帘
        /// </summary>
        /// <remarks>
        /// 设置窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="percent">打开窗帘的百分比 0 ~ 100</param>
        /// <param name="id"></param>
        /// <returns></returns>
        void PostCurtainIdStatus (int? percent, int? id);

        /// <summary>
        /// 设置窗帘
        /// </summary>
        /// <remarks>
        /// 设置窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="percent">打开窗帘的百分比 0 ~ 100</param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostCurtainIdStatusWithHttpInfo (int? percent, int? id);
        /// <summary>
        /// 停止, 如果窗帘在移动中, 立即停下
        /// </summary>
        /// <remarks>
        /// 停止, 如果窗帘在移动中, 立即停下
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns></returns>
        void PostCurtainIdStop (int? id);

        /// <summary>
        /// 停止, 如果窗帘在移动中, 立即停下
        /// </summary>
        /// <remarks>
        /// 停止, 如果窗帘在移动中, 立即停下
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostCurtainIdStopWithHttpInfo (int? id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 关闭窗帘
        /// </summary>
        /// <remarks>
        /// 关闭窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostCurtainIdCloseAsync (int? id);

        /// <summary>
        /// 关闭窗帘
        /// </summary>
        /// <remarks>
        /// 关闭窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostCurtainIdCloseAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 打开窗帘
        /// </summary>
        /// <remarks>
        /// 打开窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostCurtainIdOpenAsync (int? id);

        /// <summary>
        /// 打开窗帘
        /// </summary>
        /// <remarks>
        /// 打开窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostCurtainIdOpenAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 标记窗帘反转
        /// </summary>
        /// <remarks>
        /// 标记窗帘反转
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostCurtainIdReverseAsync (int? id);

        /// <summary>
        /// 标记窗帘反转
        /// </summary>
        /// <remarks>
        /// 标记窗帘反转
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostCurtainIdReverseAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 设置窗帘
        /// </summary>
        /// <remarks>
        /// 设置窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="percent">打开窗帘的百分比 0 ~ 100</param>
        /// <param name="id"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostCurtainIdStatusAsync (int? percent, int? id);

        /// <summary>
        /// 设置窗帘
        /// </summary>
        /// <remarks>
        /// 设置窗帘
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="percent">打开窗帘的百分比 0 ~ 100</param>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostCurtainIdStatusAsyncWithHttpInfo (int? percent, int? id);
        /// <summary>
        /// 停止, 如果窗帘在移动中, 立即停下
        /// </summary>
        /// <remarks>
        /// 停止, 如果窗帘在移动中, 立即停下
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostCurtainIdStopAsync (int? id);

        /// <summary>
        /// 停止, 如果窗帘在移动中, 立即停下
        /// </summary>
        /// <remarks>
        /// 停止, 如果窗帘在移动中, 立即停下
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostCurtainIdStopAsyncWithHttpInfo (int? id);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}