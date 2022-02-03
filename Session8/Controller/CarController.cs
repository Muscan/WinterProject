using Session8.Data.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8.Controller
{
    public  class CarController
    {
        public CarRentalEntities ReturnAllCars()
        {
            return new CarRentalEntities();
        }
    }
}
