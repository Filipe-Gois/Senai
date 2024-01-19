using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using System.Data.SqlClient;

namespace senai.inlock.webApi.Repositories
{
    public class UsuarioRepository : IUsuario
    {
        private string StringConexao = "Data Source = FILIPEGOIS\\SQLEXPRESS; Initial Catalog = inlock_games_tarde ; User = sa; Pwd = xtringer28700";

        public UsuarioDomain Login(UsuarioDomain usuario)
        {
            string Select = "SELECT Usuario.IdUsuario, Usuario.Email, Usuario.TipoUsuario, TipoUsuario.Titulo FROM Usuario INNER JOIN TipoUsuario ON TIpoUsuario.IdTipoUsuario = Usuario.IdTipoUsuario";

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                using (SqlCommand cmd = new SqlCommand(Select, con))
                {
                    con.Open();

                    SqlDataReader leitor;
                    leitor = cmd.ExecuteReader();

                    if (leitor.Read())
                    {
                        UsuarioDomain usuario = new UsuarioDomain()
                        {
                            IdUsuario = Convert.ToInt32(leitor["IdUsuario"]),
                            IdTipoUsuario = Convert.ToInt32(leitor["IdTipoUsuario"]),
                            Email = leitor["Email"].ToString()!,


                            TipoUsuario = new TipoUsuarioDomain()
                            {
                                Titulo = leitor["Titulo"].ToString()!
                            }
                        };

                        return usuario;
                    }
                }
            }
            return null;
        }
    }
}
