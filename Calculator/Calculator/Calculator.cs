using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;

namespace Calculator
{
    public class Calculator:ICalculator
    {
        public double Calculate(string expression)
        {
            Stack<double> stack = new Stack<double>();
            List<string> elements = new CalculatorConverter().Convert(expression);
            CalculatorOperation operation = new CalculatorOperation();
            foreach (var element in elements)
            {
                if (!operation.Operators.Contains(element))
                {
                    try
                    {
                        stack.Push(double.Parse(element, CultureInfo.InvariantCulture));
                    }
                    catch
                    {
                        throw new FormatException("неверный формат");
                    }
                }
                else
                {
                    try
                    {
                        double operationResult = operation.MakeOperation(element,
                            stack.Pop(), stack.Pop());
                        stack.Push(operationResult);
                    }
                    catch
                    {
                        throw new FormatException("неверный формат");

                    }
                }
            }

            return stack.Pop();
        }
    }
}

