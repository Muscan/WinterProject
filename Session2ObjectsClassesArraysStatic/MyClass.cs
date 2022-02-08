using System;
using System.Collections.Generic;

namespace Session2ObjectsClassesArraysStatic
{
    class MyClass
    {
        public static void Main()
        {
            /*Problem 1. Basic class/object
            Create a class called MyClass. Create multiple objects of MyClass.
            - Creare mai multe instante a clasei MyClass
             */
            //Declarare si apelare constructor implicit
            MyClass myClass1 = new MyClass();
            MyClass myClass2 = new MyClass();
            MyClass myClass3 = new MyClass();

            //Declarare obiect de tip car
            //Instanierea obiectului de tip car cu numele suzuki
            //apelare constructorului clasei Car

            Car Suzuki = new Car("Suzuki");
            /*Create an object of type Car, set the value of maxSpeed to 232, call the method FullThrottle, 
             * and then print the current speed of the Car object. */
            //accesarea obiectului Suzuki
            //apelare setter si setare valoare la 232
            //apleare metoda FullThorrttle
            Suzuki.setMaxSpeed(232);
            Suzuki.FullThorttle();
            //Afisarea vitezei curente prin metode de get. 
            //Avem nevoie de getter sa o accesam pt. ca e privat atributul currentSpeed/(idem pt BrandName)
            Console.WriteLine("Current speed of " + Suzuki.getBrandName() + " is: " + Suzuki.getCurrentSpeed());



            //Stop the car completely -call the Brake() method repeatedly until the currentSpeed gets to 0.
            //Atata timp cat viteza e mai mare ca 0
            while (Suzuki.getCurrentSpeed() > 0)
            {
                //apelare metodaBrake
                Suzuki.Brake();
                //accesare viteza cu getter
                Console.WriteLine("Current speed after each call to Break is: " + Suzuki.getCurrentSpeed());
            }

            //declarare si iniitalizare 3 obiecte de tip Car cu constructorul din Car(string brandName)
            Car Volvo = new Car("S1");
            Car Vw = new Car("Corrado");
            Car Renault = new Car("Logan");

            //apelare metodaStatica direct cu numele clasei. 
            Car.ChangeNumberOfTractionWheels(2);

            /*Problema 3 End the program by reading the people and executing the ToString() method on screen.
            Input
            Juan
            Sara
            Carlos*/
            Console.WriteLine("Enter three names: ");
            Console.WriteLine("Enter first name: ");
            string readerName = Console.ReadLine();
            Person p1 = new Person(readerName);
            readerName = Console.ReadLine();
            Person p2 = new Person(readerName);
            readerName = Console.ReadLine();
            Person p3 = new Person(readerName);
            //Varianta 1 in care salvez numele intr-un array
            //un sir de obiecte de tip person
            Person[] arrayPersons = { p1, p2, p3 };

            //
            /*Console.WriteLine(arrayPersons[0].ToString());
            Console.WriteLine(arrayPersons[1].ToString());
            Console.WriteLine(arrayPersons[2].ToString());*/

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arrayPersons[i].ToString());
            }
            //fully quallified name
            //ToString() default, afiseaza Session4.Person
            //Ca sa cosmetizam afisarea, declaram o metoda ToString, care suprascrie de fapt ToString()-ul default.
            //fara ToString, imi afisa adresa de memorie. 
            //ToString default, afiseaza nameSpace + clasa(obiectul).
            //
            /*public override string ToString()
             {
                 return "Hello! My name is: " + name;
             }*/



            //Adaugare persoane intr-o lista dinamica(preferat)
            List<Person> arrayPersonsDynamic = new List<Person>();
            arrayPersonsDynamic.Add(p1);
            arrayPersonsDynamic.Add(p2);
            arrayPersonsDynamic.Add(p3);

            for (int i = 0; i < arrayPersonsDynamic.Count; i++)
            {//check if fist or last char is space
                string nameToWorkWith = arrayPersonsDynamic[i].getName();
                if (nameToWorkWith[0] == ' ')
                {
                    string nameWithoutSpace = nameToWorkWith.Substring(1);
                    arrayPersonsDynamic[i].setName(nameWithoutSpace);

                }
                if (nameToWorkWith[nameToWorkWith.Length - 1] == ' ')

                {
                    int indexLastChar = nameToWorkWith.Length - 1;
                    string nameWithoutLastSpace = nameToWorkWith.Substring(0, indexLastChar);

                    arrayPersonsDynamic[i].setName(nameWithoutLastSpace);
                }

                Console.WriteLine(arrayPersonsDynamic[i].ToString());

            }
            //Trim start/end TODO
            //

            //Declarare obiect de tip PhotoBookTest si instantiere. 
            //photoBookTest e instanta clasei PhotoBookTest
            //apelare metoda afiare folosind obiectul photoBookTest
            PhotoBookTest photoBookTest = new PhotoBookTest();
            photoBookTest.Afisare();
        }
    }
}
