----Criar função para retornar os médicos de uma determinada especialidade
USE Projeto_health_clinic

CREATE FUNCTION MedicoEspecialidadeBuscada(@dt VARCHAR(50))
RETURNS TABLE

AS

RETURN
(
	SELECT M.Nome,
	MedicoEspecialidade.Titulo
FROM 
MedicoEspecialidade

INNER JOIN
Medico

ON
MedicoEspecialidade.IdMedicoEspecialidade = Medico.IdMedicoEspecialidade

INNER JOIN
Usuario M

ON
M.IdUsuario = Medico.IdUsuario

WHERE 
MedicoEspecialidade.Titulo LIKE @dt

);
--DROP FUNCTION MedicoEspecialidadeBuscada


select *
from
MedicoEspecialidadeBuscada('Neurocirurgião')