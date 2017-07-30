using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var value1 = "TEST";
            var value2 = "Test";
            //Assert.AreEqual(value1, value2, "Value 1 / 2 are not equal");

            var value3 = "TEST";
            Assert.AreEqual(value1, value3, "Value 1 / 3 are not equal");

        }
    }
}
