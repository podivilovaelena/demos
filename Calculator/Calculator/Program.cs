using System;
using System.Globalization;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            Calculator calculator=new Calculator();
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите выражение:");
                    line = Console.ReadLine();
                    Console.WriteLine($"Ответ: {calculator.Calculate(line)}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
