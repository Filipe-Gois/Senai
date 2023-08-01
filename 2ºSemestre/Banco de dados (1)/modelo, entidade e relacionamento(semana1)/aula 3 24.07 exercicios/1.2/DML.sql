USE Exercicio_1_2

INSERT INTO Marca(NomeMarca)
VALUES('Ford')

INSERT INTO Empresa(NomeEmpresa)
VALUES('Ford Company')

INSERT INTO Cliente(NomeCliente, CpfCliente)
VALUES('Filipe Góis','12345678');

INSERT INTO Modelo(NomeModelo)
VALUES('Ka');

INSERT INTO Veiculo(IdMarca, IdEmpresa, IdModelo)
VALUES(1,1,1);



SELECT * FROM Marca
SELECT * FROM Empresa
SELECT * FROM Cliente
SELECT * FROM Modelo
SELECT * FROM Veiculo

