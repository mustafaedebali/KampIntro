using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
        //    string urunAdi = "Elma";
        //    double fiyati = 15;
        //    string aciklama = "Amasya elması";

            string[] meyveler = new string[] {"Elma","Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //type-safe -- tip güvenli
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine("---------Metotlar---------------");
            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12, 5);
            sepetManager.Ekle2("elma", "yeşil elma", 13, 6);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 18, 8);

        }
    }
}


//[Don't repeat yourself - DRY] - Clean Code - Best Practice
