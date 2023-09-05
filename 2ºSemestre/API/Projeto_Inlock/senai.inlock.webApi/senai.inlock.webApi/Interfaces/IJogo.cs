using senai.inlock.webApi_.Domains;

namespace senai.inlock.webApi_.Interfaces
{
    public interface IJogo
    {
        void CadastrarJogo(JogoDomain jogo);
        List<JogoDomain> ListarJogosEEstudios();
    }
}
