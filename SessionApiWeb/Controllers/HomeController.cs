using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Session8.Data.DPO;
using SessionApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;


namespace SessionApiWeb.Controllers
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
            /*  List<CarDPO> carDpo = new List<CarDPO>();
              carDpo.Add(new CarDPO()
              {
                  Engine = 2,
                  SeriesYear = 2022,
                  Name = "Volvo"
              });
              Cars myCars = new Cars();
              myCars.carDpo = carDpo;*/
            Cars myCars = new Cars();
            
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7024/Cars/DisplayAllCars");
            string result = httpClient.GetStringAsync(httpClient.BaseAddress).GetAwaiter().GetResult();
            List<CarDPO> cars = JsonConvert.DeserializeObject<List<CarDPO>>(result);
            myCars.carDpo = cars;
            return View(myCars);
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
    }
}
