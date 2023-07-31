-- DDL - Data Definition Language

--Cria banco de dados
CREATE DATABASE BancoTarde;

USE BancoTarde
--usado para trocar o banco de dados usado "como trocar de branch no git"

CREATE TABLE Funcionarios
(
-- Cria a coluna IdFuncionario contendo valores int. � A PK de Funcionarios. O "IDENTITY" serve para criar os Ids automaticamente, no caso, o cliente n�o precisa informar o id
	IdFuncionario INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(10)
	);


CREATE TABLE Empresas
(
	IdEmpresa INT PRIMARY KEY IDENTITY,
	--N�o nulo: colocar caso queria que o cliente seja obrigado a informar o dado (isso j� vem por padr�o na PK) .� tipo um "required" em HTML
	IdFuncionario INT FOREIGN KEY REFERENCES Funcionarios(IdFuncionario),
	--REFERENCES vai at� a tabela Funcionarios e pega a coluna IdFuncionario como refer�ncia
	[Name] VARCHAR(20)
);

------------------------------

--ALTER TABLE

--Adiociona uma coluna � tabela
ALTER TABLE Funcionarios
ADD CPF VARCHAR(11);



--Remove a coluna CPF
ALTER TABLE Funcionarios
DROP COLUMN CPF

--Remove a tabela Empresas
DROP TABLE Empresas

