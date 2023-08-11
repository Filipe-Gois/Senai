--DQL

-- Criar script para consulta exibindo os seguintes dados

/*Usar JOIN

Nome do usu�rio
Tipo do usu�rio
Data do evento
Local do evento (Institui��o)
Tipo do evento
Nome do evento
Descri��o do evento
Situa��o do evento
Coment�rio do evento
*/

USE [Event+_Tarde]

SELECT -- selecionando as colunas com os dados � serem exibidos
	Usuario.Nome,
	TiposDeUsuario.TituloTipoUsuario AS Acesso,
	Evento.DataEvento AS [Data],
	Evento.HoraEvento AS Hora,
	concat(Instituicao.NomeFantasia,' - ',Instituicao.Endereco) AS Endere�o,
	TiposDeEvento.Titulo AS TipoDeEvento,
	Evento.Nome AS Evento,
	Evento.Descricao AS EventoDescricao,
	CASE WHEN PresencasEvento.Situacao = 1 THEN 'Confirmado' ELSE 'N�o confirmado' END AS Situa��o,
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