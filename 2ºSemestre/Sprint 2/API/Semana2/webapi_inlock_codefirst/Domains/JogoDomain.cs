using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi_inlock_codefirst.Domains
{
    [Table("Jogo")]
    public class JogoDomain
    {
        [Key]
        public Guid IdJogo { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome do jogo é obrigatório!")]
        public string? NomeJogo { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "A descrição do jogo é obrigatória!")]
        public string? Descricao { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "A data de lançamento do jogo é obrigatória!")]
        public DateTime DataLancamento { get; set; }

        [Column(TypeName = "DECIMAL(4,2)")]
        [Required(ErrorMessage = "O valor do jogo é obrigatório!")]
        public decimal PrecoJogo { get; set; }

        //ref. tabela estúdio - FK


        public Guid IdEstudio { get; set; }

        [ForeignKey("IdEstudio")]
        public EstudioDomain Estudio { get; set; }
    }
}
