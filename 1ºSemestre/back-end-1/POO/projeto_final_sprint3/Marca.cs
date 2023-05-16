using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_final_sprint3
{
    public class Marca
    {
        public int CodigoProduto { get; set; }
        public string NomeMarca { get; set; } = "";
        public DateTime DataCadastro { get; set; }

        public string Cadastrar(string _marca)
        {
            return _marca;
        }

        public void ListarMarca()
        {
            List <Marca> listaMarca = new List<Marca>();
            
        }

        public string DeletarMarca()
        {
            return "";
        }
    }
}