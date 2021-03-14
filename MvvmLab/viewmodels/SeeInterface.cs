using MvvmLab.models.Iface;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;

namespace MvvmLab.viewmodels
{
	public enum Option
	{
		[Description("Concrete One")]
		ConcreteOne,
		[Description("Concrete Two")]
		ConcreteTwo
	}

	class SeeInterface : mvvm.ViewModelBase
	{
		IInterf _underlying;

		private Option choice = Option.ConcreteOne;
		private Visibility panelOne = Visibility.Visible;
		private Visibility panelTwo = Visibility.Collapsed;

		public Visibility PanelOne
		{
			get
			{
				Debug.WriteLine($"Getting PanelOne: {panelOne}");
				return panelOne;
			}
			private set => panelOne = value;
		}

		public Visibility PanelTwo {
			get
			{
				Debug.WriteLine($"Getting PanelTwo: {panelTwo}");
				return panelTwo;
			}
			private set => panelTwo = value; }

		public Option Choice
		{
			get => choice;
			set
			{
				if (value == choice)
					return;
				choice = value;
				PanelOne = choice == Option.ConcreteOne ? Visibility.Visible : Visibility.Collapsed;
				PanelTwo = choice == Option.ConcreteTwo ? Visibility.Visible : Visibility.Collapsed;

				if (choice == Option.ConcreteTwo)
				{
					_underlying = new ConcreteTwo();
				}
				else
				{
					_underlying = new ConcreteOne();
				}
				NotifyPropertyChanged("PanelOne");
				NotifyPropertyChanged("PanelTwo");
				NotifyPropertyChanged("Choice");
			}
		}

		public SeeInterface(IInterf init)
		{
			_underlying = init;
			if (init.GetType() == typeof(ConcreteOne))
			{
				Choice = Option.ConcreteOne;
			}
			else if (init.GetType() == typeof(ConcreteTwo))
			{
				Choice = Option.ConcreteTwo;
			}
		}
	}
}
