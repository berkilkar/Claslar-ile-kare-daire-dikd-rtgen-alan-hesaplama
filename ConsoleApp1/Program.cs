using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool devam = true;
            AlanHesaplayıcı alan = new AlanHesaplayıcı();
            while (devam)
            {
                Console.WriteLine("***********************************");
                Console.WriteLine("1-kare alan hesaplama");
                Console.WriteLine("2-dikdörtgen alan hesaplama");
                Console.WriteLine("3-çember alan hesaplama");
                Console.WriteLine("4-çıkış");

                int secim = Convert.ToInt32(Console.ReadLine());
                alan.alanhesapla(secim);

                if (secim == 4)
                {
                    devam = false;
                }

                
            }
            Console.ReadKey();
        }
    }
}
