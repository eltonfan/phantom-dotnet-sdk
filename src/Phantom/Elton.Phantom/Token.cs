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
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Elton.Phantom
{
    /// <summary>
    /// 刷新一个令牌
    /// </summary>
    /// <remarks>
    /// https://github.com/HuanTeng/huanteng.github.io/blob/master/oauth.md
    /// 文档有误，以下两个字段不存在：user_agent / timestamp
    /// 实际多出两个字段：created_at / scope
    /// </remarks>
    [DataContract]
    public partial class Token : Elton.OAuth2.Token, Elton.OAuth2.IToken, IEquatable<Token>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Token" /> class.
        /// </summary>
        [JsonConstructor]
        protected Token() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Token" /> class.
        /// </summary>
        /// <param name="AccessToken">访问令牌 cf. RFC6749 (required).</param>
        /// <param name="TokenType">设备的名字 cf. RFC6749 (required).</param>
        /// <param name="RefreshToken">刷新令牌 cf. RFC6749 (required).</param>
        /// <param name="ExpiresIn">几秒后过期 cf. RFC6749 (required).</param>
        /// <param name="UserAgent">客户端.</param>
        /// <param name="Timestamp">utc的时间戳 (单位: 秒).</param>
        public Token(string AccessToken = default, string TokenType = default, string RefreshToken = default,
            int? ExpiresIn = default, string OpenId = default, string State = default,
            string UserAgent = default, int? Timestamp = default)
            : base(AccessToken, TokenType, RefreshToken, ExpiresIn, OpenId, State)
        {
            this.UserAgent = UserAgent;
            this.Timestamp = Timestamp;
        }

        /// <summary>
        /// 客户端
        /// </summary>
        /// <value>客户端</value>
        [Obsolete]
        [DataMember(Name="user_agent", EmitDefaultValue=false)]
        public string UserAgent { get; set; }

        /// <summary>
        /// utc的时间戳 (单位: 秒)
        /// </summary>
        /// <value>utc的时间戳 (单位: 秒)</value>
        [Obsolete]
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public int? Timestamp { get; set; }

        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public int CreatedAt { get; set; }

        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public string Scopes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Token);
        }

        /// <summary>
        /// Returns true if Token instances are equal
        /// </summary>
        /// <param name="input">Instance of Token to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Token input)
        {
            if (input == null)
                return false;

            return base.Equals(input)
                && 
                (
                    this.UserAgent == input.UserAgent ||
                    (this.UserAgent != null &&
                    this.UserAgent.Equals(input.UserAgent))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.UserAgent != null)
                    hashCode = hashCode * 59 + this.UserAgent.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                return hashCode;
            }
        }

        public override void CopyFrom(Elton.OAuth2.IToken target)
        {
            base.CopyFrom(target);

            var token = target as Token;
            if (token != null)
            {
                this.UserAgent = token.UserAgent;
                this.Timestamp = token.Timestamp;
                this.CreatedAt = token.CreatedAt;
                this.Scopes = token.Scopes;
            }
        }
    }
}
