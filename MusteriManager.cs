using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.SoyAd);
        }
        public void Liste(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.SoyAd);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.SoyAd);      
        }

    }
}
