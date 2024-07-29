using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MinimalApiMongoDB.Domains
{
    public class Cliente
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public ObjectId IdCliente { get; set; } = ObjectId.GenerateNewId();


        [BsonElement("cpf")]
        public string? CPF { get; set; } = string.Empty;

        [BsonElement("telefone")]
        public string? Telefone { get; set; } = string.Empty;

        [BsonElement("endereco")]
        public string? Endereco { get; set; } = string.Empty;

        public Dictionary<string, string>? AdditionalAtributes { get; set; }

        public Cliente()
        {
            AdditionalAtributes = [];
        }

        [BsonElement("IdUsuario")]
        public ObjectId IdUsuario { get; set; }

    }
}
