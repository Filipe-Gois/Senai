using inlock_refeito.Domains;

namespace inlock_refeito.Interfaces
{
    public interface IUsuario
    {
        UsuarioDomain Login(string uemail, string senha);

        void ExcluirUsuario(int id);

        void CadastrarUsuario();

        List<UsuarioDomain> ListarUsuarios();

        UsuarioDomain BuscarUsuarioId(int id);
    }
}
