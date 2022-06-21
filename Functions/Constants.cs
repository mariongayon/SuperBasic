﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
	public class Pi : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return (float)Math.PI;
		}
	}
	public class Euler : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return (float)Math.E;
		}
	}
}
