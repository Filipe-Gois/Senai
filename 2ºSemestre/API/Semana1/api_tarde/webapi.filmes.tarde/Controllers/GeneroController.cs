﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using webapi.filmes.tarde.Domains;
using webapi.filmes.tarde.Interfaces;
using webapi.filmes.tarde.Repositories;

namespace webapi.filmes.tarde.Controllers
{

    /// <summary>
    /// Route: define que a rota de uma requisição será no seguinte formato: dominio/api/nomeController
    /// Ex: http://Localhost:5000/api/genero
    /// </summary>
    [Route("api/[controller]")]

    /// <summary>
    /// ApiController: Define que é um controlador de api
    /// </summary>
    [ApiController]

    /// <summary>
    /// Route: Define que o tipo de resposta da api é JSON
    /// </summary>
    [Produces("application/json")]
    public class GeneroController : ControllerBase 
    {
        /// <summary>
        /// Objeto que irá receber os métodos definidos na interface
        /// </summary>
        private IGeneroRepository _generoRepository { get; set; }
        public GeneroController()
        {
            /// <summary>
            /// Instância do objeto _generoRepository para que haja referência aos métodos do repositório
            /// </summary>
            _generoRepository = new GeneroRepository();
            
        }


        /// <summary>
        /// EndPoint que acessa o método de listar os generos
        /// </summary>
        /// <returns>Lista de generos e um StatusCode</returns>

        [HttpGet]
        public IActionResult Get() 
        {
            try
            {
                //Cria uma lista para receber os generos
                List<GeneroDomain> ListaGeneros = _generoRepository.ListarTodos();

                //Retorna o status code 200 "OK" e a lista de generos no formato JSON
                return StatusCode(200, ListaGeneros);
                //return Ok(ListaGeneros);
            }
            catch (Exception erro)
            {
                //Retorna um StatusCode 400 - BadRequest e a mensagem de erro
               return BadRequest(erro.Message);
            }

        }

        /// <summary>
        /// EndPoint que acessa o método de cadastrar genero
        /// </summary>
        /// <param name="genero">Objeto recebido na requisição</param>
        /// <returns>StatusCode</returns>

        [HttpPost]
        public IActionResult Post(GeneroDomain genero)
        {
            try
            {
                //Faz a chamada para o metodo cadastrar
                _generoRepository.Cadastrar(genero);
                return StatusCode(201);
            }
            catch (Exception erro)
            {
                //Retorna StatusCode BadRequest (400) e a mensagem de erro
                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        /// EndPoint que acessa o método de deletar genero
        /// </summary>
        /// <param name="id">Objeto recebido na requisição</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            try
            {
                _generoRepository.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        /// EndPoint que acessa o método de buscar genero por Id
        /// </summary>
        /// <param name="id">Objeto recebido na requisição</param>
        /// <returns></returns>

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                _generoRepository.BuscarPorId(id);
                return StatusCode(200);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
    }
}
