using System;

namespace ReversePrintReplaceNElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] ArrangedArray = { 1, 3, 6, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            ReversePrint.ReverseArrayMethod(ArrangedArray);
            Console.WriteLine("\nReversed array is: ");
            for (int i = 0; i < ArrangedArray.Length; i++)
            {

                Console.Write(" "+ArrangedArray[i]);
            }

            ReplaceNElement.ReplaceMethod(ArrangedArray, 1, 5000);
            Console.WriteLine("\nNew Array with replaced index is: ");
            for (int i = 0; i < ArrangedArray.Length; i++)
            {
                Console.Write(" " + ArrangedArray[i]);
            }
            
        }
    }
}
