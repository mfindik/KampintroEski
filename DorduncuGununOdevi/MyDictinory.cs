using System;
using System.Collections.Generic;
using System.Text;

namespace DorduncuGununOdevi
{
    class MyDictinory<Plaka, Sehir>
    {
        Plaka[] plakalar;
        Sehir[] sehirler;
        public MyDictinory()
        {
            plakalar = new Plaka[0];
            sehirler = new Sehir[0];
        }
        public void Add(Plaka plaka, Sehir sehir)
        {
            Plaka[] tempPlaka = plakalar;
            Sehir[] tempSehir = sehirler;
            plakalar = new Plaka[plakalar.Length + 1];
            sehirler = new Sehir[sehirler.Length + 1];
            for (int i = 0; i < tempPlaka.Length; i++)
            {
                plakalar[i] = tempPlaka[i];
                sehirler[i] = tempSehir[i];
            }
            plakalar[plakalar.Length - 1] = plaka;
            sehirler[sehirler.Length - 1] = sehir;
        }

        public (Plaka, Sehir)[] Items 
        { 
            get 
            {
                List<(Plaka, Sehir)> items = new List<(Plaka, Sehir)>();
                for (int i = 0; i < sehirler.Length; i++) 
                {
                    items.Add((plakalar[i], sehirler[i]));
                }
                return items.ToArray();
            } 
        }

        //Aşağıdaki kod istediğim gibi sonuç vermediğinden internetten yardım ile yokarıdaki kodu oluşturdum

        //public Plaka[] Plakalar 
        //{ 
        //    get { return plakalar; } 
        //}

        // public Sehir[] Sehirler 
        //{ 
        //    get { return sehirler; } 
        //}

    }
}
