CREATE DATABASE PrestamoComputadores;
GO

USE PrestamoComputadores;
Go

CREATE TABLE Prestamistas (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Documento VARCHAR(30) NOT NULL UNIQUE,
	Nombre VARCHAR(30) NOT NULL,
	PrimerApellido VARCHAR(50) NOT NULL,
	SegundoApellido VARCHAR(50),
	TienePrestamo BIT DEFAULT 0,
	FechaPrestamo SMALLDATETIME NOT NULL DEFAULT GETDATE(),   --Si no se envia fecha, ingresa la de hoy 
);

CREATE TABLE Computadores (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Descripcion NVARCHAR(200) NOT NULL,
	Prestamista INT NOT NULL REFERENCES Prestamistas(Id),
	Precio DECIMAL(10,2) NOT NULL,
	Activo BIT DEFAULT 1,
);

INSERT INTO Prestamistas (Documento, Nombre, PrimerApellido, SegundoApellido, TienePrestamo,FechaPrestamo)
VALUES ('32324', 'Luis', 'Arango', 'Garcia', 1, GETDATE() );
INSERT INTO Prestamistas (Documento, Nombre, PrimerApellido, SegundoApellido, TienePrestamo,FechaPrestamo)
VALUES ('23443', 'Gilma', 'Garcia', 'Martinez', 0, GETDATE() );
INSERT INTO Prestamistas (Documento, Nombre, PrimerApellido, SegundoApellido, TienePrestamo,FechaPrestamo)
VALUES ('3453', 'Prueba', 'Prueba', 'Martinez', 1, GETDATE() );

INSERT INTO Computadores (Descripcion, Prestamista, Precio, Activo)
VALUES ('Portatil Tactil LENOVO IdeaPad Slim 3 Intel Core i5 1340H RAM 24GB, 1 TB SSD IP S3', 2, 2000000.0, 0);
INSERT INTO Computadores (Descripcion, Prestamista, Precio, Activo)
VALUES ('Portatil LENOVO ideaPad Slimd AMD Ryzen 7 7735HS RAM 24 GB 1 TB SSD IP S3', 1, 1200000.0, 1);
12|1
UPDATE Prestamistas
SET PrimerApellido = 'Garcia'
WHERE Documento = '23443';

DELETE FROM Prestamistas WHERE Id = 2; 

SELECT * FROM Prestamistas;
SELECT * FROM Computadores
SELECT Id,
	   Descripcion,
	   Prestamista,
	   Precio,
	   Activo
FROM Computadores

SELECT C.Id,
	   C.Descripcion,
	   C.Prestamista,
	   C.Precio,
	   C.Activo
FROM Computadores AS C;

SELECT C.Id,
	   C.Descripcion,
	   C.Prestamista,
	   C.Precio,
	   C.Activo,
	   P.Documento,
	   P.Nombre,
	   P.PrimerApellido,
	   P.SegundoApellido
FROM Computadores C
INNER JOIN Prestamistas P ON 
C.Prestamista = p.Id;
