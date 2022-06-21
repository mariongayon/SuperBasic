using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SuperBASIC.Functions
{
    public class Median : IFunction
    {
        public float median;

        float IFunction.Apply(List<BasicNumber> arguments)
        {
            arguments.Sort();

            int index = arguments.Count();

            if (index % 2 == 0) 
            {
                index = index / 2;
                median = arguments[index].GetValue();
            } else 
            {
                index = (index - 1) / 2;
                median = arguments[index].GetValue();
            }
            return median;
        }
    }
}
