using MvvmLab.models.Iface;
using MvvmLab.viewmodels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MvvmLab.UI.Forms
{
	/// <summary>
	/// Interaction logic for SingleInterface.xaml
	/// </summary>
	public partial class MultipleInterface : Window
	{
		ObservableCollection<SeeInterface> values = new ObservableCollection<SeeInterface>();
		

		public MultipleInterface()
		{
			values.Add(new SeeInterface(new ConcreteOne()));
			values.Add(new SeeInterface(new ConcreteTwo()));

			InitializeComponent();
			DataContext = values;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
		
		}
	}
}
