using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elton.Phantom.Models;
using Newtonsoft.Json;
using System.IO;
using Elton.Phantom.Tests.Properties;

namespace Elton.Phantom.Tests
{
    [TestClass]
    public class UnitTest1
    {
        PhantomConfiguration appConfig;
        TokenConfig tokenConfig;
        PhantomApi api = null;
        [TestInitialize]
        public void Initialize()
        {
            dynamic config = new
            {
                app = new PhantomConfiguration(),
                token = new TokenConfig(),
            };

            var configFile = Path.Combine(Settings.Default.ConfigPath, "phantom.json");
            var jsonString = File.ReadAllText(configFile);
            config = JsonConvert.DeserializeAnonymousType(jsonString, config);

            appConfig = config.app;
            tokenConfig = config.token;

            api = new PhantomApi(appConfig);
        }

        [TestMethod]
        public void TestMethod1()
        {
            bool isOK = api.Ping();
            api.SetCredentials(tokenConfig.AccessToken);

            var user = api.GetUser();
            //api.RefreshToken();
            
            Bulb[] listBulbs = api.GetBulbs();
            Bulb bulb = api.GetBulb(listBulbs[0].Id);
            api.SetBulbSwitchOff(listBulbs[0].Id);
            api.SetBulbSwitchOn(listBulbs[0].Id);
            api.SetBulbTune(listBulbs[0].Id, 0.5F, 0.5F);

            var listScenarios = api.GetScenarios(0);
            api.SetScenario(listScenarios[0].Id);
            api.SetScenarioAllOff();
            api.SetScenarioAllOn();
        }
    }
}
