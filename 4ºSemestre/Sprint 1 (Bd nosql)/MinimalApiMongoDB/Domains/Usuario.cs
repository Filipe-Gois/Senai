using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MinimalApiMongoDB.Domains
{
    public class Usuario
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public ObjectId IdUsuario { get; set; } = ObjectId.GenerateNewId();

        [BsonElement("nome")]
        public string? Nome { get; set; } = string.Empty;

        [BsonElement("email")]
        public string? Email { get; set; } = string.Empty;

        [BsonElement("senha")]
        public string? Senha { get; set; } = string.Empty;

        public Dictionary<string, string>? AdditionalAtributes { get; set; }

        public Usuario()
        {
            AdditionalAtributes = [];
        }
    }
}
