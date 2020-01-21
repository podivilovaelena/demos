using System;
using System.Collections.Generic;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class ParseTests
    {
        [TestMethod]
        public void ParseTest1()
        {
            CalculatorParser parser=new CalculatorParser();
            var actualResult = parser.Parse("1+2-3");
            List<string> expectedResult=new List<string>{"1","+","2","-","3"};
            CollectionAssert.AreEqual(expectedResult,actualResult);
        }

        [TestMethod]
        public void ParseTest2()
        {
            CalculatorParser parser = new CalculatorParser();
            var actualResult = parser.Parse("(3.8-6.77)*(2.8+1)");
            List<string> expectedResult = new List<string> { "(","3.8", "-", "6.77",")", "*", "(", "2.8", "+", "1",")" };
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ParseTest3()
        {
            CalculatorParser parser = new CalculatorParser();
            var actualResult = parser.Parse("-5+6");
            List<string> expectedResult = new List<string> { "-", "5", "+", "6" };
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ParseTest4()
        {
            CalculatorParser parser = new CalculatorParser();
            var actualResult = parser.Parse("-5a+6");
            List<string> expectedResult = new List<string> { "-", "5", "a", "+", "6" };
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

    }
}
