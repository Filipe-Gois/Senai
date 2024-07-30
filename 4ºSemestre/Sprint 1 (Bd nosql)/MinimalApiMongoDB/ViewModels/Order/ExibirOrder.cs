using MinimalApiMongoDB.Domains;
using MinimalApiMongoDB.ViewModels.Product;

namespace MinimalApiMongoDB.ViewModels.Order
{
    public class ExibirOrder
    {
        public string? IdOrder { get; set; }
        public string? IdCliente { get; set; }
        public DateTime? Date { get; set; }
        public string? Status { get; set; }
        public List<ExibirProdutoViewModel>? Produtos { get; set; } = [];
    }
}
