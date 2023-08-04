--DQL

--SCRIPT SEM USAR JOIN

--AS: serve para apelidar algo
USE Exercicio_1_1

SELECT 
	Nome,
	CNH,
	Telefone.NumeroTelefone, 
	Email.EnderecoEmail


FROM
	Pessoa


INNER JOIN Telefone
ON Pessoa.IdPessoa = Telefone.IdPessoa

INNER JOIN Email
ON  Pessoa.IdPessoa = Email.IdPessoa


ORDER BY 
	NOME DESC
--DESC: decrescente

/*WHERE 
	p.IdPessoa = e.IdPessoa AND p.IdPessoa = Telefone.IdPessoa
	*/
