using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //<> yaptık ve List olmuş oldu, T= Type'dan gelir
    {
        T[] items;

        //constructor = ctor kısayolu
        public MyList() // MyList class ı başka bir yerde newlenirse, bu metot otomatik çalışır.
        {
            items = new T[0]; // class çağırıldığında hemen boş bir liste/array oluşturur.
        }
        public void Add(T item)
        {
            T[] tempArray = items;//geçici olarak items ın adresini geçici diziye tutturuyoruz.
            items = new T[items.Length+1]; //itemsın boyutunu 1 arttırdık
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // itemsa değerlerini geri veriyoruz ve artık bu
           //     değerlere ek artık boş bir elemanımız daha var.
            }
            items[items.Length - 1] = item;
            Console.WriteLine(items[items.Length-1]+" eklendi");
            //items ın son elemanına yeni gelen item değişkenini ata/ekle
        //itemsın boyutu= 5 diyelim, 5-1=4, diziler 0 ile başladığına göre dizinin [4] = 5. eleman olmuş olur

        }
    }
}
