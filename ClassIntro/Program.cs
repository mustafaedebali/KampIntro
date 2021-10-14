using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Adi = "musti";
            //int yas = 35;


            Kurs kurs1 = new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "engin demirog";
            kurs1.IzlenmeOranı = 65;

            Kurs kurs2 = new Kurs();

            kurs2.KursAdi = "java";
            kurs2.Egitmen = "kerem varış";
            kurs2.IzlenmeOranı = 60;

            Kurs kurs3 = new Kurs();

            kurs3.KursAdi = "python";
            kurs3.Egitmen = "berkay bilgin";
            kurs3.IzlenmeOranı = 90;

            // Console.WriteLine(kurs1.KursAdi + "  "+ kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var item in kurslar)
            {
                Console.WriteLine(item.KursAdi + " : " + item.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }

    }
}
