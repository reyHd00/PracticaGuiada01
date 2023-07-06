using Microsoft.AspNetCore.Mvc;
using PracticaGuiada01.Modelos;
namespace PracticaGuiada01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
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

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost]
        public string Mensaje([FromBody] Mensaje mensaje)
        {
            Mensaje algo = new Mensaje(mensaje.Nombre, mensaje.Edad);

            Persona persona = new Persona();
            {
            }

            return String.Format($"Hola mi nombre es {mensaje.Nombre} y tengo { mensaje.Edad} años");
        }
    
    }
}