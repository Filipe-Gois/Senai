--DML Data Manipulation Language

INSERT INTO Funcionarios([Name])
VALUES('Filipe2');


UPDATE Funcionarios
SET [Name] = 'FilipeG�is' WHERE [Name] = 'FILIPE2';
--"seta" o nome "FilipeG�is" onde o nome for "Filipe2"

UPDATE Funcionarios
SET [Name] = 'FilipeG�is' WHERE IdFuncionario = 8;


--Se n�o especificar o que ir� ser exclu�do, ele apagar� todos os dados da tabela
DELETE FROM Funcionarios;