--1.Display the SalesOrderID, ShipDate of the SalesOrderHeader table (Sales schema)
--to show SalesOrders that occurred within the period ‘7/28/2002’ and ‘7/29/2014’

select soh.SalesOrderID,soh.ShipDate
from Sales.SalesOrderHeader soh
where soh.OrderDate between '7/28/2002' and '7/29/2014'

--2.Display only Products(Production schema) with a StandardCost below $110.00 (show ProductID, Name only)
select ProductID,Name
from Production.Product 
where StandardCost<110

--3.Display ProductID, Name if its weight is unknown
select ProductID,Name
from Production.Product 
where Product.Weight is null

--4.Display all Products with a Silver, Black, or Red Color
select *
from Production.Product 
where Product.Color in('silver','black','red')


--5.Display any Product with a Name starting with the letter B
select *
from Production.Product 
where Product.Name like 'b%'

--6.Run the following Query
--displays any Product description with underscore value in its description.

UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3

select * from Production.ProductDescription
where Production.ProductDescription.Description like '%_%'


--7.	Calculate sum of TotalDue for each OrderDate
--in Sales.SalesOrderHeader table for the period between  '7/1/2001' and '7/31/2014'
select sum (TotalDue) ,OrderDate
from Sales.SalesOrderHeader soh
where soh.OrderDate between '7/1/2001' and '7/31/2014'
group by OrderDate

--8.Display the Employees HireDate (note no repeated values are allowed)
select distinct HireDate
from HumanResources.Employee


--9.Calculate the average of the unique ListPrices in the Product table
select avg(distinct listprice )
from  Production.Product 


--10.	Display the Product Name and its ListPrice within the values of 100 and 120 
--the list should has the following format "The [product name] is only! 
--[List price]" (the list will be sorted according to its ListPrice value)

select CONCAT('the',Name, 'is only ',convert (varchar(20),ListPrice))
from Production .Product
where ListPrice between 100 and 120
order by ListPrice

--11.Transfer the rowguid ,Name, SalesPersonID, Demographics from Sales.Store table
--in a newly created table named [store_Archive]

select rowguid,Name,SalesPersonID,Demographics into sales.store_Archive
from Sales.Store

select rowguid,name,SalesPersonID,Demographics
from Sales.Store
where 1=2


--12.Using union statement, retrieve the today’s date in different styles using convert or format funtion.
select CONVERT(varchar,getdate(),111)
union 
select CONVERT(varchar,getdate(),104)

