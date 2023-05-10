using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace listas
{
    public class Produtos
    {
        public int Codigo { get; set; }
        public string Nome { get; set; } = "";
        public float Preco { get; set; }

        public Produtos()
        {
            
        }

        public Produtos(int codigo, string nome, float preco)
        {
           Codigo = codigo;
           Nome = nome;
           Preco = preco;
        }
    }
}