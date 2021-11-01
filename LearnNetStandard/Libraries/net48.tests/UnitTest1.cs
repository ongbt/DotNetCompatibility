using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace net48.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void net48()
        {
            string s = new net48.Class().Say();
        }
    }
}
