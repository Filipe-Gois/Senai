using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinimalApiMongoDB.Domains;
using MinimalApiMongoDB.Services;
using MinimalApiMongoDB.ViewModels.Cliente;
using MongoDB.Driver;

namespace MinimalApiMongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ClienteController(MongoDBService mongoDBService) : ControllerBase
    {
        private readonly IMongoCollection<Cliente> _cliente = mongoDBService.GetDatabase.GetCollection<Cliente>("Cliente");
        private readonly IMongoCollection<Usuario> _usuario = mongoDBService.GetDatabase.GetCollection<Usuario>("Usuario");
        [HttpPost]
        public async Task<ActionResult> Post(CadastrarClienteViewModel cliente)
        {
            try
            {

                Usuario novoUsuario = new()
                {
                    Email = cliente.Email,
                    Nome = cliente.Nome,
                    Senha = cliente.Senha,


                };
                Cliente novoCliente = new()
                {
                    IdCliente = novoUsuario.IdUsuario,
                    CPF = cliente.CPF,
                    Endereco = cliente.Endereco,
                    Telefone = cliente.Telefone,
                    AdditionalAtributes = cliente.AdditionalAtributesCliente,
                    IdUsuario = novoUsuario.IdUsuario

                };

                await _usuario.InsertOneAsync(novoUsuario);
                await _cliente.InsertOneAsync(novoCliente);

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
                _cliente.DeleteOne(x => x.IdCliente.ToString() == id);
                _usuario.DeleteOne(x => x.IdUsuario.ToString() == id);
                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpPut]
        public async Task<ActionResult> Update(string id, AtualizarDadosClienteViewModel atualizarCliente)
        {
            try
            {

                Cliente cliente = await _cliente.Find(cliente => cliente.IdCliente.ToString() == id).FirstOrDefaultAsync() ?? throw new Exception("Nenhum cliente encontrado!");


                Usuario usuario = await _usuario.Find(usuario => usuario.IdUsuario.ToString() == id).FirstOrDefaultAsync() ?? throw new Exception("Nenhum usuário encontrado!");

                await _usuario.ReplaceOneAsync(usuario, atualizarCliente.Usuario!);
                await _cliente.ReplaceOneAsync(cliente, atualizarCliente.Cliente!);
                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<List<ExibirClienteViewModel>>> GetAll()
        {
            try
            {
                List<Cliente> clienteList = await _cliente.Find(FilterDefinition<Cliente>.Empty).ToListAsync();
                List<Usuario> usuarioList = await _usuario.Find(FilterDefinition<Usuario>.Empty).ToListAsync();


                if (clienteList.Count == 0 || usuarioList.Count == 0)
                {
                    throw new Exception("Nenhum treino encontrado!");
                }

                List<ExibirClienteViewModel> clienteUsuario = [];

                foreach (Cliente cliente in clienteList)
                {
                    ExibirClienteViewModel cli = new();


                    foreach (Usuario usuario in usuarioList)
                    {
                        //usuario
                        cli.Nome = usuario.Nome;
                        cli.Email = usuario.Email;
                        cli.Senha = usuario.Senha;
                        cli.AdditionalAtributesUsuario = usuario.AdditionalAtributes;


                        //cliente
                        cli.IdCliente = cliente.IdCliente;
                        cli.Telefone = cliente.Telefone;
                        cli.Endereco = cliente.Endereco;
                        cli.CPF = cliente.CPF;
                        cli.AdditionalAtributesCliente = cliente.AdditionalAtributes;
                    }

                    clienteUsuario.Add(cli);
                }


                return StatusCode(200, clienteUsuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("BuscarPorId")]
        public async Task<ActionResult<ExibirClienteViewModel>> BuscarPorId(string id)
        {
            try
            {
                Cliente cliente = await _cliente.Find(cliente => cliente.IdCliente.ToString() == id).FirstOrDefaultAsync() ?? throw new Exception("Nenhum cliente encontrado!");

                Usuario usuario = await _usuario.Find((usuario => usuario.IdUsuario.ToString() == id)).FirstOrDefaultAsync() ?? throw new Exception("Nenhum usuário encontrado!");

                ExibirClienteViewModel cli = new()
                {
                    //usuario
                    Nome = usuario.Nome,
                    Email = usuario.Email,
                    Senha = usuario.Senha,
                    AdditionalAtributesUsuario = usuario.AdditionalAtributes,


                    //cliente
                    IdCliente = cliente.IdCliente,
                    Telefone = cliente.Telefone,
                    Endereco = cliente.Endereco,
                    CPF = cliente.CPF,
                    AdditionalAtributesCliente = cliente.AdditionalAtributes,

                };



                return StatusCode(200, cli);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
