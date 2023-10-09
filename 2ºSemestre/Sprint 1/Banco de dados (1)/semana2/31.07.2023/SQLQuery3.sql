--DML Data Manipulation Language

INSERT INTO Funcionarios([Name])
VALUES('Filipe2');


UPDATE Funcionarios
SET [Name] = 'FilipeGóis' WHERE [Name] = 'FILIPE2';
--"seta" o nome "FilipeGóis" onde o nome for "Filipe2"

UPDATE Funcionarios
SET [Name] = 'FilipeGóis' WHERE IdFuncionario = 8;


--Se não especificar o que irá ser excluído, ele apagará todos os dados da tabela
DELETE FROM Funcionarios;