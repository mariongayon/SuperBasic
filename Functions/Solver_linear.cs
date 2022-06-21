using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    public class Solver_linear : IFunction
    {
        float IFunction.Apply(List<BasicNumber> arguments)
        {
            float f = ((arguments[3] - arguments[2]) / arguments[1]);
            return f;
        }
    }
}
