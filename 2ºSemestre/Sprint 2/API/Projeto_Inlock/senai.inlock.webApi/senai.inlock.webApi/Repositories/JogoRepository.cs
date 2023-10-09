using senai.inlock.webApi_.Domains;
using senai.inlock.webApi_.Interfaces;
using System.Data.SqlClient;

namespace senai.inlock.webApi_.Repositories
{
    public class JogoRepository : IJogo
    {
        private string StringConexao { get; set; } = "Data Source = NOTE14-S14; Initial Catalog = inlock_games_tarde; User Id = sa; Pwd = Senai@134";
        //private string StringConexao { get; set; } = "Data Source = FILIPEGOIS\\SQLEXPRESS; Initial Catalog = inlock_games_tarde; User Id = sa; Pwd = xtringer28700";

        public void CadastrarJogo(JogoDomain jogo)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string INSERT = "INSERT INTO Jogo VALUES(@IdEstudio,@NomeJogo,@DescricaoJogo,@DataLancamentoJogo,@ValorJogo);";

                using (SqlCommand cmd = new SqlCommand(INSERT, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("IdEstudio", jogo.IdEstudio);
                    cmd.Parameters.AddWithValue("NomeJogo", jogo.NomeJogo);
                    cmd.Parameters.AddWithValue("DescricaoJogo", jogo.DescricaoJogo);
                    cmd.Parameters.AddWithValue("DataLancamentoJogo", jogo.DateLancamentoJogo);
                    cmd.Parameters.AddWithValue("ValorJogo", jogo.ValorJogo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<JogoDomain> ListarJogos()
        {
            List<JogoDomain> listaDeJogos = new List<JogoDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string SELECTALL = "SELECT Jogo.IdJogo, Jogo.IdEstudio, Jogo.Nome AS Jogo, Estudio.Nome AS Estudio, Jogo.Descricao, Jogo.DataLancamento, Jogo.Valor FROM Jogo INNER JOIN Estudio ON Estudio.IdEstudio = Jogo.IdEstudio";

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
                            NomeJogo = leitor["Jogo"].ToString()!,
                            DescricaoJogo = leitor["Descricao"].ToString()!,
                            DateLancamentoJogo = Convert.ToDateTime(leitor["DataLancamento"]),
                            ValorJogo = Convert.ToDecimal(leitor["Valor"]),

                            IdEstudio = Convert.ToInt32(leitor["IdEstudio"]),

                            Estudio = new EstudioDomain()
                            {
                                IdEstudio = Convert.ToInt32(leitor["IdEstudio"]),
                                NomeEstudio = leitor["Estudio"].ToString()!

                            },
                        };
                        listaDeJogos.Add(jogo);
                    }
                }
            }
            return listaDeJogos;
        }
    }
}
