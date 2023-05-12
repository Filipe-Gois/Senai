using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exe2
{
    public class ContaComercial : Contato, IContaComercial
    {
        public string CNPJ { get; set; } = "";

        public bool ValidarCNPJ(string _cnpj)
        {
            throw new NotImplementedException();
        }
    }
}