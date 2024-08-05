using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiProductManager.Interfaces;
using WebApiProductManager.ViewModels.ProductViewModels;

namespace WebApiProductManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProductRepository productRepository) : ControllerBase
    {
        private readonly IProductRepository _productRepository = productRepository;


        [HttpPost]
        public IActionResult Cadastrar(CadastrarProduto produto)
        {
            try
            {
                _productRepository.Cadastrar(produto);
                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public IActionResult Excluir(Guid id)
        {

            try
            {
                _productRepository.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult AtulizarTreino(Guid id, AtualizarProduto atualizarProduto)
        {

            try
            {
                _productRepository.Atualizar(id, atualizarProduto);
                return StatusCode(204);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet("ListarTodosOsProdutos")]
        public IActionResult ListarTodosOsProdutos()
        {

            try
            {

                return StatusCode(200, _productRepository.ListarTodosProdutos());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet("BuscarProdutoPorId")]
        public IActionResult BuscarProdutoPorId(Guid id)
        {

            try
            {

                return StatusCode(200, _productRepository.BuscarProdutoPorId(id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
