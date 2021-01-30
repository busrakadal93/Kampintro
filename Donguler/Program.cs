using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            string kurs1 = "Yazılım geliştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //kursları tek tek değişkenlere atayarak tutmamız zor olur. onun yerine dizilerde(array) tutarız

            string[] kurslar = new string[] { "Yazılım geliştirme kampı", "Programlamaya başlangıç için temel kurs", "Java", "Phyton", "C#"};

            for (int i = 0; i < kurslar.Length; i++) //Length dizinin elemanı verir.
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti.");


            //for (int i = 0; i < 10; i+=2) //2 2 artır demek
            //{
            //    Console.WriteLine(i);
            //}

            //foreach dizilere uygulanır.
            foreach (string kurs in kurslar) //dizi temelli yapıları tek tek dönmeye yarıyor. Kursları tek tek dolaş demek
            {
                Console.WriteLine(kurs); //kurs takma isim ne olduğu önemli değil.
            }

            Console.WriteLine("sayfa sonu - footer");

        }
    }
}
