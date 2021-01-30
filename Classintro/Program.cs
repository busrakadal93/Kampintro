using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Büşra"; //string gibi veri türleri bi objedir.
            int yas = 27;

            Kurs kurs1 = new Kurs(); //kurs1 değişken - Kurs tipinde (class değişkeni tanımladık)
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlemeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.izlemeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.izlemeOrani = 80;


            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            //string yazarsak içinde sadece string tutabiliriz bu şekilde KU-urs dizisi tutuyor içinde int de var
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }

            foreach (Kurs kurs in kurslar) //Kurs yerine var da yazılı olabilir.
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " : " + kurs.izlemeOrani + " : ");
            }


            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlemeOrani { get; set; }
    }
}
