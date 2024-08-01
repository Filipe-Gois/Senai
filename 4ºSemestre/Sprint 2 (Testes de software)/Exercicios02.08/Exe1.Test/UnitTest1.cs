using GerenciamentoDeLivros;

namespace Exe1.Test
{
    public class UnitTest1
    {
        [Fact]
        public void AdicionarLivroAListaTeste()
        {

            Livro livro = new()
            {
                Autor = "Filipe",
                Descricao = "askhdsakd",
                Titulo = "Teste",
                DataDePublicacao = DateTime.Now,
            };

            bool adicionou = livro.AdicionarLivro(livro);


            Assert.True(adicionou);


        }
    }
}