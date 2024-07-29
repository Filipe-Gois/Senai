using MinimalApiMongoDB.Domains;
using MongoDB.Bson;

namespace MinimalApiMongoDB.ViewModels.Cliente
{
    public class AtualizarDadosClienteViewModel
    {
        //public string? Nome { get; set; } = string.Empty;
        //public string? Email { get; set; } = string.Empty;
        //public string? Senha { get; set; } = string.Empty;
        //public string? CPF { get; set; } = string.Empty;
        //public string? Telefone { get; set; } = string.Empty;
        //public string? Endereco { get; set; } = string.Empty;

        //public Dictionary<string, string>? AdditionalAtributesUsuario { get; set; }
        //public Dictionary<string, string>? AdditionalAtributesCliente { get; set; }

        public Usuario? Usuario { get; set; }

        public Domains.Cliente? Cliente { get; set; }

    }
}
