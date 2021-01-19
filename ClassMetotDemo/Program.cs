using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriNo = 1;
            musteri1.Adi = "Musa";
            musteri1.Soyadi = "Fındık";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriNo = 2;
            musteri2.Adi = "Hayati";
            musteri2.Soyadi = "Yazmaz";

            //Listeleme-----------------------------------------------------------
            Console.WriteLine("-------Müşteri Listeleme---------------------");
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("musteri No.....: " + musteri.MusteriNo);
                Console.WriteLine("musteri Adı....: " + musteri.Adi);
                Console.WriteLine("musteri Soyadi.: " + musteri.Soyadi);
                Console.WriteLine("--------Sonraki Müşteri-----------------");
            }
            Console.WriteLine("---------Listelenecek Müşteri Kalmadı---------");
            //Listeleme Sonu-------------------------------------------------------

            //Musteri Ekle-------------------------------------------------
            Console.WriteLine("-------Müşteri Ekleme---------------------");
            MusteriManager musteriEkle = new MusteriManager();
            musteriEkle.Ekle(musteri1);
            musteriEkle.Ekle(musteri2);
            Console.WriteLine("-------Müşteri Ekleme Sonu---------------");
            //Musteri Ekleme Sonu-----------------------------------------



            //Musteri Ekle-------------------------------------------------
            Console.WriteLine("-------Müşteri Silme---------------------");
            MusteriManager musteriSil = new MusteriManager();
            musteriSil.Sil(musteri1);
            musteriSil.Sil(musteri2);
            Console.WriteLine("-------Müşteri Silme Sonu-----------------");
            //Musteri Ekleme Sonu-----------------------------------------



        }
    }
}
