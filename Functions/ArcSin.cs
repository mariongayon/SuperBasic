using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SuperBASIC.Functions
{
    class ArcSin : IFunction
    {
        float IFunction.Apply(List<BasicNumber> arguments)
        {
            double a = arguments.First().GetValue();

            return (float)Math.Asin(a);
        }


    }
}
