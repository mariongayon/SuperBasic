using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class Accumulate : IFunction
    {

        public static float Sum(int start, int end) 
        {
            float total = 0;

            for (var i = start; i <= end; i++) 
            {
                total += Memory.MemoryGet((short)i);
            }
            return total;
        }

        float IFunction.Apply(List<BasicNumber> arguments)
        {
            float a = arguments[0];
            float b = arguments[1];

            return Sum((int)a, (int)b);
        }
    }
}
