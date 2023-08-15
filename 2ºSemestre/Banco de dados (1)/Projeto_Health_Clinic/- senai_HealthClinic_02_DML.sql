USE Projeto_health_clinic

--DML

INSERT INTO TipoUsuario
VALUES
	('Administrador'),
	('Comum');

INSERT INTO Usuario
VALUES
	(1,'Filipe','Góis','filipe@gmail.com','12345'),
	(2,'Guilherme','Henrique','gui@gmail.com','12313')
	(2,'Richard','Felintro','Richard@gmail.com','192847'),
	(2,'Murilo','Souza','Murilo@gmail.com','3813740';


INSERT INTO Clinica
VALUES
	('Rua Niterói, 180.','05:00','23:00','H.C','Health Clinic','94065513000124');

INSERT INTO Paciente
VALUES
	(3,'454014983','22283554020'),
	(4,'129212209','42679620062');

INSERT INTO MedicoEspecialidade
VALUES
	('Pediatra'),
	('Nutricionista'),
	('Neurocirurgião');


INSERT INTO Medico
VALUES
	(1,3,2,'198245786','AM'),
	(1,1,1,'123457896','SP');

INSERT INTO Consulta
VALUES
	(2,2,'Consulta de rotina com o paciente Murilo Souza.'),
	(1,4,'Cirurgia de remoção de coágulo no cérebro.');


INSERT INTO Comentario
VALUES
	(3,2,1,'Doutor prestou um ótimo atendimento. Parabéns!!');

SELECT * FROM TipoUsuario
SELECT * FROM Usuario
SELECT * FROM Clinica
SELECT * FROM Paciente
SELECT * FROM MedicoEspecialidade
SELECT * FROM Medico
SELECT * FROM Consulta
SELECT * FROM Comentario
