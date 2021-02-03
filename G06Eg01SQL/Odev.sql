/*
* ÖDEV AÇIKLAMASI
* Her bir üründen toplamda ne kadar para kazandığımızı bulunuz.
* İpucu : Group by kullanılacak
* İpucu : Products, Orders, Order Details tabloları join edilecek.
* İpucu : Sum kullanılacak.
* Sonuç aşağıdaki formatta olmalıdır.
* Ürün Adı, Kazanılan Toplam Miktar
*/

select ProductName as [Ürün Adı],
sum(od.Quantity*od.UnitPrice ) as [Kazanılan Toplam Miktar]
from Products
inner join [Order Details] od on od.ProductID=Products.ProductID 
group by ProductName order by [Kazanılan Toplam Miktar];