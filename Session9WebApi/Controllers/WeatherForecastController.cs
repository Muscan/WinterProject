using Microsoft.AspNetCore.Mvc;
using Session8.Data.DPO;
using Session8.Data.Persistance;

namespace Session9WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        IConfiguration configuration;

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration config)
        {
            configuration = config;
            _logger = logger;
        }

        [HttpGet]
        [Route("readallcars")]
        public IEnumerable<CarDPO> Get()
        {
            configuration.GetConnectionString("CarRentalEntities");
            //CarRentalEntities carRentalEntities = new CarRentalEntities("Data Source=DESKTOP-RHIQ9E0\\SQLEXPRESS;Initial Catalog=CarRental;Integrated Security=True;");
            CarRentalEntities carRentalEntities = new CarRentalEntities(configuration.GetConnectionString("CarRentalEntities"));
            return carRentalEntities.Cars;


        }
        [HttpPost]
        [Route("tomorrowpost")]
        public WeatherForecast GetForecastForDayWithPost(WeatherForecast n)
        {
            return new WeatherForecast()
            {
                Date = DateTime.Now.AddDays(n.TemperatureC).Date,
                TemperatureC = 27,
                Summary = "feels like summer"
            };
        }
    } 
}