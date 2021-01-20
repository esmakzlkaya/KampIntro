using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //array
            // new dediğimiz anda bellekte yeni bir adres oluşur.!!

            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil"};
            //Console.WriteLine(isimler[0]);

            //List  .. genelde listeleri kullanırız

            List<string> isimler2 = new List<string> { "Engin","Murat", "Kerem", "Halil"};
            Console.WriteLine(isimler2[0]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            

        }
    }
}
