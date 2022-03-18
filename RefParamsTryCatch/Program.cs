using ParamsInRefOutTryCatch;
using System;

namespace ParamsInRefOutTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            params_obj.UseParamsObj(nameC, dbl, a);
            
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
        }
    }
}
