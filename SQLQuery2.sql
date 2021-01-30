--Select
--Tüm kolonları çekmek istediğimde
Select * from Customers
--Belli bir kolon çekmek istediğimde
Select ContactName,CompanyName,City from Customers
--kolon ismi değiştirme
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

--filtreleme
--Tüm müşterileri tüm kolonlarıyla getir ama şehri Londro olanları getir demek
Select * from Customers where City='London'

--Ürünler tablosunu tüm kolonlarıyla getirir
Select * from Products
--Ürünlerde categori id si 1 olanları yada categori id si 3 olanları getir
Select * from Products where CategoryID=1 or CategoryID=3
--Ürünlerde categori id si 1 olanları ve unit price ı 10dan büyük olanları getir(<> farklı olanlar demek)
Select * from Products where CategoryID=1 and UnitPrice>=10

--Sıralama
--Tüm ürünleri seç Ürünlerin ismine göre sırala
Select * from Products order by ProductName
--Tüm ürünleri seç categori id ye göre sırala ve Ürünlerin ismine göre sırala
Select * from Products order by CategoryID, ProductName
--Ürünleri fiyata göre sırala
Select * from Products order by UnitPrice
--Ürünleri fiyata göre artan sırala
Select * from Products order by UnitPrice asc	--ascending
--default olarak fiyata göre artan sıralanır
--Ürünleri fiyata göre azalan sırala
Select * from Products order by UnitPrice desc	--descending

--Ürünleri categori id si 1 olanları getir satış fiyatına göre sırala
Select * from Products where CategoryID=1 order by UnitPrice desc

--count adet Bütün product tablosunda kaç satır var demek
Select count(*) from Products

--Categori id si 2 olan kaç tane ürünümüz var
Select count(*) from Products where CategoryID=1
--tablo adı adet olsun
Select count(*) Adet from Products where CategoryID=1
-- countun yanına herhangi bi kolon gelmez

--Hangi kategori de kaç farklı ürünümüz var
--Select * from Products group by CategoryID --group by da * kullanamazsın bu satır yanlış
Select categoryId from Products group by CategoryID 
--her bir kategori için grup oluşuyor.
Select categoryId,COUNT(*) from Products group by CategoryID 

--Ürün sayısı 10 dan az olan kategorileri listele
Select categoryId,COUNT(*) from Products group by CategoryID having count(*)<10

--önce where uygulanır.
--Birim fiyatı 20 den fazla olanları ürünleri kategori idye göre grupla her bir grupta 10 dan az olanı getir
Select categoryId,COUNT(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

--join tabloları birleştirme
Select *
from Products inner join Categories --hem products hemde categoriler bir araya getiriliyor
on Products.CategoryID=Categories.CategoryID --eşitlerse yan yana getir demek

--belirli kolonlar istersek
Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID

--DTO Data Transformation Object
--join ler DTO

--Ürünlerden Fiyatı 10 dan büyük olanları kategorilerle join et
Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10

--Order details de köşeli parantez olmasının sebebi ortada boşluk olmasından ötürü
Select * from Products p left join [Order Details] od --solda olup sağda olmayanlarıda getir demek Ürünlerde var ama satışı yoksa onları getir demek
on p.ProductID=od.ProductID

--830 sipariş - eşleşen siparişler
Select * from Customers c inner join Orders o
on c.CustomerID=o.CustomerID

--832 sipariş - müşterilerde olup siparişlerde olmayanarıda getirdi.
Select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID

--Sisteme kayıt olmuş sipariş vermemişleri getir (left teki fazla olan 2 kayıt geliyor.)
Select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null --null siparişlerde gelmeyen datalar pk ya uygularız.
--PK primary key null olamayacapı için ona uygularız.

Select * from Customers c right join Orders o --sağda olup solda olmayan demek
on c.CustomerID=o.CustomerID

--ikiden fazla tabloyu join etmek için
Select * from Products p inner join [Order Details] od 
on p.ProductID=od.ProductID
inner join Orders o
on o.OrderID=od.OrderID
-- daha fazla tablo eklemek istersen inner join deyip devam et.

