USE Exercicio_1_2

INSERT INTO Marca(NomeMarca)
VALUES('Ford')

INSERT INTO Empresa(NomeEmpresa)
VALUES('Ford Company')

INSERT INTO Cliente(NomeCliente, CpfCliente)
VALUES('Guilherme', '12349812');

INSERT INTO Modelo(NomeModelo)
VALUES('Ka');

INSERT INTO Veiculo(IdMarca, IdEmpresa, IdModelo, NomeVeiculo)
VALUES(1,1,1, 'Ka 2023');

INSERT INTO Aluguel(IdVeiculo, IdCliente, Valor)
VALUES(1, 1, 56.99), (3,3, 1239.97),(3,1,129.00);


SELECT * FROM Marca
SELECT * FROM Empresa
SELECT * FROM Cliente
SELECT * FROM Modelo
SELECT * FROM Veiculo
SELECT * FROM Aluguel
