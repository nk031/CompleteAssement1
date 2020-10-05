using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompleteAssesment1.Test
{
    [TestClass]
    public class LogicClass
    {
        LogicClass Logic = new LogicClass();
        [TestMethod]
        public void TestShootATHead()
        {
            int testInt = Logic.GunShoot();
            Assert.IsTrue();
        }

        private int GunShoot()
        {
            throw new NotImplementedException();
        }
    }
}
