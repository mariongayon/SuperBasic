﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
	public class Print : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			Console.WriteLine(arguments[0]);
			return 0f;
		}
	}
}
