using Microsoft.AspNetCore.Mvc;

namespace Aula01.Controllers
{
    [ApiController]
    [Route("[controller]")] //é possível mudar o endereço da rota aqui
    public class WeatherForecastController : ControllerBase //ControllerBase herda de WeatherForecastController
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "caminho/{parametro1}/{parametro2}")] // diretório/param1/param2
        public IEnumerable<WeatherForecast> Get(string parametro1, int parametro2) //mudando o contrato, obriga a pessoa a informar o parametro1
        {
            var meuParametro1 = parametro1; //armazena o parametro1 na variável

            //Usado SQL para buscar dados

            //Select * from TalTalA where parametro2 == parametro2 && parametro1 == parametro1

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}