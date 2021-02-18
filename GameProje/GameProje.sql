--Select
--ANSII
Select ContactName,CompanyName,City from Customers

	Select * from Customers where City = 'London'

--case insensitive
Select * from Products where CategoryID=1 or CategoriesID=3

Select * from Products where CategoryID=1 and UnitPrice>=10

Select * from Products where CategoryID=1 order by UnitPrice desc  --ascending  -- descending

Select count(*) Adet from Products where CategoryID=2

Select CategoryID, count(*) from products group by CategoryID

Select CategoryID,count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10

Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation

Select * from Products left join [Order Details]  od 
on p.ProductID=od.ProductID 

Select* from Customers c left join Orders o 
on c.CustomerID = o.CustomerID
where o.CustomerID is null