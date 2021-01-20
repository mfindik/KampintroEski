using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //<T> Tip manasında
    class MyList<T>
    {
        T[] items;
        //constructor blok, aşağıdaki bolokla items'i new'leyeceğiz.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            //önce dizimizi geçici bir yere kaydediyorum çünkü new lediğimized referas idsi kaybolacak
            T[] tempArray = items;
            //dizimizin eleman sayısı 0 ekleye belmemiz için bir bir arttırmamız lazım
            items = new T[items.Length + 1];
            //şimdi gecici elemana aktardığımız değerleri gerçeği diziye aktaralım
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //Ve artık yeni elemanımızı ekleyebiliriz
            items[items.Length - 1] = item;//neden -1; çünkü index 0 dan başladığı için...
            
        }

    }
}
