using Microsoft.EntityFrameworkCore;
using webapi_inlock_codefirst.Domains;

namespace webapi_inlock_codefirst.Contexts
{
    public class InlockContext : DbContext
    {
        public DbSet<TiposUsuarioDomain> TiposUsuario { get; set; }
        public DbSet<UsuarioDomain> Usuario { get; set; }
        public DbSet<EstudioDomain> Estudio { get; set; }
        public DbSet<JogoDomain> Jogo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server = NOTE14-S14; Database = inlock_games_codeFirst_tarde; User Id = sa; Pwd = Senai@134; TrustServerCertificate = true");
            //base.OnConfiguring(optionsBuilder);



            //String de conexão pc de casa
            optionsBuilder.UseSqlServer("Server = FILIPEGOISSQLEXPRESS; Database = inlock_games_codeFirst_tarde; User Id = sa; Pwd = xtringer28700; TrustServerCertificate = true");
            base.OnConfiguring(optionsBuilder);


            
        }
    }
}
