using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //do not repeat yoursellf - kendini tekrarlama
            //alias - takma isim
            //string kategoriEtiketi = "kategori";

            //int ogrenciSayisi = 32000;
            //double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış var");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış var");
            }
            else
            {
                Console.WriteLine("değişiklik yok");
            }

            //if (sistemeGirisYapmismi == true)
            //{
            //    Console.WriteLine("Giris Yapildi !! ");
            //}
            //else
            //{
            //    Console.WriteLine("Giris yapılmamıştır !! ");
            //}


            //Console.WriteLine(kategoriEtiketi);
        }
    }
}
