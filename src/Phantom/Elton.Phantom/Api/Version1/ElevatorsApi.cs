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
    public interface IElevatorsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取当前用户的所有梯控
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有梯控
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Elevator</returns>
        Elevator GetElevators ();

        /// <summary>
        /// 获取当前用户的所有梯控
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有梯控
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Elevator</returns>
        ApiResponse<Elevator> GetElevatorsWithHttpInfo ();
        /// <summary>
        /// 获取当前用户的某个梯控
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个梯控
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">红外遥控设备的 ID</param>
        /// <returns>Elevator</returns>
        Elevator GetElevatorsId (int? id);

        /// <summary>
        /// 获取当前用户的某个梯控
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个梯控
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">红外遥控设备的 ID</param>
        /// <returns>ApiResponse of Elevator</returns>
        ApiResponse<Elevator> GetElevatorsIdWithHttpInfo (int? id);
        /// <summary>
        /// 权限验证
        /// </summary>
        /// <remarks>
        /// 权限验证
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <param name="itemId">权限 ID</param>
        /// <param name="maxScanCnt">最大使用次数</param>
        /// <param name="timestampStart">有效起始时间</param>
        /// <param name="timestampEnd">有效终止时间</param>
        /// <param name="floors">可以随便进入的楼层数组,用逗号（,）分隔</param>
        /// <returns></returns>
        void PostElevatorsIdAccessControl (int? id, int? itemId, int? maxScanCnt, int? timestampStart, int? timestampEnd, string floors);

        /// <summary>
        /// 权限验证
        /// </summary>
        /// <remarks>
        /// 权限验证
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <param name="itemId">权限 ID</param>
        /// <param name="maxScanCnt">最大使用次数</param>
        /// <param name="timestampStart">有效起始时间</param>
        /// <param name="timestampEnd">有效终止时间</param>
        /// <param name="floors">可以随便进入的楼层数组,用逗号（,）分隔</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostElevatorsIdAccessControlWithHttpInfo (int? id, int? itemId, int? maxScanCnt, int? timestampStart, int? timestampEnd, string floors);
        /// <summary>
        /// 权限取消
        /// </summary>
        /// <remarks>
        /// 权限取消
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <param name="itemId">权限 ID</param>
        /// <returns></returns>
        void PostElevatorsIdAccessForbidden (int? id, int? itemId);

        /// <summary>
        /// 权限取消
        /// </summary>
        /// <remarks>
        /// 权限取消
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <param name="itemId">权限 ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostElevatorsIdAccessForbiddenWithHttpInfo (int? id, int? itemId);
        /// <summary>
        /// 同步时间
        /// </summary>
        /// <remarks>
        /// 同步时间
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <returns></returns>
        void PostElevatorsIdAnswerTime (int? id);

        /// <summary>
        /// 同步时间
        /// </summary>
        /// <remarks>
        /// 同步时间
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostElevatorsIdAnswerTimeWithHttpInfo (int? id);
        /// <summary>
        /// 配置梯控设备密钥
        /// </summary>
        /// <remarks>
        /// 配置梯控设备密钥
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <param name="devKey">梯控设备密钥</param>
        /// <returns></returns>
        void PostElevatorsIdDevKey (int? id, string devKey);

        /// <summary>
        /// 配置梯控设备密钥
        /// </summary>
        /// <remarks>
        /// 配置梯控设备密钥
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <param name="devKey">梯控设备密钥</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostElevatorsIdDevKeyWithHttpInfo (int? id, string devKey);
        /// <summary>
        /// 配置梯控工厂密钥
        /// </summary>
        /// <remarks>
        /// 配置梯控工厂密钥
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <param name="facKey">梯控工厂密钥</param>
        /// <returns></returns>
        void PostElevatorsIdFacKey (int? id, string facKey);

        /// <summary>
        /// 配置梯控工厂密钥
        /// </summary>
        /// <remarks>
        /// 配置梯控工厂密钥
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <param name="facKey">梯控工厂密钥</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostElevatorsIdFacKeyWithHttpInfo (int? id, string facKey);
        /// <summary>
        /// 配置控制器
        /// </summary>
        /// <remarks>
        /// 配置控制器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <param name="floors">可以随便进入的楼层数组,用逗号（,）分隔</param>
        /// <returns></returns>
        void PostElevatorsIdParamConfig (int? id, string floors);

        /// <summary>
        /// 配置控制器
        /// </summary>
        /// <remarks>
        /// 配置控制器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <param name="floors">可以随便进入的楼层数组,用逗号（,）分隔</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostElevatorsIdParamConfigWithHttpInfo (int? id, string floors);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取当前用户的所有梯控
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有梯控
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Elevator</returns>
        System.Threading.Tasks.Task<Elevator> GetElevatorsAsync ();

        /// <summary>
        /// 获取当前用户的所有梯控
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有梯控
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Elevator)</returns>
        System.Threading.Tasks.Task<ApiResponse<Elevator>> GetElevatorsAsyncWithHttpInfo ();
        /// <summary>
        /// 获取当前用户的某个梯控
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个梯控
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">红外遥控设备的 ID</param>
        /// <returns>Task of Elevator</returns>
        System.Threading.Tasks.Task<Elevator> GetElevatorsIdAsync (int? id);

        /// <summary>
        /// 获取当前用户的某个梯控
        /// </summary>
        /// <remarks>
        /// 获取当前用户的某个梯控
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">红外遥控设备的 ID</param>
        /// <returns>Task of ApiResponse (Elevator)</returns>
        System.Threading.Tasks.Task<ApiResponse<Elevator>> GetElevatorsIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 权限验证
        /// </summary>
        /// <remarks>
        /// 权限验证
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <param name="itemId">权限 ID</param>
        /// <param name="maxScanCnt">最大使用次数</param>
        /// <param name="timestampStart">有效起始时间</param>
        /// <param name="timestampEnd">有效终止时间</param>
        /// <param name="floors">可以随便进入的楼层数组,用逗号（,）分隔</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostElevatorsIdAccessControlAsync (int? id, int? itemId, int? maxScanCnt, int? timestampStart, int? timestampEnd, string floors);

        /// <summary>
        /// 权限验证
        /// </summary>
        /// <remarks>
        /// 权限验证
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <param name="itemId">权限 ID</param>
        /// <param name="maxScanCnt">最大使用次数</param>
        /// <param name="timestampStart">有效起始时间</param>
        /// <param name="timestampEnd">有效终止时间</param>
        /// <param name="floors">可以随便进入的楼层数组,用逗号（,）分隔</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostElevatorsIdAccessControlAsyncWithHttpInfo (int? id, int? itemId, int? maxScanCnt, int? timestampStart, int? timestampEnd, string floors);
        /// <summary>
        /// 权限取消
        /// </summary>
        /// <remarks>
        /// 权限取消
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <param name="itemId">权限 ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostElevatorsIdAccessForbiddenAsync (int? id, int? itemId);

        /// <summary>
        /// 权限取消
        /// </summary>
        /// <remarks>
        /// 权限取消
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <param name="itemId">权限 ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostElevatorsIdAccessForbiddenAsyncWithHttpInfo (int? id, int? itemId);
        /// <summary>
        /// 同步时间
        /// </summary>
        /// <remarks>
        /// 同步时间
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostElevatorsIdAnswerTimeAsync (int? id);

        /// <summary>
        /// 同步时间
        /// </summary>
        /// <remarks>
        /// 同步时间
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostElevatorsIdAnswerTimeAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 配置梯控设备密钥
        /// </summary>
        /// <remarks>
        /// 配置梯控设备密钥
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <param name="devKey">梯控设备密钥</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostElevatorsIdDevKeyAsync (int? id, string devKey);

        /// <summary>
        /// 配置梯控设备密钥
        /// </summary>
        /// <remarks>
        /// 配置梯控设备密钥
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <param name="devKey">梯控设备密钥</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostElevatorsIdDevKeyAsyncWithHttpInfo (int? id, string devKey);
        /// <summary>
        /// 配置梯控工厂密钥
        /// </summary>
        /// <remarks>
        /// 配置梯控工厂密钥
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <param name="facKey">梯控工厂密钥</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostElevatorsIdFacKeyAsync (int? id, string facKey);

        /// <summary>
        /// 配置梯控工厂密钥
        /// </summary>
        /// <remarks>
        /// 配置梯控工厂密钥
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <param name="facKey">梯控工厂密钥</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostElevatorsIdFacKeyAsyncWithHttpInfo (int? id, string facKey);
        /// <summary>
        /// 配置控制器
        /// </summary>
        /// <remarks>
        /// 配置控制器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <param name="floors">可以随便进入的楼层数组,用逗号（,）分隔</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostElevatorsIdParamConfigAsync (int? id, string floors);

        /// <summary>
        /// 配置控制器
        /// </summary>
        /// <remarks>
        /// 配置控制器
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">梯控 ID</param>
        /// <param name="floors">可以随便进入的楼层数组,用逗号（,）分隔</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostElevatorsIdParamConfigAsyncWithHttpInfo (int? id, string floors);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}