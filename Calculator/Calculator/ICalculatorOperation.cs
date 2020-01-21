using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    interface ICalculatorOperation
    {
        double PerformCalculation(List<string> elements);
    }
}
