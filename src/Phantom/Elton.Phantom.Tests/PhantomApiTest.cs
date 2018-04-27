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
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
        }

        [TestMethod]
        public void TestPing()
        {
            var phantom = PhantomContext.Phantom;

            phantom.Ping(1);
            phantom.Ping(2);
        }

        [TestMethod]
        public void TestRefreshToken()
        {
            var phantom = PhantomContext.Phantom;
            var tokenConfig = PhantomContext.Token;

            var token = phantom.RefreshToken(tokenConfig.RefreshToken);
            tokenConfig.CopyFrom(token);

            PhantomContext.Default.SaveToken();
        }

        [TestMethod]
        public void TestGetUser()
        {
            var phantom = PhantomContext.Phantom;

            var user = phantom.GetUser();
            Assert.IsNotNull(user, "Failed to get user.");
        }

        [TestMethod]
        public void TestAllDevice()
        {
            var phantom = PhantomContext.Phantom;

            Assert.IsTrue(false, "请慎重，将开关所有设备");
            //请慎重，将开关所有设备
            //api.SetScenarioAllOn();
            //Task.Delay(5000).Wait();
            //api.SetScenarioAllOff();
        }
    }
}
