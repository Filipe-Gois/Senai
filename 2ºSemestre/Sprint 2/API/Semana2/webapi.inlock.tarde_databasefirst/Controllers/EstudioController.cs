using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.inlock.tarde.Domains;
using webapi.inlock.tarde.Interfaces;
using webapi.inlock.tarde.Repositories;

namespace webapi.inlock.tarde.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EstudioController : ControllerBase
    {
        public IEstudioRepository _estudioRepository { get; set; }

        public EstudioController()
        {
            _estudioRepository = new EstudioRepository();
        }

        /// <summary>
        /// Método para listar todos os estúdios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ListarEstudios()
        {
            try
            {
                List<Estudio> estudiosBuscados = _estudioRepository.Listar();
                return StatusCode(200, estudiosBuscados);
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }

        [HttpGet("ListarComJogos")]
        public IActionResult ListarComJogos()
        {
            try
            {

                return StatusCode(200, _estudioRepository.ListarComJogos());
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Deletar(Guid id)
        {
            try
            {
                _estudioRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }
        /// <summary>
        /// Método para cadastrar um estúdio
        /// </summary>
        /// <param name="estudio"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Cadastrar(Estudio estudio)
        {
            try
            {
                _estudioRepository.Cadastrar(estudio);
                return StatusCode(201);
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        /// Método para buscar um estúdio por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(Guid id)
        {
            try
            {
                Estudio estudioBuscado = _estudioRepository.BuscarPorId(id);

                if (estudioBuscado != null)
                {
                    return StatusCode(200, estudioBuscado);
                }
                else
                {
                    return StatusCode(404);
                }


            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(Guid id, Estudio estudio)
        {
            try
            {
                Estudio estudioBuscado = _estudioRepository.BuscarPorId(id);

                if (estudioBuscado != null)
                {
                    _estudioRepository.Atualizar(id, estudio);
                    return StatusCode(200);
                }

                else
                {
                    return StatusCode(404);
                }
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
    }
}
