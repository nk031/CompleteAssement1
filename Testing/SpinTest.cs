using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CompleteAssesment1.Test
{
    [TestClass]
    public class LogicClass
    {
        LogicClass Logic = new LogicClass();

       [TestMethod]
        public void TestSpinning()
        {
            int testInt = Logic.Spinbt();
            Assert.IsTrue();
        }

        private int Spinbt()
        {
            throw new NotImplementedException();
        }
    }
}
