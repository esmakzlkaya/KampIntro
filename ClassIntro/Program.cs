using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Esma";
            int yas = 23;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Yazılım Geliştirici Yetiştirme Kampı";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.KursIzlenmeOrani = 29;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.Egitmen = "Esma Kızılkaya";
            kurs2.KursIzlenmeOrani = 36;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "PHP";
            kurs3.Egitmen = "Volkan Alakent";
            kurs3.KursIzlenmeOrani = 82;

            // Console.WriteLine(kurs1.KursAdi+ " "+ kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" "+kurs.Egitmen+" "+kurs.KursIzlenmeOrani);
            }
        }
    }

    class Kurs
    {
        //prop = property , özellik
        //prop + 2 tab
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int KursIzlenmeOrani { get; set; }
    }
}
