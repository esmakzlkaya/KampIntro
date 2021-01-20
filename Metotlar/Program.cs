using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do not repeat yourself - DRY - Clean Code - Best Practice
            //metotlar - tekrar tekrar kullanılabilen kod blokları

            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Id);
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------\n");
            }
            //cw - console.writeline kısa yolu
            Console.WriteLine("-----Metotlar----\n");

            //instance - class örneği - nesne
            //encapsulation - ekle2 patladı(elle müdahale gerekti), ekle sorunsuz çalışıyor: (yeni bir özellik eklendiğinde)

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("---------------------");

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 15, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 80, 1);

        }
    }
}