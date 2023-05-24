using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exemplo1.Model;
using exemplo1.View;

namespace exemplo1.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        // método controlador para acessar a listagem de produtos

        public void ListarProdutos()
        {
            // chamada da model trazendo a lista
            List<Produto> produtos = produto.LER();

            // chamada da view passando a lista
            produtoView.Listar(produtos);
        }
    }
}