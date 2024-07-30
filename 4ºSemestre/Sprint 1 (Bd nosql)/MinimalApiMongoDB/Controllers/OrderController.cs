using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinimalApiMongoDB.Domains;
using MinimalApiMongoDB.Services;
using MinimalApiMongoDB.ViewModels.Order;
using MinimalApiMongoDB.ViewModels.Product;
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
        private readonly IMongoCollection<Product> _product = mongoDBService.GetDatabase.GetCollection<Product>("product");

        [HttpGet]
        public async Task<ActionResult<List<ExibirOrder>>> GetAll()
        {
            try
            {
                List<Order> ordersBuscadas = await _order.Find(FilterDefinition<Order>.Empty).ToListAsync();

                List<ExibirOrder> ordersFiltradas = [];

                foreach (Order order in ordersBuscadas)
                {
                    ExibirOrder exibirOrder = new()
                    {
                        IdOrder = order.IdOrder.ToString(),
                        IdCliente = order.IdCliente.ToString(),
                        Date = order.Date,
                        Status = order.Status,
                    };

                    foreach (ObjectId idProdutoInOrder in order.IdsProdutos!)
                    {
                        Product produtoBuscado = await _product.Find(produto => produto.IdProduto.ToString() == idProdutoInOrder.ToString()).FirstOrDefaultAsync();

                        ExibirProdutoViewModel exibirProdutoViewModel = new()
                        {
                            IdProduto = produtoBuscado.IdProduto.ToString(),
                            AdditionalAtributes = produtoBuscado.AdditionalAtributes,
                            Nome = produtoBuscado.Nome,
                            Preco = produtoBuscado.Preco,
                        };



                        exibirOrder.Produtos!.Add(exibirProdutoViewModel ?? null!);  //aqui está dando null
                        ordersFiltradas.Add(exibirOrder);
                    }



                }
                return StatusCode(200, ordersFiltradas);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("BuscarPorIdOrder")]
        public async Task<ActionResult<ExibirOrder>> BuscarPorIdOrder(string id)
        {
            try
            {
                Order order = await _order.Find(order => order.IdOrder.ToString() == id).FirstOrDefaultAsync() ?? throw new Exception("Nenhuma order encontrada!");

                ExibirOrder exibirOrder = new()
                {
                    Date = order.Date,
                    IdOrder = order.IdOrder.ToString(),
                    IdCliente = order.IdCliente.ToString(),
                    Status = order.Status,
                };


                foreach (ObjectId idProduto in order.IdsProdutos!)
                {
                    Product product = await _product.Find(product => product.IdProduto == idProduto).FirstOrDefaultAsync() ?? throw new Exception("Nenhum produto encontrada!");

                    ExibirProdutoViewModel exibirProdutoViewModel = new()
                    {
                        IdProduto = product.IdProduto.ToString(),
                        AdditionalAtributes = product.AdditionalAtributes,
                        Nome = product.Nome,
                        Preco = product.Preco,
                    };

                    exibirOrder.Produtos!.Add(exibirProdutoViewModel);
                }



                return StatusCode(200, exibirOrder);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }


        [HttpGet("BuscarPorCliente")]
        public ActionResult<ExibirOrder> BuscarPorIdCliente(string id)
        {
            try
            {


                Order order = _order.Find(order => order.IdCliente.ToString() == id).FirstOrDefault() ?? throw new Exception("Nenhuma order encontrada!");

                ExibirOrder exibirOrder = new()
                {
                    Date = order.Date,
                    IdOrder = order.IdOrder.ToString(),
                    IdCliente = order.IdCliente.ToString(),
                    Status = order.Status,
                };


                foreach (ObjectId idProduto in order.IdsProdutos!)
                {
                    Product product = _product.Find(product => product.IdProduto == idProduto).FirstOrDefault() ?? throw new Exception("Nenhum produto encontrada!");

                    ExibirProdutoViewModel exibirProdutoViewModel = new()
                    {
                        IdProduto = product.IdProduto.ToString(),
                        AdditionalAtributes = product.AdditionalAtributes,
                        Nome = product.Nome,
                        Preco = product.Preco,
                    };

                    exibirOrder.Produtos!.Add(exibirProdutoViewModel);
                }



                return StatusCode(200, exibirOrder);
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
                    Product product = _product.Find(x => x.IdProduto.ToString() == idProduto).FirstOrDefault() ?? throw new Exception($"O produto com o id ${idProduto} não existe");
                    idsProdutosList.Add(ObjectId.Parse(idProduto));
                }

                Order order = new()
                {
                    IdCliente = ObjectId.Parse(cadastrarOrder.IdCliente),
                    IdsProdutos = idsProdutosList,
                    Date = DateTime.Now,
                    Status = StatusOrder.Pendente.ToString(),
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
                _order.DeleteOne(x => x.IdOrder.ToString() == id);
                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update(string id, AtualizarOrderViewModel atualizarOrderViewModel)
        {
            try
            {
                FilterDefinition<Order> orderFilter = Builders<Order>.Filter.Eq(order => order.IdOrder, ObjectId.Parse(id));
                Order order = await _order.Find(orderFilter).FirstOrDefaultAsync();

                order.Status = atualizarOrderViewModel.Status.ToString();
                order.IdsProdutos!.Clear();

                foreach (string idProduto in atualizarOrderViewModel.IdsProdutos!)
                {
                    Product product = await _product.Find(x => x.IdProduto.ToString() == idProduto).FirstOrDefaultAsync() ?? throw new Exception($"O produto com o id ${idProduto} não existe");

                    order.IdsProdutos!.Add(ObjectId.Parse(idProduto));
                }

                _order.ReplaceOne(orderFilter, order);

                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
