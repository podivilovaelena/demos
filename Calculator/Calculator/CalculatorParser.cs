using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CalculatorParser: IParser
    {
        public List<string> Parse(string expression)
        {
            int ind = 0;
            List<string> operators = new CalculatorOperation().Operators;
            List<string> parsedItems=new List<string>();
            while (ind < expression.Length)
            {
                string item = expression[ind].ToString();
                if (!operators.Contains(expression[ind].ToString()))
                {
                        for (int i = ind + 1; i < expression.Length && (Char.IsDigit(expression[i]) || expression[i] == ',' || expression[i] == '.'); i++)
                            item += expression[i];
                }
                parsedItems.Add(item);
                ind += item.Length;
            }

            return parsedItems;
        }
    }
}
