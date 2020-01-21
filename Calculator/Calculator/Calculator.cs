using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        private readonly IParser _parser;
        private readonly IConverter _converter;
        private readonly ICalculatorOperation _calculatorOperation;

        public Calculator(CalculatorParser parser, CalculatorConverter converter,
            CalculatorOperation calculatorOperation)
        {
            _parser = parser;
            _converter = converter;
            _calculatorOperation = calculatorOperation;
        }
        public double Calculate(string expression)
        {
            return _calculatorOperation.PerformCalculation(_converter.Convert(_parser.Parse(expression)));
        }
    }
}

