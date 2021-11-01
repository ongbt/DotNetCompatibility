using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace net45.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void net4()
        {
            string s = new net4.Class().Say();
        }

        [TestMethod]
        public void net45()
        {
            string s = new net45.Class().Say();
        }
    }
}
