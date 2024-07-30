namespace MinimalApiMongoDB.ViewModels.Product
{
    public class ExibirProdutoViewModel
    {
        public string? IdProduto { get; set; }
        public string? Nome { get; set; }
        public decimal? Preco { get; set; }
        public Dictionary<string, string>? AdditionalAtributes { get; set; }
    }
}
