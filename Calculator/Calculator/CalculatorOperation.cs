using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CalculatorOperation:ICalculatorOperation
    {
        public List<string> Operators = new List<string> {"(", ")", "+", "-", "*", "/"};

        public int GetOperationPriority(string operation)
        {
            switch (operation)
            {
                case "(":
                case ")":
                    return 0;
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                default:
                    return 3;
            }
        }

        public double MakeOperation(string operation, double a, double b)
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
    }

}
