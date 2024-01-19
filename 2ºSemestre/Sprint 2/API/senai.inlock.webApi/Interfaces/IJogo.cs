using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    public interface IJogo
    {
        void Cadastrar(JogoDomain jogo);
        List<JogoDomain> ListarJogos();
    }
}
