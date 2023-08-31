using Microsoft.AspNetCore.Identity;
using webapi.filmes.tarde.Domains;

namespace webapi.filmes.tarde.Interfaces
{
    //Fazer o CRUD dessa interface como desafio
    public interface IUsuarioRepository
    {
        /// <summary>
        /// Método que busca um usuário por email e senha
        /// pode ser chamado de login
        /// </summary>
        /// <param name="email">email do usuario</param>
        /// <param name="senha">senha do usuario</param>
        /// <returns>objeto que foi buscado(usuario)</returns>
       UsuarioDomain BuscarUsuario(string email, string senha);
    }
}
