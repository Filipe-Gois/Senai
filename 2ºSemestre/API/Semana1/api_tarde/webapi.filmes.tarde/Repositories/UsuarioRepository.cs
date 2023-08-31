using System.Data.SqlClient;
using webapi.filmes.tarde.Domains;
using webapi.filmes.tarde.Interfaces;

namespace webapi.filmes.tarde.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string StringConexao = "Data Source = NOTE14-S14; Initial Catalog = Filmes_Tarde; User Id = sa; Pwd = Senai@134";
        public UsuarioDomain BuscarUsuario(string email, string senha)
        {
            UsuarioDomain usuarioo;
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                con.Open();
                string queryLogin = "SELECT Usuario.UsuarioNome, Usuario.UsuarioEmail, Usuario.UsuarioPermissao FROM Usuario WHERE Usuario.UsuarioEmail = @EmailUsuario AND Usuario.UsuarioSenha = @SenhaUsuario";

                
                using (SqlCommand cmd = new SqlCommand(queryLogin,con))
                {
                    
                    cmd.Parameters.AddWithValue("EmailUsuario", email);
                    cmd.Parameters.AddWithValue("SenhaUsuario", senha);

                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        usuarioo = new UsuarioDomain()
                        {
                            IdUsuario = Convert.ToInt32(rdr["IdUsuario"]),
                            UsuarioEmail = rdr["EmailUsuario"].ToString()!,
                            UsuarioPermissao = rdr["SenhaUsuario"].ToString()!

                        };
                        return usuarioo;
                    }
                }
            }
            return null!;
        }
        
    }
}
