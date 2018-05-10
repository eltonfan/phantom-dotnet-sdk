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
using Elton.Phantom.Models.Version2;
using RestSharp;
using System.Threading.Tasks;
using Elton.Phantom.Api.Version2;
using Elton.Phantom.Rest;

namespace Elton.Phantom.Api.Version2
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBulbsApi
    {
        Bulb GetBulbs(bool? includeShared = null);
        Task<Bulb> GetBulbsAsync(bool? includeShared = null);
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi : IBulbsApi
    {
        /// <summary>
        /// 获取了所有灯泡
        /// </summary>
        /// <remarks>
        /// 获取了所有灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeShared">返回被分享的设备 (optional)</param>
        /// <returns>Bulb</returns>
        Bulb IBulbsApi.GetBulbs(bool? includeShared = null)
        {
            var queryParams = new Dictionary<string, string>();
            if (includeShared != null)
                queryParams.Add("include_shared", includeShared.ToString()); // query parameter

            return Get<Bulb>(2, $"/bulbs", queryParams: queryParams);
        }

        /// <summary>
        /// 获取了所有灯泡
        /// </summary>
        /// <remarks>
        /// 获取了所有灯泡
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeShared">返回被分享的设备 (optional)</param>
        /// <returns>Task of Bulb</returns>
        async Task<Bulb> IBulbsApi.GetBulbsAsync(bool? includeShared = null)
        {
            var queryParams = new Dictionary<string, string>();
            if (includeShared != null)
                queryParams.Add("include_shared", includeShared.ToString()); // query parameter

            return await GetAsync<Bulb>(2, $"/bulbs", queryParams: queryParams);
        }
    }
}