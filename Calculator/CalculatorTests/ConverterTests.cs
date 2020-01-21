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
            List<string> input=new List<string>{ "(","1","+","2",")","*", "4", "+", "3" };
            var actualResult = converter.Convert(input);
            List<string> expectedResult = new List<string> { "1", "2", "+", "4", "*", "3", "+" };
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ConvertTest2()
        {
            CalculatorConverter converter = new CalculatorConverter();
            List<string> input = new List<string> { "(","3.8","-","6.77",")","*","(","2.8","+","1",")" };
            var actualResult = converter.Convert(input);
            List<string> expectedResult = new List<string> { "3.8", "6.77", "-", "2.8", "1", "+", "*" };
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ConvertTest3()
        {
            CalculatorConverter converter = new CalculatorConverter();
            List<string> input = new List<string> { "5","+","+","6" };
            var actualResult = converter.Convert(input);
            List<string> expectedResult = new List<string> { "5", "+","6",  "+" };
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ConvertTest4()
        {
            CalculatorConverter converter = new CalculatorConverter();
            List<string> input = new List<string> { "-","5", "+", "6" };
            var actualResult = converter.Convert(input);
            List<string> expectedResult = new List<string> { "0","5", "-", "6", "+" };
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}