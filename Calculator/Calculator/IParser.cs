using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    interface IParser
    {
        List<string> Parse(string expression);
    }
}
