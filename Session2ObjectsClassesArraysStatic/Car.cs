using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2ObjectsClassesArraysStatic
{
    class Car

    {
        //Atributele clasei/members
        private string brandName;
        private double currentSpeed;
        private double maxSpeed;

        //Exercitiu 5
        private static int numberOfTractionWheels;
        //Create a constructor of Car which takes a string parameter named brand.
        //clasa aceasta are un constructor default. Daca mai am nevoie de el si scriu altul, il scriu inca odata.
        public Car(string brand)
        {
            //this -> semnifica instant curenta pe care se executa clasa. (se refera la atributul din clasa in care il accesez)
            this.brandName = brand;
        }

        /*Create a method named FullThrottle() which sets the value of currentSpeed to maxSpeed*/
        public void FullThorttle()
        {
            currentSpeed = maxSpeed;
        }

        /* Create a method named Brake() which decreases the value of currentSpeed by 10 (but doesn't get below zero).*/
        public void Brake()
        {
            if (currentSpeed >= 10)
            {
                //decrement
                currentSpeed -= 10;
            }
            else
            {
                currentSpeed = 0;
            }
        }

        public static void ChangeNumberOfTractionWheels(int numberOfTractionWheelsExtra)
        {//pt atribute statice nu avem voie this.(da eroare)
            numberOfTractionWheels = numberOfTractionWheelsExtra;
        }

        //getter-> e ca si la tipul atributului
        public double getMaxSpeed()
        {
            return maxSpeed;
        }
        public void setMaxSpeed(double maxSpeed)

        {
            this.maxSpeed = maxSpeed;
        }

        public String getBrandName()
        {
            return brandName;

        }
        public void setBrandName(String brandName)
        {
            this.brandName = brandName;
        }

        public double getCurrentSpeed()
        {
            return currentSpeed;
        }

        public void setCurrentSpeed(double currentSpeed)
        {
            this.currentSpeed = currentSpeed;
        }
    }
}
