using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention - isimlendirme kuralı
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("TEBRİKLER, Sepete Eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokadedi)
        {
            Console.WriteLine("TEBRİKLER, Sepete Eklendi : " + urunAdi);
        }
    }
}
