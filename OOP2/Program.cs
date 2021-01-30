using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Engin";
            //musteri1.Soyadi = "Demiroğ";
            //musteri1.Id = 1;
            //musteri1.TcNo = "22222222222";
            //musteri1.SirketAdi = "?"; //şahıslarda şirket adı yok bu hatalı

            //Gerçek Müşteri - Tüzel Müşteri 
            //Farklı müşteri tipleri olduğu için bunlar birbiri yerine kullanılamaz.
            //Bu yüzden Gerçek Müşteri - Tüzel Müşteri classlarını oluşturduk.

            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri(); 
            Musteri musteri4 = new TuzelMusteri();
            //new görüdüğümüz alan bellekteki bir refrans nosu müşteri classı hem gerçekmüşterinin referansını tutabiliyor 
            //hemde tüzel müşterinin referansını tutabiliyor.

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);



        }
    }
}
