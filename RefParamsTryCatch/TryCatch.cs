using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsInRefOutTryCatch
{
    internal class TryCatch
    {
        public void TestingTryCatch(int index)
        {
            int[] array = new int[5];
            //will execute only if I don`t have an exception
            try
            {
                array[index] = 7;
            }catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + " " + e.StackTrace);
            }
            //execute even if there is no an exception
            finally
            {
                Console.WriteLine("Length of the array is " + array.Length);
            }
        }
    }
}
