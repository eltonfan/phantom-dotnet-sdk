using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elton.Phantom.API;

namespace Elton.Phantom.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var api = new PhantomAPI(PhantomConfiguration.Default);
        }
    }
}
