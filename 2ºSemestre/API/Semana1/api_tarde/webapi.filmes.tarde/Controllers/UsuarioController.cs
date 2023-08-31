using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.filmes.tarde.Domains;
using webapi.filmes.tarde.Interfaces;
using webapi.filmes.tarde.Repositories;

namespace webapi.filmes.tarde.Controllers
{
    /// <summary>
    /// Route: define que a rota de uma requisição será no seguinte formato: dominio/api/nomeController
    /// Ex: http://Localhost:5000/api/genero
    /// </summary>
    [Route("api/[controller]")]

    /// <summary>
    /// ApiController: Define que é um controlador de api
    /// </summary>
    [ApiController]

    /// <summary>
    /// Route: Define que o tipo de resposta da api é JSON
    /// </summary>
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _UsuarioRepository { get; set; }

        public UsuarioController()
        {
            _UsuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        [HttpPost]

        //Ao usar o objeto Usuario usuarioo como parâmetro, os dados serão preenchidos pelo corpo. Se usar string email, string senha como parâmetros, os dados deverão ser informados pela URL.
        public IActionResult Login(string email, string senha)
        {
            try
            {
                UsuarioDomain usuarioBuscado = _UsuarioRepository.BuscarUsuario(email, senha);

                if (usuarioBuscado != null)
                {
                    return StatusCode(200, usuarioBuscado);
                }
                return StatusCode(404, "Usuário não encontrado, E-mail ou senha inválidos.");
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }
    }
}
