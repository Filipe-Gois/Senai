
--DML

USE [Event+_Tarde]

INSERT INTO TiposDeUsuario (TituloTipoUsuario)
VALUES
	('Administrador'),('Comum');
	

INSERT INTO TiposDeEvento (Titulo)
VALUES
	('SQL SERVER'),('C#'),('JavaScript');

SELECT * FROM TiposDeEvento
ORDER BY IdTipoDeEvento ASC

INSERT INTO Instituicao(CNPJ, Endereco, NomeFantasia)
VALUES
	('00534635000179','Rua Niter�i, 180 S�o Caetano do Sul', 'DevSchool');


INSERT INTO Usuario(IdTipoDeUsuario,Nome,Email,Senha)
VALUES
	(1,'Filipe G�is','filipe@gmail.com','1234'),(2,'Guilherme Alberto','guilherme@gmail.com','1234567');

INSERT INTO Evento(IdTipoDeEvento,IdInstituicao,Nome,Descricao,DataEvento,HoraEvento)
VALUES
	(2,1,'L�gica de programa��o com c#','Aprendendo o b�sico de c# e l�gica.', '19/12/2023','20:00'), (3,1,'L�gica de programa��o com JS',
	'Aprendendo o b�sico de JS', '28/10/2024','13:00');

INSERT INTO PresencasEvento(IdUsuario, IdEvento, Situacao)
VALUES
	(2,2,0), (1,1,1);

	delete PresencasEvento

INSERT INTO ComentarioEvento(IdUsuario,IdEvento,Descricao,Exibe)
VALUES
	(1,1,'�timo evento, aprendi muito!',1),(2,2,'Top!!',0);

	select * from TiposDeEvento
	select * from Instituicao
	select * from Usuario
	select * from Evento
	select * from PresencasEvento
	select * from PresencasEvento
	select * from ComentarioEvento