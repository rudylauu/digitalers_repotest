select 
	[CategoryID],
	[CategoryName],
	[Description]
	from Categories
ORDER BY CategoryName DESC; --ordena descendiente

SELECT * FROM Employees
ORDER BY FirstName, TitleOfCourtesy; --ORDEN DE DOS COLUMNAS, LE DA PRIORIDAD A LA PRIMERA QUE ESCRIBI

SELECT * FROM Customers
where Country = 'USA' AND (Region = 'OR' OR Region= 'WA') 
order by CompanyName asc