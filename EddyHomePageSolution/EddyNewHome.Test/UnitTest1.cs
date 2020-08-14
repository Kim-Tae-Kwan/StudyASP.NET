using System;
using System.Net;
using System.Security.AccessControl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EddyNewHome.Helper;

namespace EddyNewHome.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CommonGetIp()
        {
            string expectedIp = "210.119.12.60";

            string actualIp = Commons.GetIpAddress();
            Assert.AreEqual(expectedIp, actualIp);
        }
    }
}
