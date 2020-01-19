using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CalculatorParser: IParser
    {
        public List<string> Parse(string expression)
        {
            int pos = 0;
            List<string> operators = new CalculatorOperation().Operators;
            List<string> parsedItems=new List<string>();
            while (pos < expression.Length)
            {
                string item = expression[pos].ToString();
                if (!operators.Contains(expression[pos].ToString()))
                {
                        for (int i = pos + 1; i < expression.Length && (Char.IsDigit(expression[i]) || expression[i] == ',' || expression[i] == '.'); i++)
                            item += expression[i];
                }
                parsedItems.Add(item);
                pos += item.Length;
            }

            return parsedItems;
        }
    }
}
