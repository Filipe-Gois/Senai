using inlock_refeito.Domains;

namespace inlock_refeito.Interfaces
{
    public interface IJogo
    {
        void CadastrarJogo();
        List<JogoDomain> ListarJogos();
        JogoDomain BuscarJogoId(int id);
        void DeletarJogo(int id);

        JogoDomain AtualizarJogoUrl(int id);
    }
}
