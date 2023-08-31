using System.Data.SqlClient;
using webapi.filmes.tarde.Domains;
using webapi.filmes.tarde.Interfaces;

namespace webapi.filmes.tarde.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {

        private string StringConexao = "Data Source = NOTE14-S14; Initial Catalog = Filmes_Tarde; User Id = sa; Pwd = Senai@134";

        /// <summary>
        /// Atualiza os dados de um filme passando seu ID pelo corpo 
        /// </summary>
        /// <param name="filme"></param>
        public void AtualizarIdCorpo(FilmeDomain filme)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string Update = "UPDATE Filme SET Filme.Titulo = @FilmeTitulo, Filme.IdGenero = @IdGenero WHERE Genero.Filme = @IdFilme";
                using (SqlCommand cmd = new SqlCommand(Update,con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@FilmeTitulo", filme.Titulo);
                    cmd.Parameters.AddWithValue("@IdGenero", filme.IdGenero);
                    cmd.Parameters.AddWithValue("@IdFilme",filme.IdFilme);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// Atualiza os dados de um filme passando seu ID pela URL
        /// </summary>
        /// <param name="id"></param>
        /// <param name="filme"></param>
        public void AtualizarIdUrl(int id, FilmeDomain filme)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string Update = "UPDATE Filme SET Filme.Titulo = @FilmeTitulo, Filme.IdGenero = @IdGenero WHERE Filme.IdFilme = @IdFilme";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(Update, con))
                {
                    cmd.Parameters.AddWithValue("FilmeTitulo", filme.Titulo);
                    cmd.Parameters.AddWithValue("IdGenero", filme.IdGenero);
                    cmd.Parameters.AddWithValue("IdFilme", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// Busca um filme através de seu ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FilmeDomain BuscarPorId(int id)
        {
            //FilmeDomain filme;
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryId = "SELECT Filme.IdFilme, Filme.Titulo, Genero.IdGenero, Genero.Nome FROM Filme INNER JOIN Genero ON Genero.IdGenero = Filme.IdGenero WHERE Filme.IdFilme = @IdFilme";
                
                
                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryId, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@IdFilme", id);
                    cmd.ExecuteNonQuery();

                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                       FilmeDomain filme = new FilmeDomain()
                        {

                            IdFilme = Convert.ToInt32(rdr["IdFilme"]),
                            IdGenero = Convert.ToInt32(rdr["IdGenero"]),
                            Titulo = rdr["Titulo"].ToString(),

                            Genero = new GeneroDomain()
                            {
                                IdGenero= Convert.ToInt32(rdr["IdGenero"]),
                                Nome = rdr["Nome"].ToString()
                            }

                        };

                        return filme;

                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Cadastra um novo filme
        /// </summary>
        /// <param name="filme"></param>
        public void Cadastrar(FilmeDomain filme)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string Insert = "INSERT INTO Filme VALUES(@IdGenero,@NomeFilme)";

                con.Open();
                using (SqlCommand cmd = new SqlCommand(Insert, con))
                {
                    cmd.Parameters.AddWithValue("@IdGenero", filme.IdGenero);
                    cmd.Parameters.AddWithValue("@NomeFilme", filme.Titulo);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// Deleta um filme através de seu ID
        /// </summary>
        /// <param name="id"></param>
        public void Deletar(int id)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string delete = "DELETE FROM Filme WHERE Filme.IdFilme = @IdFilme";
                con.Open();

                using (SqlCommand cmd = new SqlCommand(delete, con))
                {
                    cmd.Parameters.AddWithValue("@IdFilme", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// Lista todos os filmes cadastrados
        /// </summary>
        /// <returns></returns>
        public List<FilmeDomain> ListarTodos()
        {
            List<FilmeDomain> FilmesLista = new List<FilmeDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryAll = "SELECT Filme.IdFilme, Filme.Titulo, Filme.IdGenero , Genero.Nome FROM Filme INNER JOIN Genero ON Genero.IdGenero = Filme.IdGenero";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        FilmeDomain filme = new FilmeDomain()
                        {
                            IdFilme = Convert.ToInt32(rdr["IdFilme"]),
                            IdGenero = Convert.ToInt32(rdr["IdGenero"]),
                            Titulo = rdr["Titulo"].ToString(),

                            Genero = new GeneroDomain()
                            {
                                Nome = rdr["Nome"].ToString()
                            }
                        };


                        FilmesLista.Add(filme);

                    }

                }
            }
            return FilmesLista;

        }
    }
}
