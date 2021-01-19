using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirme yetiştirme kakmpı";
            string kurs2 = "Proğramlamaya başlangıç";
            string kurs3 = ">ava";
            //array : dizi
            string[] kurslar = new string[] { "Yazılım geliştirme yetiştirme kakmpı", "Proğramlamaya başlangıç", "Java", "Python", "c++" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("------------For bitti------------------------------");
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

        }
    }
}
