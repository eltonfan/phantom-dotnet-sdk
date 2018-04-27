using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elton.Phantom.Models;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace Elton.Phantom.Tests
{
    [TestClass]
    public class PhantomApiTest
    {
        Properties.Settings settings = null;
        PhantomConfiguration appConfig;
        TokenConfig tokenConfig;
        PhantomClient phantom = null;
        [TestInitialize]
        public void Initialize()
        {
            settings = Properties.Settings.Default;

            appConfig = settings.ReadConfig<PhantomConfiguration>("phantom");
            tokenConfig = settings.ReadConfig<TokenConfig>("phantom.token");

            phantom = new PhantomClient(appConfig);
            phantom.SetCredentials(tokenConfig.AccessToken);
        }

        [TestMethod]
        public void TestPing()
        {
            phantom.Ping(1);
            phantom.Ping(2);
        }

        [TestMethod]
        public void TestRefreshToken()
        {
            var token = phantom.RefreshToken(tokenConfig.RefreshToken);

            tokenConfig.CopyFrom(token);

            settings.WriteConfig("phantom.token", tokenConfig);
        }

        [TestMethod]
        public void TestGetUser()
        {
            var user = phantom.GetUser();
            Assert.IsNotNull(user, "Failed to get user.");
        }

        [TestMethod]
        public void TestGetBulbs()
        {
            var listBulbs = phantom.GetBulbs();

            var badDevice = listBulbs.First(p => p.Connectivity != "在线");
            phantom.SetBulb(badDevice.Id.Value, false);

            var detailsList = phantom.GetBulbs(true);
            var bulb = phantom.GetBulb(listBulbs.First().Id.Value);
            var isOn = bulb.TurnedOn;
            phantom.SetBulb(bulb, true);
            phantom.SetBulb(bulb, false);
            phantom.SetBulb(bulb, isOn != 0);

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
            //api.SetScenarioAllOn();
            //Task.Delay(5000).Wait();
            //api.SetScenarioAllOff();
        }
    }
}
