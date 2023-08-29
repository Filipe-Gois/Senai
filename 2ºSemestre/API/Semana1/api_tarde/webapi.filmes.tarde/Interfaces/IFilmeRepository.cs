using webapi.filmes.tarde.Domains;

namespace webapi.filmes.tarde.Interfaces
{
    public interface IFilmeRepository
    {
        void Cadastrar(FilmeDomain filme);

        List<FilmeDomain> ListarTodos();

        FilmeDomain BuscarPorId(int id);

        void AtualizarIdCorpo(FilmeDomain filme);

        void AtualizarIdUrl(int id, FilmeDomain filme);

        void Deletar(int id);
    }
}
