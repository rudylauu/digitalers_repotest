--FUNCIONES

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

--UNIONES
---relaciones de tablas con FOREIGN KEY REFERENCES
create table MisProductos (
OrderID int identity primary Key,
ProductID int foreign key references products(ProductID)
)

select * from Products 

--para unirlas utilizo el Join y colocra un alias siempre para despues colocar la condicion
Select -- columnas que deseo traer
	OrderID,
	P.ProductID, --colocar el alias para saber de que tabla traer y quitar la ambiguedad
	P.ProductName,
	D.UnitPrice
from [Order Details] D
Join Products P ON D.ProductID = P.ProductID

select
	O.OrderID,
	O.CustomerID,
	E.EmployeeID,
	E.LastName
from Orders O 
LEFT JOIN Employees E ON O.EmployeeID = E.EmployeeID

SELECT * FROM Orders
SELECT * FROM Employees