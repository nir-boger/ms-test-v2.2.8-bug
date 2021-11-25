using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestPlayground
{
    [TestClass]
    public class DummyTests
    {
        [TestMethod]
        public void A_B_C()
        {
            Assert.IsTrue(true);
        }
    }
}
