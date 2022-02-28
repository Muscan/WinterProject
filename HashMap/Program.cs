using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a["user"] = "car";
            //key, value
            
            Dictionary<string, string> dogMeister = new Dictionary<string, string>();
            dogMeister.Add("Rex", "Teddy");
            dogMeister.Add("Azores", "Vamos");
            dogMeister.Add("Tom", "Jen");
            //assign Tom to Jim
            dogMeister["Tom"] = "Jim";
            //if the key does not exist, the value and the key will be added
            dogMeister["Rexx"] = "boy";
            Console.WriteLine(dogMeister["Rex"] );
            Dictionary<int, bool> keyValuePairs = new Dictionary<int, bool>();  
            keyValuePairs.Add(1, true);
            keyValuePairs.Add(2, false);
            keyValuePairs[1] = false;
            Dictionary<char, int> charIntPair = new Dictionary<char, int>();
            charIntPair.Add('A', 87);
            charIntPair.Add('B', 32);
            Console.WriteLine();

            Driver driver = new Driver(12, "John");
            Console.WriteLine(driver);
            Dictionary<Driver, Car> DriverCarPair = new Dictionary<Driver, Car>();
            //calling constuctor directly in the Add method, we lose the objects. 
            //We cannot access them since we don`t have a reference
            Driver driver1 = new Driver(11, "Tom");
            //DriverCarPair.Add(new Driver(11, "Tom"), new Car(12, "VW"));
            DriverCarPair.Add(driver1, new Car(12, "VW"));
            Console.WriteLine(DriverCarPair[driver1]);
            //Assign more cars to a driver
            List<Car> cars = new List<Car>();
            cars.Add(new Car(12, "Suzuki"));
            cars.Add(new Car(3.3, "VW"));
            cars.Add(new Car(233.23, "ATV"));
            //one driver, more cars(List of cars)
            Dictionary<Driver, List<Car>> CarDriverPair = new Dictionary<Driver, List<Car>>();
            
            Driver driver2 = new Driver(13, "John");
            List<Car> cars2 = new List<Car>();
            cars2.Add(new Car(5, "Suzuki"));
            cars2.Add(new Car(6, "VW"));

            CarDriverPair.Add(driver1, cars2);
            CarDriverPair.Add(driver2, cars2);
            Console.WriteLine(driver1.Name);
            
            //Instaniate object car of type Car and iterate through the List with key driver1
            foreach (Car car in CarDriverPair[driver1])
            {
                Console.WriteLine(car);
            }
           
            //iterate through the Dictionary with Driver,List keyValuePair wich has a driver and a Car List
            foreach(KeyValuePair<Driver, List<Car>> keyValuePair in CarDriverPair)
            {//extract the key(Driver)+Name
                Console.WriteLine(keyValuePair.Key.Name + " has:");
                foreach(Car car in keyValuePair.Value)
                {
                    Console.WriteLine(car);
                }
            }



        
            
        }
    }
}
