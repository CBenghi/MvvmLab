using System;

namespace MvvmLab.UI.Helpers
{
	// see https://stackoverflow.com/questions/6145888/how-to-bind-an-enum-to-a-combobox-control-in-wpf
	public class ValueDescription
	{
		public ValueDescription()
		{
		}

		public Enum Value { get; set; }
		public string Description { get; set; }
	}
}