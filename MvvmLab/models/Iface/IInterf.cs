using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLab.models.Iface
{
	interface IInterf
	{
		string Text { get; set; }

		void DoSome();
	}
}
