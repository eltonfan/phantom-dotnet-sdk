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
    public class ScenariosApiTests
    {
        public TestContext TestContext { get; set; }

        Api.Version1.IScenariosApi instance = null;
        [TestInitialize]
        public void Initialize()
        {
            instance = PhantomContext.Phantom;
        }

        [TestCleanup]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of ScenariosApi
        /// </summary>
        [TestMethod]
        public void InstanceTest()
        {
            Assert.IsInstanceOfType(instance, typeof(Api.Version1.IScenariosApi), "instance is a ScenariosApi");
        }


        /// <summary>
        /// Test DeleteScenariosId
        /// </summary>
        [TestMethod]
        public void DeleteScenarioTest()
        {
            int? id = null;
            var response = instance.DeleteScenario(id);
            Assert.IsInstanceOfType(response, typeof(Scenario), "response is Scenario");
        }

        /// <summary>
        /// Test GetScenarios
        /// </summary>
        [TestMethod]
        public void GetScenariosTest()
        {
            bool? withoutSci = null;
            int? houseId = null;
            int? zoneId = null;
            string sciType = null;
            bool? sortByName = null;
            bool? sortByTime = null;
            bool? sortBySciSize = null;
            var response = instance.GetScenarios(withoutSci, houseId, zoneId, sciType, sortByName, sortByTime, sortBySciSize);
            Assert.IsInstanceOfType(response, typeof(Scenario[]), "response is Scenario");
        }

        /// <summary>
        /// Test GetScenariosId
        /// </summary>
        [TestMethod]
        public void GetScenarioTest()
        {
            int? id = null;
            var response = instance.GetScenario(id);
            Assert.IsInstanceOfType(response, typeof(Scenario), "response is Scenario");
        }

        /// <summary>
        /// Test GetScenariosTimeDivision
        /// </summary>
        [TestMethod]
        public void GetScenariosTimeDivisionTest()
        {
            var response = instance.GetScenariosTimeDivision();
            Assert.IsInstanceOfType(response, typeof(Scenario), "response is Scenario");
        }

        /// <summary>
        /// Test PostScenarios
        /// </summary>
        [TestMethod]
        public void PostScenariosTest()
        {
            //string name = null;
            //List<int?> scenarioContentItemsAttributesGenericModuleId = null;
            //List<int?> scenarioContentItemsAttributesMode = null;
            //List<int?> scenarioContentItemsAttributesBulbId = null;
            //List<float?> scenarioContentItemsAttributesBrightness = null;
            //List<bool?> scenarioContentItemsAttributesTurnedOn = null;
            //List<float?> scenarioContentItemsAttributesHue = null;
            //List<string> scenarioContentItemsAttributesInfo = null;
            //List<string> scenarioContentItemsAttributesStash = null;
            //int? zoneId = null;
            //int? areaId = null;
            //int? icon = null;
            //var response = instance.PostScenarios(name, scenarioContentItemsAttributesGenericModuleId, scenarioContentItemsAttributesMode, scenarioContentItemsAttributesBulbId, scenarioContentItemsAttributesBrightness, scenarioContentItemsAttributesTurnedOn, scenarioContentItemsAttributesHue, scenarioContentItemsAttributesInfo, scenarioContentItemsAttributesStash, zoneId, areaId, icon);
            //Assert.IsInstanceOf<Scenario> (response, "response is Scenario");
        }

        /// <summary>
        /// Test PostScenariosAllOff
        /// </summary>
        [TestMethod]
        public void PostScenarioAllOffTest()
        {
            //int? origin = null;
            //var response = instance.PostScenariosAllOff(origin);
            //Assert.IsInstanceOf<OperationResult> (response, "response is OperationResult");
        }

        /// <summary>
        /// Test PostScenariosAllOn
        /// </summary>
        [TestMethod]
        public void PostScenarioAllOnTest()
        {
            //int? origin = null;
            //var response = instance.PostScenariosAllOn(origin);
            //Assert.IsInstanceOf<OperationResult> (response, "response is OperationResult");
        }

        /// <summary>
        /// Test PostScenariosDelayTime
        /// </summary>
        [TestMethod]
        public void PostScenarioDelayTimeTest()
        {
            //int? id = null;
            //int? time = null;
            //var response = instance.PostScenariosDelayTime(id, time);
            //Assert.IsInstanceOf<Scenario> (response, "response is Scenario");
        }

        /// <summary>
        /// Test PostScenariosIdApply
        /// </summary>
        [TestMethod]
        public void PostScenarioApplyTest()
        {
            int? id = 270;
            int? origin = null;
            var response = instance.PostScenarioApply(id, origin);
            Assert.IsTrue(response.Success, $"Failed to apply Scenario, ERROR: {response.Reason}.");
        }

        /// <summary>
        /// Test PostScenariosTimeDivision
        /// </summary>
        [TestMethod]
        public void PostScenariosTimeDivisionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //List<int?> timeDivisionItemsScenarioId = null;
            //List<string> timeDivisionItemsStartTime = null;
            //List<string> timeDivisionItemsEndTime = null;
            //bool? cycleDay = null;
            //var response = instance.PostScenariosTimeDivision(name, timeDivisionItemsScenarioId, timeDivisionItemsStartTime, timeDivisionItemsEndTime, cycleDay);
            //Assert.IsInstanceOf<Scenario> (response, "response is Scenario");
        }

        /// <summary>
        /// Test PutScenariosId
        /// </summary>
        [TestMethod]
        public void PutScenariosIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string name = null;
            //List<Object> scenarioContentItemsAttributes = null;
            //int? areaId = null;
            //int? icon = null;
            //var response = instance.PutScenariosId(id, name, scenarioContentItemsAttributes, areaId, icon);
            //Assert.IsInstanceOf<Scenario> (response, "response is Scenario");
        }

    }
}
