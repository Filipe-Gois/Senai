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

INSERT INTO Aluguel(IdVeiculo, IdCliente, Valor, DataInicialAluguel, DataFinalAluguel)
VALUES(1, 1, 56.99,'13/08/2010','14/07/2013'), (3,3, 1239.97,'22/08/2014','30/04/2015'),(3,1,129.00,'20/04/2012','30/04/2012');


SELECT * FROM Marca
SELECT * FROM Empresa
SELECT * FROM Cliente
SELECT * FROM Modelo
SELECT * FROM Veiculo
SELECT * FROM Aluguel
