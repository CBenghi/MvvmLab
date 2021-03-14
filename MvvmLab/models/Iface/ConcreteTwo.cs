using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLab.models.Iface
{
	class ConcreteTwo : IInterf
	{
		public string TwoOne { get; set; }
		public string TwoTwo { get; set; }

		public string Text { get; set; } = "Two";
		public void DoSome()
		{
			// nought, really.
		}
	}
}
