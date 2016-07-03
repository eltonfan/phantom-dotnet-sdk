using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mavplus.Phantom.Win.Properties
{
    partial class Settings
    {
        static byte[] s_aditionalEntropy = { 0x1D, 0xA4, 0x9F, 0x3B, 0x21 };

        string Unprotect(string encrypted)
        {
            if (string.IsNullOrEmpty(encrypted))
                return "";

            try
            {
                byte[] encryptedData = Convert.FromBase64String(encrypted);
                byte[] userData = ProtectedData.Unprotect(encryptedData, s_aditionalEntropy, DataProtectionScope.CurrentUser);
                return Encoding.UTF8.GetString(userData);
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        string Protect(string str)
        {
            if (string.IsNullOrEmpty(str))
                return "";

            try
            {
                byte[] userData = Encoding.UTF8.GetBytes(str);
                byte[] encryptedData = ProtectedData.Protect(userData, s_aditionalEntropy, DataProtectionScope.CurrentUser);
                return Convert.ToBase64String(encryptedData);
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        /// <summary>
        /// 访问API的令牌。
        /// </summary>
        public string AccessToken
        {
            get { return Unprotect(this.AccessTokenData); }
            set { this.AccessTokenData = Protect(value); }
        }
        public string LoginPassword
        {
            get { return Unprotect(this.LoginPasswordData); }
            set { this.LoginPasswordData = Protect(value); }
        }

        /// <summary>
        /// 访问API的令牌。
        /// </summary>
        public string RefreshToken
        {
            get { return Unprotect(this.RefreshTokenData); }
            set { this.RefreshTokenData = Protect(value); }
        }
    }
}
