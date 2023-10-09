using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi_.Domains;
using senai.inlock.webApi_.Interfaces;
using senai.inlock.webApi_.Repositories;

namespace senai.inlock.webApi_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class JogoController : ControllerBase
    {
        private IJogo _jogoRepository { get; set; }

        public JogoController()
        {
            _jogoRepository = new JogoRepository();
        }

        /// <summary>
        /// Método para cadastrar um Jogo
        /// </summary>
        /// <param name="jogo"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = "Administrador")]
        public IActionResult CadastrarJogo(JogoDomain jogo)
        {
            try
            {
                _jogoRepository.CadastrarJogo(jogo);
                return StatusCode(200);
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }

        }

        /// <summary>
        /// Método que lista todos os jogos e suas informações
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ListarJogos()
        {
            try
            {
                List<JogoDomain> jogosBuscados = _jogoRepository.ListarJogos();

                return StatusCode(201, jogosBuscados);
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }
    }
}
