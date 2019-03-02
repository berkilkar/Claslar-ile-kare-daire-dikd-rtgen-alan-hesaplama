using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AlanHesaplayıcı
    {
        public void alanhesapla(int cevap)
        {
            switch (cevap)
            {
                case 1:
                    kare Kare = new kare();
                    Console.Write("Kenar uzunluğu giriniz:");
                    Kare.Kenar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Karenin alanı:"+Kare.KareAlan());
                    break;

                case 2:
                    Dikdörtgen dikdörtgen = new Dikdörtgen();
                    Console.Write("Enini giriniz:");
                    dikdörtgen.En = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Boyunu giriniz:");
                    dikdörtgen.Boy = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dikdörtgenin alanı:"+dikdörtgen.Alan());
                    break;
                case 3:
                    Cember cember = new Cember();
                    Console.Write("Yarıçapını giriniz:");
                    cember.Yaricap = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Çemberin alanı :" +cember.Alan());
                    break;

            }
        }
    }
}
