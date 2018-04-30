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
    public interface IUserApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 为当前用户的依键删除某首选项
        /// </summary>
        /// <remarks>
        /// 为当前用户的依键删除某首选项
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">首选项键</param>
        /// <returns>UserPreference</returns>
        UserPreference DeleteUserPreferences (string key);

        /// <summary>
        /// 为当前用户的依键删除某首选项
        /// </summary>
        /// <remarks>
        /// 为当前用户的依键删除某首选项
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">首选项键</param>
        /// <returns>ApiResponse of UserPreference</returns>
        ApiResponse<UserPreference> DeleteUserPreferencesWithHttpInfo (string key);
        /// <summary>
        /// 获取当前用户的资料
        /// </summary>
        /// <remarks>
        /// 获取当前用户的资料
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>User</returns>
        User GetUser ();

        /// <summary>
        /// 获取当前用户的资料
        /// </summary>
        /// <remarks>
        /// 获取当前用户的资料
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> GetUserWithHttpInfo ();
        /// <summary>
        /// 获取更改用户密码的短信验证码, 如果手机号码格式正确返回数据为 {success: true, msg: \&quot;已发送短信验证码至xxxxxxx\&quot;}
        /// </summary>
        /// <remarks>
        /// 获取更改用户密码的短信验证码, 如果手机号码格式正确返回数据为 {success: true, msg: \&quot;已发送短信验证码至xxxxxxx\&quot;}
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone">手机号码</param>
        /// <returns></returns>
        void GetUserChangePwdCode (string phone);

        /// <summary>
        /// 获取更改用户密码的短信验证码, 如果手机号码格式正确返回数据为 {success: true, msg: \&quot;已发送短信验证码至xxxxxxx\&quot;}
        /// </summary>
        /// <remarks>
        /// 获取更改用户密码的短信验证码, 如果手机号码格式正确返回数据为 {success: true, msg: \&quot;已发送短信验证码至xxxxxxx\&quot;}
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone">手机号码</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetUserChangePwdCodeWithHttpInfo (string phone);
        /// <summary>
        /// 查询指定手机号的用户是否存在
        /// </summary>
        /// <remarks>
        /// 查询指定手机号的用户是否存在
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone">手机号</param>
        /// <returns></returns>
        void GetUserFindByPhone (string phone);

        /// <summary>
        /// 查询指定手机号的用户是否存在
        /// </summary>
        /// <remarks>
        /// 查询指定手机号的用户是否存在
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone">手机号</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetUserFindByPhoneWithHttpInfo (string phone);
        /// <summary>
        /// 老子回家啦！
        /// </summary>
        /// <remarks>
        /// 老子回家啦！
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="distance">距离家的距离 (optional)</param>
        /// <returns></returns>
        void GetUserIAmBack (int? distance = null);

        /// <summary>
        /// 老子回家啦！
        /// </summary>
        /// <remarks>
        /// 老子回家啦！
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="distance">距离家的距离 (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetUserIAmBackWithHttpInfo (int? distance = null);
        /// <summary>
        /// 老子出门啦！
        /// </summary>
        /// <remarks>
        /// 老子出门啦！
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void GetUserIAmOut ();

        /// <summary>
        /// 老子出门啦！
        /// </summary>
        /// <remarks>
        /// 老子出门啦！
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetUserIAmOutWithHttpInfo ();
        /// <summary>
        /// 某人是否在家
        /// </summary>
        /// <remarks>
        /// 某人是否在家
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruserId">手机端ID</param>
        /// <returns></returns>
        void GetUserPredict (string ruserId);

        /// <summary>
        /// 某人是否在家
        /// </summary>
        /// <remarks>
        /// 某人是否在家
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruserId">手机端ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetUserPredictWithHttpInfo (string ruserId);
        /// <summary>
        /// 获取当前用户的所有首选项或某首选项
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有首选项或某首选项
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">首选项键，若传递该参数则获取某首选项，否则获取所有首选项 (optional)</param>
        /// <returns>UserPreference</returns>
        UserPreference GetUserPreferences (string key = null);

        /// <summary>
        /// 获取当前用户的所有首选项或某首选项
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有首选项或某首选项
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">首选项键，若传递该参数则获取某首选项，否则获取所有首选项 (optional)</param>
        /// <returns>ApiResponse of UserPreference</returns>
        ApiResponse<UserPreference> GetUserPreferencesWithHttpInfo (string key = null);
        /// <summary>
        /// 获取七牛文件上传 token
        /// </summary>
        /// <remarks>
        /// 获取七牛文件上传 token
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extension">拓展名, 说明文件用途。如: avatar; 多单词使用下划线分割: full_pic。</param>
        /// <returns></returns>
        void GetUserQiniuUptoken (string extension);

        /// <summary>
        /// 获取七牛文件上传 token
        /// </summary>
        /// <remarks>
        /// 获取七牛文件上传 token
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extension">拓展名, 说明文件用途。如: avatar; 多单词使用下划线分割: full_pic。</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetUserQiniuUptokenWithHttpInfo (string extension);
        /// <summary>
        /// 向用户的手机发送语音消息
        /// </summary>
        /// <remarks>
        /// 向用户的手机发送语音消息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone">手机号码</param>
        /// <param name="words">文字</param>
        /// <param name="repeat">循环播放次数(1-3)，缺省 1 次 (optional)</param>
        /// <returns></returns>
        void GetUserSendVoiceMessage (string phone, string words, int? repeat = null);

        /// <summary>
        /// 向用户的手机发送语音消息
        /// </summary>
        /// <remarks>
        /// 向用户的手机发送语音消息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone">手机号码</param>
        /// <param name="words">文字</param>
        /// <param name="repeat">循环播放次数(1-3)，缺省 1 次 (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetUserSendVoiceMessageWithHttpInfo (string phone, string words, int? repeat = null);
        /// <summary>
        /// 获取3rd应用时间流顺序
        /// </summary>
        /// <remarks>
        /// 获取3rd应用时间流顺序
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void GetUserTimelineOrder ();

        /// <summary>
        /// 获取3rd应用时间流顺序
        /// </summary>
        /// <remarks>
        /// 获取3rd应用时间流顺序
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetUserTimelineOrderWithHttpInfo ();
        /// <summary>
        /// 获取当前用户的家的当前天气
        /// </summary>
        /// <remarks>
        /// 获取当前用户的家的当前天气
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Weather</returns>
        Weather GetUserWeather ();

        /// <summary>
        /// 获取当前用户的家的当前天气
        /// </summary>
        /// <remarks>
        /// 获取当前用户的家的当前天气
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Weather</returns>
        ApiResponse<Weather> GetUserWeatherWithHttpInfo ();
        /// <summary>
        /// 第三方应用向用户发送推送通知
        /// </summary>
        /// <remarks>
        /// 第三方应用向用户发送推送通知
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">第三方应用的id</param>
        /// <param name="appSecret">第三方应用的密钥</param>
        /// <param name="text">通知显示的内容</param>
        /// <param name="action">点击通知后要执行的动作</param>
        /// <param name="actionContent">点击通知后要执行的动作的内容</param>
        /// <param name="message">传给第三方应用的消息，JSON对象 (optional)</param>
        /// <param name="appVersion">第三方应用的版本，x.y.z (optional)</param>
        /// <returns></returns>
        void PostUser3rdPush (string appId, string appSecret, string text, string action, string actionContent, string message = null, string appVersion = null);

        /// <summary>
        /// 第三方应用向用户发送推送通知
        /// </summary>
        /// <remarks>
        /// 第三方应用向用户发送推送通知
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">第三方应用的id</param>
        /// <param name="appSecret">第三方应用的密钥</param>
        /// <param name="text">通知显示的内容</param>
        /// <param name="action">点击通知后要执行的动作</param>
        /// <param name="actionContent">点击通知后要执行的动作的内容</param>
        /// <param name="message">传给第三方应用的消息，JSON对象 (optional)</param>
        /// <param name="appVersion">第三方应用的版本，x.y.z (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostUser3rdPushWithHttpInfo (string appId, string appSecret, string text, string action, string actionContent, string message = null, string appVersion = null);
        /// <summary>
        /// 更改用户密码, 返回数据格式为 {success: boolean, msg: string}
        /// </summary>
        /// <remarks>
        /// 更改用户密码, 返回数据格式为 {success: boolean, msg: string}
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone">用户的手机号，必须是接收验证码的号码</param>
        /// <param name="newPassword">新密码</param>
        /// <param name="verifyCode">验证码</param>
        /// <returns></returns>
        void PostUserChangePwd (string phone, string newPassword, string verifyCode);

        /// <summary>
        /// 更改用户密码, 返回数据格式为 {success: boolean, msg: string}
        /// </summary>
        /// <remarks>
        /// 更改用户密码, 返回数据格式为 {success: boolean, msg: string}
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone">用户的手机号，必须是接收验证码的号码</param>
        /// <param name="newPassword">新密码</param>
        /// <param name="verifyCode">验证码</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostUserChangePwdWithHttpInfo (string phone, string newPassword, string verifyCode);
        /// <summary>
        /// app报告地理围栏的进出数据
        /// </summary>
        /// <remarks>
        /// app报告地理围栏的进出数据
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jsonRadius">地理围栏的半径（米）</param>
        /// <param name="jsonDirection">进出方向：in（进）out（出）</param>
        /// <param name="jsonDeviceUuid">设备的唯一id</param>
        /// <param name="jsonTimestamp">产生这个gps事件的时间（秒）</param>
        /// <returns></returns>
        void PostUserFence (List<int?> jsonRadius, List<string> jsonDirection, List<string> jsonDeviceUuid, List<int?> jsonTimestamp);

        /// <summary>
        /// app报告地理围栏的进出数据
        /// </summary>
        /// <remarks>
        /// app报告地理围栏的进出数据
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jsonRadius">地理围栏的半径（米）</param>
        /// <param name="jsonDirection">进出方向：in（进）out（出）</param>
        /// <param name="jsonDeviceUuid">设备的唯一id</param>
        /// <param name="jsonTimestamp">产生这个gps事件的时间（秒）</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostUserFenceWithHttpInfo (List<int?> jsonRadius, List<string> jsonDirection, List<string> jsonDeviceUuid, List<int?> jsonTimestamp);
        /// <summary>
        /// 发送短信给用户
        /// </summary>
        /// <remarks>
        /// 发送短信给用户
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">app id</param>
        /// <param name="appSecret">app secret</param>
        /// <param name="text">短信内容</param>
        /// <param name="phone">电话号码 (optional)</param>
        /// <returns></returns>
        void PostUserSendSms (string appId, string appSecret, string text, string phone = null);

        /// <summary>
        /// 发送短信给用户
        /// </summary>
        /// <remarks>
        /// 发送短信给用户
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">app id</param>
        /// <param name="appSecret">app secret</param>
        /// <param name="text">短信内容</param>
        /// <param name="phone">电话号码 (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostUserSendSmsWithHttpInfo (string appId, string appSecret, string text, string phone = null);
        /// <summary>
        /// 设置用户的家的位置信息
        /// </summary>
        /// <remarks>
        /// 设置用户的家的位置信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">经度</param>
        /// <param name="latitude">维度</param>
        /// <param name="homeGaodeLat">高德地图里的维度 (optional)</param>
        /// <param name="homeGaodeLong">高德地图里的经度 (optional)</param>
        /// <param name="homeInfo">如果能根据座标获取到一些地址信息，就提供给服务器 (optional)</param>
        /// <returns></returns>
        void PostUserSetHomeInfo (string longitude, string latitude, string homeGaodeLat = null, string homeGaodeLong = null, string homeInfo = null);

        /// <summary>
        /// 设置用户的家的位置信息
        /// </summary>
        /// <remarks>
        /// 设置用户的家的位置信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">经度</param>
        /// <param name="latitude">维度</param>
        /// <param name="homeGaodeLat">高德地图里的维度 (optional)</param>
        /// <param name="homeGaodeLong">高德地图里的经度 (optional)</param>
        /// <param name="homeInfo">如果能根据座标获取到一些地址信息，就提供给服务器 (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostUserSetHomeInfoWithHttpInfo (string longitude, string latitude, string homeGaodeLat = null, string homeGaodeLong = null, string homeInfo = null);
        /// <summary>
        /// 设置用户的睡眠时间
        /// </summary>
        /// <remarks>
        /// 设置用户的睡眠时间
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sleepTime">入睡时间</param>
        /// <param name="wakeTime">起床时间</param>
        /// <returns></returns>
        void PostUserSetSleepTime (int? sleepTime, int? wakeTime);

        /// <summary>
        /// 设置用户的睡眠时间
        /// </summary>
        /// <remarks>
        /// 设置用户的睡眠时间
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sleepTime">入睡时间</param>
        /// <param name="wakeTime">起床时间</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostUserSetSleepTimeWithHttpInfo (int? sleepTime, int? wakeTime);
        /// <summary>
        /// 3rd应用汇报时间流更新
        /// </summary>
        /// <remarks>
        /// 3rd应用汇报时间流更新
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="appSecret"></param>
        /// <returns></returns>
        void PostUserTouchTimeline (string appId, string appSecret);

        /// <summary>
        /// 3rd应用汇报时间流更新
        /// </summary>
        /// <remarks>
        /// 3rd应用汇报时间流更新
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="appSecret"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostUserTouchTimelineWithHttpInfo (string appId, string appSecret);
        /// <summary>
        /// 获取语音留言上传 token(供 Sonos 应用使用)
        /// </summary>
        /// <remarks>
        /// 获取语音留言上传 token(供 Sonos 应用使用)
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="voiceMessage">留言文件名(user_id-timestamp.*)</param>
        /// <returns></returns>
        void PostUserVoiceMessage (string voiceMessage);

        /// <summary>
        /// 获取语音留言上传 token(供 Sonos 应用使用)
        /// </summary>
        /// <remarks>
        /// 获取语音留言上传 token(供 Sonos 应用使用)
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="voiceMessage">留言文件名(user_id-timestamp.*)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostUserVoiceMessageWithHttpInfo (string voiceMessage);
        /// <summary>
        /// 设置用户的语音留言链接
        /// </summary>
        /// <remarks>
        /// 设置用户的语音留言链接
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="qiniuPath">留言文件路径</param>
        /// <returns></returns>
        void PostUserVoiceMessageUrl (string qiniuPath);

        /// <summary>
        /// 设置用户的语音留言链接
        /// </summary>
        /// <remarks>
        /// 设置用户的语音留言链接
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="qiniuPath">留言文件路径</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostUserVoiceMessageUrlWithHttpInfo (string qiniuPath);
        /// <summary>
        /// 修改当前用户的资料
        /// </summary>
        /// <remarks>
        /// 修改当前用户的资料
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="homeLong">用户的家的经度 (optional)</param>
        /// <param name="homeLat">用户的家的纬度 (optional)</param>
        /// <param name="sleepTime">用户的入睡时间 (optional)</param>
        /// <param name="wakeTime">用户的起床时间 (optional)</param>
        /// <param name="homeGaodeLong">用户的家的(高德地图)经度 (optional)</param>
        /// <param name="homeGaodeLat">用户的家的(高德地图)纬度 (optional)</param>
        /// <param name="homeComingScenarioId">用户的回家情景ID (optional)</param>
        /// <param name="homeLeavingScenarioId">用户的离家情景ID (optional)</param>
        /// <returns>User</returns>
        User PutUser (string homeLong = null, string homeLat = null, int? sleepTime = null, int? wakeTime = null, string homeGaodeLong = null, string homeGaodeLat = null, int? homeComingScenarioId = null, int? homeLeavingScenarioId = null);

        /// <summary>
        /// 修改当前用户的资料
        /// </summary>
        /// <remarks>
        /// 修改当前用户的资料
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="homeLong">用户的家的经度 (optional)</param>
        /// <param name="homeLat">用户的家的纬度 (optional)</param>
        /// <param name="sleepTime">用户的入睡时间 (optional)</param>
        /// <param name="wakeTime">用户的起床时间 (optional)</param>
        /// <param name="homeGaodeLong">用户的家的(高德地图)经度 (optional)</param>
        /// <param name="homeGaodeLat">用户的家的(高德地图)纬度 (optional)</param>
        /// <param name="homeComingScenarioId">用户的回家情景ID (optional)</param>
        /// <param name="homeLeavingScenarioId">用户的离家情景ID (optional)</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> PutUserWithHttpInfo (string homeLong = null, string homeLat = null, int? sleepTime = null, int? wakeTime = null, string homeGaodeLong = null, string homeGaodeLat = null, int? homeComingScenarioId = null, int? homeLeavingScenarioId = null);
        /// <summary>
        /// 上传用户头像
        /// </summary>
        /// <remarks>
        /// 上传用户头像
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileName">头像文件名</param>
        /// <returns></returns>
        void PutUserAvatar (string fileName);

        /// <summary>
        /// 上传用户头像
        /// </summary>
        /// <remarks>
        /// 上传用户头像
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileName">头像文件名</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PutUserAvatarWithHttpInfo (string fileName);
        /// <summary>
        /// 报告有几人在家
        /// </summary>
        /// <remarks>
        /// 报告有几人在家
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="people">在家的人数</param>
        /// <returns></returns>
        void PutUserFamily (int? people);

        /// <summary>
        /// 报告有几人在家
        /// </summary>
        /// <remarks>
        /// 报告有几人在家
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="people">在家的人数</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PutUserFamilyWithHttpInfo (int? people);
        /// <summary>
        /// 修改用户昵称
        /// </summary>
        /// <remarks>
        /// 修改用户昵称
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nickname"></param>
        /// <returns></returns>
        void PutUserNickname (string nickname);

        /// <summary>
        /// 修改用户昵称
        /// </summary>
        /// <remarks>
        /// 修改用户昵称
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nickname"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PutUserNicknameWithHttpInfo (string nickname);
        /// <summary>
        /// 为当前用户的依键创建或修改某首选项
        /// </summary>
        /// <remarks>
        /// 为当前用户的依键创建或修改某首选项
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">首选项键</param>
        /// <param name="value">首选项值</param>
        /// <returns>UserPreference</returns>
        UserPreference PutUserPreferences (string key, string value);

        /// <summary>
        /// 为当前用户的依键创建或修改某首选项
        /// </summary>
        /// <remarks>
        /// 为当前用户的依键创建或修改某首选项
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">首选项键</param>
        /// <param name="value">首选项值</param>
        /// <returns>ApiResponse of UserPreference</returns>
        ApiResponse<UserPreference> PutUserPreferencesWithHttpInfo (string key, string value);
        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <remarks>
        /// 修改用户信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">用户名 (optional)</param>
        /// <param name="phone">手机号 (optional)</param>
        /// <returns></returns>
        void PutUserProfile (string name = null, string phone = null);

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <remarks>
        /// 修改用户信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">用户名 (optional)</param>
        /// <param name="phone">手机号 (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PutUserProfileWithHttpInfo (string name = null, string phone = null);
        /// <summary>
        /// 使用一个sharing key
        /// </summary>
        /// <remarks>
        /// 使用一个sharing key
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">key的code</param>
        /// <returns></returns>
        void PutUserUseKey (string code);

        /// <summary>
        /// 使用一个sharing key
        /// </summary>
        /// <remarks>
        /// 使用一个sharing key
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">key的code</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PutUserUseKeyWithHttpInfo (string code);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 为当前用户的依键删除某首选项
        /// </summary>
        /// <remarks>
        /// 为当前用户的依键删除某首选项
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">首选项键</param>
        /// <returns>Task of UserPreference</returns>
        System.Threading.Tasks.Task<UserPreference> DeleteUserPreferencesAsync (string key);

        /// <summary>
        /// 为当前用户的依键删除某首选项
        /// </summary>
        /// <remarks>
        /// 为当前用户的依键删除某首选项
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">首选项键</param>
        /// <returns>Task of ApiResponse (UserPreference)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPreference>> DeleteUserPreferencesAsyncWithHttpInfo (string key);
        /// <summary>
        /// 获取当前用户的资料
        /// </summary>
        /// <remarks>
        /// 获取当前用户的资料
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> GetUserAsync ();

        /// <summary>
        /// 获取当前用户的资料
        /// </summary>
        /// <remarks>
        /// 获取当前用户的资料
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> GetUserAsyncWithHttpInfo ();
        /// <summary>
        /// 获取更改用户密码的短信验证码, 如果手机号码格式正确返回数据为 {success: true, msg: \&quot;已发送短信验证码至xxxxxxx\&quot;}
        /// </summary>
        /// <remarks>
        /// 获取更改用户密码的短信验证码, 如果手机号码格式正确返回数据为 {success: true, msg: \&quot;已发送短信验证码至xxxxxxx\&quot;}
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone">手机号码</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetUserChangePwdCodeAsync (string phone);

        /// <summary>
        /// 获取更改用户密码的短信验证码, 如果手机号码格式正确返回数据为 {success: true, msg: \&quot;已发送短信验证码至xxxxxxx\&quot;}
        /// </summary>
        /// <remarks>
        /// 获取更改用户密码的短信验证码, 如果手机号码格式正确返回数据为 {success: true, msg: \&quot;已发送短信验证码至xxxxxxx\&quot;}
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone">手机号码</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetUserChangePwdCodeAsyncWithHttpInfo (string phone);
        /// <summary>
        /// 查询指定手机号的用户是否存在
        /// </summary>
        /// <remarks>
        /// 查询指定手机号的用户是否存在
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone">手机号</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetUserFindByPhoneAsync (string phone);

        /// <summary>
        /// 查询指定手机号的用户是否存在
        /// </summary>
        /// <remarks>
        /// 查询指定手机号的用户是否存在
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone">手机号</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetUserFindByPhoneAsyncWithHttpInfo (string phone);
        /// <summary>
        /// 老子回家啦！
        /// </summary>
        /// <remarks>
        /// 老子回家啦！
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="distance">距离家的距离 (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetUserIAmBackAsync (int? distance = null);

        /// <summary>
        /// 老子回家啦！
        /// </summary>
        /// <remarks>
        /// 老子回家啦！
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="distance">距离家的距离 (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetUserIAmBackAsyncWithHttpInfo (int? distance = null);
        /// <summary>
        /// 老子出门啦！
        /// </summary>
        /// <remarks>
        /// 老子出门啦！
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetUserIAmOutAsync ();

        /// <summary>
        /// 老子出门啦！
        /// </summary>
        /// <remarks>
        /// 老子出门啦！
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetUserIAmOutAsyncWithHttpInfo ();
        /// <summary>
        /// 某人是否在家
        /// </summary>
        /// <remarks>
        /// 某人是否在家
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruserId">手机端ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetUserPredictAsync (string ruserId);

        /// <summary>
        /// 某人是否在家
        /// </summary>
        /// <remarks>
        /// 某人是否在家
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruserId">手机端ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetUserPredictAsyncWithHttpInfo (string ruserId);
        /// <summary>
        /// 获取当前用户的所有首选项或某首选项
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有首选项或某首选项
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">首选项键，若传递该参数则获取某首选项，否则获取所有首选项 (optional)</param>
        /// <returns>Task of UserPreference</returns>
        System.Threading.Tasks.Task<UserPreference> GetUserPreferencesAsync (string key = null);

        /// <summary>
        /// 获取当前用户的所有首选项或某首选项
        /// </summary>
        /// <remarks>
        /// 获取当前用户的所有首选项或某首选项
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">首选项键，若传递该参数则获取某首选项，否则获取所有首选项 (optional)</param>
        /// <returns>Task of ApiResponse (UserPreference)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPreference>> GetUserPreferencesAsyncWithHttpInfo (string key = null);
        /// <summary>
        /// 获取七牛文件上传 token
        /// </summary>
        /// <remarks>
        /// 获取七牛文件上传 token
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extension">拓展名, 说明文件用途。如: avatar; 多单词使用下划线分割: full_pic。</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetUserQiniuUptokenAsync (string extension);

        /// <summary>
        /// 获取七牛文件上传 token
        /// </summary>
        /// <remarks>
        /// 获取七牛文件上传 token
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extension">拓展名, 说明文件用途。如: avatar; 多单词使用下划线分割: full_pic。</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetUserQiniuUptokenAsyncWithHttpInfo (string extension);
        /// <summary>
        /// 向用户的手机发送语音消息
        /// </summary>
        /// <remarks>
        /// 向用户的手机发送语音消息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone">手机号码</param>
        /// <param name="words">文字</param>
        /// <param name="repeat">循环播放次数(1-3)，缺省 1 次 (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetUserSendVoiceMessageAsync (string phone, string words, int? repeat = null);

        /// <summary>
        /// 向用户的手机发送语音消息
        /// </summary>
        /// <remarks>
        /// 向用户的手机发送语音消息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone">手机号码</param>
        /// <param name="words">文字</param>
        /// <param name="repeat">循环播放次数(1-3)，缺省 1 次 (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetUserSendVoiceMessageAsyncWithHttpInfo (string phone, string words, int? repeat = null);
        /// <summary>
        /// 获取3rd应用时间流顺序
        /// </summary>
        /// <remarks>
        /// 获取3rd应用时间流顺序
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetUserTimelineOrderAsync ();

        /// <summary>
        /// 获取3rd应用时间流顺序
        /// </summary>
        /// <remarks>
        /// 获取3rd应用时间流顺序
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetUserTimelineOrderAsyncWithHttpInfo ();
        /// <summary>
        /// 获取当前用户的家的当前天气
        /// </summary>
        /// <remarks>
        /// 获取当前用户的家的当前天气
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Weather</returns>
        System.Threading.Tasks.Task<Weather> GetUserWeatherAsync ();

        /// <summary>
        /// 获取当前用户的家的当前天气
        /// </summary>
        /// <remarks>
        /// 获取当前用户的家的当前天气
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Weather)</returns>
        System.Threading.Tasks.Task<ApiResponse<Weather>> GetUserWeatherAsyncWithHttpInfo ();
        /// <summary>
        /// 第三方应用向用户发送推送通知
        /// </summary>
        /// <remarks>
        /// 第三方应用向用户发送推送通知
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">第三方应用的id</param>
        /// <param name="appSecret">第三方应用的密钥</param>
        /// <param name="text">通知显示的内容</param>
        /// <param name="action">点击通知后要执行的动作</param>
        /// <param name="actionContent">点击通知后要执行的动作的内容</param>
        /// <param name="message">传给第三方应用的消息，JSON对象 (optional)</param>
        /// <param name="appVersion">第三方应用的版本，x.y.z (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostUser3rdPushAsync (string appId, string appSecret, string text, string action, string actionContent, string message = null, string appVersion = null);

        /// <summary>
        /// 第三方应用向用户发送推送通知
        /// </summary>
        /// <remarks>
        /// 第三方应用向用户发送推送通知
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">第三方应用的id</param>
        /// <param name="appSecret">第三方应用的密钥</param>
        /// <param name="text">通知显示的内容</param>
        /// <param name="action">点击通知后要执行的动作</param>
        /// <param name="actionContent">点击通知后要执行的动作的内容</param>
        /// <param name="message">传给第三方应用的消息，JSON对象 (optional)</param>
        /// <param name="appVersion">第三方应用的版本，x.y.z (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostUser3rdPushAsyncWithHttpInfo (string appId, string appSecret, string text, string action, string actionContent, string message = null, string appVersion = null);
        /// <summary>
        /// 更改用户密码, 返回数据格式为 {success: boolean, msg: string}
        /// </summary>
        /// <remarks>
        /// 更改用户密码, 返回数据格式为 {success: boolean, msg: string}
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone">用户的手机号，必须是接收验证码的号码</param>
        /// <param name="newPassword">新密码</param>
        /// <param name="verifyCode">验证码</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostUserChangePwdAsync (string phone, string newPassword, string verifyCode);

        /// <summary>
        /// 更改用户密码, 返回数据格式为 {success: boolean, msg: string}
        /// </summary>
        /// <remarks>
        /// 更改用户密码, 返回数据格式为 {success: boolean, msg: string}
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone">用户的手机号，必须是接收验证码的号码</param>
        /// <param name="newPassword">新密码</param>
        /// <param name="verifyCode">验证码</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostUserChangePwdAsyncWithHttpInfo (string phone, string newPassword, string verifyCode);
        /// <summary>
        /// app报告地理围栏的进出数据
        /// </summary>
        /// <remarks>
        /// app报告地理围栏的进出数据
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jsonRadius">地理围栏的半径（米）</param>
        /// <param name="jsonDirection">进出方向：in（进）out（出）</param>
        /// <param name="jsonDeviceUuid">设备的唯一id</param>
        /// <param name="jsonTimestamp">产生这个gps事件的时间（秒）</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostUserFenceAsync (List<int?> jsonRadius, List<string> jsonDirection, List<string> jsonDeviceUuid, List<int?> jsonTimestamp);

        /// <summary>
        /// app报告地理围栏的进出数据
        /// </summary>
        /// <remarks>
        /// app报告地理围栏的进出数据
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jsonRadius">地理围栏的半径（米）</param>
        /// <param name="jsonDirection">进出方向：in（进）out（出）</param>
        /// <param name="jsonDeviceUuid">设备的唯一id</param>
        /// <param name="jsonTimestamp">产生这个gps事件的时间（秒）</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostUserFenceAsyncWithHttpInfo (List<int?> jsonRadius, List<string> jsonDirection, List<string> jsonDeviceUuid, List<int?> jsonTimestamp);
        /// <summary>
        /// 发送短信给用户
        /// </summary>
        /// <remarks>
        /// 发送短信给用户
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">app id</param>
        /// <param name="appSecret">app secret</param>
        /// <param name="text">短信内容</param>
        /// <param name="phone">电话号码 (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostUserSendSmsAsync (string appId, string appSecret, string text, string phone = null);

        /// <summary>
        /// 发送短信给用户
        /// </summary>
        /// <remarks>
        /// 发送短信给用户
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">app id</param>
        /// <param name="appSecret">app secret</param>
        /// <param name="text">短信内容</param>
        /// <param name="phone">电话号码 (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostUserSendSmsAsyncWithHttpInfo (string appId, string appSecret, string text, string phone = null);
        /// <summary>
        /// 设置用户的家的位置信息
        /// </summary>
        /// <remarks>
        /// 设置用户的家的位置信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">经度</param>
        /// <param name="latitude">维度</param>
        /// <param name="homeGaodeLat">高德地图里的维度 (optional)</param>
        /// <param name="homeGaodeLong">高德地图里的经度 (optional)</param>
        /// <param name="homeInfo">如果能根据座标获取到一些地址信息，就提供给服务器 (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostUserSetHomeInfoAsync (string longitude, string latitude, string homeGaodeLat = null, string homeGaodeLong = null, string homeInfo = null);

        /// <summary>
        /// 设置用户的家的位置信息
        /// </summary>
        /// <remarks>
        /// 设置用户的家的位置信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">经度</param>
        /// <param name="latitude">维度</param>
        /// <param name="homeGaodeLat">高德地图里的维度 (optional)</param>
        /// <param name="homeGaodeLong">高德地图里的经度 (optional)</param>
        /// <param name="homeInfo">如果能根据座标获取到一些地址信息，就提供给服务器 (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostUserSetHomeInfoAsyncWithHttpInfo (string longitude, string latitude, string homeGaodeLat = null, string homeGaodeLong = null, string homeInfo = null);
        /// <summary>
        /// 设置用户的睡眠时间
        /// </summary>
        /// <remarks>
        /// 设置用户的睡眠时间
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sleepTime">入睡时间</param>
        /// <param name="wakeTime">起床时间</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostUserSetSleepTimeAsync (int? sleepTime, int? wakeTime);

        /// <summary>
        /// 设置用户的睡眠时间
        /// </summary>
        /// <remarks>
        /// 设置用户的睡眠时间
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sleepTime">入睡时间</param>
        /// <param name="wakeTime">起床时间</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostUserSetSleepTimeAsyncWithHttpInfo (int? sleepTime, int? wakeTime);
        /// <summary>
        /// 3rd应用汇报时间流更新
        /// </summary>
        /// <remarks>
        /// 3rd应用汇报时间流更新
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="appSecret"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostUserTouchTimelineAsync (string appId, string appSecret);

        /// <summary>
        /// 3rd应用汇报时间流更新
        /// </summary>
        /// <remarks>
        /// 3rd应用汇报时间流更新
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="appSecret"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostUserTouchTimelineAsyncWithHttpInfo (string appId, string appSecret);
        /// <summary>
        /// 获取语音留言上传 token(供 Sonos 应用使用)
        /// </summary>
        /// <remarks>
        /// 获取语音留言上传 token(供 Sonos 应用使用)
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="voiceMessage">留言文件名(user_id-timestamp.*)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostUserVoiceMessageAsync (string voiceMessage);

        /// <summary>
        /// 获取语音留言上传 token(供 Sonos 应用使用)
        /// </summary>
        /// <remarks>
        /// 获取语音留言上传 token(供 Sonos 应用使用)
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="voiceMessage">留言文件名(user_id-timestamp.*)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostUserVoiceMessageAsyncWithHttpInfo (string voiceMessage);
        /// <summary>
        /// 设置用户的语音留言链接
        /// </summary>
        /// <remarks>
        /// 设置用户的语音留言链接
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="qiniuPath">留言文件路径</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostUserVoiceMessageUrlAsync (string qiniuPath);

        /// <summary>
        /// 设置用户的语音留言链接
        /// </summary>
        /// <remarks>
        /// 设置用户的语音留言链接
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="qiniuPath">留言文件路径</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostUserVoiceMessageUrlAsyncWithHttpInfo (string qiniuPath);
        /// <summary>
        /// 修改当前用户的资料
        /// </summary>
        /// <remarks>
        /// 修改当前用户的资料
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="homeLong">用户的家的经度 (optional)</param>
        /// <param name="homeLat">用户的家的纬度 (optional)</param>
        /// <param name="sleepTime">用户的入睡时间 (optional)</param>
        /// <param name="wakeTime">用户的起床时间 (optional)</param>
        /// <param name="homeGaodeLong">用户的家的(高德地图)经度 (optional)</param>
        /// <param name="homeGaodeLat">用户的家的(高德地图)纬度 (optional)</param>
        /// <param name="homeComingScenarioId">用户的回家情景ID (optional)</param>
        /// <param name="homeLeavingScenarioId">用户的离家情景ID (optional)</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> PutUserAsync (string homeLong = null, string homeLat = null, int? sleepTime = null, int? wakeTime = null, string homeGaodeLong = null, string homeGaodeLat = null, int? homeComingScenarioId = null, int? homeLeavingScenarioId = null);

        /// <summary>
        /// 修改当前用户的资料
        /// </summary>
        /// <remarks>
        /// 修改当前用户的资料
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="homeLong">用户的家的经度 (optional)</param>
        /// <param name="homeLat">用户的家的纬度 (optional)</param>
        /// <param name="sleepTime">用户的入睡时间 (optional)</param>
        /// <param name="wakeTime">用户的起床时间 (optional)</param>
        /// <param name="homeGaodeLong">用户的家的(高德地图)经度 (optional)</param>
        /// <param name="homeGaodeLat">用户的家的(高德地图)纬度 (optional)</param>
        /// <param name="homeComingScenarioId">用户的回家情景ID (optional)</param>
        /// <param name="homeLeavingScenarioId">用户的离家情景ID (optional)</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> PutUserAsyncWithHttpInfo (string homeLong = null, string homeLat = null, int? sleepTime = null, int? wakeTime = null, string homeGaodeLong = null, string homeGaodeLat = null, int? homeComingScenarioId = null, int? homeLeavingScenarioId = null);
        /// <summary>
        /// 上传用户头像
        /// </summary>
        /// <remarks>
        /// 上传用户头像
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileName">头像文件名</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PutUserAvatarAsync (string fileName);

        /// <summary>
        /// 上传用户头像
        /// </summary>
        /// <remarks>
        /// 上传用户头像
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileName">头像文件名</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PutUserAvatarAsyncWithHttpInfo (string fileName);
        /// <summary>
        /// 报告有几人在家
        /// </summary>
        /// <remarks>
        /// 报告有几人在家
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="people">在家的人数</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PutUserFamilyAsync (int? people);

        /// <summary>
        /// 报告有几人在家
        /// </summary>
        /// <remarks>
        /// 报告有几人在家
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="people">在家的人数</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PutUserFamilyAsyncWithHttpInfo (int? people);
        /// <summary>
        /// 修改用户昵称
        /// </summary>
        /// <remarks>
        /// 修改用户昵称
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nickname"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PutUserNicknameAsync (string nickname);

        /// <summary>
        /// 修改用户昵称
        /// </summary>
        /// <remarks>
        /// 修改用户昵称
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nickname"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PutUserNicknameAsyncWithHttpInfo (string nickname);
        /// <summary>
        /// 为当前用户的依键创建或修改某首选项
        /// </summary>
        /// <remarks>
        /// 为当前用户的依键创建或修改某首选项
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">首选项键</param>
        /// <param name="value">首选项值</param>
        /// <returns>Task of UserPreference</returns>
        System.Threading.Tasks.Task<UserPreference> PutUserPreferencesAsync (string key, string value);

        /// <summary>
        /// 为当前用户的依键创建或修改某首选项
        /// </summary>
        /// <remarks>
        /// 为当前用户的依键创建或修改某首选项
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">首选项键</param>
        /// <param name="value">首选项值</param>
        /// <returns>Task of ApiResponse (UserPreference)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserPreference>> PutUserPreferencesAsyncWithHttpInfo (string key, string value);
        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <remarks>
        /// 修改用户信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">用户名 (optional)</param>
        /// <param name="phone">手机号 (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PutUserProfileAsync (string name = null, string phone = null);

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <remarks>
        /// 修改用户信息
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">用户名 (optional)</param>
        /// <param name="phone">手机号 (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PutUserProfileAsyncWithHttpInfo (string name = null, string phone = null);
        /// <summary>
        /// 使用一个sharing key
        /// </summary>
        /// <remarks>
        /// 使用一个sharing key
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">key的code</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PutUserUseKeyAsync (string code);

        /// <summary>
        /// 使用一个sharing key
        /// </summary>
        /// <remarks>
        /// 使用一个sharing key
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">key的code</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PutUserUseKeyAsyncWithHttpInfo (string code);
        #endregion Asynchronous Operations
    }
}

namespace Elton.Phantom
{
    partial class PhantomApi //: Api.Version1.IBulbsApi
    {
    }
}