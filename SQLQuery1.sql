CREATE DATABASE BiblicosDB
GO 
USE BiblicosDB
GO
CREATE TABLE Biblicos
(
     LibroId int primary key identity (1,1),
	 Descripcion varchar (max),
	 Siglas varchar (30),
	 Tipo varchar (30)
);
