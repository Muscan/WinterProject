using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2ObjectsClassesArraysStatic
{
    class Person
    {
        /*Problem 3. Array of objects
           Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects.
            To do this, first create a Person class that has a 
           -Name property of type string, 
           -a constructor that receives the name as a parameter,
            -a destructor that assigns the name to empty 
           - and overwrites the  ToString () method.

           End the program by reading the people and executing the ToString () method on screen.

           Input
           Juan
           Sara
           Carlos

           Output
           Hello! My name is Juan
           Hello! My name is Sara
           Hello! My name is Carlos
           */
        //private nu e vizibil in alte metode
        private string name;
        //a constructor that receives the name as a parameter,
        public Person(string name)
        {
            this.name = name;
        }
        public Person()
        {
            //Empty default constructor
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public static void People()
        {
            //i don`t know why I declared this static method:) 

        }

        ~Person()
        {
            name = "";
        }
        //Destructor - handeld by C#. 
        //Garbage collector-> not used object -> deallocate memory
        //Garbage collector -> apeleaza constructorul


        //I override de string method.

        public override string ToString()
        {
            return "(eu sunt ToString override:) )Hello! My name is: " + name;
        }

    }
}
