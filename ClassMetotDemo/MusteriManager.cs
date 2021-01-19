using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class  MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriNo +" Numaralı müşteri eklenmiştir...");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriNo + " Numaralı müşteri silindi...");
        }
    }
}
