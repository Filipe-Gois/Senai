using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using MinimalApiMongoDB.Domains;
using MinimalApiMongoDB.Services;
using MinimalApiMongoDB.ViewModels.Product;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using System.Collections.ObjectModel;
using static MongoDB.Driver.WriteConcern;

namespace MinimalApiMongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductController(MongoDBService mongoDBService) : ControllerBase
    {
        private readonly IMongoCollection<Product> _product = mongoDBService.GetDatabase.GetCollection<Product>("product");

        [HttpGet]
        public async Task<ActionResult<List<ExibirProdutoViewModel>>> GetAll()
        {
            try
            {
                List<Product> produtosBuscados = await _product.Find(FilterDefinition<Product>.Empty).ToListAsync();

                if (produtosBuscados.Count == 0)
                {
                    throw new Exception("Nenhum produto encontrado!");
                }

                List<ExibirProdutoViewModel> produtos = [];
                foreach (Product produto in produtosBuscados)
                {
                    ExibirProdutoViewModel produtoViewModel = new ExibirProdutoViewModel()

                    {
                        Nome = produto.Nome,
                        AdditionalAtributes = produto.AdditionalAtributes,
                        IdProduto = produto.IdProduto.ToString(),
                        Preco = produto.Preco,

                    };



                    produtos.Add(produtoViewModel);
                }

                return StatusCode(200, produtos);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("BuscarPorId")]
        public async Task<ActionResult<ExibirProdutoViewModel>> BuscarPorId(string id)
        {
            try
            {
                Product produtoBuscado = await _product.Find(x => x.IdProduto.ToString() == id).FirstOrDefaultAsync() ?? throw new Exception("Nenhum produto encontrado!");


                ExibirProdutoViewModel produto = new()
                {
                    IdProduto = produtoBuscado.IdProduto.ToString(),
                    Preco = produtoBuscado.Preco,
                    AdditionalAtributes = produtoBuscado.AdditionalAtributes,
                    Nome = produtoBuscado.Nome,
                };


                return StatusCode(200, produto);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult Post(CadastrarProdutoViewModel produto)
        {
            try
            {
                Product novoProduto = new()
                {
                    AdditionalAtributes = produto.AdditionalAtributes,
                    Nome = produto.Nome,
                    Preco = produto.Preco,
                };

                _product.InsertOne(novoProduto);
                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public ActionResult Delete(string id)
        {
            try
            {
                _product.DeleteOne(x => x.IdProduto.ToString() == id);
                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update(string id, CadastrarProdutoViewModel produto)
        {
            try
            {
                FilterDefinition<Product> produtoFiltrado = Builders<Product>.Filter.Eq(product => product.IdProduto.ToString(), id) ?? throw new Exception("Nenhum produto encontrado!");
                Product produtoBuscado = await _product.Find(produtoFiltrado).FirstOrDefaultAsync();

                produtoBuscado.Preco = produto.Preco;
                produtoBuscado.Nome = produto.Nome;
                produtoBuscado.AdditionalAtributes = produto.AdditionalAtributes;

                await _product.ReplaceOneAsync(produtoFiltrado, produtoBuscado);
                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
