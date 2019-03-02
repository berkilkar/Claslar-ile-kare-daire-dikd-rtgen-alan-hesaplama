using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class kare
    {
        private double _kenar;
        public double Kenar
        {
            get => _kenar;
            set => _kenar = value;
        }

        public double KareAlan()
        {
            return Kenar * Kenar;
        }
    }
}
