using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class CalculatorConverter:IConverter
    {
        private readonly List<string> _operators = new List<string> { "(", ")", "+", "-", "*", "/" };

        private int GetOperationPriority(string operation)
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

        public List<string> Convert(List<string> elements)
        {
            List<string> result = new List<string>();
            Stack<string> stack=new Stack<string>();
            try
            {
                elements = ModifyForUnaryMinus(elements);                

                foreach (string element in elements)
                {
                    if (_operators.Contains(element))
                    {
                        if (stack.Count > 0 && element != "(")
                        {
                            if (element == ")")
                            {
                                string stackOperator = stack.Pop();
                                while (stackOperator != "(")
                                {
                                    result.Add(stackOperator);
                                    stackOperator = stack.Pop();
                                }
                            }
                            else if (GetOperationPriority(element) >
                                     GetOperationPriority(stack.Peek()))
                                stack.Push(element);
                            else
                            {
                                while (stack.Count > 0 && GetOperationPriority(element) <=GetOperationPriority(stack.Peek()))
                                    result.Add(stack.Pop());
                                stack.Push(element);
                            }
                        }
                        else
                            stack.Push(element);
                    }
                    else
                        result.Add(element);
                }

                foreach (var element in stack)
                    result.Add(element);
            }
            catch
            {
                throw new FormatException("Неверный формат");
            }

            return result;
        }

        private List<string> ModifyForUnaryMinus(List<string> elements)
        {
            List<string> result=new List<string>();
            if (elements.First() == "-") elements.Insert(0, "0");
            foreach (var element in elements)
            {
                if (element == "-" && result.Last() == "(")
                {
                    result.Add("0");
                }
                result.Add(element);
            }

            return result;
        }

    }
}
