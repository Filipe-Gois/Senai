using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi_inlock_codefirst.Domains
{
    [Table("Usuario")]
    [Index(nameof(EmailUsuario), IsUnique = true)]
    public class UsuarioDomain
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome é obrigatório!")]
        public string? NomeUsuario { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "E-mail é obrigatório!")]

        public string EmailUsuario { get; set; }

        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "A senha é obrigatória!")]
        [StringLength(60, MinimumLength = 6, ErrorMessage = "Senha deve conter de 6 à 60 caracteres!")]
        public string SenhaUsuario { get; set; }

        [Required(ErrorMessage = "O tipo do usuário é obrigatório!")]
        public Guid IdTipoUsuario { get; set; }
        [ForeignKey("IdTipoUsuario")]
        public TiposUsuarioDomain? TipoUsuario { get; set; }




    }
}
