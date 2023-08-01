--DDL - Usado para criar banco e tabelas
--Criar Banco
CREATE DataBase Exercicio_1_1

--Usar banco criado
USE Exercicio_1_1

--Criar tabelas

CREATE TABLE Pessoa
(
	IdPessoa INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(15) NOT NULL,
	CNH VARCHAR(10) NOT NULL UNIQUE
);



CREATE TABLE Email
(
	IdEmail INT PRIMARY KEY IDENTITY,
	IdPessoa INT FOREIGN KEY REFERENCES Pessoa(IdPessoa) NOT NULL,
	EnderecoEmail VARCHAR(30) UNIQUE NOT NULL
);

CREATE TABLE Telefone
(
	IdTelefone INT PRIMARY KEY IDENTITY,
	IdPessoa INT FOREIGN KEY REFERENCES Pessoa(IdPessoa) NOT NULL,
	NumeroTelefone VARCHAR(20) UNIQUE NOT NULL
);

SELECT * FROM Pessoa
SELECT * FROM Email
SELECT * FROM Telefone