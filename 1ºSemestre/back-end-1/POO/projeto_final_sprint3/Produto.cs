using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_final_sprint3;

namespace projeto_final_sprint3
{
    public class Produto
    {
        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; } = "";
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca { get; set; }
        public Usuario CadastradoPor { get; set; }

        public List<Produto> produtos = new List<Produto>();



        public string Cadastrar(string _produto)
        {
            return "";
        }

        public void Listar()
        {
            List<Produto> produtos = new List<Produto>();
        }

        public string Deletar(string _produto)
        {
            return "";
        }



    }
}