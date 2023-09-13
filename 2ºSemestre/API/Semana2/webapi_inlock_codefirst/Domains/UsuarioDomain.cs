using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi_inlock_codefirst.Domains
{
    [Table("Usuario")]
    public class UsuarioDomain
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome é obrigatório!")]
        public string? NomeUsuario { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "E-mail é obrigatório!")]
        [Index(IsUnique = true)]
        public string? EmailUsuario { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "A senha é obrigatória!")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Senha deve conter de 3 à 20 caracteres!")]
        public string? SenhaUsuario { get; set; }




    }
}
