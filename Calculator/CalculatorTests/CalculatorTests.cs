using System;
using System.Collections.Generic;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalculatorTest1()
        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            var actualResult = calculator.Calculate("(1+2)*4+3");
            var expectedResult = 15;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CalculatorTest2()
        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            var actualResult = calculator.Calculate("(3.8-6.77)*(2.8+1)");
            var expectedResult = -11.286;
            Assert.AreEqual(Math.Round(expectedResult,6), Math.Round(actualResult,6));
        }

        [TestMethod]
        public void CalculatorTest3()
        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            var actualResult = calculator.Calculate("44");
            var expectedResult = 44;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CalculatorTest4()
        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            Assert.ThrowsException<System.FormatException>(() => calculator.Calculate("test"));
        }
        [TestMethod]
        public void CalculatorTest5()
        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            Assert.ThrowsException<System.FormatException>(() => calculator.Calculate("5++6"));
        }

        [TestMethod]
        public void CalculatorTest6()
        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            Assert.ThrowsException<System.FormatException>(() => calculator.Calculate("5+6)"));
        }

    }
}