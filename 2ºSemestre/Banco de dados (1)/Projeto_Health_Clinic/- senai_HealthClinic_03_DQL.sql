--DQL

USE Projeto_health_clinic


--Criar script que exiba os seguintes dados:
--Nome da Clinica,
--Nome do Paciente,
--IdConsulta,
--Nome do m�dico
--Especialidade do m�dico,
--CRM,
--Feedback(Comentario da consulta)

--Criar fun��o para retornar os m�dicos de uma determinada especialidade

--Criar procedure para retornar a idade de um determinado usu�rio espec�fico



SELECT
Concat(Clinica.NomeFantasia,' - ', Clinica.RazaoSocial) AS Cl�nica,
P.Nome AS [Nome do paciente],
Consulta.IdConsulta,
m.Nome AS [Nome do m�dico],
MedicoEspecialidade.Titulo AS [Especialidade do m�dico],
CONCAT(Medico.CRM,'-', Medico.Estado) AS CRM,
Comentario.Descricao,
Case when Comentario.Exibe = 1 THEN 'Aprovado' ELSE 'Reprovado' END AS [Situa��o do coment�rio]


FROM
Consulta

INNER JOIN
Medico

ON
Medico.IdMedico = Consulta.IdMedico

INNER JOIN
Paciente

ON
Paciente.IdPaciente = Consulta.IdPaciente

INNER JOIN
MedicoEspecialidade

ON
Medico.IdMedicoEspecialidade = MedicoEspecialidade.IdMedicoEspecialidade

INNER JOIN
Clinica

ON
Clinica.IdClinica = Medico.IdClinica

LEFT JOIN
Comentario

ON
Comentario.IdConsulta = Consulta.IdConsulta

INNER JOIN
Usuario P

ON
P.IdUsuario = Paciente.IdUsuario


INNER JOIN
Usuario M

ON
M.IdUsuario =Medico.IdUsuario




--CREATE FUNCTION MedicoseEspecialidadesBuscadas(@MEDICO2 VARCHAR(20), @ESPECIALIDADE2 VARCHAR(50))
--RETURNS @TbMedicoEspecialidade TABLE(ID INT PRIMARY KEY NOT NULL IDENTITY, 
--									 MedicoNome VARCHAR(20) NOT NULL,
--									 MedicoEspecialidade VARCHAR (50) NOT NULL)

--AS	

--BEGIN
	

--END


