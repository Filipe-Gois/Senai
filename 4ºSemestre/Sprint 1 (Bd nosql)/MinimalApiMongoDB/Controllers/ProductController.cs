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
                var produto = await _product.Find(x => x.Id == id).ToListAsync();
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
                _product.DeleteOne(x => x.Id == id);
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
                var filter = Builders<Product>.Filter.Eq(product => product.Id, id);

                var update = Builders<Product>.Update
    .Set(product => product, produto);

                var t = filter.ToJson();


                await _product.UpdateOneAsync(filter, update);
                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
