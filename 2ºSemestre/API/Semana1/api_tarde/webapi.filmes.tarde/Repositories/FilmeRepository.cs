using System.Data.SqlClient;
using webapi.filmes.tarde.Domains;
using webapi.filmes.tarde.Interfaces;

namespace webapi.filmes.tarde.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        public FilmeRepository()
        {
            
        }
        private string StringConexao = "Data Source = NOTE14-S14; Initial Catalog = Filmes_Tarde; User Id = sa; Pwd = Senai@134";
        public void AtualizarIdCorpo(FilmeDomain filme)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int id, FilmeDomain filme)
        {
            throw new NotImplementedException();
        }

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
                            filmeBuscado.IdFilme = Convert.ToInt32(rdr[0]);
                            filmeBuscado.IdGenero = Convert.ToInt32(rdr[1]);
                            filmeBuscado.NomeFilme = Convert.ToString(rdr[2]);

                        return filmeBuscado;
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
                    cmd.Parameters.AddWithValue("@NomeFilme", filme.NomeFilme);

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

        public List<FilmeDomain> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
