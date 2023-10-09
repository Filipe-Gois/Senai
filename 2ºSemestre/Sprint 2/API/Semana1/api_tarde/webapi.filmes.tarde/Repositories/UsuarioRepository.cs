using System.Data.SqlClient;
using webapi.filmes.tarde.Domains;
using webapi.filmes.tarde.Interfaces;

namespace webapi.filmes.tarde.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string StringConexao = "Data Source = NOTE14-S14; Initial Catalog = Filmes_Tarde; User Id = sa; Pwd = Senai@134";

        /// <summary>
        /// Método de Login
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public UsuarioDomain BuscarUsuario(string email, string senha)
        {
            UsuarioDomain usuarioo;
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                con.Open();
                string queryLogin = "SELECT Usuario.IdUsuario, Usuario.UsuarioNome, Usuario.UsuarioEmail, Usuario.UsuarioPermissao FROM Usuario WHERE Usuario.UsuarioEmail = @EmailUsuario AND Usuario.UsuarioSenha = @SenhaUsuario";


                using (SqlCommand cmd = new SqlCommand(queryLogin, con))
                {

                    cmd.Parameters.AddWithValue("EmailUsuario", email);
                    cmd.Parameters.AddWithValue("SenhaUsuario", senha);

                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        usuarioo = new UsuarioDomain()
                        {
                            IdUsuario = Convert.ToInt32(rdr["IdUsuario"]),
                            UsuarioNome = rdr["UsuarioNome"].ToString()!,
                            UsuarioEmail = rdr["EmailUsuario"].ToString()!,
                            UsuarioPermissao = rdr["UsuarioPermissao"].ToString()!

                        };
                        return usuarioo;
                    }
                }
            }
            return null!;
        }

    }
}
