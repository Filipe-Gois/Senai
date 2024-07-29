using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MinimalApiMongoDB.Domains
{
    public class Product
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public ObjectId IdProduto { get; set; } = ObjectId.GenerateNewId();
        [BsonElement("nome")]
        public string? Nome { get; set; }

        [BsonElement("preco")]
        public decimal? Preco { get; set; }

        public Dictionary<string, string>? AdditionalAtributes { get; set; }

        public Product()
        {
            AdditionalAtributes = [];
        }
    }
}
