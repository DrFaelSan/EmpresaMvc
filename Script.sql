-- 1 ) Criar DataBase

CREATE DATABASE MVCTeste;


-- 2 ) Criar Tabela

USE MVCTeste;
GO;
 

CREATE TABLE EMPRESA (
    Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(255) NOT NULL,
    Site NVARCHAR(255),
    QuantidadeFuncionarios int NOT NULL
);

GO;

-- 3 ) Inserir Registros

INSERT INTO EMPRESA ( NOME, SITE, QuantidadeFuncionarios ) 
VALUES( 'Apple', 'https://apple.com.br',50000);
	
	
INSERT INTO EMPRESA ( NOME, SITE, QuantidadeFuncionarios ) 
VALUES( 'Laser Fast', 'https://loja.laserfast.com.br',312);
	