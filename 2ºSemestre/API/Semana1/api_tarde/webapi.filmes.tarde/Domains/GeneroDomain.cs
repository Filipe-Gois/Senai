using System.ComponentModel.DataAnnotations;

namespace webapi.filmes.tarde.Domains
{
    /// <summary>
    /// Classe que representa a entidade/tabela Gêneros
    /// </summary>
    public class GeneroDomain
    {
        
        public int IdGenero { get; set; }

        [Required(ErrorMessage = "O nome do gênero é obrigatório.")]
        //data annotation: validação caso o cliente não informe o nome do gênero
        public string? NomeGenero { get; set; }
       
    }
}
