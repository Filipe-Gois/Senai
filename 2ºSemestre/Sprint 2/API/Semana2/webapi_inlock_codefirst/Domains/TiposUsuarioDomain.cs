using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi_inlock_codefirst.Domains
{
    [Table("TiposUsuario")]
    public class TiposUsuarioDomain
    {
        [Key]
        public Guid IdTipoUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O título é obrigatório.")]
        public string TituloTipoUsuario { get; set; }
    }
}
