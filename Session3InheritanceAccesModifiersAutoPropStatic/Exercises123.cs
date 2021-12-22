using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3InheritanceAccesModifiersAutoPropStatic
{
    class Exercises123
    {
        
        public class Shape
        //Shape, Circle, Rectangle, Square.
        {
            //default constructor
            public double a;
            private double b;
            protected double c;

            public Shape()
            {
                Console.WriteLine("I`m the default constructor for Shape ");
            }

            public Shape(double a)
            {
                Console.WriteLine("Constructor from base class with 1 parameter ");
            }

            public Shape(double a, double b)
            {
                double result = a * b;
                Console.WriteLine("Second constructor from Base CLASS! ");
            }

            public void M1()
            {

            }
            private void M2()
            {

            }
            protected void M3()
            {

            }
        }

        public class Circle : Shape
        {
            private double radious;
            public Circle()
            {
                Console.WriteLine("Default constructor Circle ");
            }
            public Circle(double radious) : base(radious, 0)//base class does not need to know the inherited classes construcors
                                                            //!Wrong
                                                            //Parent class does not need to know what the child class does
            {
                this.radious = radious;
                Console.WriteLine("Second constructor from Circle ");
            }
            public double Area()
            {
                return Math.PI * radious * radious;
            }
            /*  public void Test()
              {
                  double suma = a + b + c;
                  M1();
                  M2();
                  M3();
              }*/
        }
        public class Rectangle : Shape
        {
            private double L;
            private double l;
            public Rectangle()
            {
                Console.WriteLine("Default constructor Rectangle ");
            }
            public Rectangle(double L, double l) : base(L, l)
            //public Rectangle(double L, double l) without base, apeleaza primul constructor
            {
                this.L = L;
                this.l = l;
                Console.WriteLine("Second constructor from Rectangle ");

            }
            public double RectangleArea()
            {
                return L * l;
            }

        }
        public class Square : Shape
        {
            private double l;
            public Square()
            {
                Console.WriteLine("Default construcotr Square ");

            }
            public Square(double l) : base(l)
            {
                this.l = l;
                Console.WriteLine("Second constructor Square ");
            }
            public double SqureArea()
            {
                return Math.Pow(l, 2);
            }
        }
    }
}
