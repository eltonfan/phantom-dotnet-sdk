using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Elton.Phantom.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var api = new Version1.PhantomAPI(PhantomConfiguration.Default);
        }
    }
}
