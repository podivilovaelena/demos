using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    interface ICalculatorOperation
    {
        int GetOperationPriority(string operation);

        double MakeOperation(string operation, double a, double b);
    }
}
