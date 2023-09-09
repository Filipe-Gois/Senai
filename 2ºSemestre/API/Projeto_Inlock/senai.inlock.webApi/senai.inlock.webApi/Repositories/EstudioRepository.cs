using senai.inlock.webApi_.Domains;
using senai.inlock.webApi_.Interfaces;
using System.Data.SqlClient;

namespace senai.inlock.webApi_.Repositories
{
    public class EstudioRepository : IEstudio
    {
        //private string StringConexao { get; set; } = "Data Source = NOTE14-S14; Initial Catalog = inlock_games_tarde; User Id = sa; Pwd = Senai@134";
        private string StringConexao { get; set; } = "Data Source = FILIPEGOIS\\SQLEXPRESS; Initial Catalog = inlock_games_tarde; User Id = sa; Pwd = xtringer28700";


        public List<EstudioDomain> ListarEstudios()
        {
            List<EstudioDomain> listaDeEstudios = new List<EstudioDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string SelectAll = "SELECT Estudio.IdEstudio,Estudio.NomeEstudio,Jogo.NomeJogo FROM Estudio LEFT JOIN Jogo ON Estudio.IdEstudio = Jogo.IdEstudio";

                using (SqlCommand cmd = new SqlCommand(SelectAll, con))
                {
                    con.Open();
                    SqlDataReader leitor;

                    leitor = cmd.ExecuteReader();

                    while (leitor.Read())
                    {
                        EstudioDomain estudio = new EstudioDomain()
                        {
                            IdEstudio = Convert.ToInt32(leitor["IdEstudio"]),
                            NomeEstudio = leitor["NomeEstudio"].ToString()!
                        };

                        listaDeEstudios.Add(estudio);

                    };
                }
            }
            return listaDeEstudios;
        }


    }
}

