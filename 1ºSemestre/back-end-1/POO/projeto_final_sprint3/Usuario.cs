using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_final_sprint3;

namespace projeto_final_sprint3
{
    public class Usuario
    {
        public int CodigoUsuario { get; set; }
        public string NomeUsuario { get; set; } = "filipe";
        public string Email { get; set; } = "a";
        public string Senha { get; set; } = "123";
        public DateTime DataCadastro { get; set; }

        public void Cadastrar()
        {
            this.NomeUsuario = "filipe";
            this.Email = "a";
            this.Senha = "123";
            this.DataCadastro = DateTime.Now;
        }

        public void Deletar()
        {
            this.NomeUsuario = "";
            this.Email = "";
            this.Senha = "";
            this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }

        
        
        
    }
}