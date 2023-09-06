using senai.inlock.webApi_.Interfaces;

namespace senai.inlock.webApi_.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuario
    {
        private string StringConexao { get; set; } = "Data Source = NOTE14-S14; Initial Catalog = inlock_games_tarde; User Id = sa; Pwd = Senai@134";
    }
}
