using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinimalApiMongoDB.Domains;
using MinimalApiMongoDB.Services;
using MinimalApiMongoDB.ViewModels.Cliente;
using MinimalApiMongoDB.ViewModels.Usuario;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MinimalApiMongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController(MongoDBService mongoDBService) : ControllerBase
    {
        private readonly IMongoCollection<Usuario> _usuario = mongoDBService.GetDatabase.GetCollection<Usuario>("Usuario");
        [HttpPost]
        public async Task<ActionResult> Post(CadastrarUsuarioViewModel usuario)
        {
            try
            {
                Usuario usuarioBuscado = await _usuario.Find(x => x.Email == usuario.Email).FirstOrDefaultAsync();

                if (usuario != null)
                {
                    throw new Exception("Email já cadastrado em nosso sistema!");
                }

                Usuario novoUsuario = new()
                {
                    Email = usuario!.Email,
                    Nome = usuario.Nome,
                    Senha = usuario.Senha,
                    AdditionalAtributes = usuario.AdditionalAtributesUsuario
                };


                await _usuario.InsertOneAsync(novoUsuario);


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
                DeleteResult usuarioDeletado = _usuario.DeleteOne(x => x.IdUsuario.ToString() == id);

                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update(string id, AtualizarDadosUsuarioViewModel atualizarUsuario)
        {
            try
            {
                FilterDefinition<Usuario> usuarioFilter = Builders<Usuario>.Filter.Eq(Usuario => Usuario.IdUsuario, ObjectId.Parse(id));
                Usuario usuario = await _usuario.Find(usuarioFilter).FirstOrDefaultAsync();

                usuario.Nome = string.IsNullOrEmpty(atualizarUsuario.Nome) ? usuario.Nome : atualizarUsuario.Nome;
                usuario.Email = string.IsNullOrEmpty(atualizarUsuario.Email) ? usuario.Email : atualizarUsuario.Email;
                usuario.Senha = string.IsNullOrEmpty(atualizarUsuario.Senha) ? usuario.Senha : atualizarUsuario.Senha;
                usuario.AdditionalAtributes = atualizarUsuario.AdditionalAtributesUsuario!.Count == 0 ? usuario.AdditionalAtributes : atualizarUsuario.AdditionalAtributesUsuario;

                await _usuario.ReplaceOneAsync(usuarioFilter, usuario);
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
                List<Usuario> usuarioList = await _usuario.Find(FilterDefinition<Usuario>.Empty).ToListAsync();


                if (usuarioList.Count == 0)
                {
                    throw new Exception("Nenhum cliente encontrado!");
                }

                List<ExibirUsuarioViewModel> usuarioListFiltrados = [];


                foreach (Usuario usuario in usuarioList)
                {
                    ExibirUsuarioViewModel user = new()
                    {
                        IdUsuario = usuario.IdUsuario.ToString(),
                        Nome = usuario.Nome,
                        Email = usuario.Email,
                        Senha = usuario.Senha,
                        AdditionalAtributesUsuario = usuario.AdditionalAtributes,
                    };
                    usuarioListFiltrados.Add(user);
                }


                return StatusCode(200, usuarioListFiltrados);
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

                Usuario usuario = await _usuario.Find((usuario => usuario.IdUsuario.ToString() == id)).FirstOrDefaultAsync() ?? throw new Exception("Nenhum usuário encontrado!");

                ExibirUsuarioViewModel user = new()
                {
                    IdUsuario = usuario.IdUsuario.ToString(),
                    Nome = usuario.Nome,
                    Email = usuario.Email,
                    Senha = usuario.Senha,
                    AdditionalAtributesUsuario = usuario.AdditionalAtributes,
                };

                return StatusCode(200, user);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

    }
}
