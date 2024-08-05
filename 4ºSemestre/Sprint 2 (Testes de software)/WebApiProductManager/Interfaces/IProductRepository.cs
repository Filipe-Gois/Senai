using WebApiProductManager.ViewModels.ProductViewModels;

namespace WebApiProductManager.Interfaces
{
    public interface IProductRepository
    {
        void Cadastrar(CadastrarProduto cadastrarProduto);
        void Deletar(Guid id);
        void Atualizar(Guid id, AtualizarProduto atualizarProduto);
        ExibirProduto BuscarProdutoPorId(Guid id);

        List<ExibirProduto> ListarTodosProdutos();
    }
}
