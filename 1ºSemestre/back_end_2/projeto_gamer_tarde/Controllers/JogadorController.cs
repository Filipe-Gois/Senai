using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projeto_gamer_tarde.Infra;
using projeto_gamer_tarde.Models;

namespace projeto_gamer_tarde.Controllers
{
    [Route("[controller]")]
    public class JogadorController : Controller
    {
        private readonly ILogger<JogadorController> _logger;

        public JogadorController(ILogger<JogadorController> logger)
        {
            _logger = logger;
        }

        Context c = new Context();

        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Jogador = c.Jogador.ToList();
            ViewBag.Equipe = c.Equipe.ToList();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador novoJogador = new Jogador();

            novoJogador.Nome = form["nome"].ToString();
            novoJogador.Email = form["email"].ToString();
            novoJogador.Senha = form["senha"].ToString();
            novoJogador.Equipe = c.Equipe.First(x => x.IdEquipe == int.Parse(form["Equipe"]!));
            // novoJogador.Equipe = form["equipe"].ToString();
            // OLHA O ERRO, FDP KKKKKKK

            c.Jogador.Add(novoJogador);
            c.SaveChanges();
            
            return LocalRedirect("~/Jogador/Listar");
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}