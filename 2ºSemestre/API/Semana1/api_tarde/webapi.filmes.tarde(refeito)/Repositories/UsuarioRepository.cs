using System.Data.SqlClient;
using webapi.filmes.tarde.Domains;
using webapi.filmes.tarde.Interfaces;

namespace webapi.filmes.tarde.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        // Senai
        private string StringConexao = "Data Source = NOTE14-S14; Initial Catalog = Filmes_Tarde; User Id = sa; Pwd = Senai@134";
        //Casa:
        //private string StringConexao = "Data Source = NOTEBOOKFAMILIA; Initial Catalog = Filmes; User Id = sa; Pwd = Murilo12$";


        public UsuarioDomain LoginUsuario(string email, string senha)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QuerySelectLogin = "SELECT Usuario.IdUsuario, Usuario.UsuarioNome, Usuario.UsuarioEmail, Usuario.UsuarioPermissao FROM Usuario WHERE Usuario.UsuarioEmail = @UsuarioEmail AND Usuario.UsuarioSenha = @UsuarioSenha";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(QuerySelectLogin, con))
                {
                    cmd.Parameters.AddWithValue("@UsuarioEmail", email);
                    cmd.Parameters.AddWithValue("@UsuarioSenha", senha);

                    SqlDataReader leitor = cmd.ExecuteReader();

                    if (leitor.Read())
                    {
                        UsuarioDomain usuario = new UsuarioDomain()
                        {
                            IdUsuario = Convert.ToInt32(leitor["IdUsuario"]),
                            Nome = Convert.ToString(leitor["UsuarioNome"]),
                            Email = Convert.ToString(leitor["UsuarioEmail"]),
                            Permissao = Convert.ToString(leitor["UsuarioPermissao"])
                        };

                        //usuario.Permissao = Convert.ToInt32(leitor["UsuarioPermissao"]) == 1 ? "Administrador" : "Usúario Comun";

                        return usuario;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public void UsuarioCadastrar(UsuarioDomain usuario)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string Insert = "INSERT INTO Usuario VALUES (@Email,@Senha,@Permissao,@NomeUsuario)";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(Insert,con))
                {
                    cmd.Parameters.AddWithValue("Email",usuario.Email);
                    cmd.Parameters.AddWithValue("Senha",usuario.Senha);
                    cmd.Parameters.AddWithValue("Permissao",usuario.Permissao);
                    cmd.Parameters.AddWithValue("NomeUsuario",usuario.Nome);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
