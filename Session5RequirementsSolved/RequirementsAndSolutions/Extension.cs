using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5RequirementsSolved.RequirementsAndSolutions
{
    static class Extension
    {
        /*Add an extension method to the class from Exercise 1. 
        Add an extension method named SubstractTen to the int data type. 
        Implement this method so that it substracts 10 from a number and returns the result. 
        You should be able to call it like this: 7.SubstractTen() (the result is -1) or i.
        SubstractTen(), where i is a variable of type int and the result is i - 10. */
        public static void SubtractTen(this Forest forest, int dataTypeFromForest)
        {
            dataTypeFromForest = dataTypeFromForest - 10;
         
            
        }
    }
}
