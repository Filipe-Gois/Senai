using webapi.filmes.tarde.Domains;

namespace webapi.filmes.tarde.Interfaces
{
    public interface IFilmeRepository
    {
        void Cadastrar(FilmeDomain filme);

        List<FilmeDomain> ListarTodos();

        void BuscarPorId(int id);

        void AtualizarIdCorpo(FilmeDomain filme);

        void AtualizarIdUrl(int id, FilmeDomain filme);

        void ExcuirPorId(int id);
    }
}
