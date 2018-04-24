using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elton.Phantom.Models;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace Elton.Phantom.Tests
{
    [TestClass]
    public class PhantomApiTest
    {
        Properties.Settings settings = null;
        PhantomConfiguration appConfig;
        TokenConfig tokenConfig;
        PhantomApi api = null;
        [TestInitialize]
        public void Initialize()
        {
            settings = Properties.Settings.Default;

            appConfig = settings.ReadConfig<PhantomConfiguration>("phantom");
            tokenConfig = settings.ReadConfig<TokenConfig>("phantom.token");

            api = new PhantomApi(appConfig);
        }

        [TestMethod]
        public void TestPing()
        {
            Assert.IsTrue(api.Ping(), "Failed to ping.");
        }

        [TestMethod]
        public void TestRefreshToken()
        {
            api.SetCredentials(tokenConfig.AccessToken);
            var token = api.RefreshToken(tokenConfig.RefreshToken);

            tokenConfig.CopyFrom(token);

            settings.WriteConfig("phantom.token", tokenConfig);
        }

        [TestMethod]
        public void TestGetUser()
        {
            api.SetCredentials(tokenConfig.AccessToken);
            var user = api.GetUser();
            Assert.IsNotNull(user, "Failed to get user.");
        }

        [TestMethod]
        public void TestGetBulbs()
        {
            //Bulb[] listBulbs = api.GetBulbs();
            //Bulb bulb = api.GetBulb(listBulbs[0].Id);
            //api.SetBulbSwitchOff(listBulbs[0].Id);
            //api.SetBulbSwitchOn(listBulbs[0].Id);
            //api.SetBulbTune(listBulbs[0].Id, 0.5F, 0.5F);

            //var listScenarios = api.GetScenarios(0);
            //Task.Delay(5000).Wait();
            //api.SetScenario(listScenarios[0].Id);
            //Task.Delay(5000).Wait();
            //api.SetScenarioAllOff();
            //Task.Delay(5000).Wait();
            //api.SetScenarioAllOn();
        }

        [TestMethod]
        public void TestAllDevice()
        {
            Assert.IsTrue(false, "请慎重，将开关所有设备");
            //请慎重，将开关所有设备
            api.SetCredentials(tokenConfig.AccessToken);

            //api.SetScenarioAllOn();
            //Task.Delay(5000).Wait();
            //api.SetScenarioAllOff();
        }
    }
}
