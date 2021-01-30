using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; //sayi1 i sayi2 ye eşitledi
            sayi2 = 65;
            //sayi1=30 oldu

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]=999 oldu

            //değer tip: int, decimal, float, double, bool (sayısal görüntü değer tipidir.)
            //referans tip: array, class, interface

            //bellekte stack ve heap diye alanlar var.

            //değer tip olanlar stackte gerçekleşiyor. sayi1=10 sayi2=30 
            //sayi1 in değeri eşittir 10 diye okunur.
            //sayi1 in değeri eşittir sayi2 dediğimiz de sayi1 sayi2 nin değeri alır.
            //adı üstünde değeri kopyaıyor ve işi bitiyor. bellekte değişkeni tutmaz.

            //sayilar1 diye değişken tanımladık stackte new dediğimizde heap de alan oluştur ve sayıları orada yaz demek.
            //sayilar1 (stackte)  [10,20,30](heapde) 15.satır
            //sayilar2            [100,200,300]      16.satır
            //sayılar1 in referans numarası eşittir sayilar2 nin referans numarasına diye okunur 17.satır (adres kopyalaması yapar.)
            //sayilar2 nin de ilk elemanı 999 old için sayilar1 de sayilar2 nin referans numarasına eşit old için sayilar1[0]=999 oldu.



        }
    }
}
