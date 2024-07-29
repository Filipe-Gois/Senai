using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MinimalApiMongoDB.Domains
{

    public enum StatusOrder
    {

    }
    public class Order
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public ObjectId IdOrder { get; set; } = ObjectId.GenerateNewId();


        [BsonElement("status")]
        public StatusOrder Status { get; set; }

        [BsonElement("Date")]
        public DateTime Date { get; set; } = DateTime.UtcNow;




        //referencia do produto
        //referencia do cliente
    }
}
