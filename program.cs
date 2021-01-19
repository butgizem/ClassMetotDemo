using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            Console.WriteLine(" Müşteri Bilgileri : ");
           
            musteri1.Ad = "Ahmet";
            musteri1.SoyAd = "MEHMET";
            musteri1.KayitNo = 1;
            musteri1.HesapNo = 11111;
          
            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ayşe";
            musteri2.SoyAd = "FATMA";
            musteri2.KayitNo = 2;
            musteri2.HesapNo = 22222;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Halil";
            musteri3.SoyAd = "Malil";
            musteri3.KayitNo = 3;
            musteri3.HesapNo = 33333;

            Musteri musteri4 = new Musteri();
            musteri4.Ad = "Özlem";
            musteri4.SoyAd = "Mözlem";
            musteri4.KayitNo = 4;
            musteri4.HesapNo = 44444;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine(" Adı :    {0} \n Soyadı : {1} \n Kayıt No : {2} \n Hesap No:  {3}",
                   musteri.Ad, musteri.SoyAd, musteri.KayitNo, musteri.HesapNo);
               
            }

            Console.WriteLine("--------------------------");

            Console.WriteLine("Yeni Kayıt Yapanlar: ");
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);

            Console.WriteLine("--------------------------");
            Console.WriteLine("Kaydını Silenler: ");
            musteriManager.Silme(musteri4);

            Console.WriteLine("--------------------------");
            Console.WriteLine("Müşteri Listesi: ");

            musteriManager.Liste(musteri1);
            musteriManager.Liste(musteri2);
            musteriManager.Liste(musteri3);
            


        }     


    }
}
