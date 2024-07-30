using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MinimalApiMongoDB.Domains
{

    public enum StatusOrder
    {
        Pendente,
        Cancelada,
        Concluida,
    }
    public class Order
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public ObjectId IdOrder { get; set; } = ObjectId.GenerateNewId();


        [BsonElement("status")]
        public string? Status { get; set; }

        [BsonElement("Date")]
        public DateTime Date { get; set; } = DateTime.UtcNow;


        [BsonElement("IdCliente")]
        public ObjectId IdCliente { get; set; }

        [BsonElement("IdProduto")]
        public List<ObjectId>? IdsProdutos { get; set; }
    }
}
