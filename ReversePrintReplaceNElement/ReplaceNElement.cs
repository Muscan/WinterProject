using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrintReplaceNElement
{
    internal class ReplaceNElement
    {
       public static void ReplaceMethod(int[] array, int indexToReplace, int replacedElemAtIndex)
        {
            if (indexToReplace < array.Length && indexToReplace >= 0)
            {
                array[indexToReplace] = replacedElemAtIndex;
                
            }
            else
            {

                Console.WriteLine("Out of this world error");
            }
        }
    }
}
