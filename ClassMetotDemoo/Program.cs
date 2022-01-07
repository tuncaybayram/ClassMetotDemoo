using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Tuncay";
            musteri1.MusteriSoyadi = "Bayram";
            musteri1.MusteriHesapNo = "159783";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Burak";
            musteri2.MusteriSoyadi = "Turker";
            musteri2.MusteriHesapNo = "148668";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAdi = "Kutluhan";
            musteri3.MusteriSoyadi = "Tarlaci";
            musteri3.MusteriHesapNo = "123456789";


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("-------------------------------");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            musteriManager.Listeleme(musteriler);

            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Silme(musteri3);

            Console.WriteLine("----------------------------------");

            Console.ReadLine();

        }
    }
}