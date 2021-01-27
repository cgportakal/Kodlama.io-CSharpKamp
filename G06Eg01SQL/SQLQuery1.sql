--Select
Select ContactName Adi, CompanyName Sirketadi, City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive
seLeCT * from Products where categoryId = 1 or UnitPrice >= 10

select * from products where CategoryID = 1 and UnitPrice >= 10

select * from Products order by UnitPrice asc --asc default Kucukten Buyuge

select * from Products order by UnitPrice desc --desc Buyukten Kucuge

select count(*) from Products --Tabloda satır adedini verir 1x1 alanda sonuç verir

select count(*) Adet /*Adet aliastır*/ from Products where CategoryId = 1

/*
Group by kullanıldığı zaman sütun için * yani bütün sütunlar kullanılmaz.
Group By'da kullanmak istediğimizi orada kullanırız.
*/
Select CategoryID, count(*) Adet from Products
where UnitPrice > 20
group by CategoryID having count(*)<10 --Önce Group By ile CategoryID sütunu

Select CategoryID, count(*) Adet from Products
group by CategoryID
--DTO Data Transformation Object

--Join işlemleri, inner join sadece iki tabloda da eşleşen ürünler var ise onlaerı birleştirir
Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID 
where Products.UnitPrice > 25
order by UnitPrice asc

--Left join Solda olupda sağda olmayanları da getir.
select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null --primary key null olamayacağı için buna is null yazılır başka şeylere yazılmaz.