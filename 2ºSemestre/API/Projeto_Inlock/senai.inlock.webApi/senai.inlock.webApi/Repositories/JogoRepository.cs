using senai.inlock.webApi_.Domains;
using senai.inlock.webApi_.Interfaces;
using System.Data.SqlClient;

namespace senai.inlock.webApi_.Repositories
{
    public class JogoRepository : IJogo
    {
        public string StringConexao { get; set; } = "Data Source = NOTE14-S14; Initial Catalog = inlock_games_tarde; User Id = sa; Pwd = Senai@134";

        public void CadastrarJogo(JogoDomain jogo)
        {


            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string INSERT = "INSERT INTO Jogo VALUES(@IdJogo,@IdEstudio,@NomeJogo,@DescricaoJogo,@DataLancamentoJogo,@ValorJogo);";

                using (SqlCommand cmd = new SqlCommand(INSERT, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("IdJogo", jogo.IdJogo);
                    cmd.Parameters.AddWithValue("IdEstudio", jogo.IdEstudio);
                    cmd.Parameters.AddWithValue("NomeJogo", jogo.NomeJogo);
                    cmd.Parameters.AddWithValue("DescricaoJogo", jogo.DescricaoJogo);
                    cmd.Parameters.AddWithValue("DataLancamentoJogo", jogo.DateLancamentoJogo);
                    cmd.Parameters.AddWithValue("ValorJogo", jogo.valorJogo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<JogoDomain> ListarJogosEEstudios()
        {
            List<JogoDomain> listaDeJogos = new List<JogoDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string SELECTALL = "SELECT Jogo.IdJogo, Jogo.Nome, Jogo.IdEstudio, Estudio.Nome, Jogo.Descricao, Jogo.DataLancamento, Jogo.Valor FROM Jogo INNER JOIN Estudio ON Estudio.IdEstudio = Jogo.Idestudio";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(SELECTALL, con))
                {
                    SqlDataReader leitor;
                    leitor = cmd.ExecuteReader();

                    while (leitor.Read())
                    {
                        JogoDomain jogo = new JogoDomain()
                        {
                            IdJogo = Convert.ToInt32(leitor["IdJogo"]),
                            NomeJogo = leitor["Nome"].ToString(),
                            IdEstudio = Convert.ToInt32(leitor["IdEstudio"]),
                            DescricaoJogo = leitor["Descricao"].ToString(),
                            DateLancamentoJogo = Convert.ToDateTime(leitor["DataLancamento"]),
                            ValorJogo = float.TryParse(leitor["Valor"]),

                            Estudio = new EstudioDomain()
                            {
                                NomeEstudio = leitor["Nome"].ToString()
                            }
                        };
                    }
                }
            }



            return listaDeJogos;
        }
    }
}
