using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CalculatorParser: IParser
    {
        private readonly List<string> _operators = new List<string> { "(", ")", "+", "-", "*", "/" };
        public List<string> Parse(string expression)
        {
            int ind = 0;
            List<string> parsedItems=new List<string>();
            while (ind < expression.Length)
            {
                string item = expression[ind].ToString();
                if (!_operators.Contains(expression[ind].ToString()))
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
