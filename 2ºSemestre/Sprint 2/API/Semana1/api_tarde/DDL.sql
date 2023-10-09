--DDL
CREATE DATABASE Filmes_Tarde
USE Filmes_Tarde

CREATE TABLE Genero
(
	IdGenero INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50)
);

--A coluna Genero.Nome´já está com NOT NULL e UNIQUE

ALTER TABLE Genero
ADD UNIQUE(Nome)

CREATE TABLE Filme
(
	IdFilme INT PRIMARY KEY IDENTITY,
	IdGenero INT FOREIGN KEY REFERENCES Genero(IdGenero),
	Titulo VARCHAR(50) NOT NULL
);

--ALTER TABLE Filme
--ALTER COLUMN IdGenero INT NOT NULL



CREATE TABLE Usuario
(
	IdUsuario INT PRIMARY KEY IDENTITY,
	UsuarioEmail VARCHAR(50) NOT NULL UNIQUE,
	UsuarioSenha VARCHAR(50) NOT NULL,
	UsuarioPermissao VARCHAR(30),
	UsuarioNome VARCHAR(50) NOT NULL
);

INSERT INTO Usuario
VALUES
	('guilhermee@gmail.com','1234567','Comum','Guilherme');

	select * from Usuario

	SELECT Usuario.UsuarioNome, Usuario.UsuarioEmail, Usuario.UsuarioPermissao FROM Usuario WHERE Usuario.UsuarioEmail = 'filipe@gmail.com' AND Usuario.UsuarioSenha = '123'