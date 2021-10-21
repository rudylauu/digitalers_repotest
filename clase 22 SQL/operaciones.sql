select * from Products
-- multiplica los precios por la cantidad total
select
	UnitPrice * quantity total-- total es un alias para la nueva columna
from [Order Details]

--agrupa los orderid repetidos y luego la funcion SUM multiplica los precios por la cantidad ya agrupados 
select orderid, SUM(UnitPrice * quantity) total from [Order Details]
group by orderid

select ProductID, SUM(UnitPrice * quantity) total from [Order Details]
group by ProductID

--COUNT: Cuenta las veces que aparece un valor

select OrderId, count(orderid) cantidad from [Order Details] group by OrderID

-- cuantos registros tiene una tabla
select count(orderid) from [Order Details]


--promedio
select ProductID, AVG(UnitPrice * quantity) total from [Order Details]
group by ProductID

--maximo y minimo
select ProductID, MAX(UnitPrice * quantity) total from [Order Details]
group by ProductID ORDER BY total Desc

select ProductID, MIN(UnitPrice * quantity) total from [Order Details]
group by ProductID
