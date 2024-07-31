namespace MinimalApiMongoDB.ViewModels.Usuario
{
    public class AtualizarDadosUsuarioViewModel
    {
        public string? Nome { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public string? Senha { get; set; } = string.Empty;
        public Dictionary<string, string>? AdditionalAtributesUsuario { get; set; }
    }
}
