using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate(tüzel müşteri)
    //Miras inheritance
    //Müşteride olan herşey tüzel müşteride de var kabul edilir. 
    //Musteri Tüzel Müşterinin ebeveynidir.
    //Tüzel ve gerçekte id ve müşterino ortak olduğu için o sınıflardan kesip müşterinin içine aldık.
    //Tüzelde sadece ona ait özellikler kaldı, Müşteride ise ortak özellikleri(id ve müşteri no) oraya kopyaladık.
    class TuzelMusteri : Musteri //tüzel müşteri bir müşteridir demek //Musterinin içindeki tüm özellikler tüzel müşteride de var demek 
    {
        //public int Id { get; set; }
        //public string MusteriNo { get; set; }
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
