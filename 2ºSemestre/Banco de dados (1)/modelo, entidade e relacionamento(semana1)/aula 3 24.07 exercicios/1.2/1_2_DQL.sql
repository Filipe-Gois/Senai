--DQL (CONSULTA DE DADOS)
USE Exercicio_1_2

SELECT 
	a.IdAluguel,
	a.IdCliente,
	a.IdVeiculo,
	a.Valor


FROM 
	Cliente AS c,
	Aluguel AS a,
	Veiculo AS v,

INNER JOIN
	Veiculo

ON

