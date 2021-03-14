using MvvmLab.UI.Forms;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MvvmLab
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			var s = new Single();
			s.Show();
		}

		private void ButtonD_Click(object sender, RoutedEventArgs e)
		{
			var s = new SingleElementDouble();
			s.Show();
		}

		private void Multi_Click(object sender, RoutedEventArgs e)
		{
			var s = new MultiValues();
			s.Show();
		}

		private void ButtonDC_Click(object sender, RoutedEventArgs e)
		{
			var s = new SingleEmentDoubleWithComponent();
			s.Show();
		}

		private void MultiComp_Click(object sender, RoutedEventArgs e)
		{
			var s = new MultiValuesComp();
			s.Show();
		}

		private void ButtonInt_Click(object sender, RoutedEventArgs e)
		{
			var s = new SingleInterface();
			s.Show();
		}

		private void MultiInter_Click(object sender, RoutedEventArgs e)
		{
			var s = new MultipleInterface();
			s.Show();
		}
	}
}
