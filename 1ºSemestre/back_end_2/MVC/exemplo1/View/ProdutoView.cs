using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exemplo1.Model;

namespace exemplo1.View
{
    public class ProdutoView
    {
        // método para exibir os dados da lsita no console

        public void Listar(List<Produto> produto)
        {
           foreach (var item in produto)
           {
            Console.WriteLine(@$"
            Código: {item.Codigo}
            Nome: {item.Nome}
            Preço: {item.Preco:C}");
           }
            
        }
        public Produto CadastrarProduto()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o código do produto:");
            novoProduto.Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Informe o nome do produto:");
            novoProduto.Nome = Console.ReadLine()!;

            Console.WriteLine($"Informe o preço do produto:");
            novoProduto.Preco = float.Parse(Console.ReadLine()!);
            
            
            
            return novoProduto;
        }
    }
}