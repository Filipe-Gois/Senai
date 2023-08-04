--DML

USE Exercicio_1_3

INSERT INTO Dono(Nome, CPF, RG)
VALUES
	('Filipe',123456,1234812),
	('Gui', 98765142, 7246814);

INSERT INTO Raca
VALUES
	('Pitbull'),
	('Poodle'),
	('Shih tzu');

INSERT INTO TipoPet
VALUES
	('Cachorro'),
	('Gato');

INSERT INTO Clinica
VALUES
	('Pet Love', 'Rua São Francisco'),
	('Pet Senai', 'Rua Niterói');

INSERT INTO Veterinario
VALUES
	(1,'João'),
	(2,'Kleber');

INSERT INTO Atendimento
VALUES
	(1,1),
	(3,2);

INSERT INTO Pet
VALUES
	(1,2,1,'Toy','20/07/2016'),
	(2,1,1, 'Snow','17/03/2020');

INSERT INTO Atendimento
VALUES
	(1,5),
	(2,6);


SELECT * FROM Dono
SELECT * FROM Raca
SELECT * FROM TipoPet
SELECT * FROM Clinica
SELECT * FROM Veterinario
SELECT * FROM Pet
SELECT * FROM Atendimento

DELETE FROM Veterinario where IdVeterinario = 4