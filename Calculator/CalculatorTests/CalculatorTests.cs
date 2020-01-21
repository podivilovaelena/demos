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
            Calculator.Calculator calculator = new Calculator.Calculator(new CalculatorParser(), new CalculatorConverter(), new CalculatorOperation());
            var actualResult = calculator.Calculate("-(1+2)*4+(-33/3)");
            var expectedResult = -23;
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}