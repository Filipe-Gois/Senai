﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

    public class FilmeController : ControllerBase
    {
        private IFilmeRepository _filmeRepository { get; set; }

        public FilmeController()
        {
            _filmeRepository = new FilmeRepository();
        }

        /// <summary>
        /// Cadastra um filme associado à um gênero
        /// </summary>
        /// <param name="filme"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Cadastrar(FilmeDomain filme)
        {
            try
            {
                _filmeRepository.Cadastrar(filme);
                return StatusCode(200, "Filme cadastrado com sucesso!");
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
        /// <summary>
        /// Deleta um filme através de seu ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete("{id")]
        public IActionResult Delete(int id)
        {
            try
            {
                FilmeDomain filmeBuscado = _filmeRepository.BuscarPorId(id);
                try
                {
                    if(filmeBuscado != null)
                    {
                        _filmeRepository.Deletar(id);
                        return StatusCode(204);
                    }
                    return StatusCode(404);
                }
                catch (Exception erro)
                {

                    return BadRequest(erro.Message);
                }

            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }
        /// <summary>
        /// Busca um filme através de seu ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                FilmeDomain filmeBuscado = _filmeRepository.BuscarPorId(id);

                if (filmeBuscado != null)
                {
                    return StatusCode(200, filmeBuscado);
                }

                return StatusCode(404);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        /// Lista todos os filmes cadastrados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ListarTodos()
        {
            try
            {
                List<FilmeDomain> listaDeFilmes = _filmeRepository.ListarTodos();
                return StatusCode(200, listaDeFilmes);
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        /// Atualiza os dados de um filme passando seu ID pela URL
        /// </summary>
        /// <param name="id"></param>
        /// <param name="filme"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult AtualizarPorUrl(int id, FilmeDomain filme)
        {
            try
            {
                FilmeDomain filmeBuscado = _filmeRepository.BuscarPorId(id);

                if (filmeBuscado != null)
                {
                    try
                    {
                        _filmeRepository.AtualizarIdUrl(id, filme);
                        return StatusCode(204);
                    }
                    catch (Exception erro)
                    {

                        return BadRequest(erro.Message);
                    }


                }
                return StatusCode(404);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        /// Atualiza os dados de um filme passando seu ID pelo corpo 
        /// </summary>
        /// <param name="filme"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult AtualizarIdCorpo(FilmeDomain filme)
        {
            try
            {
                FilmeDomain filmeBuscado = _filmeRepository.BuscarPorId(filme.IdFilme);

                if(filmeBuscado != null)
                {
                    try
                    {
                        _filmeRepository.AtualizarIdCorpo(filme);
                        return StatusCode(204);
                    }
                    catch (Exception erro)
                    {

                        return BadRequest(erro.Message);
                    }
                }
                return StatusCode(404);
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }
    }
}
