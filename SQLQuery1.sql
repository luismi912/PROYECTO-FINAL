CREATE DATABASE db_prestamos;
GO
USE db_prestamos;
GO

CREATE TABLE [Prestamistas] (
	[Id] INT PRIMARY KEY IDENTITY(1, 1),
	[Documento] NVARCHAR(20) NOT NULL,
	[Nombre] NVARCHAR(50) NOT NULL,
	[Apellido] NVARCHAR(50) NOT NULL,
	[FechaPrestamo] SMALLDATETIME NOT NULL DEFAULT GETDATE(),
	[TienePrestamo] BIT DEFAULT 0,
);

CREATE TABLE [Computadores] (
	[Id] INT PRIMARY KEY IDENTITY(1, 1),
	[Descripcion] NVARCHAR(200) NOT NULL,
	[Prestamista] INT NOT NULL REFERENCES [Prestamistas]([Id]),
	[Precio] DECIMAL(10, 2) NOT NULL,
	[Activo] BIT DEFAULT 1,
);

--QUERIES
INSERT INTO [Prestamistas] ([Documento], [Nombre], [Apellido], [FechaPrestamo], [TienePrestamo])
VALUES ('6465', 'Pepito', 'Perez', GETDATE(), 1);
INSERT INTO [Prestamistas] ([Documento], [Nombre], [Apellido], [FechaPrestamo], [TienePrestamo])
VALUES ('1238', 'Susana', 'Rincon', GETDATE(), 0);
INSERT INTO [Prestamistas] ([Documento], [Nombre], [Apellido], [FechaPrestamo], [TienePrestamo])
VALUES ('3453', 'Prueba', 'Prueba', GETDATE(), 1);

INSERT INTO [Computadores] ([Descripcion], [Prestamista], [Precio], [Activo])
VALUES ('Portatil Tactil LENOVO IdeaPad Slim 3 Intel Core i5 13420H RAM 24 GB 1 TB SSD IP S3', 
	2, 200000.0, 0);
INSERT INTO [Computadores] ([Descripcion], [Prestamista], [Precio], [Activo])
VALUES ('Portatil LENOVO IdeaPad Slim 3 AMD Ryzen 7 7735HS RAM 24 GB 1 TB SSD IP S3', 
	1, 100000.0, 1);

UPDATE [Prestamistas]
SET [Apellido] = 'Prueba'
WHERE [Id] = 3;

DELETE FROM [Prestamistas] WHERE [Id] = 3;

UPDATE [Prestamistas]
SET [Documento] = '9876'
WHERE [Id] = 1;

SELECT * FROM [Prestamistas];
SELECT * FROM [Computadores];
SELECT [Id]
      ,[Descripcion]
      ,[Prestamista]
      ,[Precio]
      ,[Activo]
FROM [Computadores];

SELECT C.[Id]
      ,C.[Descripcion]
      ,C.[Prestamista]
      ,C.[Precio]
      ,C.[Activo]
FROM [Computadores] AS C;

SELECT C.[Id]
      ,C.[Descripcion]
      ,C.[Prestamista]
      ,C.[Precio]
      ,C.[Activo]
      ,P.[Documento]
      ,P.[Nombre]
      ,P.[Apellido]
FROM [Computadores] C
	INNER JOIN [Prestamistas] P ON C.Prestamista = P.Id;