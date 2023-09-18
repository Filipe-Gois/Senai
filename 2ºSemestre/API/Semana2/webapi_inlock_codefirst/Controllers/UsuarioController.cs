using Microsoft.AspNetCore.Http;
using webapi_inlock_codefirst.Repositories;
using Microsoft.AspNetCore.Mvc;
using webapi_inlock_codefirst.Domains;
using webapi_inlock_codefirst.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace webapi_inlock_codefirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Método para cadastrar um usuário
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPost("usuario")]
        [Authorize(Roles = "A43666C4-1B34-4AE3-8E86-55BE81BF2628")] //id representante da autorização tipo ADM
        public IActionResult Cadastrar(UsuarioDomain usuario)
        {
            try
            {
                _usuarioRepository.CadastrarUsuario(usuario);
                return StatusCode(200);
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }

    }
}
