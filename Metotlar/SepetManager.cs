using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{   
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("{0} Sepete Eklendi ", urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("{0} Sepete Eklendi ", urunAdi);
        }

    }
}
