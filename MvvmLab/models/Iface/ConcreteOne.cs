using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLab.models.Iface
{
	class ConcreteOne : IInterf
	{
		public string OneOne { get; set; }
		public string OneTwo { get; set; }
		public string Text { get; set; } = "One";

		public void DoSome()
		{
			// nought, really.
		}
	}
}
