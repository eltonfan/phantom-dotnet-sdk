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

using System.Text;
using System.Runtime.Serialization;

namespace Elton.Phantom.Rest
{
    public interface IToken
    {
        /// <summary>
        /// 访问令牌 cf. RFC6749
        /// </summary>
        /// <value>访问令牌 cf. RFC6749</value>
        string AccessToken { get; set; }

        /// <summary>
        /// 设备的名字 cf. RFC6749
        /// </summary>
        /// <value>设备的名字 cf. RFC6749</value>
        string TokenType { get; set; }

        /// <summary>
        /// 刷新令牌 cf. RFC6749
        /// </summary>
        /// <value>刷新令牌 cf. RFC6749</value>
        string RefreshToken { get; set; }

        /// <summary>
        /// 几秒后过期 cf. RFC6749
        /// </summary>
        /// <value>几秒后过期 cf. RFC6749</value>
        int? ExpiresIn { get; set; }

        /// <summary>
        /// 授权用户的唯一标识
        /// </summary>
        /// <value></value>
        string OpenId { get; set; }

        /// <summary>
        /// 取值为任意字符串，认证服务器将原样返回该参数
        /// </summary>
        /// <value></value>
        string State { get; set; }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        string ToJson();

        void CopyFrom(IToken target);
    }
}
