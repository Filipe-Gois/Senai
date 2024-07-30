using MinimalApiMongoDB.Domains;

namespace MinimalApiMongoDB.ViewModels.Order
{
    public class CadastrarOrder
    {
        public string? IdCliente { get; set; }
        public List<string>? IdProdutos { get; set; }
    }
}
