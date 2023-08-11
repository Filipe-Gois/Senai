--DQL

-- Criar script para consulta exibindo os seguintes dados

/*Usar JOIN

Nome do usuário
Tipo do usuário
Data do evento
Local do evento (Instituição)
Tipo do evento
Nome do evento
Descrição do evento
Situação do evento
Comentário do evento
*/

USE [Event+_Tarde]

SELECT -- selecionando as colunas com os dados à serem exibidos
	Usuario.Nome,
	TiposDeUsuario.TituloTipoUsuario AS Acesso,
	Evento.DataEvento AS [Data],
	Evento.HoraEvento AS Hora,
	concat(Instituicao.NomeFantasia,' - ',Instituicao.Endereco) AS Endereço,
	TiposDeEvento.Titulo AS TipoDeEvento,
	Evento.Nome AS Evento,
	Evento.Descricao AS EventoDescricao,
	CASE WHEN PresencasEvento.Situacao = 1 THEN 'Confirmado' ELSE 'Não confirmado' END AS Situação,
	ComentarioEvento.Descricao AS ComentarioEvento

FROM
	Evento

INNER JOIN
TiposDeEvento

ON Evento.IdTipoDeEvento = TiposDeEvento.IdTipoDeEvento

INNER JOIN 
Instituicao

ON Evento.IdInstituicao = Instituicao.IdInstituicao

INNER JOIN 
PresencasEvento

ON PresencasEvento.IdEvento = Evento.IdEvento

INNER JOIN
Usuario
ON Usuario.IdUsuario = PresencasEvento.IdUsuario

INNER JOIN
TiposDeUsuario

ON Usuario.IdTipoDeUsuario = TiposDeUsuario.IdTipoDeUsuario

LEFT JOIN
ComentarioEvento

ON Usuario.IdUsuario = ComentarioEvento.IdUsuario