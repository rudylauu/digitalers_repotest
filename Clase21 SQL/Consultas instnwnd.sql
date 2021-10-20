select 
	[CategoryID],
	[CategoryName],
	[Description]
	from Categories
ORDER BY CategoryName DESC; --ordena descendiente

SELECT * FROM Employees
ORDER BY FirstName, TitleOfCourtesy; --ORDEN DE DOS COLUMNAS, LE DA PRIORIDAD A LA PRIMERA QUE ESCRIBI

SELECT * FROM Customers
where Country = 'USA' AND (Region = 'OR' OR Region= 'WA') --conectores logicos
order by CompanyName asc

SELECT * FROM Products
where UnitPrice <> 53 --distinto <>
order by UnitPrice desc

select * from Products  -- booleanos se escriben como bit "1,0"
where Discontinued = 1

SELECT * FROM Customers
where Country = 'USA' AND Region IN ('OR','WA') --conectores logicos
order by CompanyName asc

select * from Customers
where ContactTitle like '%Manager%'-- busca dentro de la columna todos los que tengan la palabra Manager, el % significa que hay cualquier cosa en ese lugar


select * from Customers where Region IS NULL -- traer los que son nulos 

select * from Customers-- corroboro antes que quiero cambiar para no arruiar la base
where Country ='Argentina'

update Customers set-- luego ejecuto esto para actualizar la celda correcta
PostalCode = '1876'
where Country ='Argentina'


