using MinimalApiMongoDB.Domains;

namespace MinimalApiMongoDB.ViewModels.Order
{
    public class AtualizarOrderViewModel
    {
        public StatusOrder Status { get; set; }
        public List<string>? IdsProdutos { get; set; }
    }
}
