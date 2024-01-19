namespace senai.inlock.webApi.Domains
{
    public class JogoDomain
    {
        public int IdJogo { get; set; }
        public int IdEstudio { get; set; }
        public string NomeJogo { get; set; }
        public string DescricaoJogo { get; set; }
        public DateTime DataLancamentoJogo { get; set; }
        public decimal ValorJogo { get; set; }

        public EstudioDomain Estudio { get; set; }
    }
}
