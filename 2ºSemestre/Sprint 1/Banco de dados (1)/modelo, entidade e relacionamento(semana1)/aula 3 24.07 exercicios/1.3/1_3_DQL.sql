--DQL

USE Exercicio_1_3

SELECT
	Clinica.Nome AS Clinica,
	Veterinario.IdVeterinario AS CRMV,
	Veterinario.NomeVeterinario

FROM 
	Clinica

INNER JOIN Veterinario

ON Clinica.IdClinica = Veterinario.IdClinica

--


SELECT
	Raca.IdRaca,
	Raca.Nome AS [Raça]

From Raca

WHERE Raca.Nome like 'S%'

--

SELECT
	TipoPet.IdTipoPet,
	TipoPet.Nome

From TipoPet

WHERE TipoPet.Nome like '%O'

--

SELECT
	Pet.IdPet,
	Pet.Nome,
	Dono.Nome

FROM Pet

INNER JOIN Dono

ON Pet.IdDono = Dono.IdDono

--

SELECT
	Atendimento.IdAtendimento,
	Veterinario.NomeVeterinario,
	Pet.Nome AS 'Pet nome',
	Raca.Nome AS 'Raça',
	TipoPet.Nome AS 'Tipo pet',
	Dono.Nome AS 'Dono',
	Clinica.Nome AS 'Clínica'

FROM
	Atendimento

INNER JOIN Veterinario

ON Veterinario.IdVeterinario = Atendimento.IdVeterinario

INNER JOIN Pet

ON Pet.IdPet = Atendimento.IdPet

INNER JOIN Raca

ON Raca.IdRaca = Pet.IdRaca

INNER JOIN TipoPet

ON TipoPet.IdTipoPet = Pet.IdPet

INNER JOIN Dono

ON Dono.IdDono = Pet.IdDono

INNER JOIN Clinica

ON Clinica.IdClinica = Veterinario.IdClinica