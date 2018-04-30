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
    public interface IDevicesApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 根据设备标识字符串删除设备，           删除后的设备会获得一个位于字段death_qr_code中的二维码，           这样误删或是送人都可以用这个二维码，或是自己的设备坏了也可以用。
        /// </summary>
        /// <remarks>
        /// 根据设备标识字符串删除设备，           删除后的设备会获得一个位于字段death_qr_code中的二维码，           这样误删或是送人都可以用这个二维码，或是自己的设备坏了也可以用。
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceIdentifier">设备标识字符串 cf. 总则§2.3</param>
        /// <returns>Device</returns>
        Device DeleteDevicesDeviceIdentifier(string deviceIdentifier);

        /// <summary>
        /// 根据设备标识字符串删除设备，           删除后的设备会获得一个位于字段death_qr_code中的二维码，           这样误删或是送人都可以用这个二维码，或是自己的设备坏了也可以用。
        /// </summary>
        /// <remarks>
        /// 根据设备标识字符串删除设备，           删除后的设备会获得一个位于字段death_qr_code中的二维码，           这样误删或是送人都可以用这个二维码，或是自己的设备坏了也可以用。
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceIdentifier">设备标识字符串 cf. 总则§2.3</param>
        /// <returns>ApiResponse of Device</returns>
        ApiResponse<Device> DeleteDevicesDeviceIdentifierWithHttpInfo(string deviceIdentifier);
        /// <summary>
        /// 获取当前用户的所有设备
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有设备
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Device</returns>
        Device GetDevices();

        /// <summary>
        /// 获取当前用户的所有设备
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有设备
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Device</returns>
        ApiResponse<Device> GetDevicesWithHttpInfo();
        /// <summary>
        /// 根据设备标识字符串获取设备信息
        /// </summary>
        /// <remarks>
        /// 根据设备标识字符串获取设备信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceIdentifier">设备标识字符串 cf. 总则§2.3</param>
        /// <returns>Device</returns>
        Device GetDevicesDeviceIdentifier(string deviceIdentifier);

        /// <summary>
        /// 根据设备标识字符串获取设备信息
        /// </summary>
        /// <remarks>
        /// 根据设备标识字符串获取设备信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceIdentifier">设备标识字符串 cf. 总则§2.3</param>
        /// <returns>ApiResponse of Device</returns>
        ApiResponse<Device> GetDevicesDeviceIdentifierWithHttpInfo(string deviceIdentifier);
        /// <summary>
        /// 根据AppID获取设备信息
        /// </summary>
        /// <remarks>
        /// 根据AppID获取设备信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">设备二维码</param>
        /// <returns></returns>
        void GetDevicesPartnerDevices(string appId);

        /// <summary>
        /// 根据AppID获取设备信息
        /// </summary>
        /// <remarks>
        /// 根据AppID获取设备信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">设备二维码</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetDevicesPartnerDevicesWithHttpInfo(string appId);
        /// <summary>
        /// 根据二维码获取设备信息
        /// </summary>
        /// <remarks>
        /// 根据二维码获取设备信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="qrCode">设备二维码</param>
        /// <returns>QrCode</returns>
        QrCode GetDevicesQrCode(string qrCode);

        /// <summary>
        /// 根据二维码获取设备信息
        /// </summary>
        /// <remarks>
        /// 根据二维码获取设备信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="qrCode">设备二维码</param>
        /// <returns>ApiResponse of QrCode</returns>
        ApiResponse<QrCode> GetDevicesQrCodeWithHttpInfo(string qrCode);
        /// <summary>
        /// 根据二维码添加设备
        /// </summary>
        /// <remarks>
        /// 根据二维码添加设备
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="qrCode">设备二维码</param>
        /// <param name="home">是否添加到全家区域 (optional, default to true)</param>
        /// <returns>Device</returns>
        Device PostDevices(string qrCode, bool? home = null);

        /// <summary>
        /// 根据二维码添加设备
        /// </summary>
        /// <remarks>
        /// 根据二维码添加设备
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="qrCode">设备二维码</param>
        /// <param name="home">是否添加到全家区域 (optional, default to true)</param>
        /// <returns>ApiResponse of Device</returns>
        ApiResponse<Device> PostDevicesWithHttpInfo(string qrCode, bool? home = null);
        /// <summary>
        /// 根据设备标识字符串给设备排序
        /// </summary>
        /// <remarks>
        /// 根据设备标识字符串给设备排序
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="positionsDid"></param>
        /// <param name="positionsPosition"></param>
        /// <returns>Device</returns>
        Device PostDevicesPosition(List<string> positionsDid, List<int?> positionsPosition);

        /// <summary>
        /// 根据设备标识字符串给设备排序
        /// </summary>
        /// <remarks>
        /// 根据设备标识字符串给设备排序
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="positionsDid"></param>
        /// <param name="positionsPosition"></param>
        /// <returns>ApiResponse of Device</returns>
        ApiResponse<Device> PostDevicesPositionWithHttpInfo(List<string> positionsDid, List<int?> positionsPosition);
        /// <summary>
        /// 根据设备标识字符串为某设备改名
        /// </summary>
        /// <remarks>
        /// 根据设备标识字符串为某设备改名
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceIdentifier">设备标识字符串 cf. 总则§2.3</param>
        /// <param name="name">设备的新名字</param>
        /// <returns>Device</returns>
        Device PutDevicesDeviceIdentifier(string deviceIdentifier, string name);

        /// <summary>
        /// 根据设备标识字符串为某设备改名
        /// </summary>
        /// <remarks>
        /// 根据设备标识字符串为某设备改名
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceIdentifier">设备标识字符串 cf. 总则§2.3</param>
        /// <param name="name">设备的新名字</param>
        /// <returns>ApiResponse of Device</returns>
        ApiResponse<Device> PutDevicesDeviceIdentifierWithHttpInfo(string deviceIdentifier, string name);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 根据设备标识字符串删除设备，           删除后的设备会获得一个位于字段death_qr_code中的二维码，           这样误删或是送人都可以用这个二维码，或是自己的设备坏了也可以用。
        /// </summary>
        /// <remarks>
        /// 根据设备标识字符串删除设备，           删除后的设备会获得一个位于字段death_qr_code中的二维码，           这样误删或是送人都可以用这个二维码，或是自己的设备坏了也可以用。
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceIdentifier">设备标识字符串 cf. 总则§2.3</param>
        /// <returns>Task of Device</returns>
        System.Threading.Tasks.Task<Device> DeleteDevicesDeviceIdentifierAsync(string deviceIdentifier);

        /// <summary>
        /// 根据设备标识字符串删除设备，           删除后的设备会获得一个位于字段death_qr_code中的二维码，           这样误删或是送人都可以用这个二维码，或是自己的设备坏了也可以用。
        /// </summary>
        /// <remarks>
        /// 根据设备标识字符串删除设备，           删除后的设备会获得一个位于字段death_qr_code中的二维码，           这样误删或是送人都可以用这个二维码，或是自己的设备坏了也可以用。
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceIdentifier">设备标识字符串 cf. 总则§2.3</param>
        /// <returns>Task of ApiResponse (Device)</returns>
        System.Threading.Tasks.Task<ApiResponse<Device>> DeleteDevicesDeviceIdentifierAsyncWithHttpInfo(string deviceIdentifier);
        /// <summary>
        /// 获取当前用户的所有设备
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有设备
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Device</returns>
        System.Threading.Tasks.Task<Device> GetDevicesAsync();

        /// <summary>
        /// 获取当前用户的所有设备
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有设备
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Device)</returns>
        System.Threading.Tasks.Task<ApiResponse<Device>> GetDevicesAsyncWithHttpInfo();
        /// <summary>
        /// 根据设备标识字符串获取设备信息
        /// </summary>
        /// <remarks>
        /// 根据设备标识字符串获取设备信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceIdentifier">设备标识字符串 cf. 总则§2.3</param>
        /// <returns>Task of Device</returns>
        System.Threading.Tasks.Task<Device> GetDevicesDeviceIdentifierAsync(string deviceIdentifier);

        /// <summary>
        /// 根据设备标识字符串获取设备信息
        /// </summary>
        /// <remarks>
        /// 根据设备标识字符串获取设备信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceIdentifier">设备标识字符串 cf. 总则§2.3</param>
        /// <returns>Task of ApiResponse (Device)</returns>
        System.Threading.Tasks.Task<ApiResponse<Device>> GetDevicesDeviceIdentifierAsyncWithHttpInfo(string deviceIdentifier);
        /// <summary>
        /// 根据AppID获取设备信息
        /// </summary>
        /// <remarks>
        /// 根据AppID获取设备信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">设备二维码</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetDevicesPartnerDevicesAsync(string appId);

        /// <summary>
        /// 根据AppID获取设备信息
        /// </summary>
        /// <remarks>
        /// 根据AppID获取设备信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">设备二维码</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetDevicesPartnerDevicesAsyncWithHttpInfo(string appId);
        /// <summary>
        /// 根据二维码获取设备信息
        /// </summary>
        /// <remarks>
        /// 根据二维码获取设备信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="qrCode">设备二维码</param>
        /// <returns>Task of QrCode</returns>
        System.Threading.Tasks.Task<QrCode> GetDevicesQrCodeAsync(string qrCode);

        /// <summary>
        /// 根据二维码获取设备信息
        /// </summary>
        /// <remarks>
        /// 根据二维码获取设备信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="qrCode">设备二维码</param>
        /// <returns>Task of ApiResponse (QrCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<QrCode>> GetDevicesQrCodeAsyncWithHttpInfo(string qrCode);
        /// <summary>
        /// 根据二维码添加设备
        /// </summary>
        /// <remarks>
        /// 根据二维码添加设备
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="qrCode">设备二维码</param>
        /// <param name="home">是否添加到全家区域 (optional, default to true)</param>
        /// <returns>Task of Device</returns>
        System.Threading.Tasks.Task<Device> PostDevicesAsync(string qrCode, bool? home = null);

        /// <summary>
        /// 根据二维码添加设备
        /// </summary>
        /// <remarks>
        /// 根据二维码添加设备
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="qrCode">设备二维码</param>
        /// <param name="home">是否添加到全家区域 (optional, default to true)</param>
        /// <returns>Task of ApiResponse (Device)</returns>
        System.Threading.Tasks.Task<ApiResponse<Device>> PostDevicesAsyncWithHttpInfo(string qrCode, bool? home = null);
        /// <summary>
        /// 根据设备标识字符串给设备排序
        /// </summary>
        /// <remarks>
        /// 根据设备标识字符串给设备排序
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="positionsDid"></param>
        /// <param name="positionsPosition"></param>
        /// <returns>Task of Device</returns>
        System.Threading.Tasks.Task<Device> PostDevicesPositionAsync(List<string> positionsDid, List<int?> positionsPosition);

        /// <summary>
        /// 根据设备标识字符串给设备排序
        /// </summary>
        /// <remarks>
        /// 根据设备标识字符串给设备排序
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="positionsDid"></param>
        /// <param name="positionsPosition"></param>
        /// <returns>Task of ApiResponse (Device)</returns>
        System.Threading.Tasks.Task<ApiResponse<Device>> PostDevicesPositionAsyncWithHttpInfo(List<string> positionsDid, List<int?> positionsPosition);
        /// <summary>
        /// 根据设备标识字符串为某设备改名
        /// </summary>
        /// <remarks>
        /// 根据设备标识字符串为某设备改名
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceIdentifier">设备标识字符串 cf. 总则§2.3</param>
        /// <param name="name">设备的新名字</param>
        /// <returns>Task of Device</returns>
        System.Threading.Tasks.Task<Device> PutDevicesDeviceIdentifierAsync(string deviceIdentifier, string name);

        /// <summary>
        /// 根据设备标识字符串为某设备改名
        /// </summary>
        /// <remarks>
        /// 根据设备标识字符串为某设备改名
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceIdentifier">设备标识字符串 cf. 总则§2.3</param>
        /// <param name="name">设备的新名字</param>
        /// <returns>Task of ApiResponse (Device)</returns>
        System.Threading.Tasks.Task<ApiResponse<Device>> PutDevicesDeviceIdentifierAsyncWithHttpInfo(string deviceIdentifier, string name);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}