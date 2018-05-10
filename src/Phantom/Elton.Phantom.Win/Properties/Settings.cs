using Elton.Phantom.Rest;
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
        readonly Elton.Utils.OneDrive oneDrive = null;
        public Settings()
        {
            oneDrive = new Utils.OneDrive(@"ApplicationData\ConnectedHome\config");
        }

        public PhantomConfiguration LoadConfig()
        {
            return oneDrive.ReadConfig<PhantomConfiguration>("phantom.json");
        }

        public Token LoadToken()
        {
            return oneDrive.ReadConfig<Token>("phantom.token.json");
        }

        public void SaveToken(Token token)
        {
            oneDrive.WriteConfig<Token>("phantom.token.json", token);
        }
    }
}
