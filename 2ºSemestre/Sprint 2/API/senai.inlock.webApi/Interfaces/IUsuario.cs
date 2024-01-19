using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    public interface IUsuario
    {
        UsuarioDomain Login(UsuarioDomain usuario);
    }
}
