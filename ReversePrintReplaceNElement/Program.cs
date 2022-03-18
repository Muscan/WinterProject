using System;

namespace ReversePrintReplaceNElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReplaceNElement replaceNElement = new ReplaceNElement();
            int[] ArrangedArray = { 1, 11, 3, 6, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 11, 19 };

            ReversePrint.ReverseArrayMethod(ArrangedArray);
            Console.WriteLine("\nReversed array is: ");
            replaceNElement.IterateArray(ArrangedArray); 
            
            //Array.Reverse(ArrangedArray);
            replaceNElement.ReplaceMethod(ArrangedArray, 1, 5000);
            Console.WriteLine("\nNew Array with replaced index is: ");
            replaceNElement.IterateArray(ArrangedArray);


            //replace a numbeer(11) with a new number(2)
            Console.WriteLine("New array with number replaced ");
            replaceNElement.ReplaceOccurence(ArrangedArray, 11, 790);
            replaceNElement.IterateArray(ArrangedArray);
            
        }
    }
}
