using MinimalApiMongoDB.Domains;

namespace MinimalApiMongoDB.ViewModels.Order
{
    public class ExibirOrder
    {
        public string? IdOrder { get; set; }
        public string? IdCliente { get; set; }
        public DateTime? Date { get; set; }
        public StatusOrder Status { get; set; }
        public List<Product>? Produtos { get; set; }
    }
}
