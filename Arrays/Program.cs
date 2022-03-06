using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a single-dimensional array of 5 integers.
            int[] array1 = new int[5];

            // Declare and set array element values.
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            // Alternative syntax.
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            // Declare a two dimensional array.
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values.
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            //line 0: 1 2 3
            //line 1: 4 5 6 
            Console.WriteLine(multiDimensionalArray2[1, 1]);
            for(int i = 0; i <= 1; i++)
            {
                for (int j = 0; j <= 2; j++)
                    Console.Write(multiDimensionalArray2[i, j] + " ");
                Console.WriteLine();
            }

            // Declare a jagged array.
            int[][] jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array structure.
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[2] { 2, 3 };
        }
    }
}
