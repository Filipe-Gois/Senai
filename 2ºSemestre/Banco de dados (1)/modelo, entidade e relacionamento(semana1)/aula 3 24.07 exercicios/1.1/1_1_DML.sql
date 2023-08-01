USE Exercicio_1_1

--Jeito 1 (simplificado)
INSERT INTO Pessoa(Nome, CNH) 
VALUES('Filipe', '12345678'), ('Guilherme', '1236547'), ('Murilo','619123853')

--Jeito 2
--INSERT INTO Pessoa VALUES('Filipe', '12345678');

INSERT INTO Email(IdPessoa, EnderecoEmail) 
Values(1,'Filipe@gmail.com'), (2, 'Guilherme@gmail.com'),(3, 'Murilo@gmail.com')

SELECT * FROM Pessoa

SELECT * FROM Email