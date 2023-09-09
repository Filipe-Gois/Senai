using senai.inlock.webApi_.Domains;
using senai.inlock.webApi_.Interfaces;
using System.Data.SqlClient;

namespace senai.inlock.webApi_.Repositories
{
    public class UsuarioRepository : IUsuario
    {
        //private string StringConexao { get; set; } = "Data Source = NOTE14-S14; Initial Catalog = inlock_games_tarde; User Id = sa; Pwd = Senai@134";
        private string StringConexao { get; set; } = "Data Source = FILIPEGOIS\\SQLEXPRESS; Initial Catalog = inlock_games_tarde; User Id = sa; Pwd = xtringer28700";

        public UsuarioDomain Login(string email, string senha)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string usuarioAutenticacao = "SELECT Usuario.IdUsuario, Usuario.Email, Usuario.IdTipoUsuario, TiposUsuario.Titulo FROM Usuario INNER JOIN TiposUsuario ON TiposUsuario.IdTipoUsuario = Usuario.IdTipoUsuario WHERE Usuario.Email = @Email AND Usuario.Senha = @Senha";

                SqlDataReader leitor;
                con.Open();

                using (SqlCommand cmd = new SqlCommand(usuarioAutenticacao, con))
                {
                    cmd.Parameters.AddWithValue("Email", email);
                    cmd.Parameters.AddWithValue("Senha", senha);

                    leitor = cmd.ExecuteReader();

                    if (leitor.Read())
                    {
                        UsuarioDomain usuario = new UsuarioDomain()
                        {
                            IdUsuario = Convert.ToInt32(leitor["IdUsuario"]),
                            EmailUsuario = leitor["Email"].ToString()!,
                            IdTipoUsuario = Convert.ToInt32(leitor["IdTipoUsuario"]),

                            tipoUsuario = new TipoUsuarioDomain()
                            {
                                TituloTipoUsuario = leitor["Titulo"].ToString()
                            }

                        };

                        return usuario;

                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
    }
}
