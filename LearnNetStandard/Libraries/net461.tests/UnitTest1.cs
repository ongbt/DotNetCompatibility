using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace net461.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void net461()
        {
            string s = new net461.Class().Say();
        }
         
    }
}
