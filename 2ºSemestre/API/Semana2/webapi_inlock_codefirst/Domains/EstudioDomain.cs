using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi_inlock_codefirst.Domains
{
    [Table("Estudio")] //Declara que esta classe será uma tabela com o nome Estudio
    public class EstudioDomain
    {
        [Key] //BD identifica que é uma PK
        public Guid IdEstudio { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome do estúdio é obrigatório!")]
        public string? NomeEstudio { get; set; }

        //Referência à lista de jogos
        public List<JogoDomain>? Jogos { get; set; }
    }
}
