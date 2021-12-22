using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2ObjectsClassesArraysStatic
{
    class Requierements
    {
        /*Problem 1. Basic class/object
        Create a class called MyClass. Create multiple objects of MyClass.
        
        Problem 2. Car class
        Create a class named Car which has the following members: brandName, currentSpeed, maxSpeed. 
        Create a constructor of Car which takes a string parameter named brand. 
        Create a method named FullThrottle() which sets the value of currentSpeed to maxSpeed
        Create a method named Brake() which decreases the value of currentSpeed by 10 (but doesn't get below zero).
        Create an object of Car, set the value of maxSpeed to 232, call the method FullThrottle, 
        and then print the current speed of the Car object. 
        Stop the car completely - call the Brake() method repeatedly until the currentSpeed gets to 0. 
        Print to the console the car's speed after each call to Brake()
        
        
        Problem 3. Array of objects
        Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects.
         To do this, first create a Person class that has a Name property of type string, a constructor that receives 
        the name as a parameter,
         a destructor that assigns the name to empty and overwrites the ToString () method.
        
        End the program by reading the people and executing the ToString () method on screen.
        
        Input
        Juan
        Sara
        Carlos
        
        Output
        Hello! My name is Juan
        Hello! My name is Sara
        Hello! My name is Carlos
        
        
        Problem 4. Photo book class
        Create a C# program to manage a photo book using object-oriented programming.
        
        To start, create a class called PhotoBook with a private attribute numPages of type int. 
        It must also have a public method GetNumberPages that will return the number of photo book pages.
        
        The default constructor will create an album with 16 pages. There will be an additional constructor, 
        with which we can specify the number of pages we want in the album.
        
        Finally create a PhotoBookTest class to perform the following actions:
        
        Create a default photo book and show the number of pages
        Create a photo book with 24 pages and show the number of pages
        Input
         
        Output
        16
        24
        
        Problem 5. Static members
        Enhance the program written at Problem 2. Add a static int member named NumberOfTractionWheels. 
        Cteate a static method named ChangeNumberOfTractionWheels with an int parameter, 
        which changes the value of NumberOfTractionWheels. 
        Create multiple Car objects, change the value of NumberOfWheels to 2.
        Change the value of NumberOfTractionWheels by calling NumberOfTractionWheels. 
        Try to use an instance member in a static method and a static member in an instance method 
        (this means a non-static method) and see what */
    }
}
