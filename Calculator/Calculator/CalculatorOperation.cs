using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Calculator
{
    public class CalculatorOperation:ICalculatorOperation
    {
        private readonly List<string> _operators = new List<string> { "(", ")", "+", "-", "*", "/" };

        private double MakeOperation(string operation, double a, double b)
        {

                double result=0;
                switch (operation)
                {
                    case "+":
                    {
                        result = a+b;
                        break;
                    }
                    case "-":
                    {
                        result = b-a;
                        break;
                    }
                    case "*":
                    {
                        result = a*b;
                        break;
                    }
                    case "/":
                    {
                        result = b/a;
                        break;
                    }
                }

                return result;
        }

        public double PerformCalculation(List<string> elements)
        {
            Stack<double> stack = new Stack<double>();

            foreach (var element in elements)
            {
                if (!_operators.Contains(element))
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
                        double operationResult = MakeOperation(element,
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
