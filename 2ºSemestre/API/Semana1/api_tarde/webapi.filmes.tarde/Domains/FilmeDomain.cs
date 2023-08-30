using System.ComponentModel.DataAnnotations;
using webapi.filmes.tarde.Domains;

namespace webapi.filmes.tarde.Domains
{
    /// <summary>
    /// Classe que rerpesenta a entidade/table Filme
    /// </summary>
    public class FilmeDomain
    {
        public int IdFilme { get; set; }
        public int IdGenero { get; set; }

        //Referência para a classe GeneroDomain
        public GeneroDomain? Genero { get; set; }

        [Required(ErrorMessage = "O título do filme é obrigatório.")]
        public string? Titulo { get; set; }

    }
}
