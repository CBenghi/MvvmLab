using MvvmLab.models.Iface;
using System;
using System.Collections.Generic;
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

		IInterf value;

		public MultipleInterface()
		{
			InitializeComponent();
			value = new ConcreteOne();
			DataContext = new viewmodels.SeeInterface(value);
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (sender is Button b)
			{
				b.Content = value.GetType().Name;
			}
		}
	}
}
