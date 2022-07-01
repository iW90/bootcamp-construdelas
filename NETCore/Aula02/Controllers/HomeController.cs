using Aula02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Aula02.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult ImprimeFrase (FraseModel model)
        {
            //opcional inserir aqui um comando para gravar no banco de dados
            return View(model);
        }

        [HttpPost]
        public IActionResult Somar([FromBody] ValoresModel model) //FromBody para exibir no corpo da requisição
        {
            if (model?.Resultado > 0)
            {
                model.Resultado = model.Resultado + model.ValorDois;
                model.ValorUm = null;
            }
            else
            {
                model.Resultado = model.ValorUm + model.ValorDois;
            }
            return Ok(model);
        }

        [HttpPost]
        public IActionResult Subtrair([FromBody] ValoresModel model) //FromBody para exibir no corpo da requisição
        {
            if (model?.Resultado > 0)
            {
                model.Resultado = model.Resultado - model.ValorDois;
                model.ValorUm = null;
            }
            else
            {
                model.Resultado = model.ValorUm - model.ValorDois;
            }
            return Ok(model);
        }

        [HttpPost]
        public IActionResult Multiplicar([FromBody] ValoresModel model) //FromBody para exibir no corpo da requisição
        {
            if (model?.Resultado > 0)
            {
                model.Resultado = model.Resultado * model.ValorDois;
                model.ValorUm = null;
            }
            else
            {
                model.Resultado = model.ValorUm * model.ValorDois;
            }
            return Ok(model);
        }

        [HttpPost]
        public IActionResult Dividir([FromBody] ValoresModel model) //FromBody para exibir no corpo da requisição
        {
            if (model?.Resultado > 0)
            {
                model.Resultado = model.Resultado / model.ValorDois;
                model.ValorUm = null;
            }
            else
            {
                model.Resultado = model.ValorUm / model.ValorDois;
            }
            return Ok(model);
        }

        [HttpGet]
        public IActionResult Limpar([FromBody] ValoresModel model) //FromBody para exibir no corpo da requisição
        {
            return Ok();
        }
    }
}