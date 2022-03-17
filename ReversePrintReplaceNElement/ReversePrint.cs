using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrintReplaceNElement
{
    internal class ReversePrint
    {
       // 0 1 2 3 4 INDEXES 
                    //Iteration
       // 1 3 2 6 8         0
       // 8 3 2 6 1         1  
       // 8 6 2 3 1         2
        public static int[] ReverseArrayMethod(int[] array)
        {
            for (int i = 0; i < array.Length/2; i++)
            {
                //
                int aux;
                //aux takes value 1 for the first iteration
                //arrray[i] -> first iteration for index 0 elem is 1
                aux = array[i];
                //5 -1 -i(0)->for starts from index 0 => 4
                //index 0(value1) takes value of index 4(value8)
                // 1 3 2 6 8         0
                array[i] = array[array.Length - 1 - i];
                //elem from index4, value8 takes value 1 from index 0
                array[array.Length - 1 - i] = aux;
            }
            return array;
        }
    }
}
