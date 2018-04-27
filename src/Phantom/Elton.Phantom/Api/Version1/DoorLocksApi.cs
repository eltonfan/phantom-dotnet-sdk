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
    public interface IDoorLocksApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 清空门锁离线密码
        /// </summary>
        /// <remarks>
        /// 清空门锁离线密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="seq">请求序列号</param>
        /// <returns></returns>
        void DeleteDoorLocksIdPasswords(int? id, int? seq);

        /// <summary>
        /// 清空门锁离线密码
        /// </summary>
        /// <remarks>
        /// 清空门锁离线密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="seq">请求序列号</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteDoorLocksIdPasswordsWithHttpInfo(int? id, int? seq);
        /// <summary>
        /// 删除门锁离线密码
        /// </summary>
        /// <remarks>
        /// 删除门锁离线密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="seq">请求序列号</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        void DeleteDoorLocksIdPasswordsPassword(int? id, int? seq, string password);

        /// <summary>
        /// 删除门锁离线密码
        /// </summary>
        /// <remarks>
        /// 删除门锁离线密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="seq">请求序列号</param>
        /// <param name="password">密码</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteDoorLocksIdPasswordsPasswordWithHttpInfo(int? id, int? seq, string password);
        /// <summary>
        /// 获取了所有门锁
        /// </summary>
        /// <remarks>
        /// 获取了所有门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DoorLock</returns>
        DoorLock GetDoorLocks();

        /// <summary>
        /// 获取了所有门锁
        /// </summary>
        /// <remarks>
        /// 获取了所有门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DoorLock</returns>
        ApiResponse<DoorLock> GetDoorLocksWithHttpInfo();
        /// <summary>
        /// 获取某个门锁
        /// </summary>
        /// <remarks>
        /// 获取某个门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <returns>DoorLock</returns>
        DoorLock GetDoorLocksId(int? id);

        /// <summary>
        /// 获取某个门锁
        /// </summary>
        /// <remarks>
        /// 获取某个门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <returns>ApiResponse of DoorLock</returns>
        ApiResponse<DoorLock> GetDoorLocksIdWithHttpInfo(int? id);
        /// <summary>
        /// 获取门锁开门记录
        /// </summary>
        /// <remarks>
        /// 获取门锁开门记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="startTime">时间范围，开始时间戳</param>
        /// <param name="endTime">时间范围，结束时间戳</param>
        /// <returns></returns>
        void GetDoorLocksIdOpenRecords(int? id, int? startTime, int? endTime);

        /// <summary>
        /// 获取门锁开门记录
        /// </summary>
        /// <remarks>
        /// 获取门锁开门记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="startTime">时间范围，开始时间戳</param>
        /// <param name="endTime">时间范围，结束时间戳</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetDoorLocksIdOpenRecordsWithHttpInfo(int? id, int? startTime, int? endTime);
        /// <summary>
        /// 获取门锁动态密码
        /// </summary>
        /// <remarks>
        /// 获取门锁动态密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <returns></returns>
        void GetDoorLocksIdOtp(int? id);

        /// <summary>
        /// 获取门锁动态密码
        /// </summary>
        /// <remarks>
        /// 获取门锁动态密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetDoorLocksIdOtpWithHttpInfo(int? id);
        /// <summary>
        /// 关闭某个门锁
        /// </summary>
        /// <remarks>
        /// 关闭某个门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <returns>OperationResult</returns>
        OperationResult PostDoorLocksIdClose(int? id);

        /// <summary>
        /// 关闭某个门锁
        /// </summary>
        /// <remarks>
        /// 关闭某个门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <returns>ApiResponse of OperationResult</returns>
        ApiResponse<OperationResult> PostDoorLocksIdCloseWithHttpInfo(int? id);
        /// <summary>
        /// 打开某个门锁
        /// </summary>
        /// <remarks>
        /// 打开某个门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="keepOpen">是否保持长开状态 (optional)</param>
        /// <returns>OperationResult</returns>
        OperationResult PostDoorLocksIdOpen(int? id, bool? keepOpen = null);

        /// <summary>
        /// 打开某个门锁
        /// </summary>
        /// <remarks>
        /// 打开某个门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="keepOpen">是否保持长开状态 (optional)</param>
        /// <returns>ApiResponse of OperationResult</returns>
        ApiResponse<OperationResult> PostDoorLocksIdOpenWithHttpInfo(int? id, bool? keepOpen = null);
        /// <summary>
        /// 新增门锁离线密码
        /// </summary>
        /// <remarks>
        /// 新增门锁离线密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="seq">请求序列号</param>
        /// <param name="password">密码</param>
        /// <param name="startTime">开始时间戳，需要设置密码有效时间时使用</param>
        /// <param name="endTime">结束时间戳，与开始时间戳一起使用</param>
        /// <param name="times">使用次数，需要设置密码使用次数时使用 (optional, default to 255)</param>
        /// <returns></returns>
        void PostDoorLocksIdPasswords(int? id, int? seq, string password, int? startTime, int? endTime, int? times = null);

        /// <summary>
        /// 新增门锁离线密码
        /// </summary>
        /// <remarks>
        /// 新增门锁离线密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="seq">请求序列号</param>
        /// <param name="password">密码</param>
        /// <param name="startTime">开始时间戳，需要设置密码有效时间时使用</param>
        /// <param name="endTime">结束时间戳，与开始时间戳一起使用</param>
        /// <param name="times">使用次数，需要设置密码使用次数时使用 (optional, default to 255)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostDoorLocksIdPasswordsWithHttpInfo(int? id, int? seq, string password, int? startTime, int? endTime, int? times = null);
        /// <summary>
        /// 门锁配对
        /// </summary>
        /// <remarks>
        /// 门锁配对
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <returns></returns>
        void PostDoorLocksIdPm(int? id);

        /// <summary>
        /// 门锁配对
        /// </summary>
        /// <remarks>
        /// 门锁配对
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostDoorLocksIdPmWithHttpInfo(int? id);
        /// <summary>
        /// 修改门锁描述
        /// </summary>
        /// <remarks>
        /// 修改门锁描述
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="desc">门锁名称</param>
        /// <returns>DoorLock</returns>
        DoorLock PutDoorLocksId(int? id, string desc);

        /// <summary>
        /// 修改门锁描述
        /// </summary>
        /// <remarks>
        /// 修改门锁描述
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="desc">门锁名称</param>
        /// <returns>ApiResponse of DoorLock</returns>
        ApiResponse<DoorLock> PutDoorLocksIdWithHttpInfo(int? id, string desc);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 清空门锁离线密码
        /// </summary>
        /// <remarks>
        /// 清空门锁离线密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="seq">请求序列号</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteDoorLocksIdPasswordsAsync(int? id, int? seq);

        /// <summary>
        /// 清空门锁离线密码
        /// </summary>
        /// <remarks>
        /// 清空门锁离线密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="seq">请求序列号</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteDoorLocksIdPasswordsAsyncWithHttpInfo(int? id, int? seq);
        /// <summary>
        /// 删除门锁离线密码
        /// </summary>
        /// <remarks>
        /// 删除门锁离线密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="seq">请求序列号</param>
        /// <param name="password">密码</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteDoorLocksIdPasswordsPasswordAsync(int? id, int? seq, string password);

        /// <summary>
        /// 删除门锁离线密码
        /// </summary>
        /// <remarks>
        /// 删除门锁离线密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="seq">请求序列号</param>
        /// <param name="password">密码</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteDoorLocksIdPasswordsPasswordAsyncWithHttpInfo(int? id, int? seq, string password);
        /// <summary>
        /// 获取了所有门锁
        /// </summary>
        /// <remarks>
        /// 获取了所有门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DoorLock</returns>
        System.Threading.Tasks.Task<DoorLock> GetDoorLocksAsync();

        /// <summary>
        /// 获取了所有门锁
        /// </summary>
        /// <remarks>
        /// 获取了所有门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DoorLock)</returns>
        System.Threading.Tasks.Task<ApiResponse<DoorLock>> GetDoorLocksAsyncWithHttpInfo();
        /// <summary>
        /// 获取某个门锁
        /// </summary>
        /// <remarks>
        /// 获取某个门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <returns>Task of DoorLock</returns>
        System.Threading.Tasks.Task<DoorLock> GetDoorLocksIdAsync(int? id);

        /// <summary>
        /// 获取某个门锁
        /// </summary>
        /// <remarks>
        /// 获取某个门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <returns>Task of ApiResponse (DoorLock)</returns>
        System.Threading.Tasks.Task<ApiResponse<DoorLock>> GetDoorLocksIdAsyncWithHttpInfo(int? id);
        /// <summary>
        /// 获取门锁开门记录
        /// </summary>
        /// <remarks>
        /// 获取门锁开门记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="startTime">时间范围，开始时间戳</param>
        /// <param name="endTime">时间范围，结束时间戳</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetDoorLocksIdOpenRecordsAsync(int? id, int? startTime, int? endTime);

        /// <summary>
        /// 获取门锁开门记录
        /// </summary>
        /// <remarks>
        /// 获取门锁开门记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="startTime">时间范围，开始时间戳</param>
        /// <param name="endTime">时间范围，结束时间戳</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetDoorLocksIdOpenRecordsAsyncWithHttpInfo(int? id, int? startTime, int? endTime);
        /// <summary>
        /// 获取门锁动态密码
        /// </summary>
        /// <remarks>
        /// 获取门锁动态密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetDoorLocksIdOtpAsync(int? id);

        /// <summary>
        /// 获取门锁动态密码
        /// </summary>
        /// <remarks>
        /// 获取门锁动态密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetDoorLocksIdOtpAsyncWithHttpInfo(int? id);
        /// <summary>
        /// 关闭某个门锁
        /// </summary>
        /// <remarks>
        /// 关闭某个门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <returns>Task of OperationResult</returns>
        System.Threading.Tasks.Task<OperationResult> PostDoorLocksIdCloseAsync(int? id);

        /// <summary>
        /// 关闭某个门锁
        /// </summary>
        /// <remarks>
        /// 关闭某个门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <returns>Task of ApiResponse (OperationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationResult>> PostDoorLocksIdCloseAsyncWithHttpInfo(int? id);
        /// <summary>
        /// 打开某个门锁
        /// </summary>
        /// <remarks>
        /// 打开某个门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="keepOpen">是否保持长开状态 (optional)</param>
        /// <returns>Task of OperationResult</returns>
        System.Threading.Tasks.Task<OperationResult> PostDoorLocksIdOpenAsync(int? id, bool? keepOpen = null);

        /// <summary>
        /// 打开某个门锁
        /// </summary>
        /// <remarks>
        /// 打开某个门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="keepOpen">是否保持长开状态 (optional)</param>
        /// <returns>Task of ApiResponse (OperationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationResult>> PostDoorLocksIdOpenAsyncWithHttpInfo(int? id, bool? keepOpen = null);
        /// <summary>
        /// 新增门锁离线密码
        /// </summary>
        /// <remarks>
        /// 新增门锁离线密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="seq">请求序列号</param>
        /// <param name="password">密码</param>
        /// <param name="startTime">开始时间戳，需要设置密码有效时间时使用</param>
        /// <param name="endTime">结束时间戳，与开始时间戳一起使用</param>
        /// <param name="times">使用次数，需要设置密码使用次数时使用 (optional, default to 255)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostDoorLocksIdPasswordsAsync(int? id, int? seq, string password, int? startTime, int? endTime, int? times = null);

        /// <summary>
        /// 新增门锁离线密码
        /// </summary>
        /// <remarks>
        /// 新增门锁离线密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="seq">请求序列号</param>
        /// <param name="password">密码</param>
        /// <param name="startTime">开始时间戳，需要设置密码有效时间时使用</param>
        /// <param name="endTime">结束时间戳，与开始时间戳一起使用</param>
        /// <param name="times">使用次数，需要设置密码使用次数时使用 (optional, default to 255)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostDoorLocksIdPasswordsAsyncWithHttpInfo(int? id, int? seq, string password, int? startTime, int? endTime, int? times = null);
        /// <summary>
        /// 门锁配对
        /// </summary>
        /// <remarks>
        /// 门锁配对
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostDoorLocksIdPmAsync(int? id);

        /// <summary>
        /// 门锁配对
        /// </summary>
        /// <remarks>
        /// 门锁配对
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostDoorLocksIdPmAsyncWithHttpInfo(int? id);
        /// <summary>
        /// 修改门锁描述
        /// </summary>
        /// <remarks>
        /// 修改门锁描述
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="desc">门锁名称</param>
        /// <returns>Task of DoorLock</returns>
        System.Threading.Tasks.Task<DoorLock> PutDoorLocksIdAsync(int? id, string desc);

        /// <summary>
        /// 修改门锁描述
        /// </summary>
        /// <remarks>
        /// 修改门锁描述
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="desc">门锁名称</param>
        /// <returns>Task of ApiResponse (DoorLock)</returns>
        System.Threading.Tasks.Task<ApiResponse<DoorLock>> PutDoorLocksIdAsyncWithHttpInfo(int? id, string desc);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}