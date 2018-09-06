using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomskCable.TestTask.ViewModel
{
    public class TestDataVm : INotifyPropertyChanged
    {
        public int Index { get; set; }
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }
        public double E { get; set; }
        public double F { get; set; }
        public double G { get; set; }
        public double H { get; set; }
        public double I { get; set; }
        public double J { get; set; }
        public double K { get; set; }
        public double L { get; set; }
        public double M { get; set; }
        public double N { get; set; }
        public double O { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
