using System;
using System.Collections.Generic;
using System.Text;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorOperationTests
    {
        [TestMethod]
        public void CalculatorOperationTest1()
        {
            CalculatorOperation calculatorOperation = new CalculatorOperation();
            List<string> input=new List<string>{ "3", "4", "+"};
            var actualResult = calculatorOperation.PerformCalculation(input);
            var expectedResult =7 ;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CalculatorOperationTest2()
        {
            CalculatorOperation calculatorOperation = new CalculatorOperation();
            List<string> input = new List<string> { "5", "2", "*", "10", "+" };
            var actualResult = calculatorOperation.PerformCalculation(input);
            var expectedResult = 20;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CalculatorOperationTest6()
        {
            CalculatorOperation calculatorOperation = new CalculatorOperation();
            List<string> input = new List<string> { "5", "+", "6", "+" };
            Assert.ThrowsException<System.FormatException>(() => calculatorOperation.PerformCalculation(input));
        }
    }
}
