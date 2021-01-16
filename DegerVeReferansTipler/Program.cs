using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? = 30

            int[] sayilar1 = new int[] {10,20,30 };
            int[] sayilar2 = new int[] {100,200,300 };

            sayilar1 = sayilar2;
            sayilar2[0]=999;

            // sayilar1[0] = 999 olur


            ///*****
            // int decimal, float, double, bool= değer tip
            //array, class, interface = referans tip 


            //stack :  değer tipler burada gerçekleşir
            //sayi1=10 değeri 10
            //sayi2=30 değeri 30
            //sayi1=sayi2:  sayi1 in değeri sayi2nin değeri olur yani sayi1in değeri = 30

            //***********************************************************

            //referans tipler  (pointer)
            //stack sayilar1  \101 ( adres verdik )
            /////   sayilar2  \102 ( adres verdik )

            //heap :
            //[10,20,30]      \101 xxx
            //                \102 yeni adresi (sayilar1=sayilar2 dendiği için sayilar1 in yeni adresi 102 olur)

            //[100,200,300]   \102
            //[999,200,300]   \102  yeni değeri (100 yerine 999 geldi)(sayilar2[0]=999 dendiği için )

            //sayilar1 = sayilar2 : demek : sayilar1 in referans nosu = sayilar2 nin referans nosu olur
            //yanii sayilar1 \102 olur
            //o zaman sayilar1[0] ?? = 999 olur
        }
    }
}
