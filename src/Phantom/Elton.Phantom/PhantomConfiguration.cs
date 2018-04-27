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

using Elton.Phantom.Models.Version1;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom
{
    /// <summary>
    /// 幻腾接口配置。（配置客户端信息）
    /// 从 https://huantengsmart.com/oauth2/applications 获取 Application 信息。
    /// </summary>
    public class PhantomConfiguration
    {
        [JsonProperty("appId")]
        public string ApplicationId { get; set; }
        [JsonProperty("appSecret")]
        public string ApplicationSecret { get; set; }
        [JsonProperty("redirectUri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Gets the HTTP connection timeout (in milliseconds). Default to 100000 milliseconds.
        /// </summary>
        /// <value>HTTP connection timeout.</value>
        [JsonProperty("timeout")]
        public int Timeout { get; set; } = 100000;
        /// <summary>
        /// 客户端的 User-Agent。
        /// </summary>
        [JsonProperty("userAgent")]
        public string UserAgent { get; set; } = "eltonfan@live.cn/1.0.0 (Windows 10)";
        /// <summary>
        /// 请求的时间间隔。（毫秒）
        /// </summary>
        public int RequestInterval { get; set; } = 20 * 1000;

        public PhantomConfiguration()
        { }

        public PhantomConfiguration(string appId, string appSecret, string redirectUri)
        {
            this.ApplicationId = appId;
            this.ApplicationSecret = appSecret;
            this.RedirectUri = redirectUri;
        }

        private string _tempFolderPath = Path.GetTempPath();

        /// <summary>
        /// Gets or sets the temporary folder path to store the files downloaded from the server.
        /// </summary>
        /// <value>Folder path.</value>
        public virtual string TempFolderPath
        {
            get { return _tempFolderPath; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // Possible breaking change since swagger-codegen 2.2.1, enforce a valid temporary path on set.
                    _tempFolderPath = Path.GetTempPath();
                    return;
                }

                // create the directory if it does not exist
                if (!Directory.Exists(value))
                {
                    Directory.CreateDirectory(value);
                }

                // check if the path contains directory separator at the end
                if (value[value.Length - 1] == Path.DirectorySeparatorChar)
                {
                    _tempFolderPath = value;
                }
                else
                {
                    _tempFolderPath = value + Path.DirectorySeparatorChar;
                }
            }
        }

        /// <summary>
        /// Identifier for ISO 8601 DateTime Format
        /// </summary>
        /// <remarks>See https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8 for more information.</remarks>
        // ReSharper disable once InconsistentNaming
        public const string ISO8601_DATETIME_FORMAT = "o";

        private string _dateTimeFormat = ISO8601_DATETIME_FORMAT;
        /// <summary>
        /// Gets or sets the the date time format used when serializing in the ApiClient
        /// By default, it's set to ISO 8601 - "o", for others see:
        /// https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
        /// and https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
        /// No validation is done to ensure that the string you're providing is valid
        /// </summary>
        /// <value>The DateTimeFormat string</value>
        public virtual string DateTimeFormat
        {
            get { return _dateTimeFormat; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // Never allow a blank or null string, go back to the default
                    _dateTimeFormat = ISO8601_DATETIME_FORMAT;
                    return;
                }

                // Caution, no validation when you choose date time format other than ISO 8601
                // Take a look at the above links
                _dateTimeFormat = value;
            }
        }
    }

    public class TokenConfig
    {
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
        [JsonProperty("refreshToken")]
        public string RefreshToken { get; set; }
        [JsonProperty("scope")]
        public string Scopes { get; set; }
        [JsonProperty("expiresIn")]
        public int? ExpiresIn { get; set; }
        [JsonProperty("createdAt")]
        public int? CreatedAt { get; set; }

        [JsonIgnore]
        public DateTime DateExpired
        {
            get => DateCreated.AddSeconds((int)ExpiresIn);
            set => ExpiresIn = (int)value.Subtract(DateCreated).TotalSeconds;
        }

        [JsonIgnore]
        public DateTime DateCreated
        {
            get => new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds((int)CreatedAt);
            set => CreatedAt = (int)value.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }

        public void CopyFrom(Token token)
        {
            this.AccessToken = token.AccessToken;
            this.RefreshToken = token.RefreshToken;
            this.Scopes = token.Scopes;
            this.ExpiresIn = token.ExpiresIn;
            this.CreatedAt = token.CreatedAt;
        }
    }
}