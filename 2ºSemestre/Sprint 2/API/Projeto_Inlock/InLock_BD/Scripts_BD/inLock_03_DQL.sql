USE inlock_games_tarde;

SELECT * FROM TiposUsuario;

SELECT * FROM Usuario;

SELECT * FROM Estudio;

SELECT * FROM Jogo;

SELECT Jogo.NomeJogo AS Jogo,Estudio.NomeEstudio AS Estudio From Jogo
INNER JOIN Estudio
ON Jogo.IdEstudio = Estudio.IdEstudio;

SELECT Estudio.NomeEstudio AS Estudio,Jogo.NomeJogo AS Jogo FROM Estudio
LEFT JOIN Jogo
ON Estudio.IdEstudio = Jogo.IdEstudio;

SELECT * FROM Usuario WHERE Email = 'cliente@cliente.com' AND Senha = 'cliente';

SELECT * FROM Jogo WHERE IdJogo = 4;

SELECT * FROM Estudio WHERE IdEstudio = 2;

SELECT Estudio.IdEstudio,Estudio.NomeEstudio,Jogo.NomeJogo FROM Estudio
LEFT JOIN Jogo
ON Estudio.IdEstudio = Jogo.IdEstudio;



