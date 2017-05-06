using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace Elton.Phantom.Tests
{
    /// <summary>
    /// Summary description for NotificationTest
    /// </summary>
    [TestClass]
    public class NotificationTest
    {
        public NotificationTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        public string JsonExampleDir
        {
            get
            {
                return Path.Combine(
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                    @"examples\Notifications\");
            }
        }

        string ReadExampleJsonString(NotificationType type)
        {
            string fileName = Path.Combine(
                JsonExampleDir,
                type.ToString() + ".json");

            if (!File.Exists(fileName))
                throw new FileNotFoundException("The json file is not found." + fileName, fileName);

            return File.ReadAllText(fileName, Encoding.UTF8);
        }

        void TestNotificationJson(NotificationType type)
        {
            string jsonString = ReadExampleJsonString(type);
            var notification = Notification.Parse(jsonString);
            Assert.IsNotNull(notification, "Failed to parse message '{0}'.", type);
            Assert.AreEqual(notification.Type, type);

            string actual = Notification.Format(notification);
            Assert.IsTrue(JToken.DeepEquals(JObject.Parse(jsonString), JObject.Parse(actual)),
                "Message '{0}' json Data is incorrect.", type);
        }

        [TestMethod]
        public void TestDoorSensorsChanged()
        {
            TestNotificationJson(NotificationType.DoorSensorsChanged);
        }

        [TestMethod]
        public void TestIoDetectorChanged()
        {
            TestNotificationJson(NotificationType.IoDetectorChanged);
        }

        [TestMethod]
        public void TestDeviceConnectivity()
        {
            TestNotificationJson(NotificationType.DeviceConnectivity);
        }

        [TestMethod]
        public void TestBulbsChanged()
        {
            TestNotificationJson(NotificationType.BulbsChanged);
        }

        [TestMethod]
        public void TestInfraredSensorsChanged()
        {
            TestNotificationJson(NotificationType.InfraredSensorsChanged);
        }

        [TestMethod]
        public void TestSwitchesChanged()
        {
            TestNotificationJson(NotificationType.SwitchesChanged);
        }

        [TestMethod]
        public void TestWallSwitchPressed()
        {
            TestNotificationJson(NotificationType.WallSwitchPressed);
        }

        [TestMethod]
        public void TestSwitchPressed()
        {
            TestNotificationJson(NotificationType.SwitchPressed);
        }

        [TestMethod]
        public void TestWallSwitchesChanged()
        {
            TestNotificationJson(NotificationType.WallSwitchesChanged);
        }

        [TestMethod]
        public void TestGroupCreated()
        {
            TestNotificationJson(NotificationType.GroupCreated);
        }

        [TestMethod]
        public void TestSecurityPatternsChanged()
        {
            TestNotificationJson(NotificationType.SecurityPatternsChanged);
        }

        [TestMethod]
        public void TestUserEvent()
        {
            TestNotificationJson(NotificationType.UserEvent);
        }

        [TestMethod]
        public void TestAllNotifications()
        {
            foreach(NotificationType type in Enum.GetValues(typeof(NotificationType)))
            {
                if (type == NotificationType.Unknown)
                    continue;

                TestNotificationJson(type);
            }
        }
    }
}
