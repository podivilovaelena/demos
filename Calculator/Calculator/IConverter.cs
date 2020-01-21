using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    interface IConverter
    {
        List<string> Convert(List<string> elements);
    }
}
