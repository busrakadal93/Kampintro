using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Aziz", "Nihal", "Dila", "Büşra" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            //Dizileri genişletemiyoruz. Eğer genişletirsek aşağıdaki gibi değerleri kaybediyoruz. Burada yenii dizi atadık ve tek bir elamanı
            //belli o da İlker o yüzden sadece onu yazacak diğerleri tekrar egtirsin dersek onarı yazmayacak.

            isimler = new string[5];
            isimler[4] = "Duygu";
            Console.WriteLine(isimler[4]); //duyguyu yazacak.
            Console.WriteLine(isimler[0]); // Azizi yazmayacak çünkü yeniden tanımlandı isimler dizisi ve onda Aziz yok

            Console.WriteLine("-------------------------");

            //Diziler yerine koleksiyonları kullanırız.
            List<string> isimler2 = new List<string> { "Aziz", "Nihal", "Dila", "Büşra" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Duygu");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            //List sınıf, <> generic bir yapı

            


        }
    }
}
