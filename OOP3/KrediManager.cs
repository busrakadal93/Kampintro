using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //class KrediManager
    //{
    //    public void Hesapla()
    //    {
    //        //kredi için hesaplama yaparken döngülere ihtiyacım var.
    //        //tüm kredi çeşitlerinin farklı faiz oranları ve dosya masrafları vardır.
    //    }
    //}
    //interface olmalı - eğer ki bi sınıf bir interface kullanıyorsa kredimanager daki metotları içermelidir.
    //interface ler birden fazla metot içerebilir.
    //interfaceler I harfi ile başlar 
    //kredimanager dan miras alan tüm sınıflar hesapla ve biseyyap metotlarını içermelidir.
    //genellikle operasyonel sınıflarda kullanıyoruz interface

    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
        
    }

    //alternatif sistemler veri tabanına yazma, sms gönderme, vs varsa log ekle projeye 
}
