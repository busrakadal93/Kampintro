using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        //Metotun parametresi ihtiyacı olanlar. Toplamada iki sayıya ihtiyacı var o yüzden 2 tane sayı verdim
        //Topla(2,3) (sayi1=2 - sayi2=3)
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2; //önce eşitliğin sağ tarafı çalışır.
            Console.WriteLine("Sonuç : " + toplam);
        }
    }
}
