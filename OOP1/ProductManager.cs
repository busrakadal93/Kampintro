using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //Operasyonların (metotların)olduğu yer. Yani ürünler ekleme-güncelleme-silme-listeleme-arama-filtreleme-...
        //encapsulation
        public void Add(Product product)
        {
            //neyi ekleceğimizi söylememiz lazım.
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        //void anahtar keimesi ne işe yarıyor: voidle belirttiğimiz metotları git ekle git sil .. diyoruz emir kipinde çağırıp işlemini yapp bitiriyor.
        //işlem sonucunun ne olduğu ile ilgili ekstra bi bilgiye ihtiyacım yoksa metodu void ile tanımlarım.

        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}

        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2); //sayi1 ile sayi2 yi toplar ve ekrana yazdırır.
        //}



    }
}
