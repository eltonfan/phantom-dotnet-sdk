using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom.Win.Properties
{
    partial class Settings
    {
        [DllImport("Shell32.dll")]
        static extern int SHGetKnownFolderPath(
            [MarshalAs(UnmanagedType.LPStruct)]Guid rfid, uint dwFlags, IntPtr hToken,
            out IntPtr ppszPath);

        public static string GetOneDrivePath()
        {
            var skyDriveGuid = new Guid("{A52BBA46-E9E1-435F-B3D9-28DAA648C0F6}");
            var flags = 0x00004000; //DontVerify
            var defaultUser = false;

            IntPtr outPath;
            int result = SHGetKnownFolderPath(skyDriveGuid,
                (uint)flags, new IntPtr(defaultUser ? -1 : 0), out outPath);
            if (result >= 0)
            {
                return Marshal.PtrToStringUni(outPath);
            }
            else
            {
                throw new ExternalException("Unable to retrieve the known folder path. It may not "
                    + "be available on this system.", result);
            }
        }

        readonly string basePath = null;
        readonly string configPath = null;
        public Settings()
        {
            basePath = Path.Combine(
                GetOneDrivePath(),
                @"ApplicationData\ConnectedHome\");

            configPath = Path.Combine(basePath, "config");
        }

        public string ConfigPath => configPath;

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
