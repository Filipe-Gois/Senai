﻿// Ctrl + kd -> identa o código

using System.Data.SqlClient;
using webapi.filmes.tarde.Domains;
using webapi.filmes.tarde.Interfaces;

namespace webapi.filmes.tarde.Repositories
{
    /// <summary>
    /// Repository que será responsável pelas regras de negócios da entidade(tabela) Filme - assm como fazer seus CRUD
    /// </summary>
    public class FilmeRepository : IFilmeRepository
    {
        // Senai
        private string StringConexao = "Data Source = NOTE14-S14; Initial Catalog = Filmes_Tarde; User Id = sa; Pwd = Senai@134";
        //Casa:
        //private string StringConexao = "Data Source = NOTEBOOKFAMILIA; Initial Catalog = Filmes; User Id = sa; Pwd = Murilo12$";

        /// <summary>
        /// Método responsável por atualizar determinado filme pela Url
        /// </summary>
        /// <param name="_idFilme">Id do filme passado pela url</param>
        /// <param name="_filmeAtualizado">Objeto com as novas informações do filme</param>
        public void AtualizarPelaUrl(int _idFilme, FilmeDomain _filmeAtualizado)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QueryUptadeByUrl = "UPDATE Filme SET Filme.IdGenero = @IdGenero, Filme.Titulo = @Titulo WHERE Filme.IdFilme = @IdFilme;";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(QueryUptadeByUrl, con))
                {
                    cmd.Parameters.AddWithValue("@IdGenero", _filmeAtualizado.Genero.IdGenero);
                    cmd.Parameters.AddWithValue("@Titulo", _filmeAtualizado.Titulo);
                    cmd.Parameters.AddWithValue("@IdFilme", _idFilme);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        /// <summary>
        /// Método responsável por atualizar um filme
        /// </summary>
        /// <param name="_filmeAtualizado">Objeto com as novas informações do filme</param>
        public void AtualizarPeloCorpo(FilmeDomain _filmeAtualizado)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QueryUptade = "UPDATE Filme SET Filme.Titulo = @FilmeTitulo, Filme.IdGenero = @IdGenero WHERE Genero.Filme = @IdFilme";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(QueryUptade, con))
                {
                    cmd.Parameters.AddWithValue("@IdGenero", _filmeAtualizado.IdGenero);
                    cmd.Parameters.AddWithValue("@Titulo", _filmeAtualizado.Titulo);
                    cmd.Parameters.AddWithValue("@IdFilme", _filmeAtualizado.IdFilme);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Método responsável por buscar um determinado filme pelo seu id
        /// </summary>
        /// <param name="_idFilme">Id do filme a ser buscado</param>
        /// <returns>O objeto contendo o filme buscado</returns>
        public FilmeDomain BurcarPorId(int _idFilme)
        {

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QuerySelectById = "SELECT Filme.IdFilme, Filme.Titulo, Genero.IdGenero, Genero.Nome FROM Filme INNER JOIN Genero ON Genero.IdGenero = Filme.IdGenero WHERE Filme.IdFilme = @IdFilme;";

                con.Open();

                SqlDataReader leitor;

                using (SqlCommand cmd = new SqlCommand(QuerySelectById, con))
                {
                    cmd.Parameters.AddWithValue("@Id", _idFilme);
                    leitor = cmd.ExecuteReader();

                    if (leitor.Read())
                    {
                        FilmeDomain filme = new FilmeDomain()
                        {
                            IdFilme = Convert.ToInt32(leitor["IdFilme"]),
                            Titulo = Convert.ToString(leitor["Titulo"]),
                            IdGenero = Convert.ToInt32(leitor["IdGenero"]),
                            Genero = new GeneroDomain()
                            {
                                IdGenero = Convert.ToInt32(leitor["IdGenero"]),
                                Nome = Convert.ToString(leitor["Nome"])
                            }

                        };
                        return filme;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Método para cadastrar um novo filme
        /// </summary>
        /// <param name="_novoFilme">Objeto contendo as informações do filme a ser cadastrado</param>
        public void CadastrarFilme(FilmeDomain _novoFilme)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QueryInsert = "INSERT INTO Filme VALUES(@IdGenero,@NomeFilme)";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(QueryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@IdGenero", _novoFilme.IdGenero);
                    cmd.Parameters.AddWithValue("@Titulo", _novoFilme.Titulo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Método responsável por deletar determinado filme pelo seu Id
        /// </summary>
        /// <param name="_idFilme">Id do filme a ser deletado</param>
        public void DeletarFilme(int _idFilme)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QueryDelete = "DELETE FROM Filme WHERE Filme.IdFilme = @IdFilme";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(QueryDelete, con))
                {
                    cmd.Parameters.AddWithValue("@IdFilme", _idFilme);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Método que será responsável por listar todos os filmes cadastrados
        /// </summary>
        /// <returns>Lista com todos os filmes cadastrados</returns>
        public List<FilmeDomain> ListarFilmes()
        {
            List<FilmeDomain> listaDeFilmes = new List<FilmeDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string SelecionaTodosFilmes = "SELECT Filme.IdFilme, Filme.Titulo, Filme.IdGenero, Genero.Nome FROM Filme INNER JOIN Genero ON Genero.IdGenero = Filme.IdGenero";

                con.Open();

                SqlDataReader leitor;

                using (SqlCommand cmd = new SqlCommand(SelecionaTodosFilmes, con))
                {
                    leitor = cmd.ExecuteReader();

                    while (leitor.Read())
                    {
                        FilmeDomain filme = new FilmeDomain()
                        {
                            IdFilme = Convert.ToInt32(leitor["IdFilme"]),
                            Titulo = Convert.ToString(leitor["Titulo"]),
                            IdGenero = Convert.ToInt32(leitor["IdGenero"]),
                            Genero = new GeneroDomain()
                            {
                                IdGenero = Convert.ToInt32(leitor["IdGenero"]),
                                Nome = Convert.ToString(leitor["Nome"])
                            }
                        };

                        listaDeFilmes.Add(filme);
                    }
                }
            }
            return listaDeFilmes;
        }
    }
}
