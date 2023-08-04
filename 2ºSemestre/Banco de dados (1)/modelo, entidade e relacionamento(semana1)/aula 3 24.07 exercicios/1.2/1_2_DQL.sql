--DQL (CONSULTA DE DADOS)
USE Exercicio_1_2

SELECT 
	IdAluguel,
	DataInicialAluguel AS Inicio,
	DataFinalAluguel AS Final,
	Cliente.NomeCliente,
	Veiculo.NomeVeiculo,
	Modelo.NomeModelo,
	Valor

FROM 
	Aluguel AS a

INNER JOIN Cliente

ON a.IdCliente = Cliente.IdCliente

INNER JOIN Veiculo

ON a.IdVeiculo = Veiculo.IdVeiculo

INNER JOIN Modelo

ON Veiculo.IdModelo = Modelo.IdModelo


