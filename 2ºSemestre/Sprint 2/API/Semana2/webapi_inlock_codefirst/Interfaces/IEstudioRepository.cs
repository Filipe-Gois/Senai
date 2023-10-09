using webapi_inlock_codefirst.Domains;

namespace webapi_inlock_codefirst.Interfaces
{
    public interface IEstudioRepository
    {
        void Cadastrar(EstudioDomain Estudio);

        void Deletar(Guid id);
        List<EstudioDomain> ListarEstudio();
        EstudioDomain BuscarPorId(Guid id);
        void Atualizar(Guid id, EstudioDomain Estudio);
    }
}
