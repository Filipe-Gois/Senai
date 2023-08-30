using System.Data.SqlClient;
using webapi.filmes.tarde.Domains;
using webapi.filmes.tarde.Interfaces;

namespace webapi.filmes.tarde.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {

        private string StringConexao = "Data Source = NOTE14-S14; Initial Catalog = Filmes_Tarde; User Id = sa; Pwd = Senai@134";
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
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FilmeDomain BuscarPorId(int id)
        {
            FilmeDomain filmeBuscado = new FilmeDomain();
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryId = "SELECT Filme.IdFilme, Filme.Titulo, Genero.Nome FROM Filme INNER JOIN Genero ON Genero.IdGenero = Filme.IdGenero WHERE Filme.IdFilme = @IdFilme";

                con.Open();
                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryId, con))
                {
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
                                NomeGenero = rdr["Nome"].ToString()
                            }

                        };

                        return filme;




                    }
                }

            }

            return null;

        }

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
        /// 
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
                                NomeGenero = rdr["Nome"].ToString()
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
