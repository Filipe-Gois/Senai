using System.Collections.Generic;
using WebApiProductManager.Contexts;
using WebApiProductManager.Domains;
using WebApiProductManager.Interfaces;
using WebApiProductManager.ViewModels.ProductViewModels;

namespace WebApiProductManager.Repository
{
    public class ProductRepository(ProductManagerContext ctx) : IProductRepository
    {
        private readonly ProductManagerContext _ctx = ctx;
        public void Atualizar(Guid id, AtualizarProduto atualizarProduto)
        {
            Product produtoBuscado = _ctx.Product.FirstOrDefault(x => x.IdProduct == id) ?? throw new Exception("Produto não encontrado.");

            if (atualizarProduto.Price.HasValue)
            {
                produtoBuscado.Price = atualizarProduto.Price;
            }

            produtoBuscado.Name = atualizarProduto.Name ?? produtoBuscado.Name;

            _ctx.Product.Update(produtoBuscado);
            _ctx.SaveChanges();
        }

        public ExibirProduto BuscarProdutoPorId(Guid id)
        {
            Product product = _ctx.Product.FirstOrDefault(x => x.IdProduct == id) ?? throw new Exception("Produto não encontrado.");

            ExibirProduto exibirProduto = new()
            {
                IdProduct = product.IdProduct,
                Name = product.Name,
                Price = product.Price,

            };

            return exibirProduto;

        }

        public void Cadastrar(CadastrarProduto cadastrarProduto)
        {
            Product product = new()
            {
                Name = cadastrarProduto.Name,
                Price = cadastrarProduto.Price,

            };

            _ctx.Product.Add(product);
            _ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Product product = _ctx.Product.FirstOrDefault(x => x.IdProduct == id) ?? throw new Exception("Produto não encontrado.");
            _ctx.Product.Remove(product);
            _ctx.SaveChanges();
        }

        public List<ExibirProduto> ListarTodosProdutos()
        {
            List<Product> produtos = _ctx.Product.ToList();

            List<ExibirProduto> produtosFormatados = [];


            foreach (Product produto in produtos)
            {
                ExibirProduto exibirProduto = new()
                {
                    IdProduct = produto.IdProduct,
                    Name = produto.Name,
                    Price = produto.Price,
                };

                produtosFormatados.Add(exibirProduto);
            }

            return produtosFormatados;
        }
    }
}
