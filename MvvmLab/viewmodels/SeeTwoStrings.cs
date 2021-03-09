using mvvm;
using MvvmLab.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLab.viewmodels
{
	public class SeeTwoString : ViewModelBase
	{
		SeeTwoString()
		{

		}

        TwoStrings _model;

        public SeeTwoString(TwoStrings init)
		{
            _model = init;
		}

        public string SeeOne
        {
            get { return _model.StringNumberOne; }
            set
            {
                _model.StringNumberOne = value;
                NotifyPropertyChanged("SeeOne");
            }
        }

        public string SeeTwo
        {
            get { return _model.StringNumberTwo; }
            set
            {
                _model.StringNumberOne = value;
                NotifyPropertyChanged("SeeTwo");
            }
        }


    }
}
