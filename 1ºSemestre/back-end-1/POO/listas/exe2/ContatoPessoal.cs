using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exe2
{
    public class ContatoPessoal : Contato, IContaPessoal
    {
        public string Cpf { get; set; } = "";


        public bool ValidarCPF(string _cpf)
        {
            throw new NotImplementedException();
        }
    }
}