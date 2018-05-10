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

using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization;

namespace Elton.Phantom.Rest
{
    [DataContract]
    public class ApiConfiguration
    {
        [DataMember(Name = "baseUrl")]
        public string BaseUrl { get; set; }
        [DataMember(Name = "authorizationUrl")]
        public string AuthorizationUrl { get; set; }
        [DataMember(Name = "refreshTokenUrl")]
        public string RefreshTokenUrl { get; set; }
        [DataMember(Name = "accessTokenUrl")]
        public string AccessTokenUrl { get; set; }
        [DataMember(Name = "revokeTokenUrl")]
        public string RevokeTokenUrl { get; set; }

        [DataMember(Name = "appId")]
        public string ApplicationId { get; set; }
        [DataMember(Name = "appSecret")]
        public string ApplicationSecret { get; set; }

        [DataMember(Name = "redirectUri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Gets the HTTP connection timeout (in milliseconds). Default to 100000 milliseconds.
        /// </summary>
        /// <value>HTTP connection timeout.</value>
        [DataMember(Name = "timeout")]
        public int Timeout { get; set; } = 100000;
        /// <summary>
        /// 客户端的 User-Agent。
        /// </summary>
        [DataMember(Name = "userAgent")]
        public string UserAgent { get; set; } = "eltonfan@live.cn/1.0.0 (Windows 10)";

        /// <summary>
        /// 请求的时间间隔。（毫秒）
        /// </summary>
        public int RequestInterval { get; set; } = 20 * 1000;

        [JsonConstructor]
        protected ApiConfiguration() { }

        public ApiConfiguration(string baseUrl = default, string authorizationUrl = default, string accessTokenUrl = default, string refreshTokenUrl = default, string revokeTokenUrl = default,
            string appId = default, string appSecret = default, string redirectUri = default)
        {
            this.BaseUrl = baseUrl;
            this.AuthorizationUrl = authorizationUrl;
            this.AccessTokenUrl = accessTokenUrl;
            this.RefreshTokenUrl = refreshTokenUrl;
            this.RevokeTokenUrl = revokeTokenUrl;
            this.ApplicationId = appId;
            this.ApplicationSecret = appSecret;
            this.RedirectUri = redirectUri;
        }

        public virtual string GetAuthorizationUrl(string appId = default, string redirectUri = default, string state = default, int theme = default)
        {
            return $"{AuthorizationUrl}?client_id={appId}&response_type=code&redirect_uri={redirectUri}&state={state}&theme={theme}";
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
                    _tempFolderPath = Path.GetTempPath();
                    return;
                }

                // create the directory if it does not exist
                if (!Directory.Exists(value))
                    Directory.CreateDirectory(value);

                // check if the path contains directory separator at the end
                if (value[value.Length - 1] == Path.DirectorySeparatorChar)
                    _tempFolderPath = value;
                else
                    _tempFolderPath = value + Path.DirectorySeparatorChar;
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
}