using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrintReplaceNElement
{
    internal class ReplaceNElement
    {
       public  void ReplaceMethod(int[] array, int indexToReplace, int replacedElemAtIndex)
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

        public  void ReplaceOccurence(int[] arr, int nrToBeReplaced, int newNumber)
        {
            int contor = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == nrToBeReplaced)
                {
                    arr[i] = newNumber;
                    contor++;
                }
            }
            if(contor > 0)
            {
                Console.WriteLine("Replaced " + contor + " numbers");
            }
            else
            {
                Console.WriteLine("None of the conditions were met.");
            }
        }
        public  void IterateArray(int[]ArrangedArray)
        {
            for (int i = 0; i < ArrangedArray.Length; i++)
            {
                Console.Write(" " + ArrangedArray[i]);
            }
            Console.WriteLine();
        }


    }
}
