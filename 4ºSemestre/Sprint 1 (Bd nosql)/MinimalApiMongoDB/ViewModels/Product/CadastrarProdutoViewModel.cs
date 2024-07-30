using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MinimalApiMongoDB.ViewModels.Product
{
    public class CadastrarProdutoViewModel
    {

        public string? Nome { get; set; }
        public decimal? Preco { get; set; }
        public Dictionary<string, string>? AdditionalAtributes { get; set; }
    }
}
