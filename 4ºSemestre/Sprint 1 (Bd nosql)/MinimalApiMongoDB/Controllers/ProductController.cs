using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using MinimalApiMongoDB.Domains;
using MinimalApiMongoDB.Services;
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
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            try
            {
                var products = await _product.Find(FilterDefinition<Product>.Empty).ToListAsync();
                return StatusCode(200, products);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("BuscarPorId")]
        public async Task<ActionResult<Product>> BuscarPorId(string id)
        {
            try
            {
                var produto = await _product.Find(x => x.IdProduto.ToString() == id).FirstOrDefaultAsync() ?? throw new Exception("Nenhum produto encontrado!");
                return StatusCode(200, produto);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult Post(Product produto)
        {
            try
            {
                _product.InsertOne(produto);
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
        public async Task<ActionResult> Update(string id, Product produto)
        {
            try
            {
                FilterDefinition<Product> produtoFiltrado = Builders<Product>.Filter.Eq(product => product.IdProduto.ToString(), id) ?? throw new Exception("Nenhum produto encontrado!");

                await _product.ReplaceOneAsync(produtoFiltrado, produto);
                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
