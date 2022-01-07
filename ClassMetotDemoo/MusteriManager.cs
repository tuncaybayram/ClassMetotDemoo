using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        Musteri musteri = new Musteri();

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " adlı kullanıcı eklenmistir.");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " adlı kullanıcı silindi.");
        }

        public void Listeleme(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id: " + musteri.Id);
                Console.WriteLine("Müşteri Adı: " + musteri.MusteriAdi);
                Console.WriteLine("Müşteri Soyadı: " + musteri.MusteriSoyadi);
                Console.WriteLine("Müşteri Hesap No: " + musteri.MusteriHesapNo);
                Console.WriteLine("------------------------");

            }
        }


    }
}