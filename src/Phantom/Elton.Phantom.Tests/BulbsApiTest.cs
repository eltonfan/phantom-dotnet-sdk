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
    public class BulbsApiTest
    {
        public TestContext TestContext { get; set; }

        PhantomClient instance = null;
        [TestInitialize]
        public void Initialize()
        {
            instance = PhantomContext.Phantom;
        }

        [TestMethod]
        public void TestModels()
        {
            var jsonString = PhantomContext.GetJsonString("Models", "Bulbs.json");

            var data = JsonConvert.DeserializeObject<Bulb[]>(jsonString);
            var str = JsonConvert.SerializeObject(data, Formatting.Indented);
            Assert.AreEqual(jsonString, str);
        }

        [TestMethod]
        public void TestGetBulbs()
        {

            var listBulbs = instance.GetBulbs();

            var badDevice = listBulbs.First(p => p.Connectivity != "在线");
            instance.SetBulb(badDevice.Id, false);

            var detailsList = instance.GetBulbDetails();
            var bulb = instance.GetBulb(listBulbs.First().Id);
            var isOn = bulb.TurnedOn;
            instance.SetBulb(bulb, true);
            instance.SetBulb(bulb, false);
            instance.SetBulb(bulb, isOn);

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

        /// <summary>
        /// Test an instance of BulbsApi
        /// </summary>
        [TestMethod]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BulbsApi
            //Assert.IsInstanceOfType(typeof(BulbsApi), instance, "instance is a BulbsApi");
        }


        /// <summary>
        /// Test GetBulbs
        /// </summary>
        [TestMethod]
        public void GetBulbsTest()
        {
            var response = instance.GetBulbs();
            Assert.IsInstanceOfType(response, typeof(Bulb[]), "response is Bulb");
        }

        /// <summary>
        /// Test GetBulbsAdvanceId
        /// </summary>
        [TestMethod]
        public void GetBulbAdvanceTest()
        {
            int? id = 2242;
            var result = instance.GetBulbAdvance(id);
        }

        /// <summary>
        /// Test GetBulbsAdvanceIdChart
        /// </summary>
        [TestMethod]
        public void GetBulbsAdvanceIdChartTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string date = null;
            //instance.GetBulbsAdvanceIdChart(id, date);

        }

        /// <summary>
        /// Test GetBulbsAdvanceIdLogs
        /// </summary>
        [TestMethod]
        public void GetBulbsAdvanceIdLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string startDate = null;
            //string endDate = null;
            //instance.GetBulbsAdvanceIdLogs(id, startDate, endDate);

        }

        /// <summary>
        /// Test GetBulbsId
        /// </summary>
        [TestMethod]
        public void GetBulbsIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetBulbsId(id);
            //Assert.IsInstanceOf<Bulb> (response, "response is Bulb");
        }

        /// <summary>
        /// Test PostBulbsIdAutoHue
        /// </summary>
        [TestMethod]
        public void PostBulbsIdAutoHueTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //bool? autoHue = null;
            //var response = instance.PostBulbsIdAutoHue(id, autoHue);
            //Assert.IsInstanceOf<OperationResult> (response, "response is OperationResult");
        }

        /// <summary>
        /// Test PostBulbsIdSwitchOff
        /// </summary>
        [TestMethod]
        public void PostBulbsIdSwitchOffTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.PostBulbsIdSwitchOff(id);
            //Assert.IsInstanceOf<OperationResult> (response, "response is OperationResult");
        }

        /// <summary>
        /// Test PostBulbsIdSwitchOn
        /// </summary>
        [TestMethod]
        public void PostBulbsIdSwitchOnTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.PostBulbsIdSwitchOn(id);
            //Assert.IsInstanceOf<OperationResult> (response, "response is OperationResult");
        }

        /// <summary>
        /// Test PostBulbsIdTune
        /// </summary>
        [TestMethod]
        public void PostBulbsIdTuneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //float? brightness = null;
            //float? hue = null;
            //var response = instance.PostBulbsIdTune(id, brightness, hue);
            //Assert.IsInstanceOf<OperationResult> (response, "response is OperationResult");
        }
    }
}
