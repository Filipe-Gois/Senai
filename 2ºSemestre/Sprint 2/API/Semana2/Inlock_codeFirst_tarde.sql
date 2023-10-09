USE [inlock_games_codeFirst_tarde]

INSERT INTO Estudio
VALUES (NEWID(),'Sebrae'),(NEWID(),'adv');

INSERT INTO TiposUsuario
VALUES (NEWID(),'Administrador'),(NEWID(),'Comum');

INSERT INTO Usuario
VALUES (NEWID(),'Filipe','fe@gmail.com','1234567','A43666C4-1B34-4AE3-8E86-55BE81BF2628'), 
(NEWID(),'Guilherme','gui@gmail.com', '1234567','59545101-C5F1-480F-90EC-647480FA9FEA');

INSERT INTO Jogo
VALUES (NEWID(),'Jogo1','Muito legal','2019-01-12',0.99,'94482165-59C2-495A-8CBC-386B561B6A49'),
(NEWID(),'Jogo2','Muito chato','2023-09-14',89.9,'30F24F15-45E4-4DC0-BF11-77C3089E49C5');

SELECT * FROM Estudio
SELECT * FROM TiposUsuario
SELECT * FROM Usuario
SELECT * FROM Jogo