using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using System.Data.SqlClient;

namespace senai.inlock.webApi.Repositories
{
    public class JogoRepository : IJogo
    {
        private string StringConexao = "Data Source = FILIPEGOIS\\SQLEXPRESS; Initial Catalog = inlock_games_tarde ; User = sa; Pwd = xtringer28700";

        public void Cadastrar(JogoDomain jogo)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string InsertInto = "INSERT INTO Jogo VALUES (@IdEstudio, @NomeJogo, @DescricaoJogo, @DataLancamentoJogo, @ValorJogo)";

                using (SqlCommand cmd = new SqlCommand(InsertInto, con))
                {
                    con.Open();
                    

                    cmd.Parameters.AddWithValue("IdEstudio", jogo.IdEstudio);
                    cmd.Parameters.AddWithValue("NomeJogo", jogo.NomeJogo);
                    cmd.Parameters.AddWithValue("DescricaoJogo", jogo.DescricaoJogo);
                    cmd.Parameters.AddWithValue("DataLancamentoJogo", jogo.DataLancamentoJogo);
                    cmd.Parameters.AddWithValue("ValorJogo", jogo.ValorJogo);

                    cmd.ExecuteNonQuery();

                }
            }
        }

        public List<JogoDomain> ListarJogos()
        {
            List<JogoDomain> ListaDeJogos = new List<JogoDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string SelectAll = "SELECT Jogo.IdEstudio, Estudio.NomeEstudio, Jogo.Idjogo, Jogo.NomeJogo, Jogo.Descricao, Jogo.DataLancamento, Jogo.Valor FROM Jogo INNER JOIN Estudio ON Estudio.IdEstudio = Jogo.IdEstudio";

                using (SqlCommand cmd = new SqlCommand(SelectAll, con))
                {
                    con.Open();

                    SqlDataReader leitor;

                    leitor = cmd.ExecuteReader();

                    while (leitor.Read())
                    {
                        JogoDomain jogo = new JogoDomain()
                        {
                            Estudio = new EstudioDomain()
                            {
                                NomeEstudio = leitor["NomeEstudio"].ToString()!
                            },

                            IdEstudio = Convert.ToInt32(leitor["IdEstudio"]),

                            IdJogo = Convert.ToInt32(leitor["IdJogo"]),
                            NomeJogo = leitor["NomeJogo"].ToString()!,
                            DescricaoJogo = leitor["Descricao"].ToString()!,
                            DataLancamentoJogo = Convert.ToDateTime(leitor["DataLancamento"]),
                            ValorJogo = Convert.ToDecimal(leitor["Valor"])

                            

                            

                        };

                        ListaDeJogos.Add(jogo);
                    }
                }
            }

            return ListaDeJogos;
        }
    }
}
