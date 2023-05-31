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

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();

            novaEquipe.Nome = form["nome"].ToString();
            // novaEquipe.Imagem = form["Imagem"].ToString();
            // vem como string, porém, precisamos de uma  imagem


            // aqui começa a lógica do upload de imagem

            if (form.Files.Count > 0)
            {
                var file = form.Files[0];

                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                if (Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;
            }

            else
            {
                novaEquipe.Imagem = "padrao.png";
            }
            // Fim da lógica de upload de imagem


            c.Equipe.Add(novaEquipe);
            // c.Add(novaEquipe); outra opção

            c.SaveChanges();

            return LocalRedirect("~/Equipe/Listar");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}