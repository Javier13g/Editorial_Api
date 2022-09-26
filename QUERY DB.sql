CREATE DATABASE Editorial;

USE Editorial;

CREATE TABLE Editorial(
Cod_Editorial INT NOT NULL PRIMARY KEY IDENTITY(1,1),
Nombre_Editorial VARCHAR (15) NOT NULL,
Latitud_Ubicacion DECIMAL (8,6) NOT NULL,
Longitud_Ubicacion DECIMAL (9,6) NOT NULL
);  

INSERT INTO Editorial(Nombre_Editorial, Latitud_Ubicacion,
Longitud_Ubicacion) 
VALUES
('TestEdi', 18.493020928262276, -69.786390253944);


CREATE PROCEDURE EditorialRegistros
AS
BEGIN
  SELECT * FROM Editorial
END;

EXECUTE EditorialRegistros

