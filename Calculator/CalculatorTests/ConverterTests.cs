using System;
using System.Collections.Generic;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class ConvertTests
    {
        [TestMethod]
        public void ConvertTest1()
        {
            CalculatorConverter converter = new CalculatorConverter();
            var actualResult = converter.Convert("(1+2)*4+3");
            List<string> expectedResult = new List<string> { "1", "2", "+", "4", "*", "3", "+" };
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ParseTest2()
        {
            CalculatorConverter converter = new CalculatorConverter();
            var actualResult = converter.Convert("(3.8-6.77)*(2.8+1)");
            List<string> expectedResult = new List<string> { "3.8", "6.77", "-", "2.8", "1", "+", "*" };
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ParseTest3()
        {
            CalculatorConverter converter = new CalculatorConverter();
            var actualResult = converter.Convert("5++6");
            List<string> expectedResult = new List<string> { "5", "+","6",  "+" };
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}