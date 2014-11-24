using System;
using FuzzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzBuzz.Unit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FuzzTest()
        {
            string isFuzzTest = Program.IsFuzzBuzz(3);
            Assert.AreEqual("Fuzz", isFuzzTest);
        }
    }
}
