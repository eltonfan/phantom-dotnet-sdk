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
    public interface IServicesApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取所有的第三方应用列表信息
        /// </summary>
        /// <remarks>
        /// 获取所有的第三方应用列表信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>ThirdAppV2</returns>
        ThirdAppV2 GetServicesAll (string platform = null, string rnVersion = null);

        /// <summary>
        /// 获取所有的第三方应用列表信息
        /// </summary>
        /// <remarks>
        /// 获取所有的第三方应用列表信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>ApiResponse of ThirdAppV2</returns>
        ApiResponse<ThirdAppV2> GetServicesAllWithHttpInfo (string platform = null, string rnVersion = null);
        /// <summary>
        /// 获取某一个第三方应用的详情信息
        /// </summary>
        /// <remarks>
        /// 获取某一个第三方应用的详情信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">第三方APP ID</param>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>ThirdAppV2</returns>
        ThirdAppV2 GetServicesId (int? id, string platform = null, string rnVersion = null);

        /// <summary>
        /// 获取某一个第三方应用的详情信息
        /// </summary>
        /// <remarks>
        /// 获取某一个第三方应用的详情信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">第三方APP ID</param>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>ApiResponse of ThirdAppV2</returns>
        ApiResponse<ThirdAppV2> GetServicesIdWithHttpInfo (int? id, string platform = null, string rnVersion = null);
        /// <summary>
        /// 获取用户已订阅的第三方应用列表信息
        /// </summary>
        /// <remarks>
        /// 获取用户已订阅的第三方应用列表信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>UserThirdAppV2</returns>
        UserThirdAppV2 GetServicesUser (string platform = null, string rnVersion = null);

        /// <summary>
        /// 获取用户已订阅的第三方应用列表信息
        /// </summary>
        /// <remarks>
        /// 获取用户已订阅的第三方应用列表信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>ApiResponse of UserThirdAppV2</returns>
        ApiResponse<UserThirdAppV2> GetServicesUserWithHttpInfo (string platform = null, string rnVersion = null);
        /// <summary>
        /// 订阅指定的第三方应用
        /// </summary>
        /// <remarks>
        /// 订阅指定的第三方应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">第三方APP ID</param>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>UserThirdAppV2</returns>
        UserThirdAppV2 PostServicesIdInstall (int? id, string platform = null, string rnVersion = null);

        /// <summary>
        /// 订阅指定的第三方应用
        /// </summary>
        /// <remarks>
        /// 订阅指定的第三方应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">第三方APP ID</param>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>ApiResponse of UserThirdAppV2</returns>
        ApiResponse<UserThirdAppV2> PostServicesIdInstallWithHttpInfo (int? id, string platform = null, string rnVersion = null);
        /// <summary>
        /// 退订指定的第三方应用
        /// </summary>
        /// <remarks>
        /// 退订指定的第三方应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">第三方APP ID</param>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns></returns>
        void PostServicesIdUninstall (int? id, string platform = null, string rnVersion = null);

        /// <summary>
        /// 退订指定的第三方应用
        /// </summary>
        /// <remarks>
        /// 退订指定的第三方应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">第三方APP ID</param>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostServicesIdUninstallWithHttpInfo (int? id, string platform = null, string rnVersion = null);
        /// <summary>
        /// 老应用迁移接口
        /// </summary>
        /// <remarks>
        /// 老应用迁移接口
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns></returns>
        void PostServicesRecipesMigration (string platform = null, string rnVersion = null);

        /// <summary>
        /// 老应用迁移接口
        /// </summary>
        /// <remarks>
        /// 老应用迁移接口
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostServicesRecipesMigrationWithHttpInfo (string platform = null, string rnVersion = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 获取所有的第三方应用列表信息
        /// </summary>
        /// <remarks>
        /// 获取所有的第三方应用列表信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>Task of ThirdAppV2</returns>
        System.Threading.Tasks.Task<ThirdAppV2> GetServicesAllAsync (string platform = null, string rnVersion = null);

        /// <summary>
        /// 获取所有的第三方应用列表信息
        /// </summary>
        /// <remarks>
        /// 获取所有的第三方应用列表信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>Task of ApiResponse (ThirdAppV2)</returns>
        System.Threading.Tasks.Task<ApiResponse<ThirdAppV2>> GetServicesAllAsyncWithHttpInfo (string platform = null, string rnVersion = null);
        /// <summary>
        /// 获取某一个第三方应用的详情信息
        /// </summary>
        /// <remarks>
        /// 获取某一个第三方应用的详情信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">第三方APP ID</param>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>Task of ThirdAppV2</returns>
        System.Threading.Tasks.Task<ThirdAppV2> GetServicesIdAsync (int? id, string platform = null, string rnVersion = null);

        /// <summary>
        /// 获取某一个第三方应用的详情信息
        /// </summary>
        /// <remarks>
        /// 获取某一个第三方应用的详情信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">第三方APP ID</param>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>Task of ApiResponse (ThirdAppV2)</returns>
        System.Threading.Tasks.Task<ApiResponse<ThirdAppV2>> GetServicesIdAsyncWithHttpInfo (int? id, string platform = null, string rnVersion = null);
        /// <summary>
        /// 获取用户已订阅的第三方应用列表信息
        /// </summary>
        /// <remarks>
        /// 获取用户已订阅的第三方应用列表信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>Task of UserThirdAppV2</returns>
        System.Threading.Tasks.Task<UserThirdAppV2> GetServicesUserAsync (string platform = null, string rnVersion = null);

        /// <summary>
        /// 获取用户已订阅的第三方应用列表信息
        /// </summary>
        /// <remarks>
        /// 获取用户已订阅的第三方应用列表信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>Task of ApiResponse (UserThirdAppV2)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserThirdAppV2>> GetServicesUserAsyncWithHttpInfo (string platform = null, string rnVersion = null);
        /// <summary>
        /// 订阅指定的第三方应用
        /// </summary>
        /// <remarks>
        /// 订阅指定的第三方应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">第三方APP ID</param>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>Task of UserThirdAppV2</returns>
        System.Threading.Tasks.Task<UserThirdAppV2> PostServicesIdInstallAsync (int? id, string platform = null, string rnVersion = null);

        /// <summary>
        /// 订阅指定的第三方应用
        /// </summary>
        /// <remarks>
        /// 订阅指定的第三方应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">第三方APP ID</param>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>Task of ApiResponse (UserThirdAppV2)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserThirdAppV2>> PostServicesIdInstallAsyncWithHttpInfo (int? id, string platform = null, string rnVersion = null);
        /// <summary>
        /// 退订指定的第三方应用
        /// </summary>
        /// <remarks>
        /// 退订指定的第三方应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">第三方APP ID</param>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostServicesIdUninstallAsync (int? id, string platform = null, string rnVersion = null);

        /// <summary>
        /// 退订指定的第三方应用
        /// </summary>
        /// <remarks>
        /// 退订指定的第三方应用
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">第三方APP ID</param>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostServicesIdUninstallAsyncWithHttpInfo (int? id, string platform = null, string rnVersion = null);
        /// <summary>
        /// 老应用迁移接口
        /// </summary>
        /// <remarks>
        /// 老应用迁移接口
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostServicesRecipesMigrationAsync (string platform = null, string rnVersion = null);

        /// <summary>
        /// 老应用迁移接口
        /// </summary>
        /// <remarks>
        /// 老应用迁移接口
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="platform">ios or android, default is ios (optional)</param>
        /// <param name="rnVersion">React Native 版本 (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostServicesRecipesMigrationAsyncWithHttpInfo (string platform = null, string rnVersion = null);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}