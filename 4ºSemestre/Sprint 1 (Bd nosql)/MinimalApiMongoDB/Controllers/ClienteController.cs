using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinimalApiMongoDB.Domains;
using MinimalApiMongoDB.Services;
using MinimalApiMongoDB.ViewModels.Cliente;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

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
                Cliente clienteBuscado = await _cliente.Find(x => x.CPF == cliente.CPF).FirstOrDefaultAsync();

                if (clienteBuscado != null)
                {
                    throw new Exception("CPF já cadastrado em nosso sistema!");
                }

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
                DeleteResult clienteDeletado = _cliente.DeleteOne(x => x.IdCliente.ToString() == id);
                DeleteResult usuarioDeletado = _usuario.DeleteOne(x => x.IdUsuario.ToString() == id);

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

                FilterDefinition<Cliente> clienteFilter = Builders<Cliente>.Filter.Eq(cliente => cliente.IdCliente, ObjectId.Parse(id));
                Cliente cliente = await _cliente.Find(clienteFilter).FirstOrDefaultAsync();
                FilterDefinition<Usuario> usuarioFilter = Builders<Usuario>.Filter.Eq(Usuario => Usuario.IdUsuario, ObjectId.Parse(id));
                Usuario usuario = await _usuario.Find(usuarioFilter).FirstOrDefaultAsync();

                cliente.Telefone = string.IsNullOrEmpty(atualizarCliente.Telefone) ? cliente.Telefone : atualizarCliente.Telefone;
                cliente.Endereco = string.IsNullOrEmpty(atualizarCliente.Endereco) ? cliente.Endereco : atualizarCliente.Endereco;
                cliente.AdditionalAtributes = atualizarCliente.AdditionalAtributesCliente!.Count == 0 ? cliente.AdditionalAtributes : atualizarCliente.AdditionalAtributesCliente;
                cliente.CPF = string.IsNullOrEmpty(atualizarCliente.CPF) ? cliente.CPF : atualizarCliente.CPF;

                usuario.Nome = string.IsNullOrEmpty(atualizarCliente.Nome) ? usuario.Nome : atualizarCliente.Nome;
                usuario.Email = string.IsNullOrEmpty(atualizarCliente.Email) ? usuario.Email : atualizarCliente.Email;
                usuario.Senha = string.IsNullOrEmpty(atualizarCliente.Senha) ? usuario.Senha : atualizarCliente.Senha;
                usuario.AdditionalAtributes = atualizarCliente.AdditionalAtributesUsuario!.Count == 0 ? usuario.AdditionalAtributes : atualizarCliente.AdditionalAtributesUsuario;

                await _usuario.ReplaceOneAsync(usuarioFilter, usuario);
                await _cliente.ReplaceOneAsync(clienteFilter, cliente);
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
                    foreach (Usuario usuario in usuarioList)
                    {
                        ExibirClienteViewModel cli = new()
                        {
                            //usuario
                            Nome = usuario.Nome,
                            Email = usuario.Email,
                            Senha = usuario.Senha,
                            AdditionalAtributesUsuario = usuario.AdditionalAtributes,

                            //cliente
                            IdCliente = cliente.IdCliente.ToString(),
                            Telefone = cliente.Telefone,
                            Endereco = cliente.Endereco,
                            CPF = cliente.CPF,
                            AdditionalAtributesCliente = cliente.AdditionalAtributes
                        };
                        clienteUsuario.Add(cli);
                    }
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
                    IdCliente = cliente.IdCliente.ToString(),
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
