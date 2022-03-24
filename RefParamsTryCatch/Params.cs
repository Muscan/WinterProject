using NPOI.SS.Formula.Functions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsInRefOutTryCatch
{
    internal class Params
    {
        public void UseParams(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        //using object, we can use any type(*) of data
        //* primitive types, objects. 
        //cannot be used(at least now) for List<T>.
        public void UseParamsObj(params object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] is List<int>)
                {
                    List<int> list = (List<int>)array[i];
                    for(int j = 0; j < list.Count; j++)
                    {
                         Console.Write(list[j] + " ");
                    }
                }
                else 
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.WriteLine();
        }

    }
}
