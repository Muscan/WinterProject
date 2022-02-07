using Microsoft.AspNetCore.Mvc;
using Session8.Data.DPO;
using Session8.Data.Persistance;
using System.Data.Entity;

namespace Session9WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        IConfiguration configuration;

        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger, IConfiguration config)
        {
            configuration = config;
            _logger = logger;
        }

        [HttpGet]
        [Route("DisplayAllCars")]
        public IEnumerable<CarDPO> Get()
        {
            configuration.GetConnectionString("CarRentalEntities");
            //CarRentalEntities carRentalEntities = new CarRentalEntities("Data Source=DESKTOP-RHIQ9E0\\SQLEXPRESS;Initial Catalog=CarRental;Integrated Security=True;");
            CarRentalEntities carRentalEntities = new CarRentalEntities(configuration.GetConnectionString("CarRentalEntities"));
            return carRentalEntities.Cars;
  


        }

        [HttpGet]
        [Route("DisplayOneCar")]
        public async Task<ActionResult<CarDPO>> GetOneCar(int id) 
        {

            configuration.GetConnectionString("CarRentalEntities");
            CarRentalEntities carRentalEntities = new CarRentalEntities(configuration.GetConnectionString("CarRentalEntities"));
            var oneCar = await carRentalEntities.Cars.FindAsync(id);
            await carRentalEntities.SaveChangesAsync();
            if (oneCar == null)
                return BadRequest("Car not found ");
            return Ok(oneCar);

        }
        [HttpPost]
        [Route("AddCar")]
        public async Task<ActionResult> AddOneCar(CarDPO carDPO, int id)
        {
            configuration.GetConnectionString("CarRentalEntities");
            CarRentalEntities carRentalEntities = new CarRentalEntities(configuration.GetConnectionString("CarRentalEntities"));
            carRentalEntities.Cars.Add(carDPO);
            await carRentalEntities.SaveChangesAsync();
            return Ok(await carRentalEntities.Cars.FindAsync(id));
        }

        [HttpPut]
        [Route("UpdateCar")]
        public async Task<ActionResult<List<CarDPO>>> UpdateCar(CarDPO car, int id)
        {
            configuration.GetConnectionString("CarRentalEntities");
            CarRentalEntities carRentalEntities = new CarRentalEntities(configuration.GetConnectionString("CarRentalEntities"));
            var oneCar = await carRentalEntities.Cars.FindAsync(car.ID);

            if (oneCar == null)
                return BadRequest("Car not found.");

            oneCar.ID = car.ID;
            oneCar.Name = car.Name;
            oneCar.Engine = car.Engine; 
            oneCar.SeriesYear = car.SeriesYear; 
            await carRentalEntities.SaveChangesAsync();
            return Ok(await carRentalEntities.Cars.ToListAsync());
        }

        [HttpDelete]
        [Route("DeleteCar")]
        public async Task<ActionResult> DeleteCar(int id)
        {
            configuration.GetConnectionString("CarRentalEntities");
            CarRentalEntities carRentalEntities = new CarRentalEntities(configuration.GetConnectionString("CarRentalEntities"));
            var oneCar = await carRentalEntities.Cars.FindAsync(id);

            if (oneCar == null)
                return BadRequest("Car not found.");
            carRentalEntities.Cars.Remove(oneCar);
            await carRentalEntities.SaveChangesAsync();
            return Ok(await carRentalEntities.Cars.FindAsync(id));

        }
                   
    } 
}