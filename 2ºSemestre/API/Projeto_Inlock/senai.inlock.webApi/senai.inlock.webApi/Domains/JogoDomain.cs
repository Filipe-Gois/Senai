using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi_.Domains
{
    public class JogoDomain
    {
        public int IdJogo { get; set; }
        public int IdEstudio { get; set; }
        public EstudioDomain Estudio { get; set; }

        [Required(ErrorMessage = "O nome do jogo é obrigatório!")]
        public string NomeJogo { get; set; }
        public string DescricaoJogo { get; set; }
        public DateTime DateLancamentoJogo { get; set; }
        public decimal ValorJogo { get; set; }

    }
}
