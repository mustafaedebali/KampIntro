using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            //string kurs1 = "yazılım geliştirici kampı";
            //string kurs2 = "temel kurs";
            //string kurs3 = "java kursu";

            //Array - dizi

            string[] kurslar = new string[] { "yazılım geliştirici kampı", "temel kurs", "java kursu","python" };

            //for (int i = 0; i < kurslar.Length; ++i)
            //{
                
            //    Console.WriteLine(kurslar[i]);
               
            //}

            foreach (var kurs in kurslar)
            {

                Console.WriteLine(kurs);
                
            }

        }
    }
}
