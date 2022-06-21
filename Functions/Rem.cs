using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    public class Rem : IFunction
    {
        float IFunction.Apply(List<BasicNumber> arguments)
        {
            float a = arguments[0];
            float b = arguments[1]; 
            
            return a % b;
        }
    }
}
