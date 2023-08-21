--DML

INSERT INTO Genero
VALUES
	('Comédia'),('Terror');

INSERT INTO Filme
VALUES
	(2,'A freira'),(1,'As branquelas');

SELECT * FROM Genero
SELECT * FROM Filme

SELECT
Filme.Titulo,
Genero.Nome

From
Filme

INNER JOIN
Genero

ON
Genero.IdGenero = Filme.IdGenero