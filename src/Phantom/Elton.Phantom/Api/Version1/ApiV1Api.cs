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
using System.Threading.Tasks;
using RestSharp;
using Elton.Phantom.Models.Version1;

namespace Elton.Phantom.Api.Version1
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IApiV1Api
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void GetApiV1();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetApiV1WithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Resource name of mounted API</param>
        /// <param name="locale">Locale of API documentation (optional)</param>
        /// <returns></returns>
        void GetApiV1Name(string name, string locale = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Resource name of mounted API</param>
        /// <param name="locale">Locale of API documentation (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetApiV1NameWithHttpInfo(string name, string locale = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetApiV1Async();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetApiV1AsyncWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Resource name of mounted API</param>
        /// <param name="locale">Locale of API documentation (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetApiV1NameAsync(string name, string locale = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Resource name of mounted API</param>
        /// <param name="locale">Locale of API documentation (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetApiV1NameAsyncWithHttpInfo(string name, string locale = null);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi : Api.Version1.IApiV1Api
    {
        public void GetApiV1()
        {
            throw new NotImplementedException();
        }

        public Task GetApiV1Async()
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<object>> GetApiV1AsyncWithHttpInfo()
        {
            throw new NotImplementedException();
        }

        public void GetApiV1Name(string name, string locale = null)
        {
            throw new NotImplementedException();
        }

        public Task GetApiV1NameAsync(string name, string locale = null)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<object>> GetApiV1NameAsyncWithHttpInfo(string name, string locale = null)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<object> GetApiV1NameWithHttpInfo(string name, string locale = null)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<object> GetApiV1WithHttpInfo()
        {
            throw new NotImplementedException();
        }
    }
}