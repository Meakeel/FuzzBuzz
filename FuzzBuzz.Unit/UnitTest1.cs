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
        [TestMethod]
        public void BuzzTest()
        {
            string isBuzzTest = Program.IsFuzzBuzz(5);
            Assert.AreEqual("Buzz", isBuzzTest);
        }
        [TestMethod]
        public void FuzzBuzzTest()
        {
            string isFuzzBuzzTest = Program.IsFuzzBuzz(15);
            Assert.AreEqual("FuzzBuzz", isFuzzBuzzTest);
        }
        [TestMethod]
        public void isNotFuzzBuzzTest()
        {
            string isNotFuzzBuzzTest = Program.IsFuzzBuzz(11);
            Assert.AreEqual(string.Empty, isNotFuzzBuzzTest);
        }
    }
}
