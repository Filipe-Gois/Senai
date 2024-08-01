using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeLivros
{
    public class Livro
    {
        public Guid IdLivro { get; set; } = Guid.NewGuid();

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataDePublicacao { get; set; }
        public bool AdicionarLivro(Livro livro)
        {
            List<Livro> livrosLista = [];

            livrosLista.Add(livro);

            return livrosLista.Count > 0;
        }

    }
}
