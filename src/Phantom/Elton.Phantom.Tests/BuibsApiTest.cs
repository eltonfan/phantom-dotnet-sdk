using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elton.Phantom.Models;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using Elton.Phantom.Models.Version1;

namespace Elton.Phantom.Tests
{
    [TestClass]
    public class BuibsApiTest
    {
        public TestContext TestContext { get; set; }

        private JsonSerializerSettings serializerSettings = new JsonSerializerSettings
        {
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
        };
        [TestMethod]
        public void TestModels()
        {
            var jsonString = PhantomContext.GetJsonString("Models", "Bulbs.json");

            var data = JsonConvert.DeserializeObject<Bulb[]>(jsonString, serializerSettings);
            var str = JsonConvert.SerializeObject(data, Formatting.Indented);
            Assert.AreEqual(jsonString, str);
        }

        [TestMethod]
        public void TestGetBulbs()
        {
            var phantom = PhantomContext.Phantom;

            var listBulbs = phantom.GetBulbs();

            var badDevice = listBulbs.First(p => p.Connectivity != "在线");
            phantom.SetBulb(badDevice.Id, false);

            var detailsList = phantom.GetBulbs(true);
            var bulb = phantom.GetBulb(listBulbs.First().Id);
            var isOn = bulb.TurnedOn;
            phantom.SetBulb(bulb, true);
            phantom.SetBulb(bulb, false);
            phantom.SetBulb(bulb, isOn);

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
    }
}
