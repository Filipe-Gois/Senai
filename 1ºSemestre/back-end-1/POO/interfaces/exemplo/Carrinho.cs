using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo
{
    public class Carrinho : ICarrinho
    {
        public float Valor { get; set; }

        // criar uma lista para manipular os nossos objetos
        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Listar()
        {
            if (carrinho.Count > 0)
            {
                foreach (Produto p in carrinho)
                {
                    Console.WriteLine(@$"
                    
                    Código do produto: {p.Codigo}
                    Nome: {p.Nome}
                    Preço: {p.Preco:C2}
                    ");

                }
            }
        }

        public void Atualizar(int _codigo, Produto produtoAlterado)
        {
            carrinho.Find(x => x.Codigo == _codigo)!.Nome = produtoAlterado.Nome;
            carrinho.Find(x => x.Codigo == _codigo)!.Preco = produtoAlterado.Preco;
        }

        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void Totalcarrinho()
        {
            Valor = 0;

            if (carrinho.Count > 0)
            {
                foreach (Produto p in carrinho)
                {
                    Valor += p.Preco;
                }
                Console.WriteLine($"Total do carrinho: {this.Valor:C2}");

            }
            else
            {
                Console.WriteLine($"Carrinho vazio.");

            }
        }
    }
}