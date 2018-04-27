using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom.Tests
{
    public class PhantomContext
    {
        static PhantomContext instance = null;
        public static PhantomContext Default
        {
            get
            {
                if (instance == null)
                    instance = new PhantomContext();

                return instance;
            }
        }

        readonly Properties.Settings settings = Properties.Settings.Default;
        readonly PhantomConfiguration appConfig;
        readonly TokenConfig tokenConfig;
        readonly PhantomClient phantom;
        private PhantomContext()
        {
            appConfig = settings.ReadConfig<PhantomConfiguration>("phantom");
            tokenConfig = settings.ReadConfig<TokenConfig>("phantom.token");

            phantom = new PhantomClient(appConfig);
            phantom.SetCredentials(tokenConfig.AccessToken);
        }

        public void SaveToken()
        {
            settings.WriteConfig("phantom.token", tokenConfig);
        }

        public static string GetJsonString(string category, string fileName)
        {
            var fullName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "examples", category, fileName);
            if (!File.Exists(fullName))
                throw new FileNotFoundException("Json file is not exists.", fullName);

            return File.ReadAllText(fullName, Encoding.UTF8);
        }

        public static PhantomClient Phantom => Default.phantom;
        public static PhantomConfiguration Config => Default.appConfig;
        public static TokenConfig Token => Default.tokenConfig;
    }
}
