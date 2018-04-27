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
    public class PingApiTests
    {
        public TestContext TestContext { get; set; }

        PhantomClient instance = null;
        [TestInitialize]
        public void Initialize()
        {
            instance = PhantomContext.Phantom;
        }

        [TestMethod]
        public void GetPingV1Test()
        {
            var api = instance as Api.Version1.IPingApi;
            api.GetPing();
        }

        [TestMethod]
        public void GetPingV2Test()
        {
            var api = instance as Api.Version2.IPingApi;
            api.GetPing();
        }
    }
}
