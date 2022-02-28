using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary

{
    internal class Car
    {
        public double CarId { get; set; }
        public string CarName { get; set; }

        public Car(double CarId, string CarName)
        {
            this.CarId = CarId;
            this.CarName = CarName; 
        }

        public override string ToString()
        {
            return CarId + " " + CarName;
        }
    }
}
