using Session3InheritanceAccesModifiersAutoPropStatic.Exercise4;
using Session3InheritanceAccesModifiersAutoPropStatic.Exercise5;
using System;
using System.Collections.Generic;

namespace Session3InheritanceAccesModifiersAutoPropStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circle circle = new Circle(1);
            //Circle circle1 = new Circle(1, 2);
            //Rectangle rectangle = new Rectangle(2, 4);

            //Square square = new Square(10);
            //Console.WriteLine("Area of square is " + square.SqaureArea());

            //Set a stundent grade(10) at Mathematik
            Student studentMarco = new Student("Marco");
            Course courseMath = new Course("Math");
            Course courseInfo = new Course("Info");
            studentMarco.AddCourses(courseMath);
            studentMarco.AddCourses(courseInfo);
            //courseMath {10, 7, 8, 6}
            List<int> grades = new List<int> { 10, 7, 8, 6 };
            studentMarco.SetAStudentGradeForVariousCourses(courseMath, grades);

            //Console.WriteLine("Grades for" + studentMarco.GetCoursesGradesForAStudent(courseMath));
            //!!!Grades forSystem.Collections.Generic.List`1[System.Int32]

            List<int> courseGrades = studentMarco.GetCoursesGradesForAStudent(courseMath);
            Console.WriteLine("Course grades for " + courseMath.getCourseName() +
                " student " + studentMarco.getStudentName());
            for (int i = 0; i < courseGrades.Count; i++)
            {
                Console.Write(courseGrades[i] + " ");
            }
            Console.WriteLine();
            //List implements IEnumerable 
            //foreach elem from the list exec instruction from {}
            foreach (int currentGrade in courseGrades)
            {
                Console.Write(currentGrade + " ");
            }


            //Exercice5
            Library library = new Library();
            Person person1 = new Person("Klauss");
            Book book1 = new Book("FoundLetter", "Rafka", 412, true);
            //Book book2 = new Book("GroundLetter", "Qafka", 112, true);

            library.RegisterPerson(person1);
            library.RegisterBook(book1);
            Console.WriteLine(book1.BookAvailable);
            person1.Borrow(book1);

            //person1.Borrow(book2);

            //Print books rented for a person
            //With getters and setters Prop, I get always false
            person1.PrintBooksRentedByThePerson();
            //book1.BookName = "Learning C# with Kafka";

            person1.ReturnBook(book1);

            person1.PrintBooksRentedByThePerson();

        }

        private void Test()
        {
            //cand accesam this. , metodele ToString vin din clasa object
            //Toate clasele mostenesc implicit clasa Object
            object obj = new object();
            obj.ToString();
            obj.GetType();


            //Static -> Declaratia lui va fi folosita in toate clasele
            //Modificatori de acces:
            //Public, protected, private, internal
            /*Unele atribute e preferabil sa nu fie vizibile in exterior
             incapsulare - ascunzi informatiile sa nu fie vizibile intr-o clasa publica. 
            In momentul in care faci o clasa, faci totul privat.
            private - doar in interiorul clasei
            protected - in interiorul clasei si in clasele in care le mostenesc
            Daca am definit cu acelasi nume si acelasi tip din clasa de baza, nu pot sa il accesez pe cel din clasa de baza, cu Base.
            O clasa sealed nu poate fi mostenita. 
            Base e cuvant cheie prin care avem acces la membrii clasei de baza,
            inclusiv in constructor */

            /*Public   -> The type or member can be accessed by any other code 
             * in the same assembly or another assembly that references it. 
             Private   -> The type or member can be accessed only by code in the same class or struct
             Protected -> The type or member can be accessed only by code in the same class,
                          or in a class that is derived from that class.
            (a class derived from the class Autos->Car; Car can access protected members from Autos. 
             Internal: The type or member can be accessed by any code in the same assembly, but not from another assembly.
            -(project related)
            protected internal: The type or member can be accessed by any code in the assembly in which it's declared,
            or from within a derived class in another assembly.
            class Employee : Person (din dreapta in stanga!!!!)
             clasa Employee mosteneste Person. 
             Clasa Employee, ia atributele si metodele clasei Person.
            Is A -> Inheritance
                class Employee : Person{
                base.GetInfo() -> du-te in clasa Person, si foloseste metoda asta
                                      }
           Sealed-> nu poate fi mostenita niciodata
            Virtual -> metoda poate fi suprascrisa intr-o clasa derivata doar daca are virtual. 
            (ToString, e virtuala(object), chiar daca e override fara virtual vizibil. 
            public virtual string? ToString();
            Cand vreau sa suprascriu o metoda, metoda din clasa de baza, trebuie sa fie virtuala,
            si in clasa derivata(unde o suprascriu) sa fie cu modificator overrride
             */
        }
    }
}
