using mvvm;
using MvvmLab.models;
using MvvmLab.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmLab.viewmodels
{
	public class SeeDouble : ViewModelBase
	{
		DoubleValue _model;

		public class CallPopup : ICommand
		{
			SeeDouble _ref;
			public CallPopup(SeeDouble reference)
			{
				_ref = reference;
			}

			public event EventHandler CanExecuteChanged;

			public bool CanExecute(object parameter) => true;

			public void Execute(object parameter)
			{
				var t = new DoubleModalPopup(_ref);
				t.ShowDialog();
				_ref.SeeValue = t.Count;
			}
		}

		public class MakeRandom : ICommand
		{
			SeeDouble _ref;
			public MakeRandom(SeeDouble reference)
			{
				_ref = reference;
			}

			public event EventHandler CanExecuteChanged;

			public bool CanExecute(object parameter)
			{
				return _ref.SeeValue > 15;
			}

			public void Execute(object parameter)
			{
				// we're not using the parameter at all
				var r = new Random();
				_ref.SeeValue = r.Next(0, 30);
			}

			internal void Eval()
			{
				CanExecuteChanged?.Invoke(this, null);
			}
		}

		public SeeDouble(DoubleValue init)
		{
            _model = init;
			RandomCommand = new MakeRandom(this);
			CallPopupCommand = new CallPopup(this);
		}

        public int SeeValue
        {
            get { return _model.Value; }
            set
            {
                _model.Value = value;
                NotifyPropertyChanged("SeeValue");
                NotifyPropertyChanged("SeeDoubleVal");
				RandomCommand.Eval();
            }
        }

        public int SeeDoubleVal
		{
            get
			{
                return _model.Double;
			}
		}

		public MakeRandom RandomCommand { get; set; }
		public CallPopup CallPopupCommand { get; set; }

		
	}
}
