using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştme Kampı";
            string kurs2 = "Programlamaya başlangıç";
            string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazılım Geliştme Kampı",
                "Programlamaya başlangıç", "Java", "Phyton", "C#" };

            for (int i = 0; i <kurslar.Length; i++) 
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu");

        }
    }
}
