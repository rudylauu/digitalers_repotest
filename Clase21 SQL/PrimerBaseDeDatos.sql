--CREAR BASE DE DATOS
CREATE DATABASE Digitalers2021

-- SELECCIONAR Y POSICIONARNOS EN UNA BASE DE DATOS
USE Digitalers2021

--CREAR UNA BASE DE DATOS
CREATE TABLE dbo.MiPrimerTabla(
	ID INT
)
-- para borra una tabla
DROP TABLE Personas
-- CREO LA TABLA Y DEFINO LOS TIPOS DE VARIABLES QUE UTILIZARE
--PUEDO A�ADIR MAS ELEMENTOS PERO DEBO BORRAR LA TABLA Y LUEGO VOLVER A EJECUTARLA
CREATE TABLE Personas (
	LEGAJO INT IDENTITY,
	DNI INT NOT NULL,
	APELLIDOS NVARCHAR(40) NOT NULL,
	NOMBRE NVARCHAR(40) NOT NULL,
	APODO NVARCHAR(20) NOT NULL,
	ACTIVO BIT NOT NULL,
	FECHA_DE_NACIMIENTO DATE,
	PRIMARY KEY(LEGAJO)--PARA QUE LA CLAVE O INDICE A BUSCAR SEA EL LEGAJO
)
--DROP TABLE Personas

INSERT INTO Personas (DNI,APELLIDOS,NOMBRE,APODO,ACTIVO,FECHA_DE_NACIMIENTO) VALUES
(323232,'LAU','RUDY','KILO',1,'1997-01-18T21:26:00.000') --INSERTAR FILAS

INSERT INTO Personas (DNI,APELLIDOS,NOMBRE,APODO,ACTIVO,FECHA_DE_NACIMIENTO) VALUES
(6532566,'LAU','MARIO','LOCO',0,'2001-01-19T21:26:00.000')

INSERT INTO Personas (DNI,APELLIDOS,NOMBRE,APODO,ACTIVO,FECHA_DE_NACIMIENTO) VALUES
(2525256,'FLEITAS','ANDREA','LOLO',1,'1990-01-17T21:26:00.000')

INSERT INTO Personas (DNI,APELLIDOS,NOMBRE,APODO,ACTIVO,FECHA_DE_NACIMIENTO) VALUES
(645789,'ORTIZ','NICOLE','LOLO',0,'1952-01-17T21:26:00.000')

INSERT INTO Personas (DNI,APELLIDOS,NOMBRE,APODO,ACTIVO,FECHA_DE_NACIMIENTO) VALUES
(696969,'FIGUEROA','EMMANUEL','LOLO',1,'1987-01-17T21:26:00.000')

INSERT INTO Personas (DNI,APELLIDOS,NOMBRE,APODO,ACTIVO,FECHA_DE_NACIMIENTO) VALUES
(121212,'GARCIA','LAURA','LOLO',1,'1966-01-17T21:26:00.000')

INSERT INTO Personas (DNI,APELLIDOS,NOMBRE,APODO,ACTIVO,FECHA_DE_NACIMIENTO) VALUES
(636345,'LOBIANCO','HERNAN','LOLO',0,'1996-01-17T21:26:00.000')

INSERT INTO Personas (DNI,APELLIDOS,NOMBRE,APODO,ACTIVO,FECHA_DE_NACIMIENTO) VALUES
(694578,'LOBIANCO','NATALIA','LOLO',0,'1998-01-17T21:26:00.000')

SELECT DNI, APODO FROM Personas
WHERE DNI = 323232  OR DNI = 121212 --EL WHERE ME SIRVE PARA CONDICIONAR LO QUE QUIERO TRAER, Y PUEDO USAR OPERADORES NORMALES Y LOGICOS

