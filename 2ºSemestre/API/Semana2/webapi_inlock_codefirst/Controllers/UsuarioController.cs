using Microsoft.AspNetCore.Http;
using webapi_inlock_codefirst.Repositories;
using Microsoft.AspNetCore.Mvc;
using webapi_inlock_codefirst.Domains;
using webapi_inlock_codefirst.Interfaces;



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
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPost("usuario")]
        public IActionResult Cadastrar(UsuarioDomain usuario)
        {
            try
            {
                _usuarioRepository.CadastrarUsuario(usuario);
                return StatusCode(200, usuario);
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        [HttpPost("email")]
        public IActionResult Login(string email, string senha)
        {
            try
            {
                _usuarioRepository.BuscarUsuario(email, senha);

                return StatusCode(200);
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }
    }
}
