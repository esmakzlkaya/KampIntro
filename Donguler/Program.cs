using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array = dizi
            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs", "Java Geliştirme Kursu","C++","Phyton","C#"};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i] + " " + i);
            }

            Console.WriteLine("\n///////////Sayfa arası///////\n");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa sonu - Footer");
        }
    }
}