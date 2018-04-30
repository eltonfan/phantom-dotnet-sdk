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
    public interface IHuoheLocksApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 删除密码
        /// </summary>
        /// <remarks>
        /// 删除密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="pwdNo">密码编号</param>
        /// <returns>HuohePwd</returns>
        HuohePwd DeleteHuoheLocksIdPwdsPwdNo (int? id, string pwdNo);

        /// <summary>
        /// 删除密码
        /// </summary>
        /// <remarks>
        /// 删除密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="pwdNo">密码编号</param>
        /// <returns>ApiResponse of HuohePwd</returns>
        ApiResponse<HuohePwd> DeleteHuoheLocksIdPwdsPwdNoWithHttpInfo (int? id, string pwdNo);
        /// <summary>
        /// 获取所有火河门锁
        /// </summary>
        /// <remarks>
        /// 获取所有火河门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">当前页 (optional, default to 1)</param>
        /// <param name="perPage">每页 (optional, default to 10)</param>
        /// <returns>HuoheLock</returns>
        HuoheLock GetHuoheLocks (int? page = null, int? perPage = null);

        /// <summary>
        /// 获取所有火河门锁
        /// </summary>
        /// <remarks>
        /// 获取所有火河门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">当前页 (optional, default to 1)</param>
        /// <param name="perPage">每页 (optional, default to 10)</param>
        /// <returns>ApiResponse of HuoheLock</returns>
        ApiResponse<HuoheLock> GetHuoheLocksWithHttpInfo (int? page = null, int? perPage = null);
        /// <summary>
        /// 获取某个火河门锁
        /// </summary>
        /// <remarks>
        /// 获取某个火河门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <returns>HuoheLock</returns>
        HuoheLock GetHuoheLocksId (int? id);

        /// <summary>
        /// 获取某个火河门锁
        /// </summary>
        /// <remarks>
        /// 获取某个火河门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <returns>ApiResponse of HuoheLock</returns>
        ApiResponse<HuoheLock> GetHuoheLocksIdWithHttpInfo (int? id);
        /// <summary>
        /// 获取开门记录
        /// </summary>
        /// <remarks>
        /// 获取开门记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="searchTimeStart">开始时间戳 (optional)</param>
        /// <param name="searchTimeEnd">结束时间戳 (optional)</param>
        /// <param name="page">当前页 (optional, default to 1)</param>
        /// <param name="perPage">每页 (optional, default to 10)</param>
        /// <returns></returns>
        void GetHuoheLocksIdOpenRecords (int? id, int? searchTimeStart = null, int? searchTimeEnd = null, int? page = null, int? perPage = null);

        /// <summary>
        /// 获取开门记录
        /// </summary>
        /// <remarks>
        /// 获取开门记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="searchTimeStart">开始时间戳 (optional)</param>
        /// <param name="searchTimeEnd">结束时间戳 (optional)</param>
        /// <param name="page">当前页 (optional, default to 1)</param>
        /// <param name="perPage">每页 (optional, default to 10)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetHuoheLocksIdOpenRecordsWithHttpInfo (int? id, int? searchTimeStart = null, int? searchTimeEnd = null, int? page = null, int? perPage = null);
        /// <summary>
        /// 获取门锁密码
        /// </summary>
        /// <remarks>
        /// 获取门锁密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="page">当前页 (optional, default to 1)</param>
        /// <param name="perPage">每页 (optional, default to 10)</param>
        /// <returns>HuohePwd</returns>
        HuohePwd GetHuoheLocksIdPwds (int? id, int? page = null, int? perPage = null);

        /// <summary>
        /// 获取门锁密码
        /// </summary>
        /// <remarks>
        /// 获取门锁密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="page">当前页 (optional, default to 1)</param>
        /// <param name="perPage">每页 (optional, default to 10)</param>
        /// <returns>ApiResponse of HuohePwd</returns>
        ApiResponse<HuohePwd> GetHuoheLocksIdPwdsWithHttpInfo (int? id, int? page = null, int? perPage = null);
        /// <summary>
        /// 更新门锁信息
        /// </summary>
        /// <remarks>
        /// 更新门锁信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="name">门锁名称 (optional)</param>
        /// <param name="houseId">房间ID (optional)</param>
        /// <returns>HuoheLock</returns>
        HuoheLock PatchHuoheLocksId (int? id, string name = null, int? houseId = null);

        /// <summary>
        /// 更新门锁信息
        /// </summary>
        /// <remarks>
        /// 更新门锁信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="name">门锁名称 (optional)</param>
        /// <param name="houseId">房间ID (optional)</param>
        /// <returns>ApiResponse of HuoheLock</returns>
        ApiResponse<HuoheLock> PatchHuoheLocksIdWithHttpInfo (int? id, string name = null, int? houseId = null);
        /// <summary>
        /// 修改门锁密码
        /// </summary>
        /// <remarks>
        /// 修改门锁密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="pwdNo">密码编号</param>
        /// <param name="newPwd">新密码</param>
        /// <param name="startTime">有效期开始时间戳，若为空，则不修改 (optional)</param>
        /// <param name="endTime">有效期结束时间戳，若为空，则不修改 (optional)</param>
        /// <returns>HuohePwd</returns>
        HuohePwd PatchHuoheLocksIdPwdsPwdNo (int? id, string pwdNo, string newPwd, int? startTime = null, int? endTime = null);

        /// <summary>
        /// 修改门锁密码
        /// </summary>
        /// <remarks>
        /// 修改门锁密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="pwdNo">密码编号</param>
        /// <param name="newPwd">新密码</param>
        /// <param name="startTime">有效期开始时间戳，若为空，则不修改 (optional)</param>
        /// <param name="endTime">有效期结束时间戳，若为空，则不修改 (optional)</param>
        /// <returns>ApiResponse of HuohePwd</returns>
        ApiResponse<HuohePwd> PatchHuoheLocksIdPwdsPwdNoWithHttpInfo (int? id, string pwdNo, string newPwd, int? startTime = null, int? endTime = null);
        /// <summary>
        /// 远程开门
        /// </summary>
        /// <remarks>
        /// 远程开门
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="mobile">手机号，默认为管理账号手机号 (optional)</param>
        /// <returns>HuoheLock</returns>
        HuoheLock PostHuoheLocksIdOpenAction (int? id, string mobile = null);

        /// <summary>
        /// 远程开门
        /// </summary>
        /// <remarks>
        /// 远程开门
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="mobile">手机号，默认为管理账号手机号 (optional)</param>
        /// <returns>ApiResponse of HuoheLock</returns>
        ApiResponse<HuoheLock> PostHuoheLocksIdOpenActionWithHttpInfo (int? id, string mobile = null);
        /// <summary>
        /// 新增门锁密码
        /// </summary>
        /// <remarks>
        /// 新增门锁密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="startTime">有效期开始时间戳</param>
        /// <param name="endTime">有效期结束时间戳</param>
        /// <param name="mobile">密码使用人手机号</param>
        /// <param name="pwd">密码，若为空，则随机生成 (optional)</param>
        /// <returns>HuohePwd</returns>
        HuohePwd PostHuoheLocksIdPwds (int? id, int? startTime, int? endTime, string mobile, string pwd = null);

        /// <summary>
        /// 新增门锁密码
        /// </summary>
        /// <remarks>
        /// 新增门锁密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="startTime">有效期开始时间戳</param>
        /// <param name="endTime">有效期结束时间戳</param>
        /// <param name="mobile">密码使用人手机号</param>
        /// <param name="pwd">密码，若为空，则随机生成 (optional)</param>
        /// <returns>ApiResponse of HuohePwd</returns>
        ApiResponse<HuohePwd> PostHuoheLocksIdPwdsWithHttpInfo (int? id, int? startTime, int? endTime, string mobile, string pwd = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 删除密码
        /// </summary>
        /// <remarks>
        /// 删除密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="pwdNo">密码编号</param>
        /// <returns>Task of HuohePwd</returns>
        System.Threading.Tasks.Task<HuohePwd> DeleteHuoheLocksIdPwdsPwdNoAsync (int? id, string pwdNo);

        /// <summary>
        /// 删除密码
        /// </summary>
        /// <remarks>
        /// 删除密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="pwdNo">密码编号</param>
        /// <returns>Task of ApiResponse (HuohePwd)</returns>
        System.Threading.Tasks.Task<ApiResponse<HuohePwd>> DeleteHuoheLocksIdPwdsPwdNoAsyncWithHttpInfo (int? id, string pwdNo);
        /// <summary>
        /// 获取所有火河门锁
        /// </summary>
        /// <remarks>
        /// 获取所有火河门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">当前页 (optional, default to 1)</param>
        /// <param name="perPage">每页 (optional, default to 10)</param>
        /// <returns>Task of HuoheLock</returns>
        System.Threading.Tasks.Task<HuoheLock> GetHuoheLocksAsync (int? page = null, int? perPage = null);

        /// <summary>
        /// 获取所有火河门锁
        /// </summary>
        /// <remarks>
        /// 获取所有火河门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">当前页 (optional, default to 1)</param>
        /// <param name="perPage">每页 (optional, default to 10)</param>
        /// <returns>Task of ApiResponse (HuoheLock)</returns>
        System.Threading.Tasks.Task<ApiResponse<HuoheLock>> GetHuoheLocksAsyncWithHttpInfo (int? page = null, int? perPage = null);
        /// <summary>
        /// 获取某个火河门锁
        /// </summary>
        /// <remarks>
        /// 获取某个火河门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <returns>Task of HuoheLock</returns>
        System.Threading.Tasks.Task<HuoheLock> GetHuoheLocksIdAsync (int? id);

        /// <summary>
        /// 获取某个火河门锁
        /// </summary>
        /// <remarks>
        /// 获取某个火河门锁
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <returns>Task of ApiResponse (HuoheLock)</returns>
        System.Threading.Tasks.Task<ApiResponse<HuoheLock>> GetHuoheLocksIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 获取开门记录
        /// </summary>
        /// <remarks>
        /// 获取开门记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="searchTimeStart">开始时间戳 (optional)</param>
        /// <param name="searchTimeEnd">结束时间戳 (optional)</param>
        /// <param name="page">当前页 (optional, default to 1)</param>
        /// <param name="perPage">每页 (optional, default to 10)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetHuoheLocksIdOpenRecordsAsync (int? id, int? searchTimeStart = null, int? searchTimeEnd = null, int? page = null, int? perPage = null);

        /// <summary>
        /// 获取开门记录
        /// </summary>
        /// <remarks>
        /// 获取开门记录
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="searchTimeStart">开始时间戳 (optional)</param>
        /// <param name="searchTimeEnd">结束时间戳 (optional)</param>
        /// <param name="page">当前页 (optional, default to 1)</param>
        /// <param name="perPage">每页 (optional, default to 10)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetHuoheLocksIdOpenRecordsAsyncWithHttpInfo (int? id, int? searchTimeStart = null, int? searchTimeEnd = null, int? page = null, int? perPage = null);
        /// <summary>
        /// 获取门锁密码
        /// </summary>
        /// <remarks>
        /// 获取门锁密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="page">当前页 (optional, default to 1)</param>
        /// <param name="perPage">每页 (optional, default to 10)</param>
        /// <returns>Task of HuohePwd</returns>
        System.Threading.Tasks.Task<HuohePwd> GetHuoheLocksIdPwdsAsync (int? id, int? page = null, int? perPage = null);

        /// <summary>
        /// 获取门锁密码
        /// </summary>
        /// <remarks>
        /// 获取门锁密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="page">当前页 (optional, default to 1)</param>
        /// <param name="perPage">每页 (optional, default to 10)</param>
        /// <returns>Task of ApiResponse (HuohePwd)</returns>
        System.Threading.Tasks.Task<ApiResponse<HuohePwd>> GetHuoheLocksIdPwdsAsyncWithHttpInfo (int? id, int? page = null, int? perPage = null);
        /// <summary>
        /// 更新门锁信息
        /// </summary>
        /// <remarks>
        /// 更新门锁信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="name">门锁名称 (optional)</param>
        /// <param name="houseId">房间ID (optional)</param>
        /// <returns>Task of HuoheLock</returns>
        System.Threading.Tasks.Task<HuoheLock> PatchHuoheLocksIdAsync (int? id, string name = null, int? houseId = null);

        /// <summary>
        /// 更新门锁信息
        /// </summary>
        /// <remarks>
        /// 更新门锁信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="name">门锁名称 (optional)</param>
        /// <param name="houseId">房间ID (optional)</param>
        /// <returns>Task of ApiResponse (HuoheLock)</returns>
        System.Threading.Tasks.Task<ApiResponse<HuoheLock>> PatchHuoheLocksIdAsyncWithHttpInfo (int? id, string name = null, int? houseId = null);
        /// <summary>
        /// 修改门锁密码
        /// </summary>
        /// <remarks>
        /// 修改门锁密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="pwdNo">密码编号</param>
        /// <param name="newPwd">新密码</param>
        /// <param name="startTime">有效期开始时间戳，若为空，则不修改 (optional)</param>
        /// <param name="endTime">有效期结束时间戳，若为空，则不修改 (optional)</param>
        /// <returns>Task of HuohePwd</returns>
        System.Threading.Tasks.Task<HuohePwd> PatchHuoheLocksIdPwdsPwdNoAsync (int? id, string pwdNo, string newPwd, int? startTime = null, int? endTime = null);

        /// <summary>
        /// 修改门锁密码
        /// </summary>
        /// <remarks>
        /// 修改门锁密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="pwdNo">密码编号</param>
        /// <param name="newPwd">新密码</param>
        /// <param name="startTime">有效期开始时间戳，若为空，则不修改 (optional)</param>
        /// <param name="endTime">有效期结束时间戳，若为空，则不修改 (optional)</param>
        /// <returns>Task of ApiResponse (HuohePwd)</returns>
        System.Threading.Tasks.Task<ApiResponse<HuohePwd>> PatchHuoheLocksIdPwdsPwdNoAsyncWithHttpInfo (int? id, string pwdNo, string newPwd, int? startTime = null, int? endTime = null);
        /// <summary>
        /// 远程开门
        /// </summary>
        /// <remarks>
        /// 远程开门
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="mobile">手机号，默认为管理账号手机号 (optional)</param>
        /// <returns>Task of HuoheLock</returns>
        System.Threading.Tasks.Task<HuoheLock> PostHuoheLocksIdOpenActionAsync (int? id, string mobile = null);

        /// <summary>
        /// 远程开门
        /// </summary>
        /// <remarks>
        /// 远程开门
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="mobile">手机号，默认为管理账号手机号 (optional)</param>
        /// <returns>Task of ApiResponse (HuoheLock)</returns>
        System.Threading.Tasks.Task<ApiResponse<HuoheLock>> PostHuoheLocksIdOpenActionAsyncWithHttpInfo (int? id, string mobile = null);
        /// <summary>
        /// 新增门锁密码
        /// </summary>
        /// <remarks>
        /// 新增门锁密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="startTime">有效期开始时间戳</param>
        /// <param name="endTime">有效期结束时间戳</param>
        /// <param name="mobile">密码使用人手机号</param>
        /// <param name="pwd">密码，若为空，则随机生成 (optional)</param>
        /// <returns>Task of HuohePwd</returns>
        System.Threading.Tasks.Task<HuohePwd> PostHuoheLocksIdPwdsAsync (int? id, int? startTime, int? endTime, string mobile, string pwd = null);

        /// <summary>
        /// 新增门锁密码
        /// </summary>
        /// <remarks>
        /// 新增门锁密码
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">门锁ID</param>
        /// <param name="startTime">有效期开始时间戳</param>
        /// <param name="endTime">有效期结束时间戳</param>
        /// <param name="mobile">密码使用人手机号</param>
        /// <param name="pwd">密码，若为空，则随机生成 (optional)</param>
        /// <returns>Task of ApiResponse (HuohePwd)</returns>
        System.Threading.Tasks.Task<ApiResponse<HuohePwd>> PostHuoheLocksIdPwdsAsyncWithHttpInfo (int? id, int? startTime, int? endTime, string mobile, string pwd = null);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}