using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //krediye başvuru işlemlerini aacağımız class
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService) //tek kredi istiyoruz.
        {
            //burada çeşitli bilgiler alınır.
            //başvuran bilgilerini değerlendirme

            //tüm başvuruları konutkredisine bağlı hale getiriz bu şekilde yani bu doğru değil
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();


            krediManager.Hesapla();
            loggerService.Log(); //hangi loglayıcı seçilmişse onu logla
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //birden fazla kredi bilgisi istiyorum burada o yüzden list kullandık.
        {
            //listelerin içinde her bir kredinin hesabını yapacaı için foreach kullandık
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
