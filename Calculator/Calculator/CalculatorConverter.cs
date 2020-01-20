using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CalculatorConverter:IConverter
    {
        public List<string> Convert(string expression)
        {
            List<string> elements=new CalculatorParser().Parse(expression);
            List<string> result = new List<string>();
            Stack<string> stack = new Stack<string>();
            CalculatorOperation operation =new CalculatorOperation();
            try
            {
                foreach (string element in elements)
                {
                    if (operation.Operators.Contains(element))
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
                            else if (operation.GetOperationPriority(element) >
                                     operation.GetOperationPriority(stack.Peek()))
                                stack.Push(element);
                            else
                            {
                                while (stack.Count > 0 && operation.GetOperationPriority(element) <=operation.GetOperationPriority(stack.Peek()))
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

    }
}
