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

namespace MvvmLab
{
	/// <summary>
	/// Interaction logic for MultiValues.xaml
	/// </summary>
	public partial class MultiValues : Window
	{
		public MultiValues()
		{
			InitializeComponent();
			this.DataContext = new SeeMultiple(5);
		}
	}
}
