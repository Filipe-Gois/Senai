USE Exercicio_1_1

--Jeito 1 (simplificado)
INSERT INTO Pessoa(Nome, CNH) 
VALUES
	('Filipe', '12345678'), 
	('Guilherme', '1236547'), 
	('Murilo','619123853');

--Jeito 2
--INSERT INTO Pessoa VALUES('Filipe', '12345678');

INSERT INTO Email(IdPessoa, EnderecoEmail) 
Values
	(1,'Filipe@gmail.com'),		
	(2,'Guilherme@gmail.com'),
	(3,'Murilo@gmail.com');

INSERT INTO Telefone(IdPessoa, NumeroTelefone)
VALUES
	(1, '11 911550'), 
	(2, '12 92354689'),
	(3, '13 986150574');

SELECT * FROM Pessoa
SELECT * FROM Email
SELECT * FROM Telefone
