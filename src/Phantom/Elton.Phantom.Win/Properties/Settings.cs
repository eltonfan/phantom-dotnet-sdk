using Newtonsoft.Json;
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

        public PhantomConfiguration LoadConfig()
        {
            var configFile = Path.Combine(configPath, "phantom.json");
            var jsonString = File.ReadAllText(configFile);
            return JsonConvert.DeserializeObject<PhantomConfiguration>(jsonString);
        }

        public TokenConfig LoadToken()
        {
            var configFile = Path.Combine(configPath, "phantom.token.json");
            if (!File.Exists(configFile))
                return null;
            var jsonString = File.ReadAllText(configFile, Encoding.UTF8);
            return JsonConvert.DeserializeObject<TokenConfig>(jsonString);
        }

        public void SaveToken(TokenConfig token)
        {
            var jsonString = JsonConvert.SerializeObject(token);
            var configFile = Path.Combine(configPath, "phantom.token.json");
            File.WriteAllText(configFile, jsonString, Encoding.UTF8);
        }

        public string ConfigPath => configPath;
    }
}
