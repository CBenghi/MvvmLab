using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLab.models
{
	public class DoubleValue
	{
		public int Value { get; set; } = 10;

		public int Double => Value * 2;
	}
}
