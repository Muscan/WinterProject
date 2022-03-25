using NPOI.SS.Formula.Functions;
using ParamsInRefOutTryCatch;
using System;
using System.Collections.Generic;

namespace ParamsInRefOutTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            //params cannot be used because is a keyword
            //UseParams is a method from the class Params
            //Use Params when I don`t know how many 
            Params params_obj = new Params();
            int a = 10, b = 20, c = 50;
            params_obj.UseParams(a, b, c);
            int d = 60;
            params_obj.UseParams(a, b, c, d);
            double dbl = 3.12;
            string nameC = "C#";
            List<int> myList = new List<int>();
            myList.Add(10);
            myList.Add(20);
            params_obj.UseParamsObj(nameC, dbl, a, myList);
            
            //single parameter in
            In in_obj = new In();
            in_obj.UseIn(15);
            in_obj.UseIn(2);

            //object as parameter
            in_obj.UseInObj(nameC);

            Out out_obj = new Out();
            int age1;
            string name1;
            out_obj.UseOut(out name1, out age1);
            Console.WriteLine(name1 + " is " + age1 + " years old.");

            //Ref in methods
            int number = 1;
            Ref refObj = new Ref();
            refObj.RefMethod(ref number);
            Console.WriteLine(number);

            //Ref in main
            int number1 = 1;
           
            refObj.Method(number1);
            Console.WriteLine(number1);*/

            //TryCatch
            TryCatch tryCatch = new TryCatch();
            tryCatch.TestingTryCatch(10);
        }
    }
}
