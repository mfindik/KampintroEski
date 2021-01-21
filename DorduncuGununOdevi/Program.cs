using System;
using System.Collections.Generic;
using System.Text;

namespace DorduncuGununOdevi
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictinory<int, string> sehirler = new MyDictinory<int, string>();
            sehirler.Add(1, "Adana");
            sehirler.Add(6, "Ankara");
            sehirler.Add(18, "Çankırı");
            sehirler.Add(21, "Diyarbakır");
            foreach (var p in sehirler.Items)
            {
                //Console.WriteLine($"{p.Item2} : {p.Item1}");
                Console.WriteLine("Plaka : " + p.Item1 + " Şehir : " + p.Item2);
            }
     
        }
    }
}
