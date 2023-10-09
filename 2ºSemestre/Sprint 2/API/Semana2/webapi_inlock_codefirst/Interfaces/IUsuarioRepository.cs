using webapi_inlock_codefirst.Domains;

namespace webapi_inlock_codefirst.Interfaces
{
    public interface IUsuarioRepository
    {
        UsuarioDomain BuscarUsuario(string email, string senha);
        void CadastrarUsuario(UsuarioDomain usuario);
    }
}
