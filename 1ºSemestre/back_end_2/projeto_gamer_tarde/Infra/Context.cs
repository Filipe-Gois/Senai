using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projeto_gamer_tarde.Models;

namespace projeto_gamer_tarde.Infra
{
    public class Context : DbContext
    {
        public Context()
        {
            
        }
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data source = NOTE21-S15; initial catalog = gamerTarde; User Id=sa; pwd=Senai@134; TrustServerCertificate = true;");
            }
        }
        public DbSet<Jogador> Jogador {get;set;}
        public DbSet<Equipe> Equipe {get;set;}
    }
}