using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Tüm kredilerde hesapla metotu olduğu için ayrı ayrı hesaplamak yerine KrediManagerden miras alsın.
    class KonutKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            //
            //
            //

            Console.WriteLine("Konut Kredisi Ödeme Planı Heaplandı");
        }
    }
}
