using Session8CRUDSQL.Model;
using System.Data.SqlClient;
using System.Linq;

namespace Session8CRUDSQL.Classes
{
    class CarsManager
    {
        public IEnumerable<Car> GetAllCarsWithEF()
        {
            CarRentalContext context = new CarRentalContext();
            var cars =  context.Cars.ToList();
            
            //TBD!!!
            //return cars;
            return (IEnumerable<Car>)context.Cars.AsEnumerable();
            

            //return (IEnumerable<Car>)cars;
            //List<Car> cars = new List<Car>();
          

            //return new List<Car>();
        }
        //ado.net
        public IEnumerable<CreatedCar> GetAllCars()
        {
            List<CreatedCar> cars = new List<CreatedCar>();
            
            //tbd - move connection into a separate class
            //add ADO.NEt and EntityFramework
            string connString = "Server=DESKTOP-RHIQ9E0\\SQLEXPRESS;Database=CarRental;Trusted_Connection=True;";
          
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM CAR";
                command.CommandType = System.Data.CommandType.Text;

                SqlDataReader rdr = command.ExecuteReader();

                while (rdr.Read())
                {
                    CreatedCar car = new CreatedCar();
                    car.ID = rdr.GetInt32(0);
                    car.Name = rdr.GetString(1);
                    car.Engine = rdr.GetDecimal(2);
                    car.SeriesYear = rdr.GetInt32(3);
                    cars.Add(car);

                }
            }
            return cars;
        }
    }
}
