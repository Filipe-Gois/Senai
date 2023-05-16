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
        public string Email { get; set; } = "fefe@";
        public string Senha { get; set; } = "123";
        public DateTime DataCadastro;

        public string Cadastrar(string _usuario)
        {

            return "";
        }

        public string Deletar(string _usuario)
        {
            return "";
        }

        
        
        
    }
}