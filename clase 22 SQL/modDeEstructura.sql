--MODIFICACION DE LA ESTRUCTURA DE UNA BASE DE DATOS
SELECT * from Products

--agrego columna
ALTER TABLE Products
add outlet bit 

--quito columna
alter table Products
drop column outlet

--agrego columna not null que necesita un valor
alter table products
add outlet bit not null default 0
