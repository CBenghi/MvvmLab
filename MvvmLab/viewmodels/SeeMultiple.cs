using mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLab.viewmodels
{
	public class SeeMultiple : ViewModelBase
	{
		private ObservableCollection<SeeDouble> seeDoubles;
		
		public SeeMultiple(int howMany)
		{
			seeDoubles = new ObservableCollection<SeeDouble>();
			for (int i = 0; i < howMany; i++)
			{
				SeeDouble d = new SeeDouble(new models.DoubleValue());
				d.SeeValue = i;
				// d.RandomCommand.Execute(null);
				seeDoubles.Add(d);
			}
			// OnPropertyChanged("DoubleValues");
		}

		public ObservableCollection<SeeDouble> DoubleValues 
		{
			get { return seeDoubles; }
			set { 
				seeDoubles = value;
				NotifyPropertyChanged("DoubleValues");
			}
		}
	}
}
