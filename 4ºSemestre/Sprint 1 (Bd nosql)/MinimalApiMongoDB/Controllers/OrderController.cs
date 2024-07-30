using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinimalApiMongoDB.Domains;
using MinimalApiMongoDB.Services;
using MinimalApiMongoDB.ViewModels.Order;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MinimalApiMongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class OrderController(MongoDBService mongoDBService) : ControllerBase
    {

        private readonly IMongoCollection<Order> _order = mongoDBService.GetDatabase.GetCollection<Order>("Order");
        private readonly IMongoCollection<Usuario> _usuario = mongoDBService.GetDatabase.GetCollection<Usuario>("Cliente");
        private readonly IMongoCollection<Product> _produuct = mongoDBService.GetDatabase.GetCollection<Product>("product");


        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetAll()
        {
            try
            {
                return StatusCode(200);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("BuscarPorIdOrder")]
        public async Task<ActionResult<Order>> BuscarPorIdOrder(string id)
        {
            try
            {
                return StatusCode(200);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }


        [HttpGet("BuscarPorCliente")]
        public  ActionResult<Order> BuscarPorIdCliente(string id)
        {
            try
            {

                Order order = 
                return StatusCode(200, );
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult Post(CadastrarOrder cadastrarOrder)
        {
            try
            {
                List<ObjectId> idsProdutosList = [];
                foreach (string idProduto in cadastrarOrder.IdProdutos!)
                {
                    idsProdutosList.Add(ObjectId.Parse(idProduto));
                }

                Order order = new()
                {
                    IdCliente = ObjectId.Parse(cadastrarOrder.IdCliente),
                    IdsProdutos = idsProdutosList,
                    Date = DateTime.Now,
                };

                _order.InsertOne(order);

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
                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
