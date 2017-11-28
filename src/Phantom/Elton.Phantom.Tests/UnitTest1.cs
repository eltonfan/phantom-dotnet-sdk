using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elton.Phantom.Models;

namespace Elton.Phantom.Tests
{
    [TestClass]
    public class UnitTest1
    {
        Version1.PhantomAPI api = null;
        public Version1.PhantomAPI GetApi()
        {
            if (api == null)
                api = new Version1.PhantomAPI(PhantomConfiguration.Default);
            return api;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var api = GetApi();
        }

        public void TestAPI(string token)
        {
            var api = GetApi();
            bool isOK = api.Ping();
            api.SetCredentials(token);

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
