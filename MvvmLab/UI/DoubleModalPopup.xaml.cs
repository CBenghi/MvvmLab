using MvvmLab.viewmodels;
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

namespace MvvmLab.UI
{
	/// <summary>
	/// Interaction logic for DoublePopup.xaml
	/// </summary>
	public partial class DoubleModalPopup : Window
	{
		public DoubleModalPopup()
		{
			InitializeComponent();
		}

		public int Count { get; set; }

		// this class is not dealt following mvvm.
		public DoubleModalPopup(SeeDouble init) 
		{
			InitializeComponent();
			Count = init.SeeDoubleVal;
			NoMvvmHere.Content = Count;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
		{
			// increase decrease the counter with clicks, just to try a weird interaction
			//
			if (e.LeftButton== MouseButtonState.Pressed)
				Count++;
			else
				Count--;
			NoMvvmHere.Content = Count;
		}
	}
}
