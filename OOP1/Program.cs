using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock=5, ProductName="Kalem", UnitPrice=35 };

            //PascalCase    //camelCase
            //case sensitive - büyük küçük harf duyarlı
            ProductManager productManager = new ProductManager(); //ProductManager türündeki productManager yeni bir referan numarası almış ProductManagerdır. sol taraf stack sağ taraf heap
            //string isim; //string tründe isim
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //productManager.Topla2(3, 6); //ekrana 9 yazdırır.
            ////Bu işlem sonucunda çıkan değeri başka birşey de çağırmam gerekirse voidle olan metotlarda bunu kullanamam yani buradaki 9 sonucu
            ////tek seferlik bir daha o 9 u kullanamam ama metodu int ile kullanırsam tekrar çağırabilirim.

            //int toplamaSonucu = productManager.Topla(3, 6); //9 sonucu olur ve ben bu 9 u toplamaSonucu bu değişkene atadım.
            ////Sonrasında o değeri kullanmak için

            //Console.WriteLine(toplamaSonucu*2); //toplamaSonucu bu değişkeni yani 9u 2 ile çarp demek.

        }
    }
}
