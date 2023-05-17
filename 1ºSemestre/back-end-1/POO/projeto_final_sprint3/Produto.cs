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
        // n precisa de get e set pq já está instanciando
        public Marca _Marca = new Marca();
        public Usuario CadastradoPor { get; set; } = new Usuario();

        public List<Produto> listadeprodutos = new List<Produto>();

        public Produto()
        {
            
        }
        public Produto(int codigoproduto, string nomeproduto, float preco)
        {
            codigoproduto = CodigoProduto;
            nomeproduto = NomeProduto;
            preco = Preco;
        }
        public void Cadastrar()
        {

            


            Console.WriteLine($"Informe o código do produto:");
            CodigoProduto = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Informe o nome do protudo:");
            NomeProduto = Console.ReadLine()!;

            Console.WriteLine($"Informe o preço");
            Preco = int.Parse(Console.ReadLine()!);


            Console.WriteLine($"\nProduto cadastrado!");

            listadeprodutos.Add(
                new(CodigoProduto, NomeProduto, Preco)
            );
        }

        public void Listar()
        {
            

            Console.WriteLine($"Produtos cadastrados:");
            foreach (var item in listadeprodutos)
            {
                Console.WriteLine(@$"
                Código: {item.CodigoProduto}
                Marca: {item._Marca.NomeMarca}
                Nome: {item.NomeProduto}
                Preço: {item.NomeProduto}");
            }
        }

        public void Deletar()
        {
            int codigoproduto = CodigoProduto;

            Console.WriteLine($"Informe o código do produto a ser removido:");
            codigoproduto = int.Parse(Console.ReadLine()!);

            Produto p = listadeprodutos.Find(x => x.CodigoProduto == codigoproduto)!;
            listadeprodutos.Remove(p);

            Console.WriteLine($"\nProduto excluído.");
            

        }



    }
}