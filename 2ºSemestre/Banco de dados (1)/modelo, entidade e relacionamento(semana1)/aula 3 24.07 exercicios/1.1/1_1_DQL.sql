--DQL

--SCRIPT SEM USAR JOIN

--AS: serve para apelidar algo
USE Exercicio_1_1
SELECT 
	p.Nome AS NomePessoa, 
	Telefone.NumeroTelefone AS Telefone, 
	e.EnderecoEmail AS Email, 
	p.CNH


FROM 
	Pessoa AS p, 
	Email AS E, 
	Telefone

WHERE 
	p.IdPessoa = e.IdPessoa AND p.IdPessoa = Telefone.IdPessoa

ORDER BY 
	NOME DESC
--DESC: decrescente