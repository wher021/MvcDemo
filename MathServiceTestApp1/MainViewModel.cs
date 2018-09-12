using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathServiceTestApp1
{
    class MainViewModel : INotifyPropertyChanged
    {
        MainViewModel()
        {
            TxtBox2 = "awdaw";
        }

        private string txtBox2;

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public string TxtBox2
        {
            get { return "adawdw"; }
            set
            {
                txtBox2 = value;
                RaisePropertyChanged("TxtBox2");
            }
        }

    }
}
