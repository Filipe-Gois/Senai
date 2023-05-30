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
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }

        // instância do objeto da classe context : acessa o BD
        Context c = new Context();


        [Route("Listar")] //http://localhost/Equipe/Listar
        // esse "Listar" tá substituindo o nome do método Index
        public IActionResult Index()
        {
            // "mochila" que contem a lista das equipes
            // podemos usa-la na view de equipe
            ViewBag.Equipe = c.Equipe.ToList(); //acessa e exibe as coisas dentro

            //    retorna a view de equipe
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();

            novaEquipe.Nome = form["nome"].ToString();
            novaEquipe.Imagem = form["Imagem"].ToString();

            c.Equipe.Add(novaEquipe);
            // c.Add(novaEquipe); outra opção

            c.SaveChanges();

            ViewBag.Equipe = c.Equipe.ToList();

            return LocalRedirect("~/Equipe/Listar");
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}