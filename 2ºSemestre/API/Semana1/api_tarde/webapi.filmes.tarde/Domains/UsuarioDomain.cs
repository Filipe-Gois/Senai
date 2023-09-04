using System.ComponentModel.DataAnnotations;

namespace webapi.filmes.tarde.Domains
{
    /// <summary>
    /// Classe que representa a entidade(tabela) Usuario
    /// </summary>
    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O Email é obrigatório!")]
        public string UsuarioEmail { get; set; }

        [StringLength(20, MinimumLength = 4, ErrorMessage = "O campo senha precisa ter no mínimo 4 e no máximo 20 caracteres!")]
        [Required(ErrorMessage = "A senha é obrigatória!")]
        public string UsuarioSenha { get; set; }
        public string UsuarioPermissao { get; set; }
        public string UsuarioNome { get; set; }
    }
}
