using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dikdörtgen
    {
        private double _en;
        public double En
        {
            get => _en;
            set => _en = value;
        }
        private double _boy;
        public double Boy
        {
            get => _boy;
            set => _boy = value;
        }

        public double Alan()
        {
            return En * Boy;
        }
    }
}
