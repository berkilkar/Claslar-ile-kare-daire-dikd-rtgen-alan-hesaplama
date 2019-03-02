using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cember
    {
        public double pi = 3.14;
        private double _yaricap;
        public double Yaricap
        {
            get => _yaricap;
            set =>_yaricap = value;
        }

        public double Alan()
        {
            return pi * (Yaricap * Yaricap);
        }
    }
}
