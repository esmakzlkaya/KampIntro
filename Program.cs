using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //değişken = değer tutucu , alias = takma isim
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Değişmedi Oku");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
