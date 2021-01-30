using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringSumKata;

namespace StringSumTests
{
    [TestClass]
    public class SumStringTests
    {
        [TestMethod]
        public void AddReturnSum0()
        {
            StringSumma stringSum = new StringSumma();
            string num1 = "";
            string num2 = null;
            string expected = "0";
            var result = stringSum.Sum(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void AddReturnSum1And2()
        {
            StringSumma stringSum = new StringSumma();
            string num1 = "2";
            string num2 = "1";
            string expected = "3";
            var result = stringSum.Sum(num1, num2);
            Assert.AreEqual(expected, result);
        }

    }
}

